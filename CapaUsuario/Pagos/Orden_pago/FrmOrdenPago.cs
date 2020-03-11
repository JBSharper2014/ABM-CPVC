using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

using CapaDatos;

namespace CapaUsuario.Pagos.Orden_pago
{
    public partial class FrmOrdenPago : Form
    {

        int codProveedor = 0;
        int codFactura = 0;

        public FrmOrdenPago()
        {
            InitializeComponent();
        }

        private void ListarFacturas()
        {
            DgvFacturas.DataSource = ExecuteQuery.SelectAll(200);
        }

        private void ListarOrdenes()
        {
            DgvListadoOrdenes.DataSource = ExecuteQuery.SelectAll(201);
        }

        private void FrmOrdenPago_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            // Cargar Grids
            ListarOrdenes();
            ListarFacturas();
            FrmOrdenPago_SizeChanged(sender, e);
        }

        private void FrmOrdenPago_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBancosProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool IsGridEmpty(string msg, DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show($"No hay {msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BorrarOrdenPagoButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty("órdenes de pago", DgvListadoOrdenes))
            {
                return;
            }

            if ((bool)DgvListadoOrdenes.SelectedRows[0].Cells[5].Value && (bool)DgvListadoOrdenes.SelectedRows[0].Cells[6].Value)
            {
                MessageBox.Show("No se puede borrar la orden. Ésta fue debitada y/o aceptada para pago",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var rta = MessageBox.Show("¿Está seguro de borrar la orden de pago?", "Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int codOrden = (int)DgvListadoOrdenes.SelectedRows[0].Cells[0].Value;

            // Lógica de borrado
            ExecuteQuery.DeleteFrom(2, codOrden);
            if (MessageException.message == "")
            {
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "La orden de pago ha sido borrada con exito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F)

                };
                popup1.Popup();

                ListarFacturas();
                ListarOrdenes();
            }

          
        }

        private void CodOrdenPagoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodOrdenPagoTextBox.Text != "")
            {

                if (!int.TryParse(CodOrdenPagoTextBox.Text, out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodOrdenPagoTextBox.Text = string.Empty;
                    return;
                }

                DgvListadoOrdenes.DataSource = ExecuteQuery.SelectOne(203, codigo);
            }
            else
            {
                ListarOrdenes();
            }
        }

        private void CrearOrdenPagoButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty("facturas", DgvFacturas))
            {
                return;
            }
            materialTabControl1.SelectedTab = TabNueva;
            HabilitarCampos();

            codFactura = (int)DgvFacturas.SelectedRows[0].Cells[0].Value;

            codProveedor = (int)ExecuteQuery.SelectCode(250, codFactura);
            if (codProveedor == 0)
            {
                codProveedor = (int)ExecuteQuery.SelectCode(251, codFactura);
            }

            dgvBancosProveedor.DataSource = ExecuteQuery.SelectOne(202, codProveedor);

        }

        private void HabilitarCampos()
        {
            ObservacionesTextBox.ReadOnly = false;

            GrabarOrdenButton.Enabled = true;
            CancelarButton.Enabled = true;

            ObservacionesTextBox.Focus();

            dgvBancosProveedor.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            ObservacionesTextBox.ReadOnly = true;

            GrabarOrdenButton.Enabled = false;
            CancelarButton.Enabled = false;

            dgvBancosProveedor.Enabled = false;
        }

        private void LeerObservacionesButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty("órdenes de pago", DgvListadoOrdenes))
            {
                return;
            }

            ObservacionesTextBox.Text = DgvListadoOrdenes.SelectedRows[0].Cells[7].Value.ToString();
            ObservacionesTextBox.Focus();
            materialTabControl1.SelectedTab = TabNueva;
            CancelarButton.Enabled = true;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ObservacionesTextBox.Text = string.Empty;
        }

        private void GrabarOrdenButton_Click(object sender, EventArgs e)
        {
            var rta = MessageBox.Show("¿Grabar orden de pago?",
                "Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (dgvBancosProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una cuenta bancaria de proveedores a la cual pagar");
                return;
            }



            // obtener código de proveedor a través de la orden de compra asociada a la factura
            // o a partir de nombre de proveedor que figura en la factura

            // obtener código de banco del proveedor

            // InsertOrdenPago(codFactura, codProveedor, codBanco, codCuentaBancaria,
            // false, false, ObservacionesTextBox.Text);


            int codBancoProv = (int)dgvBancosProveedor.SelectedRows[0].Cells[0].Value;


            if (MessageException.message == "")
            {
                object[] parameters =
                {
                    codFactura,
                    codProveedor,
                    codBancoProv,
                    ObservacionesTextBox.Text,
                    0,
                    0
                };

                ExecuteQuery.InsertInto(20, parameters);
                if (MessageException.message == "")
                {
                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.sql_success1,
                        TitleText = "Mensaje",
                        ContentText = "La orden de pago ha sido grabada con exito",
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(8)
                    };
                    popup1.Popup();

                    DesabilitarCampos();
                    ListarFacturas();
                    ListarOrdenes();
                    
                }
            }

        }
    }
}

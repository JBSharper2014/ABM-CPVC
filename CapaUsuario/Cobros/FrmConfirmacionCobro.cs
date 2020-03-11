using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using CapaDatos;

namespace CapaUsuario.Cobros
{
    public partial class FrmConfirmacionCobro : Form
    {
        private int codFactura;
        public FrmConfirmacionCobro()
        {
            InitializeComponent();
        }

        private void FrmConfirmacionCobro_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;
            FrmConfirmacionCobro_SizeChanged(sender, e);

            // TODO: Cargar Grids
            ListarConfirmaciones();
            ListarCuentas();
            ListarFacturas();

        }

        private  void ListarConfirmaciones()
        {
            DgvListadoConfirmaciones.DataSource = ExecuteQuery.SelectAll(400);
        }

        private void ListarCuentas()
        {
            dgvCuentasEmpresa.DataSource = ExecuteQuery.SelectAll(402);
        }

        private void ListarFacturas()
        {
            DgvFacturas.DataSource = ExecuteQuery.SelectAll(403);
        }

        private void FrmConfirmacionCobro_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoConfirmaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentasEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmConfirmacionCobro_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                BorrarConfirmacionButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                BorrarConfirmacionButton.Text = "Borrar confirmación";
                BorrarConfirmacionButton.Width = 200;
                BorrarConfirmacionButton.ImageAlign = ContentAlignment.MiddleLeft;
                BorrarConfirmacionButton.Padding = new Padding(10, 0, 0, 0);
            }
            else
            {
                BorrarConfirmacionButton.TextImageRelation = TextImageRelation.Overlay;
                BorrarConfirmacionButton.Text = string.Empty;
                BorrarConfirmacionButton.Width = 80;
                BorrarConfirmacionButton.ImageAlign = ContentAlignment.MiddleCenter;
                BorrarConfirmacionButton.Padding = new Padding(0);

            }
        }

        private void CrearConfirmacionButton_Click(object sender, EventArgs e)
        {
            if (DgvFacturas.Rows.Count == 0)
            {
                MessageBox.Show("No hay facturas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            codFactura = (int)DgvFacturas.SelectedRows[0].Cells[0].Value;

            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            FechaDebitacionPicker.Enabled = true;
            ImporteRecibidoNumeric.Enabled = true;
          

            CancelarButton.Enabled = true;
            GuardarDatosButton.Enabled = true;

            dgvCuentasEmpresa.Enabled = true;

            CrearConfirmacionButton.Enabled = false;
            BorrarConfirmacionButton.Enabled = false;

            materialTabControl1.SelectedTab = TabNueva;
            FechaDebitacionPicker.Focus();
        }

        private void DeshabilitarCampos()
        {
            FechaDebitacionPicker.Enabled = false;
            ImporteRecibidoNumeric.Enabled = false;
         

            CancelarButton.Enabled = false;
            GuardarDatosButton.Enabled = false;
            dgvCuentasEmpresa.Enabled = false;

            CrearConfirmacionButton.Enabled = true;
            BorrarConfirmacionButton.Enabled = true;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            FechaDebitacionPicker.Value = DateTime.Now;
            ImporteRecibidoNumeric.Value = 0;
            errorProvider1.Clear();
        }

        private void BorrarConfirmacionButton_Click(object sender, EventArgs e)
        {
            if(DgvListadoConfirmaciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay confirmaciones de cobro a borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Está seguro de borrar la confirmación de cobro?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (DgvListadoConfirmaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione la confirmación de cobro a borrar");
                return;
            }


            // Lógica de borrado de facturas (??) -> Confirmacion de cobro

            int codConf = (int)DgvListadoConfirmaciones.SelectedRows[0].Cells[0].Value;

            int? existe = ExecuteQuery.SelectCode(600, codConf);

            if (existe > 0)
            {
                MessageBox.Show("El pago ya fue sumado a la cuenta corriente ingresada. No puede ser borrado");
                return;
            }

            if (existe == 0)
            {
                ExecuteQuery.DeleteFrom(4, codConf);
                if (MessageException.message == "")
                {
                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.info100,
                        TitleText = "Mensaje",
                        ContentText = "La confirmación ha sido borrada con exito",
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F)

                    };
                    popup1.Popup();
                    ListarConfirmaciones();
                }
            }

            // CargarGrids();

        }

        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var fechaDebitacion = FechaDebitacionPicker.Value;
            var importeRecibido = ImporteRecibidoNumeric.Value;

            // var cuenta bancaria = etc
            // TODO: determinar si lo ingresado en el TextBox de cuenta bancaria es código o número de cuenta 
            // para mandarlo como parámetro
            // (Solucionado utilizando un datagrid)

            int codcuenta = (int)dgvCuentasEmpresa.SelectedRows[0].Cells[0].Value;

            object[] parameters =
            {
                codFactura,
                codcuenta,
                fechaDebitacion.ToShortDateString(),
                (int)importeRecibido
            };

            ExecuteQuery.InsertInto(40, parameters);
            // InsertConfirmación(codFactura, cuentaBancaria, fechaDebitacion, importeRecibido);
            if (MessageException.message == "")
            {
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_success1,
                    TitleText = "Mensaje",
                    ContentText = "La confirmación ha sido insertada con exito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();

                CancelarButton_Click(sender, e);

                //CargarGrids();
                ListarFacturas();
                ListarConfirmaciones();
            }
        }

        private bool ValidarCampos()
        {
            if (ImporteRecibidoNumeric.Value == 0)
            {
                errorProvider1.SetError(DineroLabel, "Ingrese un importe mayor a cero (0)");
                ImporteRecibidoNumeric.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (dgvCuentasEmpresa.SelectedRows.Count  == 0)
            {
                errorProvider1.SetError(dgvCuentasEmpresa, "Seleccione una cuenta bacaria");
                dgvCuentasEmpresa.Focus();
                return false;
            }
            errorProvider1.Clear();


            return true;
        }

        private void CodConfirmacionBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            int codigo = 0;
            if (CodConfirmacionBusquedaTextBox.Text != "")
            {
                if (Int32.TryParse(CodConfirmacionBusquedaTextBox.Text, out codigo))
                {
                    DgvListadoConfirmaciones.DataSource = ExecuteQuery.SelectOne(500, codigo);
                }
            }
            else
            {
                ListarConfirmaciones();
            }
        }

        private void CodCuentaBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            int codigo = 0;
            if (CodCuentaBusquedaTextBox.Text != "")
            {
                if (Int32.TryParse(CodCuentaBusquedaTextBox.Text, out codigo))
                {
                    DgvListadoConfirmaciones.DataSource = ExecuteQuery.SelectOne(501, codigo);
                }
            }
            else
            {
                ListarConfirmaciones();
            }
        }
    }
}

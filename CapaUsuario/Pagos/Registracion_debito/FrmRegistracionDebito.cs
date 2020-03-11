using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

using CapaDatos;

namespace CapaUsuario.Pagos.Registracion_debito
{
    public partial class FrmRegistracionDebito : Form
    {
        public FrmRegistracionDebito()
        {
            InitializeComponent();
        }

        private void ListarRegistraciones()
        {
            DgvListadoRegistraciones.DataSource = ExecuteQuery.SelectAll(203);
        }

        private void ListarOrdenes()
        {
            DgvOrdenesPago.DataSource = ExecuteQuery.SelectAll(202);
        }

        private void CrearRegistracionButton_Click(object sender, EventArgs e)
        {


            if (DgvOrdenesPago.Rows.Count == 0)
            {
                MessageBox.Show("No hay órdenes de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Está seguro de registrar la orden de pago?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int codOrden = (int)DgvOrdenesPago.SelectedRows[0].Cells[0].Value;
            var fecha = DateTime.Now;
            int importe = Convert.ToInt32(DgvOrdenesPago.SelectedRows[0].Cells[2].Value);
            int cuentaEmpresa = (int)DgvOrdenesPago.SelectedRows[0].Cells[5].Value;
            int codProveedor = (int)DgvOrdenesPago.SelectedRows[0].Cells[4].Value;

            // InsertRegistracion(codOrden, fecha);

            /* 
             * Modificar:
             * 
             *  La orden de pago seleccionada -> el atributo "Debitada" pasa a ser true
             *  
             *  Cuenta bancaria de empresa -> se resta "Importe" de la factura asociada a la orden de pago a "Saldo" de la cuenta bancaria
             *  
             *  Cuenta corriente proveedor -> se resta "Importe" a "Debe" a la cuenta corriente del proveedor que figura en la orden de pago
             * 
             */

            object[] parameters =
            {
                codOrden,
                fecha.ToShortDateString()
            };

            ExecuteQuery.InsertInto(21, parameters);
            if (MessageException.message == "")
            {
                ExecuteQuery.UpdateOne(2, codOrden,"Relleno");
                if (MessageException.message == "")
                {
                    ExecuteQuery.UpdateOne(3, cuentaEmpresa, importe);
                    if (MessageException.message == "")
                    {
                        ExecuteQuery.UpdateOne(4, codProveedor, importe);
                        if (MessageException.message == "")
                        {
                            var popup1 = new PopupNotifier()
                            {
                                Image = Properties.Resources.info100,
                                TitleText = "Mensaje",
                                ContentText = "La orden ha sido registrada con exito",
                                ContentFont = new Font("Segoe UI Bold", 11F),
                                TitleFont = new Font("Segoe UI Bold", 10F)

                            };
                            popup1.Popup();
                            ListarOrdenes();
                            ListarRegistraciones();
                        }
                    }
                }
            }
            

        }

        private void FrmRegistracionDebito_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            //ListarGrids();
            ListarOrdenes();
            ListarRegistraciones();

            FrmRegistracionDebito_SizeChanged(sender, e);
        }

        private void FrmRegistracionDebito_SizeChanged(object sender, EventArgs e)
        {
            DgvOrdenesPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoRegistraciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CodOrdenBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
          
            // Lógica de filtrado de ordenes de pago por código de orden de pago
            if (CodOrdenBusquedaTextBox.Text == "")
            {
                ListarOrdenes();
            }
            else
            {
                if (!int.TryParse(CodOrdenBusquedaTextBox.Text.Trim(), out int val))
                {
                    MessageBox.Show("Ingrese solo valores numéricos", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    CodOrdenBusquedaTextBox.Text = string.Empty;
                    return;
                }
                DgvOrdenesPago.DataSource = ExecuteQuery.SelectOne(204, val);
            }
        }
    }
}

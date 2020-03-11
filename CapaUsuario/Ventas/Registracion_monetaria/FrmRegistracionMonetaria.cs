using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

using CapaDatos;

namespace CapaUsuario.Ventas.Registracion_monetaria
{
    public partial class FrmRegistracionMonetaria : Form
    {
        public FrmRegistracionMonetaria()
        {
            InitializeComponent();
        }

        private void FrmRegistracionMonetaria_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;

            // Logica para cargar los Grids
            ListarFacturas();
            ListarRegistraciones();
            ListarNotas();
            FrmRegistracionMonetaria_SizeChanged(sender, e);
        }

        private void ListarRegistraciones()
        {
            DgvListadoRegistraciones.DataSource = ExecuteQuery.SelectAll(3017);
        } 

        private void ListarFacturas()
        {
            DgvListadoFacturas.DataSource = ExecuteQuery.SelectAll(3016);
        }

        private void ListarNotas()
        {
            DgvListadoNotasCredito.DataSource = ExecuteQuery.SelectAll(3015);
        }

        private void CrearRegisFacturaButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty("facturas", DgvListadoFacturas)) return;

            var rta = MessageBox.Show("¿Está seguro de grabar una registración por la factura seleccionada?",
                "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int codFactura = (int)DgvListadoFacturas.SelectedRows[0].Cells[0].Value;

            int importe = Convert.ToInt32(DgvListadoFacturas.SelectedRows[0].Cells[2].Value); // --> sumarlo al campo "Haber" en cuenta corriente

            // Lógica de obtención de nº de cuenta corriente del cliente e insertado de la registración,
            // con código de nota de crédito en null

            int codCC = (int)ExecuteQuery.SelectCode(8005, codFactura);

            if (codCC == -1 || codCC == 0)
            {
                MessageBox.Show("El usuario no tiene cuenta corriente por lo tanto no se le puede hacer una registración");
                return;
            }

            object[] parameters =
            {
                codFactura,
                0,
                codCC
            };

            ExecuteQuery.InsertInto(310, parameters);

            if (MessageException.message == "")
            {
                ExecuteQuery.UpdateOne(400008, codFactura, "Relleno");
                if (MessageException.message == "")
                { 

                    ExecuteQuery.UpdateOne(400011, codCC, importe);
                    if (MessageException.message == "")
                    {
                        var popup = new PopupNotifier()
                        {
                            Image = Properties.Resources.sql_success1,
                            TitleText = "Mensaje",
                            ContentText = "Registración por factura grabada con éxito",
                            ContentFont = new Font("Segoe UI Semilight", 10F),
                            TitleFont = new Font("Segoe UI Bold", 10F),
                            ImagePadding = new Padding(10)
                        };
                        popup.Popup();
                        ListarFacturas();
                        ListarRegistraciones();
                    }
                }
            }

        }

        private void CrearRegisNotaCreditoButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty("notas de crédito", DgvListadoNotasCredito)) return;

            var rta = MessageBox.Show("¿Está seguro de grabar una registración por la nota de crédito seleccionada?",
               "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int codNotaCredito = (int)DgvListadoNotasCredito.SelectedRows[0].Cells[0].Value;

            int importe = Convert.ToInt32( DgvListadoNotasCredito.SelectedRows[0].Cells[2].Value); // --> sumarlo al campo "Debe" en cuenta corriente

            // Lógica de obtención de nº de cuenta corriente del cliente e insertado de la registración,
            // con código de factura en null

            // Modificar en la tabla "devolucion_venta" el campo "estado" a 'Finalizado con nota de crédito'
            // y en la tabla "nota_credito_cliente" el campo "sumada" a true

            int codCC = (int)ExecuteQuery.SelectCode(8006, codNotaCredito);

            if (codCC == -1 || codCC == 0)
            {
                MessageBox.Show("El usuario no tiene cuenta corriente por lo tanto no se le puede hacer una registración");
                return;
            }

            object[] parameters =
            {
                0,
                codNotaCredito,
                codCC
            };

            ExecuteQuery.InsertInto(310, parameters);
            if (MessageException.message == "")
            {
                ExecuteQuery.UpdateOne(400009, codNotaCredito, "relleno");
                if (MessageException.message == "")
                {
                    ExecuteQuery.UpdateOne(400010, codCC, importe);
                    if (MessageException.message == "")
                    {
                        var popup = new PopupNotifier()
                        {
                            Image = Properties.Resources.sql_success1,
                            TitleText = "Mensaje",
                            ContentText = "Registración por nota de crédito grabada con éxito",
                            ContentFont = new Font("Segoe UI Semilight", 10F),
                            TitleFont = new Font("Segoe UI Bold", 10F),
                            ImagePadding = new Padding(10)
                        };
                        popup.Popup();
                        ListarRegistraciones();
                        ListarNotas();
                    }
                }
            }

        }

        private bool IsGridEmpty(string msg, DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count == 0)
            {
                MessageBox.Show($"No hay {msg}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CodRegisTextBox_TextChanged(object sender, EventArgs e)
        {
            // Lógica para filtrado de registraciones por código de registración
        }

        private void FrmRegistracionMonetaria_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoRegistraciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoNotasCredito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

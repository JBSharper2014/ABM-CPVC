using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Ventas.Factura_venta
{
    public partial class FrmFacturaVenta : Form
    {
        private int codRemito;
        private int codFactura;
        private bool esNuevo;

        public FrmFacturaVenta()
        {
            InitializeComponent();
        }

        private void Listar_remitos()
        {
            DgvRemitosVenta.DataSource = ExecuteQuery.SelectAll(3009);
        }

        private void Listar_facturas()
        {
            DgvListadoFacturas.DataSource = ExecuteQuery.SelectAll(3010);
        }

        private void FrmFacturaVenta_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FrmFacturaVenta_SizeChanged(sender, e);
            Listar_facturas();
            Listar_remitos();
        }

        private void HabilitarCampos()
        {
            ObservacionesTextBox.ReadOnly = false;

            GuardarCambiosButton.Enabled = true;
            CancelarButton.Enabled = true;

            CrearFacturaButton.Enabled = false;

            ObservacionesTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            ObservacionesTextBox.ReadOnly = true;
            ObservacionesTextBox.Text = string.Empty;

            GuardarCambiosButton.Enabled = false;
            CancelarButton.Enabled = false;

            CrearFacturaButton.Enabled = true;

        }

        private void CrearFacturaButton_Click(object sender, EventArgs e)
        {
            if (DgvRemitosVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay remitos de venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(DgvRemitosVenta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione un remito de venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            esNuevo = true;
            codRemito = (int)DgvRemitosVenta.SelectedRows[0].Cells[0].Value;

            HabilitarCampos();
            materialTabControl1.SelectedTab = TabAdmin;

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private void ModificarFacturaButton_Click(object sender, EventArgs e)
        {
            if (DgvListadoFacturas.Rows.Count == 0)
            {
                MessageBox.Show("No hay facturas a modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            codFactura = (int)DgvListadoFacturas.SelectedRows[0].Cells[0].Value;
            esNuevo = false;
            GuardarCambiosButton.Text = "Guardar cambios";
            HabilitarCampos();
            materialTabControl1.SelectedTab = TabAdmin;

            // ObservacionesTextBox.Text =  Logica para obtener la descripción de la factura

        }

        private void GuardarCambiosButton_Click(object sender, EventArgs e)
        {
            decimal importe = 0;
            DataTable dt = new DataTable();
            int cod_pedido;

            DialogResult rta = MessageBox.Show(esNuevo ?
               "¿Grabar factura?"
               : "¿Guardar cambios?"
               , "Confirmación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            // Logica para insertar la factura
            cod_pedido = (int)ExecuteQuery.SelectCode(8004, codRemito);
            dt = ExecuteQuery.SelectOne(7010, cod_pedido);

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                importe += (decimal)dt.Rows[i].ItemArray[1] * (int)dt.Rows[i].ItemArray[2];
            }
            
            

            object[] parameters =
            {
                codRemito,
                importe.ToString(),
                ObservacionesTextBox.Text,
                0
            };
            ExecuteQuery.InsertInto(308, parameters);
            if (MessageException.message == "")
            {
                
                //MessageBox.Show("Factura de venta insertada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_success1,
                    TitleText = "Mensaje",
                    ContentText = "Factura de venta insertada con éxito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();
                Listar_facturas();
                Listar_remitos();
            }

         

            DeshabilitarCampos();
            GuardarCambiosButton.Text = "Grabar factura";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {


            if (DgvListadoFacturas.SelectedRows.Count > 0)
            {
                ObservacionesTextBox.Text = (string)DgvListadoFacturas.SelectedRows[0].Cells[3].Value;
                materialTabControl1.SelectedTab = TabAdmin;
            }
            else
            {
                MessageBox.Show("Primero seleccione un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmFacturaVenta_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvRemitosVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}

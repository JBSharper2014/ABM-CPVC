using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Compras.Registracion
{
    public partial class FrmRegistracion : Form
    {
        DInformeRecep dInformeRecep;
        DPedidoReaprov pedidoReaprov;
        DRegistracion dRegistracion;
        private DStockPedidoReaprov dStockPedido;
        private DStock dStock;

        public FrmRegistracion()
        {
            InitializeComponent();
        }

        private void FrmRegistracion_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            SelectInformes();
            SelectRegistraciones();
        }

        private void SelectRegistraciones()
        {
            dRegistracion = new DRegistracion();
            DgvRegistraciones.DataSource = dRegistracion.SelectRegistracionesCompras();
            DgvRegistraciones.Refresh();
        }

        private void SelectInformes()
        {
            dInformeRecep = new DInformeRecep();
            DgvInformes.DataSource = dInformeRecep.SelectInformesSinRegistracion();
            DgvInformes.Refresh();
        }

        private void FrmRegistracion_SizeChanged(object sender, EventArgs e)
        {
            DgvRegistraciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CodRegistracionBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            var codRegistracion = CodRegistracionBusquedaTextBox.Text.Trim();
            if (codRegistracion != string.Empty)
            {

                if (!int.TryParse(codRegistracion, out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodRegistracionBusquedaTextBox.Text = string.Empty;
                    return;
                }


                DgvInformes.DataSource =
                    dRegistracion.SelectRegistracionesComprasByCodReg(int.Parse(codRegistracion));
                DgvInformes.Refresh();
            }
            else
            {
                SelectRegistraciones();
            }
        }

        private void CrearRegistracionButton_Click(object sender, EventArgs e)
        {
            if (DgvInformes.RowCount == 0)
            {
                MessageBox.Show("No hay informe de recepción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Registrar informe de recepción y sus productos?", "Confirmación"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            // 0. Insertar registración

            dRegistracion = new DRegistracion();
            var codInforme = (int)DgvInformes.SelectedRows[0].Cells[0].Value;

            dRegistracion.InsertRegistracionCompra(codInforme, DateTime.Now);


            // 1. Obtener la orden de compra del informe

            var codOrdenCompra = (int)DgvInformes.SelectedRows[0].Cells[1].Value;

            // 2. Obtener pedido reaprov. o solicitud

            pedidoReaprov = new DPedidoReaprov();

            var codPR = pedidoReaprov.GetCodPedidoReaprovByCodOrdenCompra(codOrdenCompra);

            // 3. Obtener productos del pedido

            dStockPedido = new DStockPedidoReaprov();
            var dt2 = dStockPedido.GetStockEnPedidoReaprov(codPR);

            // 4. Modificar stock


            try
            {
                dStock = new DStock();

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    dStock.UpdateStockActualRegis(
                        (int)dt2.Rows[i]["CodStock"],
                        (int)dt2.Rows[i]["Cantidad"]);

                }

                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_success1,
                    TitleText = "Mensaje",
                    ContentText = "Se registró el informe con éxito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectInformes();
            SelectRegistraciones();

        }
    }
}

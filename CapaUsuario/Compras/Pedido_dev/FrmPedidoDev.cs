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

namespace CapaUsuario.Compras.Pedido_dev
{
    public partial class FrmPedidoDev : Form
    {
        CapaDatos.DPedidoDev pedidoDev = new CapaDatos.DPedidoDev();
        public FrmPedidoDev()
        {
            InitializeComponent();
        }

        private void FrmPedidoDev_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarPedidos();
            CargarInformes();
        }

        private void CargarPedidos()
        {
            DgvPedidos.DataSource = pedidoDev.SelectPedidosDev();
        }

        private void CargarInformes()
        {
            var informeRecep = new CapaDatos.DInformeRecep();
            DgvInformes.DataSource = informeRecep.SelectInformesRecepcionSinProcesar();
            DgvInformes.Refresh();
        }

        private void FrmPedidoDev_SizeChanged(object sender, EventArgs e)
        {
            DgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (DgvPedidos.RowCount == 0)
            {
                MessageBox.Show("No hay pedidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codPedido = (int)DgvPedidos.SelectedRows[0].Cells[0].Value;
            if (pedidoDev.PedidoDevolucionTieneInformeAsociado(codPedido))
            {
                MessageBox.Show("El pedido tiene un informe de recepción asociado, no puede borrarse", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pedidoDev.PedidoDevolucionTieneNotaCreditoAsociada(codPedido))
            {
                MessageBox.Show("El pedido tiene una nota de crédito asociada, no puede borrarse", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cod_ir = (int)DgvInformes.SelectedRows[0].Cells[0].Value;

            var msg = pedidoDev.DeletePedidoDev(cod_ir);

            var popup1 = new PopupNotifier()
            {
                Image = msg == "Se eliminó el registro correctamente" ? Properties.Resources.info100 : Properties.Resources.sql_error,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
                ImagePadding = msg == "Se eliminó el registro correctamente" ? new Padding(0) : new Padding(10)
            };
            popup1.Popup();
        }

        private void CrearPedidoButon_Click(object sender, EventArgs e)
        {
            if (DgvInformes.RowCount == 0)
            {
                MessageBox.Show("No hay informes de recepción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DgvInformes.SelectedRows[0].Cells[6].Value.ToString() != "Fallido")
            {
                MessageBox.Show("El informe de recepción tiene un exitoso control de calidad, no puede crearse", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cod_ir = (int)DgvInformes.SelectedRows[0].Cells[0].Value;

            try
            {
                pedidoDev.InsertPedidoDev(cod_ir, DateTime.Now);

                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_success1,
                    ContentText = "Se ingresó el registro correctamente",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            CargarInformes();
            CargarPedidos();
        }

        private void CodPedidoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodPedidoTextBox.Text.Trim() != string.Empty)
            {
                if (!int.TryParse(CodPedidoTextBox.Text.Trim(), out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodPedidoTextBox.Text = string.Empty;
                    return;
                }

                DgvPedidos.DataSource = pedidoDev.SelectPedidosDevByCodPedDev(int.Parse(CodPedidoTextBox.Text.Trim()));
                DgvPedidos.Refresh();
            }
            else
            {
                CargarPedidos();
            }
        }

        private void CodPedidoTextBox_TextChanged_1(object sender, EventArgs e)
        {
            CodPedidoTextBox_TextChanged(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CapaDatos;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Compras.Orden_de_Compra
{
    public partial class FrmOrdenDeCompra : Form
    {
        DOrdenCompra ordenCompra = new DOrdenCompra();
        private DSolicitudCompra solicitud;
        private DPedidoReaprov pedido;
        private bool isPedido;
        private DCotizacionSC cotSC;
        private DCotizacionPR cotPR;

        public FrmOrdenDeCompra()
        {
            InitializeComponent();
        }

        private void FrmOrdenDeCompra_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarListados();
            FrmOrdenDeCompra_SizeChanged(sender, e);
            //PersonalizarGrids();
        }

        private void PersonalizarGridDetalle()
        {
            if (isPedido)
            {
                DgvDetalleCompra.Columns["CodStock"].HeaderText = "Código de producto";
            }
            else
            {
                DgvDetalleCompra.Columns["CodBienUso"].HeaderText = "Código de bien de uso";

            }
        }

        private void PersonalizarGridCotizacion()
        {
            Dgv2.Columns["CodCotizacion"].HeaderText = "Código de cotización";
        }



        private void CargarListados()
        {
            CargarOrdenes();
            CargarSolicitudes();
            CargarPedidos();
        }

        private void CargarSolicitudes()
        {
            solicitud = new DSolicitudCompra();
            DgvSolicitudes.DataSource = solicitud.SelectSCSinOrdenCompra();
            DgvSolicitudes.Refresh();
        }

        private void CargarOrdenes()
        {
            DgvOrdenesCompra.DataSource = ordenCompra.SelectOrdenesCompra();
            DgvOrdenesCompra.Refresh();
        }

        private void CargarPedidos()
        {
            pedido = new DPedidoReaprov();
            DgvPedidos.DataSource = pedido.SelectPRSinOrdenCompra();
            DgvPedidos.Refresh();
        }
        private void FrmOrdenDeCompra_SizeChanged(object sender, EventArgs e)
        {
            DgvOrdenesCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDetalleCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PedidoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PedidoRadioButton.Checked)
            {
                DgvOrdenesCompra.DataSource = ordenCompra.SelectOrdenesCompraByTipo("PR");
                DgvOrdenesCompra.Refresh();
            }
            else if (SolicitudRadioButton.Checked)
            {
                DgvOrdenesCompra.DataSource = ordenCompra.SelectOrdenesCompraByTipo("SC");
                DgvOrdenesCompra.Refresh();
            }
            else
            {
                CargarOrdenes();
            }
        }

        private void SolicitudRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SolicitudRadioButton.Checked)
            {
                DgvOrdenesCompra.DataSource = ordenCompra.SelectOrdenesCompraByTipo("SC");
                DgvOrdenesCompra.Refresh();
            }
            else if (PedidoRadioButton.Checked)
            {
                DgvOrdenesCompra.DataSource = ordenCompra.SelectOrdenesCompraByTipo("PR");
                DgvOrdenesCompra.Refresh();
            }
            else
            {
                CargarOrdenes();
            }
        }

        private void CrearOrdenPedidoButton_Click(object sender, EventArgs e)
        {
            if (DgvPedidos.RowCount == 0)
            {
                MessageBox.Show("No hay pedidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isPedido = true;
            DeshabilitarBotones();
            materialTabControl1.SelectedTab = TabNueva;
            var stock = new DStockPedidoReaprov();
            DgvDetalleCompra.DataSource = stock.GetStockEnPedidoReaprov((int)DgvPedidos.SelectedRows[0].Cells[0].Value);
            DgvDetalleCompra.Refresh();
            PersonalizarGridDetalle();
        }


        private void CrearOrdenSolicitudButton_Click(object sender, EventArgs e)
        {
            if (DgvSolicitudes.RowCount == 0)
            {
                MessageBox.Show("No hay solicitudes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isPedido = false;
            DeshabilitarBotones();
            materialTabControl1.SelectedTab = TabNueva;
            var bienUso = new DSolicitudBienUso();
            DgvDetalleCompra.DataSource = bienUso.GetBienesUsoEnSolicitudCompra((int)DgvSolicitudes.SelectedRows[0].Cells[0].Value);
            DgvDetalleCompra.Refresh();
        }

        private void DgvDetalleCompra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (isPedido)
                {
                    cotPR = new DCotizacionPR();
                    Dgv2.DataSource = cotPR.SelectCotizacionesPRByCodStockAndCodPR((int)DgvDetalleCompra.SelectedRows[0].Cells[0].Value
                        , (int)DgvPedidos.SelectedRows[0].Cells[0].Value);
                    Dgv2.Refresh();

                    PersonalizarGridCotizacion();
                }
                else
                {
                    cotSC = new DCotizacionSC();
                    Dgv2.DataSource = cotSC.SelectCotizacionesSCByCodBienUsoAndCodSC((int)DgvDetalleCompra.SelectedRows[0].Cells[0].Value,
                        (int)DgvSolicitudes.SelectedRows[0].Cells[0].Value);
                    Dgv2.Refresh();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void DeshabilitarBotones()
        {
            CrearOrdenPedidoButton.Enabled = false;
            CrearOrdenSolicitudButton.Enabled = false;

            EmitirButton.Enabled = false;
            BorrarOrdenButton.Enabled = false;

            ConfirmarOrdenButton.Enabled = true;
            CancelarButton.Enabled = true;
        }

        private void HabilitarBotones()
        {
            CrearOrdenPedidoButton.Enabled = true;
            CrearOrdenSolicitudButton.Enabled = true;

            EmitirButton.Enabled = true;
            BorrarOrdenButton.Enabled = true;

            ConfirmarOrdenButton.Enabled = false;
            CancelarButton.Enabled = false;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarGridsDetalles();

            HabilitarBotones();
        }

        private void LimpiarGridsDetalles()
        {
            DgvDetalleCompra.DataSource = null;
            Dgv2.DataSource = null;

            DgvDetalleCompra.Refresh();
            Dgv2.Refresh();
        }

        private void ConfirmarOrdenButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvDetalleCompra.RowCount; i++)
            {
                DataTable dtDetalle = (DataTable)DgvDetalleCompra.DataSource;
                var codProducto = 0;
                var codCotizacion = 0;
                decimal precioCot;

                // Comprobamos que todos los productos de la orden de compra tengan una cotización
                if (isPedido)
                {
                    codProducto = (int)dtDetalle.Rows[i]["CodStock"];

                    cotPR = new DCotizacionPR();
                    var dtCot = cotPR.SelectCotizacionesPRByCodStockAndCodPR(codProducto
                        , (int)DgvPedidos.SelectedRows[0].Cells[0].Value);

                    codCotizacion = (int)dtCot.Rows[0]["CodCotizacion"];

                    precioCot = cotPR.GetPrecioCotizadoByCodCotizacionPR(codProducto, codCotizacion);

                    if (precioCot <= 0)
                    {
                        MessageBox.Show("Alguno de los productos del detalle de orden de compra no tiene una cotización."
                            + Environment.NewLine + "Revise las cotizaciones.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CancelarButton_Click(sender, e);
                        return;
                    }

                }
                else
                {
                    codProducto = (int)dtDetalle.Rows[i]["CodBienUso"];

                    cotSC = new DCotizacionSC();
                    var dtCot = cotPR.SelectCotizacionesPRByCodStockAndCodPR(codProducto
                        , (int)DgvSolicitudes.SelectedRows[0].Cells[0].Value);

                    codCotizacion = (int)dtCot.Rows[0]["CodCotizacion"];

                    precioCot = cotSC.GetPrecioCotizadoByCodBienUsoSC(codProducto, codCotizacion);

                    if (precioCot <= 0)
                    {
                        MessageBox.Show("Alguno de los productos del detalle de orden de compra no tiene una cotización."
                            + Environment.NewLine + "Revise las cotizaciones.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CancelarButton_Click(sender, e);
                        return;
                    }
                }
            }

            var rta = MessageBox.Show("¿Realizar orden de compra?", "Confirmación", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            string msg;
            try
            {
                int codOrdenCompra = ordenCompra.InsertOrdenCompra(false, isPedido ? "PR" : "SC");

                if (isPedido)
                {
                    cotPR.UpdateCotizacionPR((int)DgvPedidos.SelectedRows[0].Cells[0].Value, codOrdenCompra);

                }
                else
                {
                    cotSC.UpdateCotizacionSC((int)DgvSolicitudes.SelectedRows[0].Cells[0].Value, codOrdenCompra);
                }

                msg = "Se ingresó la orden de compra correctamente";
            }
            catch (Exception ex)
            {
                msg = "Error al ingresar la orden de compra";
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var popup1 = new PopupNotifier()
            {
                Image = msg == "Se ingresó la orden de compra correctamente" ?
                    Properties.Resources.sql_success1 : Properties.Resources.sql_error,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
                ImagePadding = new Padding(10)
            };
            popup1.Popup();

            HabilitarBotones();
            LimpiarGridsDetalles();
            CargarListados();
        }

        private void BorrarOrdenButton_Click(object sender, EventArgs e)
        {

            if (DgvOrdenesCompra.RowCount == 0)
            {
                MessageBox.Show("No hay órdenes de compra a borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((bool)DgvOrdenesCompra.SelectedRows[0].Cells[1].Value)
            {
                MessageBox.Show("No se puede borrar la orden de compra, se encuentra emitida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Borrar orden de compra?", "Confirmación", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            try
            {
                ordenCompra.DeleteOrdenCompra((int)DgvOrdenesCompra.SelectedRows[0].Cells[0].Value);

                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "Se eliminó la orden de compra correctamente",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                };
                popup1.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarListados();
        }

        private void EmitirButton_Click(object sender, EventArgs e)
        {
            if (DgvOrdenesCompra.RowCount == 0)
            {
                MessageBox.Show("No hay órdenes de compra a emitir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Emitir orden de compra?", "Confirmación", MessageBoxButtons.YesNo
               , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            string msg = ordenCompra.EmitirOrdenCompra((int)DgvOrdenesCompra.SelectedRows[0].Cells[0].Value, DateTime.Now);

            var popup1 = new PopupNotifier()
            {
                Image = msg == "Se emitió la orden de compra correctamente" ? Properties.Resources.info100 : Properties.Resources.sql_error,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
            };
            popup1.Popup();

            CargarOrdenes();
        }
    }
}

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

namespace CapaUsuario.Cotizaciones
{
    public partial class FrmCotizaciones : Form
    {
        private bool isPedido;
        DCotizacionPR dCotizacionPR;
        DCotizacionSC dCotizacionSC;
        public FrmCotizaciones()
        {
            InitializeComponent();
        }

        private void FrmCotizaciones_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarSolicitudes();
            CargarPedidos();
            CargarCotizacionesSolicitud();
            CargarCotizacionesPedido();

            //ProveedorComboBox.SelectedIndex = -1;
            FrmCotizaciones_SizeChanged(sender, e);
        }

        private void CargarPedidos()
        {
            var pedido = new DPedidoReaprov();
            DgvPedidos.DataSource = pedido.SelectPedidosReaprovSinCotizacion();
            DgvPedidos.Refresh();
        }

        private void CargarSolicitudes()
        {
            var solicitud = new DSolicitudCompra();
            DgvSolicitudes.DataSource = solicitud.SolicitudCompraSinCotizacion();
            DgvSolicitudes.Refresh();
        }

        private void CargarCotizacionesPedido()
        {
            dCotizacionPR = new DCotizacionPR();
            DgvCotizacionesPedidos.DataSource = dCotizacionPR.SelectCotizacionesPR();
            DgvCotizacionesPedidos.Refresh();
        }

        private void CargarCotizacionesSolicitud()
        {
            dCotizacionSC = new DCotizacionSC();
            DgvCotizacionesSolicitud.DataSource = dCotizacionSC.SelectCotizacionesSC();
            DgvCotizacionesSolicitud.Refresh();
        }

        private void FrmCotizaciones_SizeChanged(object sender, EventArgs e)
        {
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCotizacionesSolicitud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCotizacionesPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductosPorCotizar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void AgregarCotizacionSolicitudButton_Click(object sender, EventArgs e)
        {
            isPedido = false;
            var solicitudBuso = new DSolicitudBienUso();
            DgvProductosPorCotizar.DataSource =
                solicitudBuso.GetBienesUsoEnSolicitudCompra((int)DgvSolicitudes.SelectedRows[0].Cells[0].Value);
            DgvProductosPorCotizar.Refresh();

            HabilitarCampos();
            materialTabControl1.SelectedTab = TabNueva;
        }

        private void AgregarCotizacionPedidoButton_Click(object sender, EventArgs e)
        {
            isPedido = true;
            var stockPedido = new DStockPedidoReaprov();
            DgvProductosPorCotizar.DataSource =
                stockPedido.GetStockEnPedidoReaprov((int)DgvPedidos.SelectedRows[0].Cells[0].Value);
            DgvProductosPorCotizar.Refresh();

            HabilitarCampos();
            materialTabControl1.SelectedTab = TabNueva;
        }

        private void HabilitarCampos()
        {
            CotizarProductoButton.Enabled = true;

            AgregarCotizacionPedidoButton.Enabled = false;
            AgregarCotizacionSolicitudButton.Enabled = false;
        }

        private void DeshabilitarCampos()
        {
            
            CotizarProductoButton.Enabled = false;

            AgregarCotizacionPedidoButton.Enabled = true;
            AgregarCotizacionSolicitudButton.Enabled = true;
        }

        private void DejarCotizarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }

        private void DgvProductosPorCotizar_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void CotizarProductoButton_Click(object sender, EventArgs e)
        {
            int codProducto = (int)DgvProductosPorCotizar.SelectedRows[0].Cells[0].Value;

            if (isPedido)
            {
                var stock = new DStock();
                if (!stock.StockTieneProveedorAsociado(codProducto))
                {
                    MessageBox.Show("El producto no tiene un proveedor asociado. Asígnele uno para seguir cotizando",
                        "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                var bienUso = new DBienUso();
                if (!bienUso.BienUsoTieneProveedorAsociado(codProducto))
                {
                    MessageBox.Show("El bien de uso no tiene un proveedor asociado. Asígnele uno para seguir cotizando",
                       "Mensaje",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            



            var rta = MessageBox.Show("¿Está seguro de cotizar el producto?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int codCotizacion;

            try
            {
                if (isPedido)
                {
                    codCotizacion = dCotizacionPR.InsertCotizacionPR(codProducto,
                       (int)DgvPedidos.SelectedRows[0].Cells[0].Value, "1 Semana", DateTime.Now, 0);

                    //dCotizacionPR.InsertCotizacionPRProveedor(codCotizacion, (int)ProveedorComboBox.SelectedValue);
                }
                else
                {
                    codCotizacion = dCotizacionSC.InsertCotizacionSC(codProducto,
                       (int)DgvSolicitudes.SelectedRows[0].Cells[0].Value, "1 Semana", DateTime.Now, 0);

                    //dCotizacionSC.InsertCotizacionSCProveedor(codCotizacion, (int)ProveedorComboBox.SelectedValue);
                }


                MessageBox.Show("Cotización realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar la cotización: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //DeshabilitarCampos();
           
            DgvProductosPorCotizar.Rows.RemoveAt(DgvProductosPorCotizar.CurrentRow.Index);
            if (DgvProductosPorCotizar.RowCount == 0)
            {
                if (isPedido)
                {
                    CargarPedidos();
                    CargarCotizacionesPedido();
                }
                else
                {
                    CargarSolicitudes();
                    CargarCotizacionesSolicitud();
                }

                DeshabilitarCampos();
            }
        }

        private void FrmCotizaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DgvProductosPorCotizar.RowCount != 0)
            {
                MessageBox.Show("Antes de salir, por favor, termine de cotizar los productos",
                     "Mensaje",
               MessageBoxButtons.OK, MessageBoxIcon.Information);


                e.Cancel = true;

            }
        }

        private void BorrarCotizacionPedidoButton_Click(object sender, EventArgs e)
        {
            int codCotizacion = (int)DgvCotizacionesPedidos.SelectedRows[0].Cells[0].Value;

            if (dCotizacionPR.CotizacionPRTieneOrdenCompraAsociada(codCotizacion))
            {
                MessageBox.Show("La cotización tiene una orden de compra asignada, no se puede borrar",
                    "Mensaje",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dCotizacionPR.DeleteCotizacionPR(codCotizacion);
                MessageBox.Show("La cotización fue borrada con éxito",
                   "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar la cotización: {ex.Message}",
                   "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int codCotizacion = (int)DgvCotizacionesSolicitud.SelectedRows[0].Cells[0].Value;

            if (dCotizacionSC.CotizacionSCTieneOrdenCompraAsociada(codCotizacion))
            {
                MessageBox.Show("La cotización tiene una orden de compra asignada, no se puede borrar",
                    "Mensaje",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dCotizacionSC.DeleteCotizacionSC(codCotizacion);
                MessageBox.Show("La cotización fue borrada con éxito",
                   "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar la cotización: {ex.Message}",
                   "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}

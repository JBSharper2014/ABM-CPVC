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

namespace CapaUsuario.Compras.Informe_recepcion
{
    public partial class FrmInformeRecepcion : Form
    {
        DInformeRecep informeRecep;
        private DOrdenCompra dOrdenCompra;
        DPedidoReaprov dPedido;
        DStockPedidoReaprov dStockPedido;
            
        public FrmInformeRecepcion()
        {
            InitializeComponent();
        }

        private void FrmInformeRecepcion_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarOrdenesCompra();
            CargarInformes();
            FrmInformeRecepcion_SizeChanged(sender, e);
        }

        private void CargarInformes()
        {
            informeRecep = new CapaDatos.DInformeRecep();
            DgvInformes.DataSource = informeRecep.SelectInformesRecepcion();
            DgvInformes.Refresh();
        }

        private void CargarOrdenesCompra()
        {
            var ordenCompra = new CapaDatos.DOrdenCompra();
            DgvOrdenesCompra.DataSource = ordenCompra.SelectOrdenCompraSinInforme();
            DgvOrdenesCompra.Refresh();
        }

        private void FrmInformeRecepcion_SizeChanged(object sender, EventArgs e)
        {
            DgvOrdenesCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductosOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CodInformeBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodInformeBusquedaTextBox.Text.Trim() != string.Empty)
            {

                if (!int.TryParse(CodInformeBusquedaTextBox.Text.Trim(), out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodInformeBusquedaTextBox.Text = string.Empty;
                    return;
                }


                DgvInformes.DataSource =
                    informeRecep.SelectInformesRecepcionByCodInforme(int.Parse(CodInformeBusquedaTextBox.Text.Trim()));
                DgvInformes.Refresh();
            }
            else
            {
                CargarInformes();
            }
        }

        private void BorrarInformeButton_Click(object sender, EventArgs e)
        {
            if (DgvInformes.RowCount == 0)
            {
                MessageBox.Show("No hay informes de recepción a borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CrearInformeButton_Click(object sender, EventArgs e)
        {
            if (DgvOrdenesCompra.RowCount == 0)
            {
                MessageBox.Show("No hay órdenes de compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dOrdenCompra = new DOrdenCompra();

            var codOrdenCompra = (int)DgvOrdenesCompra.SelectedRows[0].Cells[0].Value;

            if (!dOrdenCompra.OrdenCompraTieneFacturaAsociada(codOrdenCompra))
            {
                MessageBox.Show("La orden de compra no tiene una factura asociada, no se puede generar un informe",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            CargarDatosInforme(codOrdenCompra);

            if (!(DgvOrdenesCompra.SelectedRows[0].Cells[2].Value is DateTime))
            {
                MessageBox.Show("Debe emitir la orden de compra antes de seguir",
                   "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            HabilitarBotones();
            materialTabControl1.SelectedTab = TabNuevo;
        }

        private void CargarDatosInforme(int codOrdenCompra)
        {
            informeRecep = new DInformeRecep();
            dPedido = new DPedidoReaprov();
            dStockPedido = new DStockPedidoReaprov();


            var dt = informeRecep.GetDatosInformeByCodOrdenCompra(codOrdenCompra);


            var codPR = dPedido.GetCodPedidoReaprovByCodOrdenCompra(codOrdenCompra);


            var dt2 = dStockPedido.GetStockEnPedidoReaprov(codPR);

            CodOrdenCompraLabel.Text = dt.Rows[0]["CodOrdenCompra"].ToString();
            ProveedorLabel.Text = dt.Rows[0]["RazonSocial"].ToString();
            FechaEmisionLabel.Text = dt.Rows[0]["FechaEmision"].ToString();
            CodFacLabel.Text = dt.Rows[0]["CodFac"].ToString();
            FechaRecepcionLabel.Text = dt.Rows[0]["FechaRecep"].ToString();
            ImporteLabel.Text = dt.Rows[0]["Importe"].ToString();

            try
            {
                ObservacionesTextBox.Text = dt.Rows[0]["Observaciones"].ToString();
            }
            catch (Exception)
            {
                ObservacionesTextBox.Text = string.Empty;
            }

            DgvProductosOrden.DataSource = dt2;
            DgvProductosOrden.Refresh();

            //var nRows = DgvProductosOrden.RowCount;

            //for (int i = 0; i < nRows / 2; i++)
            //{
            //    DgvProductosOrden.Rows.RemoveAt(nRows - 1);
            //}

        }

        private void HabilitarBotones()
        {
            GuardarDatosButton.Enabled = true;
            CancelarNuevoButton.Enabled = true;

            ExitosoRadioButton.Enabled = true;
            FallidoRadioButton.Enabled = true;
        }

        private void DeshabilitarBotones()
        {
            GuardarDatosButton.Enabled = false;
            CancelarNuevoButton.Enabled = false;

            ExitosoRadioButton.Enabled = false;
            FallidoRadioButton.Enabled = false;

            ExitosoRadioButton.Checked = false;
            FallidoRadioButton.Checked = false;
        }

        private void LimpiarCampos()
        {
            ObservacionesTextBox.Text = string.Empty;
            ProblemasTextBox.Text = string.Empty;

            DgvProductosOrden.DataSource = null;
            DgvProductosOrden.Refresh();

            CodOrdenCompraLabel.Text = "---";
            ProveedorLabel.Text = "---";
            FechaEmisionLabel.Text = "---";
            FechaRecepcionLabel.Text = "---";
            CodFacLabel.Text = "---";
            ImporteLabel.Text = "---";
        }

        private void FallidoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FallidoRadioButton.Checked)
            {
                ProblemasTextBox.ReadOnly = false;
                ProblemasTextBox.Focus();
            }
            else
            {
                ProblemasTextBox.ReadOnly = true;
            }
        }

        private void CancelarNuevoButton_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            LimpiarCampos();
        }

        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            var rta = MessageBox.Show("¿Grabar informe de recepción?", "Cofirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            informeRecep = new DInformeRecep();

            var codOrdenCompra = int.Parse(CodOrdenCompraLabel.Text);
            var codFac = int.Parse(CodFacLabel.Text);
            var resultado_calidad = ExitosoRadioButton.Checked ? "Exitoso" : "Fallido";
            var problemas = ProblemasTextBox.Text != string.Empty ? ProblemasTextBox.Text : "";
            var estado_pd = "Sin procesar";
            var fechaCreacion = DateTime.Now;

            var msg = informeRecep.InsertInformeRecep(codOrdenCompra, codFac, resultado_calidad, problemas, estado_pd, fechaCreacion);

            var popup1 = new PopupNotifier()
            {
                Image = msg == "Se ingresó el registro correctamente" ?
                    Properties.Resources.sql_success1 : Properties.Resources.sql_error,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
                ImagePadding = new Padding(10)
            };
            popup1.Popup();

            LimpiarCampos();
            DeshabilitarBotones();
            CargarInformes();
            CargarOrdenesCompra();
        }

        private bool Validar()
        {
            if(!(ExitosoRadioButton.Checked && FallidoRadioButton.Checked))
            {
                if (FallidoRadioButton.Checked)
                {
                    if (ProblemasTextBox.Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese los problemas encontrados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                if (ExitosoRadioButton.Checked)
                {
                    return true;
                }

                MessageBox.Show("Seleccione un resultado de control de calidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            

            return true;
        }
    }
}

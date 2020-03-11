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

namespace CapaUsuario.Compras.Factura_prov
{
    public partial class FrmFacurasProv : Form
    {
        CapaDatos.DFacturasProv dFactura = new CapaDatos.DFacturasProv();
        CapaDatos.DOrdenCompra dOrdenCompra = new CapaDatos.DOrdenCompra();
        private bool isNueva;
        private bool isPedido;

        public FrmFacurasProv()
        {
            InitializeComponent();
        }

        private void FrmFacurasProv_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarOrdenesCompra();
            CargarFacturas();
            FrmFacurasProv_SizeChanged(sender, e);
        }

        private void CargarOrdenesCompra()
        {
            DgvOrdenesCompra.DataSource = dOrdenCompra.SelectOrdenesCompraSinFactura();
            DgvOrdenesCompra.Refresh();
        }

        private void CargarFacturas()
        {
            DgvFacturas.DataSource = dFactura.SelectFacturas();
            DgvFacturas.Refresh();
        }

        private void FrmFacurasProv_SizeChanged(object sender, EventArgs e)
        {
            DgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrdenesCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CodFacturaBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodFacturaBusquedaTextBox.Text.Trim() != string.Empty)
            {

                if (!int.TryParse(CodFacturaBusquedaTextBox.Text.Trim(), out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodFacturaBusquedaTextBox.Text = string.Empty;
                    return;
                }


                DgvFacturas.DataSource =
                    dFactura.SelectFacturasByCodFactura(int.Parse(CodFacturaBusquedaTextBox.Text.Trim()));
                DgvFacturas.Refresh();
            }
            else
            {
                CargarFacturas();
            }
        }

        private void NuevaFacturaButton_Click(object sender, EventArgs e)
        {
            if (DgvOrdenesCompra.RowCount == 0)
            {
                MessageBox.Show("No hay órdenes de compra", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codOrdenCompra = (int)DgvOrdenesCompra.SelectedRows[0].Cells[0].Value;
            var tipoOrden = dOrdenCompra.GetTipoOrdenCompra(codOrdenCompra);

            if (tipoOrden == "PR")
            {
                isPedido = true;
            }
            else
            {
                isPedido = false;
            }

            HabilitarCampos();
            isNueva = true;
            CalcularImporteFactura(codOrdenCompra);
        }

        private void CalcularImporteFactura(int codOrdenCompra)
        {
            decimal importeFAC;

            importeFAC = isPedido
                ? dFactura.CalcularImporteDeFacturaPR(codOrdenCompra)
                : dFactura.CalcularImporteDeFacturaSC(codOrdenCompra);

            ImporteTextBox.Text = importeFAC.ToString("N2");
        }

        private void HabilitarCampos()
        {
            ImporteTextBox.ReadOnly = false;
            NumFacTextBox.ReadOnly = false;
            ObservacionesTextBox.ReadOnly = false;

            GuardarDatosButton.Enabled = true;
            CancelarNuevoButton.Enabled = true;

            CodFacturaBusquedaTextBox.ReadOnly = true;

            materialTabControl1.SelectedTab = TabNueva;

            ImporteTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            ImporteTextBox.ReadOnly = true;
            NumFacTextBox.ReadOnly = true;
            ObservacionesTextBox.ReadOnly = true;

            GuardarDatosButton.Enabled = false;
            CancelarNuevoButton.Enabled = false;

            CodFacturaBusquedaTextBox.ReadOnly = true;
        }

        private void LimpiarCampos()
        {
            ImporteTextBox.Text = string.Empty;
            NumFacTextBox.Text = string.Empty;
            ObservacionesTextBox.Text = string.Empty;
        }

        private void CancelarNuevoButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void ModificarFacturaButton_Click(object sender, EventArgs e)
        {
            if (DgvFacturas.RowCount == 0)
            {
                MessageBox.Show("No hay facturas a modificar", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FacturaProvTieneInformeAsociado((int)DgvFacturas.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("La factura tiene un informe de recepción asociado, no se puede modificar", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImporteTextBox.Text = DgvFacturas.SelectedRows[0].Cells[4].Value.ToString();

            NumFacTextBox.Text = DgvFacturas.SelectedRows[0].Cells[2].Value.ToString();
            try
            {
                ObservacionesTextBox.Text = dFactura.GetObservacionesFacturaProv((int)DgvFacturas.SelectedRows[0].Cells[2].Value);
            }
            catch (Exception)
            {
                ObservacionesTextBox.Text = string.Empty;
            }


            isNueva = false;
            HabilitarCampos();
        }

        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var rta = MessageBox.Show("¿Guardar datos?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            var dCuentaCorriente = new CapaDatos.DCuentaCorriente();


            string msg;
            var codOrdenCompra = (int)DgvOrdenesCompra.SelectedRows[0].Cells[0].Value;
            var numFac = int.Parse(NumFacTextBox.Text.Trim());
            var importe = decimal.Parse(ImporteTextBox.Text);
            var observaciones = ObservacionesTextBox.Text;

            if (isNueva)
            {
                msg = dFactura.InsertFacturaProv(codOrdenCompra, numFac, DateTime.Now, importe, observaciones, false);

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se ingresó la factura correctamente" ? Properties.Resources.sql_success1 : Properties.Resources.sql_error,
                    TitleText = "Mensaje",
                    ContentText = msg,
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();
            }
            else
            {
                msg = dFactura.UpdateFactura((int)DgvFacturas.SelectedRows[0].Cells[0].Value, numFac, importe, observaciones);

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se actualizó la factura correctamente" ? Properties.Resources.info100 : Properties.Resources.sql_error,
                    TitleText = "Mensaje",
                    ContentText = msg,
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = msg == "Se actualizó la factura correctamente" ? new Padding(10) : new Padding(0)
                };
                popup1.Popup();
            }

            DeshabilitarCampos();
            CargarFacturas();
            CargarOrdenesCompra();
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (ImporteTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(ImporteTextBox, "Ingrese un importe");
                ImporteTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (ImporteTextBox.Text.Trim() != string.Empty)
            {
                if (!decimal.TryParse(ImporteTextBox.Text.Trim(), out decimal imp))
                {
                    errorProvider1.SetError(ImporteTextBox, "Ingrese un valor numérico");
                    ImporteTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();

            if (NumFacTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(NumFacTextBox, "Ingrese un número de factura");
                NumFacTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (NumFacTextBox.Text.Trim() != string.Empty)
            {
                if (!decimal.TryParse(NumFacTextBox.Text.Trim(), out decimal imp))
                {
                    errorProvider1.SetError(NumFacTextBox, "Ingrese un valor numérico");
                    NumFacTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();

            return true;
        }

        private bool FacturaProvTieneInformeAsociado(int codFac)
        {
            if (dFactura.FacturaProvTieneInformeAsociado(codFac))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BorrarFacturaButton_Click(object sender, EventArgs e)
        {
            if (DgvFacturas.RowCount == 0)
            {
                MessageBox.Show("No hay facturas a borrar", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Borrar factura?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            var codFac = (int)DgvFacturas.SelectedRows[0].Cells[0].Value;

            if (FacturaProvTieneInformeAsociado(codFac))
            {
                MessageBox.Show("La factura tiene un informe de recepción asociado, no se puede borrar", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var msg = dFactura.DeleteFacturaProv(codFac);

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

            CargarFacturas();
            CargarOrdenesCompra();
        }
    }
}

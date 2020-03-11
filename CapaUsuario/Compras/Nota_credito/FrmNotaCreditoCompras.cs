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

namespace CapaUsuario.Compras.Nota_credito
{
    public partial class FrmNotaCreditoCompras : Form
    {
        DNotaCredito dNotaCredito;
        DPedidoDev dPedido;
        private bool nueva;
        public FrmNotaCreditoCompras()
        {
            InitializeComponent();
        }

        private void FrmNotaCreditoCompras_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            SelectNotasCredito();
            SelectPedidosDev();
        }

        private void SelectPedidosDev()
        {
            dPedido = new DPedidoDev();
            DgvPedidos.DataSource = dPedido.SelectPedidosDevSinNotaCredito();
            DgvPedidos.Refresh();
        }

        private void SelectNotasCredito()
        {
            dNotaCredito = new DNotaCredito();
            DgvNotas.DataSource = dNotaCredito.SelectNotasCredito();
            DgvNotas.Refresh();
        }

        private void FrmNotaCreditoCompras_SizeChanged(object sender, EventArgs e)
        {
            DgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void CodNotaBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodNotaBusquedaTextBox.Text.Trim() != string.Empty)
            {

                if (!int.TryParse(CodNotaBusquedaTextBox.Text.Trim(), out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodNotaBusquedaTextBox.Text = string.Empty;
                    return;
                }


                DgvNotas.DataSource =
                    dNotaCredito.SelectNotasCreditoByCodNotaAndSumado(
                        int.Parse(CodNotaBusquedaTextBox.Text.Trim()),
                        SumadoCheckBox.Checked);
                DgvNotas.Refresh();
            }
            else
            {
                SelectNotasCredito();
            }
        }

        private void CrearNotaButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty(DgvPedidos, "pedidos", ""))
            {
                return;
            }

            nueva = true;
            materialTabControl1.SelectedTab = TabNueva;
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            ImporteTextBox.ReadOnly = false;
            DetalleTextBox.ReadOnly = false;

            CancelarNuevoButton.Enabled = true;
            GuardarDatosButton.Enabled = true;

            CrearNotaButton.Enabled = false;
            BorrarNotaButton.Enabled = false;
            ModificarNotaButton.Enabled = false;

            CodNotaBusquedaTextBox.Enabled = false;
            SumadoCheckBox.Enabled = false;
            SumadoCheckBox.Checked = false;


            ImporteTextBox.Focus();
        }

        private void DeshabilitarControles()
        {
            ImporteTextBox.ReadOnly = true;
            DetalleTextBox.ReadOnly = true;

            CancelarNuevoButton.Enabled = false;
            GuardarDatosButton.Enabled = false;

            CrearNotaButton.Enabled = true;
            BorrarNotaButton.Enabled = true;
            ModificarNotaButton.Enabled = true;

            CodNotaBusquedaTextBox.Enabled = true;
            SumadoCheckBox.Enabled = true;
            SumadoCheckBox.Checked = false;
        }

        private void CancelarNuevoButton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarCampos();
            errorProvider1.Clear();
        }

        private void LimpiarCampos()
        {
            ImporteTextBox.Text = string.Empty;
            DetalleTextBox.Text = string.Empty;
        }

        private void ModificarNotaButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty(DgvNotas, "notas", "modificar"))
            {
                return;
            }

            nueva = false;

            var cod_nc = (int)DgvNotas.SelectedRows[0].Cells[0].Value;

            var dt = dNotaCredito.GetImporteAndDetalleNotaByCodNota(cod_nc);

            ImporteTextBox.Text = dt.Rows[0]["Importe"].ToString();
            DetalleTextBox.Text = dt.Rows[0]["Detalle"].ToString();

            materialTabControl1.SelectedTab = TabNueva;

        }

        private bool IsGridEmpty(DataGridView dgv, string entidad, string operacion)
        {
            if (dgv.RowCount == 0)
            {
                MessageBox.Show(operacion == ""
                    ? $"No hay {entidad}"
                    : $"No hay {entidad} a {operacion}",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void BorrarNotaButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty(DgvNotas, "notas", "borrar")) return;

            var cod_nc = (int)DgvNotas.SelectedRows[0].Cells[0].Value;

            try
            {
                dNotaCredito.DeleteNotaCredito(cod_nc);

                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "Se eliminó la nota de crédito con éxito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(0)
                };
                popup1.Popup();

            }
            catch (Exception ex)
            {
                ErrorMsg(ex);
                return;
            }



        }

        private static void ErrorMsg(Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var codPedido = (int)DgvPedidos.SelectedRows[0].Cells[0].Value;
            var detalle = DetalleTextBox.Text.Trim();
            var importe = int.Parse(DetalleTextBox.Text);

            if (nueva)
            {
                try
                {

                    
                    dNotaCredito.InsertNotaCredito(
                        codPedido,
                        false,
                        detalle,
                        importe);

                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.sql_success1,
                        TitleText = "Mensaje",
                        ContentText = "Se ingresó la nota de crédito con éxito",
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(10)
                    };
                    popup1.Popup();
                }
                catch (Exception ex) 
                {
                    ErrorMsg(ex);
                    return;
                }
            }
            else
            {
                var codNota = (int)DgvNotas.SelectedRows[0].Cells[0].Value;

                try
                {
                    dNotaCredito.UpdateNotaCredito(codNota, detalle, importe);

                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.info100,
                        TitleText = "Mensaje",
                        ContentText = "Se actualizó la nota de crédito con éxito",
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(0)
                    };
                    popup1.Popup();
                }
                catch (Exception ex)
                {
                    ErrorMsg(ex);
                    return;
                }
            }

            LimpiarCampos();
            DeshabilitarControles();
            SelectPedidosDev();
            SelectNotasCredito();
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
                    errorProvider1.SetError(ImporteLabel, "Ingrese un valor numérico");
                    ImporteTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();

            return true;
        }
    }
}

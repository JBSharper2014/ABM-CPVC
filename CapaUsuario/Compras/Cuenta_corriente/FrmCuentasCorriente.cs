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

namespace CapaUsuario.Compras.Cuenta_corriente
{
    public partial class FrmCuentasCorriente : Form
    {
        private DCuentaCorriente cuentaCorriente;
        private DProveedores dProveedores;
        DFacturasProv dFacturas;
        DNotaCredito dNotaCredito;
        private bool nueva;
        private bool modifSaldos;
        private int codCuentaCorriente;

        public FrmCuentasCorriente()
        {
            InitializeComponent();
        }

        private void FrmCuentasCorriente_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarCuentas();
            ProveedorComboBox.SelectedIndex = -1;
        }

        private void CargarCuentas()
        {
            cuentaCorriente = new CapaDatos.DCuentaCorriente();
            DgvCuentas.DataSource = cuentaCorriente.SelectCuentasCorriente();
            DgvCuentas.Refresh();
        }

        private void FrmCuentasCorriente_SizeChanged(object sender, EventArgs e)
        {
            DgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void HabilitarCampos()
        {
            ProveedorComboBox.Enabled = true;
            DebeTextBox.ReadOnly = true;
            HaberTextBox.ReadOnly = true;

            BorrarCuentaButton.Enabled = false;
            ModificarCuentaButton.Enabled = false;
            ModificarSaldosButton.Enabled = false;
            NuevaCuentaButton.Enabled = false;

            GuardarDatosButton.Enabled = true;
            CancelarNuevoButton.Enabled = true;

            ProveedorComboBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            ProveedorComboBox.Enabled = false;
            DebeTextBox.ReadOnly = true;
            HaberTextBox.ReadOnly = true;

            BorrarCuentaButton.Enabled = true;
            ModificarCuentaButton.Enabled = true;
            ModificarSaldosButton.Enabled = true;
            NuevaCuentaButton.Enabled = true;

            GuardarDatosButton.Enabled = false;
            CancelarNuevoButton.Enabled = false;

            ProveedorComboBox.Focus();
        }

        private void LimpiarCampos()
        {
            ProveedorComboBox.SelectedIndex = -1;
            DebeTextBox.Text = string.Empty;
            HaberTextBox.Text = string.Empty;
        }

        private void NuevaCuentaButton_Click(object sender, EventArgs e)
        {
            CargarComboProveedores();
            HabilitarCampos();
            nueva = true;
            materialTabControl1.SelectedTab = TabNuevaCuenta;

        }

        private void CargarComboProveedores()
        {
            dProveedores = new DProveedores();

            ProveedorComboBox.DataSource = dProveedores.SelectCodAndRazonProveedoresSinCuentaCorriente();
            ProveedorComboBox.DisplayMember = "RazonSocial";
            ProveedorComboBox.ValueMember = "CodProveedor";
        }

        private void CancelarNuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
            VaciarGrids();
        }

        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            if (!modifSaldos)
            {
                if (ProveedorComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            var rta = MessageBox.Show("¿Guardar datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.No) return;

            cuentaCorriente = new DCuentaCorriente();

            if (!modifSaldos)
            {

                var codProv = (int)ProveedorComboBox.SelectedValue;
                if (nueva)
                {
                    var msg = cuentaCorriente.InsertCuentaProveedor(codProv, 0, 0);

                    var popup1 = new PopupNotifier()
                    {
                        Image = msg == "Se ingresó la cuenta correctamente"
                      ? Properties.Resources.sql_success1 : Properties.Resources.sql_error,
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
                    var msg = cuentaCorriente.UpdateCuentaProveedor(codProv);

                    var popup1 = new PopupNotifier()
                    {
                        Image = msg == "Se actualizó la cuenta correctamente"
                      ? Properties.Resources.info100 : Properties.Resources.sql_error,
                        TitleText = "Mensaje",
                        ContentText = msg,
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(0)
                    };
                    popup1.Popup();
                }
            }
            else
            {
                var debe = decimal.Parse(DebeTextBox.Text);
                var haber = decimal.Parse(HaberTextBox.Text);

                var msg = cuentaCorriente.UpdateDebeHaberCuentaProveedor(codCuentaCorriente, debe, haber);

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se actualizó la cuenta correctamente"
                     ? Properties.Resources.info100 : Properties.Resources.sql_error,
                    TitleText = "Mensaje",
                    ContentText = msg,
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(0)
                };
                popup1.Popup();

            }

            VaciarGrids();
            LimpiarCampos();
            DeshabilitarCampos();
            CargarCuentas();
        }

        private void ModificarCuentaButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty(DgvCuentas, "cuentas")) return;

            nueva = false;
            CargarComboProveedores();
            HabilitarCampos();
            materialTabControl1.SelectedTab = TabNuevaCuenta;

        }

        private void CargarFacturas()
        {
            dFacturas = new DFacturasProv();
            DgvFacturas.DataSource = dFacturas.SelectFacturasNoRegistradas();
            DgvFacturas.Refresh();
        }

        private void CargarNotasCredito()
        {
            dNotaCredito = new DNotaCredito();
            DgvNotas.DataSource = dNotaCredito.SelectNotasCreditoNoRegistradas();
            DgvNotas.Refresh();
        }

        private void BorrarCuentaButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty(DgvCuentas, "cuentas")) return;

            var rta = MessageBox.Show("¿Borrar cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.No) return;

            var codProv = (int)ProveedorComboBox.SelectedValue;

            var msg = cuentaCorriente.DeleteCuentaProveedor(codProv);

            var popup1 = new PopupNotifier()
            {
                Image = msg == "Se borró la cuenta correctamente"
              ? Properties.Resources.info100 : Properties.Resources.sql_error,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
                ImagePadding = new Padding(0)
            };
            popup1.Popup();

            CargarCuentas();

        }

        private bool IsGridEmpty(DataGridView dgv, string entidad)
        {
            if (dgv.RowCount == 0)
            {
                MessageBox.Show($"No hay {entidad}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void ModificarSaldosButton_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = TabSaldos;

            ModificarManualButton.Enabled = true;
            ModifDebeFacturaButton.Enabled = true;
            ModifHaberNotaButton.Enabled = true;


            codCuentaCorriente = (int)DgvCuentas.SelectedRows[0].Cells[0].Value;


            CargarFacturas();
            CargarNotasCredito();

            DeshabilitarCampos();
        }

        private void ModificarManualButton_Click(object sender, EventArgs e)
        {
            ModifDebeFacturaButton.Enabled = false;
            ModifHaberNotaButton.Enabled = false;
            ModificarManualButton.Enabled = false;

            materialTabControl1.SelectedTab = TabNuevaCuenta;

            DebeTextBox.ReadOnly = false;
            HaberTextBox.ReadOnly = false;

            CancelarNuevoButton.Enabled = true;
            GuardarDatosButton.Enabled = true;

            modifSaldos = true;

            DebeTextBox.Text = DgvCuentas.SelectedRows[0].Cells[2].Value.ToString();
            HaberTextBox.Text = DgvCuentas.SelectedRows[0].Cells[3].Value.ToString();


            DebeTextBox.Focus();
        }

        private void ModifDebeFacturaButton_Click(object sender, EventArgs e)
        {

            if (IsGridEmpty(DgvFacturas, "facturas")) return;
            try
            {
                var debe = (decimal)DgvCuentas.SelectedRows[0].Cells[2].Value;

                cuentaCorriente = new DCuentaCorriente();
                dFacturas = new DFacturasProv();

                cuentaCorriente.UpdateDebeCuenta(debe, codCuentaCorriente);

                dFacturas.RegistrarFactura((int)DgvFacturas.SelectedRows[0].Cells[0].Value, codCuentaCorriente);
            }

            catch (Exception ex )
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cuenta modificada y factura registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            VaciarGrids();
            
            
        }

        private void VaciarGrids()
        {
            try
            {
                DgvFacturas.DataSource = null;
                DgvFacturas.Refresh();

                DgvNotas.DataSource = null;
                DgvNotas.Refresh();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void ModifHaberNotaButton_Click(object sender, EventArgs e)
        {
            if (IsGridEmpty(DgvNotas, "notas")) return;

            try
            {
                var haber = (decimal)DgvCuentas.SelectedRows[0].Cells[3].Value;

                cuentaCorriente = new DCuentaCorriente();
                dNotaCredito = new DNotaCredito();

                cuentaCorriente.UpdateHaberCuenta(haber, codCuentaCorriente);

               dNotaCredito.RegistrarNotaCredito((int)DgvNotas.SelectedRows[0].Cells[0].Value, codCuentaCorriente);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cuenta modificada y nota de crédito registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            VaciarGrids();
        }
    }
}

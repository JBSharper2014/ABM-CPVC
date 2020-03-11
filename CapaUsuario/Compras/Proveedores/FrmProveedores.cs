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

namespace CapaUsuario.Compras.Proveedores
{
    public partial class FrmProveedores : Form
    {
        //private DUsuario usuarioLogueado;
        //public DUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        private bool nuevo, agregaStock;
        private DProveedores dProveedores = new DProveedores();

        public FrmProveedores()
        {
            InitializeComponent();
        }


        private bool ValidarCampos()
        {
            //Nombre
            if (nombreTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un nombre");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Telefono
            if (numero_telefonoTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(numero_telefonoTextBox, "Debe ingresar un teléfono");
                numero_telefonoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (numero_telefonoTextBox.Text.Trim() != string.Empty)
            {
                if (!decimal.TryParse(numero_telefonoTextBox.Text.Trim(), out decimal precio))
                {

                    errorProvider1.SetError(numero_telefonoTextBox, "Debe ingresar un valor numérico");
                    numero_telefonoTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();

            decimal telefono = Convert.ToDecimal(numero_telefonoTextBox.Text.Trim());
            if (telefono <= 0)
            {
                errorProvider1.SetError(numero_telefonoTextBox, "Debe ingesar un valor mayor a cero (0)");
                numero_telefonoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Direccion
            if (DireccionComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(DireccionComboBox, "Debe seleccionar una dirección");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

           

            //Email
            if (emailTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(emailTextBox, "Debe ingresar una dirección");
                emailTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (emailTextBox.Text.Trim() != string.Empty)
            {
                var regexUtilities = new RegexUtilities();

                // con el método IsValidEmail la clase regex utilities comprueba que el correo ingresado
                // tenga el formato correcto

                if (!regexUtilities.IsValidEmail(emailTextBox.Text.Trim()))
                {
                    errorProvider1.SetError(emailTextBox, "Debe ingresar un email válido");
                    emailTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }


            //Razón social
            if (razon_socialTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(razon_socialTextBox, "Debe ingresar una razón social");
                razon_socialTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Codigo postal
            if (CodPostalTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(CodPostalTextBox, "Debe ingresar un código postal");
                CodPostalTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (CodPostalTextBox.Text.Trim() != string.Empty)
            {
                if (!int.TryParse(CodPostalTextBox.Text.Trim(), out int cp))
                {
                    errorProvider1.SetError(CodPostalTextBox, "Debe ingresar un valor numérico");
                    CodPostalTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();


            return true;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ActualizarListado();
            CargarComboBoxes();
            DireccionComboBox.SelectedIndex = -1;
            FrmProveedores_SizeChanged(sender, e);
        }

        private void CargarComboBoxes()
        {
            var dDireccion = new DDireccion();
            DireccionComboBox.DataSource = null;
            DireccionComboBox.DataSource = dDireccion.SelectDirecciones();
            DireccionComboBox.DisplayMember = "Direccion";
            DireccionComboBox.ValueMember = "CodDir";

        }

        private void AgregaBienUso()
        {
            var dBienUso = new DBienUso();
            StockComboBox.DataSource = null;
            StockComboBox.DataSource = dBienUso.SelectBienesUsoSinProveedoresAsociados((int)DgvProveedores.SelectedRows[0].Cells[0].Value);
            StockComboBox.DisplayMember = "Nombre";
            StockComboBox.ValueMember = "CodBienUso";
        }

        private void AgregaStock()
        {
            var dStock = new DStock();
            StockComboBox.DataSource = null;
            StockComboBox.DataSource = dStock.SelectStockSinProveedoresAsociados((int)DgvProveedores.SelectedRows[0].Cells[0].Value);
            StockComboBox.DisplayMember = "Nombre";
            StockComboBox.ValueMember = "CodStock";
        }

        private void ActualizarListado()
        {
            DgvProveedores.DataSource = dProveedores.SelectProveedores();
            DgvProveedores.Refresh();
        }

        private void FrmProveedores_SizeChanged(object sender, EventArgs e)
        {
            DgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        

        private void HabilitarCampos()
        {

            nombreTextBox.ReadOnly = false;
            numero_telefonoTextBox.ReadOnly = false;
            DireccionComboBox.Enabled = true;
            numero_telefonoTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            razon_socialTextBox.ReadOnly = false;
            CodPostalTextBox.ReadOnly = false;

            BuscarTextBox.ReadOnly = true;

            CancelarNuevoButton.Enabled = true;
            GuardarDatosButton.Enabled = true;

            AgregarProveedorButton.Enabled = false;
            AgregarProveedorButton.Enabled = false;

            BorrarButton.Enabled = false;
            ModificarButton.Enabled = false;

            AgregarBienUsoButton.Enabled = false;
            AgregarStockButton.Enabled = false;

            nombreTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {

            nombreTextBox.ReadOnly = true;
            numero_telefonoTextBox.ReadOnly = true;
            DireccionComboBox.Enabled = false;
            numero_telefonoTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            razon_socialTextBox.ReadOnly = true;
            CodPostalTextBox.ReadOnly = true;

            BuscarTextBox.ReadOnly = false;

            CancelarNuevoButton.Enabled = false;
            GuardarDatosButton.Enabled = false;

            AgregarProveedorButton.Enabled = true;
            AgregarBancoButton.Enabled = true;

            BorrarButton.Enabled = true;
            ModificarButton.Enabled = true;

            AgregarBienUsoButton.Enabled = true;
            AgregarStockButton.Enabled = true;

            nombreTextBox.Focus();
        }
        
        private void LimpiarCampos()
        {
            cod_proveedorTextBox.Text = string.Empty;
            nombreTextBox.Text = string.Empty;
            numero_telefonoTextBox.Text = string.Empty;
            DireccionComboBox.SelectedIndex = -1;
            emailTextBox.Text = string.Empty;
            razon_socialTextBox.Text = string.Empty;
            CodPostalTextBox.Text = string.Empty;
        }

        
        private bool ValidarSeleccion()
        {
            if (StockComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(StockComboBox, "Debe seleccionar un producto o bien de uso");
                StockComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }


        private void GetDatosProveedor()
        {
            cod_proveedorTextBox.Text = DgvProveedores.SelectedRows[0].Cells[0].Value.ToString();
            nombreTextBox.Text = DgvProveedores.SelectedRows[0].Cells[1].Value.ToString();
            numero_telefonoTextBox.Text = DgvProveedores.SelectedRows[0].Cells[2].Value.ToString();
            DireccionComboBox.SelectedItem = DgvProveedores.SelectedRows[0].Cells[3].Value.ToString();
            CodPostalTextBox.Text = DgvProveedores.SelectedRows[0].Cells[4].Value.ToString();
            emailTextBox.Text = DgvProveedores.SelectedRows[0].Cells[5].Value.ToString();
            razon_socialTextBox.Text = DgvProveedores.SelectedRows[0].Cells[6].Value.ToString();

        }


        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (nuevo)
            {
                string msg = dProveedores.InsertProveedor(
                     nombreTextBox.Text.Trim(),
                     numero_telefonoTextBox.Text.Trim(),
                     (int)DireccionComboBox.SelectedValue,
                     int.Parse(CodPostalTextBox.Text.Trim()),
                     emailTextBox.Text.Trim(),
                     razon_socialTextBox.Text.Trim());

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se ingresó el proveedor correctamente" 
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
                string msg = dProveedores.UpdateProveedor(
                      (int)DgvProveedores.SelectedRows[0].Cells[0].Value,
                      nombreTextBox.Text.Trim(),
                      numero_telefonoTextBox.Text.Trim(),
                      (int)DireccionComboBox.SelectedValue,
                      int.Parse(CodPostalTextBox.Text.Trim()),
                      emailTextBox.Text.Trim(),
                      razon_socialTextBox.Text.Trim());

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se modificó el proveedor correctamente"
                     ? Properties.Resources.updated_proveedor64 : Properties.Resources.sql_error,
                    TitleText = "Mensaje",
                    ContentText = msg,
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();
            }

            DeshabilitarCampos();
            ActualizarListado();
            LimpiarCampos();
            errorProvider1.Dispose();
        }

        private void AgregarProveedorButton_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            //_1_proveedorBindingSource.AddNew();
            nombreTextBox.Focus();
        }

        private void CancelarNuevoButton_Click(object sender, EventArgs e)
        {
            // _1_proveedorBindingSource.CancelEdit();
            errorProvider1.Dispose();
            DeshabilitarCampos();
            LimpiarCampos();
        }

        

        private void CancelarButton_Click_1(object sender, EventArgs e)
        {
            StockComboBox.Enabled = false;
            AgregarBancoButton.Enabled = true;
            GuardarStockButton.Enabled = false;
            CancelarButton.Enabled = false;
            AgregarStockButton.Enabled = true;
            AgregarBienUsoButton.Enabled = true;
            AgregarProveedorButton.Enabled = true;
            GuardarDatosButton.Enabled = false;
            BorrarButton.Enabled = true;
            ModificarButton.Enabled = true;
            CancelarNuevoButton.Enabled = false;

            StockComboBox.DataSource = null;
        }

        private void ModificarButton_Click_1(object sender, EventArgs e)
        {
            if(DgvProveedores.RowCount == 0)
            {
                MessageBox.Show("No hay proveedores", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nuevo = false;
            HabilitarCampos();
            GetDatosProveedor();
            materialTabControl1.SelectedTab = tabPage1;
        }

        private void BuscarTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (BuscarTextBox.Text.Trim() != string.Empty)
            {
                DgvProveedores.DataSource = dProveedores.SelectProveedorByNombre(BuscarTextBox.Text.Trim());
                DgvProveedores.Refresh();
            }
            else
            {
                ActualizarListado();
            }

        }

        private void AgregarStockButton_Click_1(object sender, EventArgs e)
        {
            agregaStock = true;
            AgregaStock();
            AgregarStockOrBienUso();
            materialTabControl1.SelectedTab = tabPage1;
            
        }

        private void AgregarBienUsoButton_Click_1(object sender, EventArgs e)
        {
            agregaStock = false;
            AgregaBienUso();
            AgregarStockOrBienUso();
            materialTabControl1.SelectedTab = tabPage1;
        }

        private void AgregarStockOrBienUso()
        {
            StockComboBox.Enabled = true;
            StockComboBox.Focus();

            StockComboBox.Enabled = true;
            AgregarBancoButton.Enabled = false;
            GuardarStockButton.Enabled = true;
            CancelarButton.Enabled = true;
            ModificarButton.Enabled = false;
            BorrarButton.Enabled = false;
            AgregarStockButton.Enabled = false;
            AgregarBienUsoButton.Enabled = false;
            AgregarProveedorButton.Enabled = false;
            GuardarDatosButton.Enabled = false;
            CancelarNuevoButton.Enabled = false;
        }

        private void GuardarStockButton_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            int codProveedor = (int)DgvProveedores.SelectedRows[0].Cells[0].Value;


            if (!agregaStock)
            {
                int codBienUso = (int)StockComboBox.SelectedValue;
                string msg = dProveedores.InsertBienUsoProveedor(codProveedor, codBienUso);
                MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int codStock = (int)StockComboBox.SelectedValue;
                string msg2 = dProveedores.InsertStockProveedor(codProveedor, codStock);
                MessageBox.Show(msg2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CancelarButton_Click_1(sender, e);
        }

        private void AgregarBancoButton_Click(object sender, EventArgs e)
        {

            if (DgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int codProv = (int)DgvProveedores.SelectedRows[0].Cells[0].Value;
            if (dProveedores.ProveedorTieneCBU(codProv))
            {
                MessageBox.Show("El proveedor seleccionado ya tiene un CBU asociado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bancos = new Bancos.Bancos
            {
                RazonSocial = DgvProveedores.SelectedRows[0].Cells[6].Value.ToString(),
                CodProv = codProv
            };

            bancos.ShowDialog();
        }

        private void BorrarButton_Click_1(object sender, EventArgs e)
        {
            if (DgvProveedores.RowCount == 0)
            {
                MessageBox.Show("No hay proveedores", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Está seguro de borrar el registro?" + Environment.NewLine +
               "Si continúa, borrará las asociaciones del proveedor con el producto o bien de uso que provee", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            var dproveedores = new DProveedores();

            int codProveedor = (int)DgvProveedores.SelectedRows[0].Cells[0].Value;

            string msg = dproveedores.DeleteStockProveedor(codProveedor);
            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string msg2 = dproveedores.DeleteBienesUsoProveedor(codProveedor);
            MessageBox.Show(msg2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);



            try
            {
                dproveedores.DeleteProveedor(codProveedor);
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "Se eliminó el proveedor correctamente",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F)
                };
                popup1.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message + Environment.NewLine +
                    "Cierre el formulario para recargar la información", "Mensaje", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
        }
    }
}

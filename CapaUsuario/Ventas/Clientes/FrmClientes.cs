using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using DatosVentas;
using CapaDatos;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Ventas.Clientes
{

    public partial class FrmClientes : Form
    {

        bool nuevo = false;

        public FrmClientes()
        {
            InitializeComponent();

            DataTable tab;
            listar_clientes();
            tab = ExecuteQuery.SelectAll(3003);
            if (tab != null)
            {
                foreach (string element in tab.Rows[0].ItemArray)
                {
                    ProvinciaComboBox.Items.Add(element);
                }
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AgregarCuentaButton_Click(object sender, EventArgs e)
        {


            // Si hay seleccionado un cliente
            if (DgvClientes.SelectedCells.Count != 0)
            {
                int clienteId = (int)DgvClientes.SelectedRows[0].Cells[0].Value;
                string clienteNombre = DgvClientes.SelectedRows[0].Cells[1].Value.ToString();

                // Consulta para saber si el usuario existe
                bool? existe = (SelectCommands.selectExist(4000, clienteId));

                if (existe != null && existe == true)
                {
                    MessageBox.Show("El cliente ya tiene una cuenta corriente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FrmCuentaCorriente cuentaCorriente = new FrmCuentaCorriente
                    {
                        IDCliente = clienteId,
                        NombreCliente = clienteNombre
                    };
                    cuentaCorriente.ShowDialog();
                    
                 
     
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void ListadoCuentasButton_Click(object sender, EventArgs e)
        {
            FrmListadoCuentasCorriente listadoCuentasCorriente = new FrmListadoCuentasCorriente();
            listadoCuentasCorriente.ShowDialog();
        }
        

        private void BorarClienteButton_Click(object sender, EventArgs e)
        {
            

            if (DgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("No hay clientes a borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ExecuteQuery.SelectExist(4001, (int)DgvClientes.SelectedCells[0].Value) == false)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro de borrar el cliente seleccionado?", "Confirmación",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rta == DialogResult.No) return;
            }
            else
            {
                MessageBox.Show("El cliente está asociado a un pedido de venta y no puede ser borrado", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            ExecuteQuery.DeleteFrom(30001, (int)DgvClientes.SelectedCells[0].Value);

            if (MessageException.message == "")
            {
                //MessageBox.Show("El cliente ha sido borrado con exito", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "El cliente ha sido borrado con exito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F)

                };
                popup1.Popup();
                listar_clientes();
            }

        }

        private void AgregarClienteButton_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            NombreTextBox.ReadOnly = false;
            ApellidoTextBox.ReadOnly = false;
            CalleTextBox.ReadOnly = false;
            EsquinaTextBox.ReadOnly = false;

            TelefonoTextBox.ReadOnly = false;
            NumeroNumericUpDown.ReadOnly = false;

            ProvinciaComboBox.Enabled = true;
            CiudadComboBox.Enabled = true;

            AgregarClienteButton.Enabled = false;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            AgregarCuentaButton.Enabled = false;
            ListadoCuentasButton.Enabled = false;

            EditarClienteButton.Enabled = false;
            BorarClienteButton.Enabled = false;

            NombreTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            NombreTextBox.ReadOnly = true;
            ApellidoTextBox.ReadOnly = true;
            CalleTextBox.ReadOnly = true;
            EsquinaTextBox.ReadOnly = true;

            TelefonoTextBox.ReadOnly = true;
            NumeroNumericUpDown.ReadOnly = true;

            ProvinciaComboBox.Enabled = false;
            CiudadComboBox.Enabled = false;

            AgregarClienteButton.Enabled = true;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            AgregarCuentaButton.Enabled = true;
            ListadoCuentasButton.Enabled = true;

            EditarClienteButton.Enabled = true;
            BorarClienteButton.Enabled = true;

            errorProvider1.Clear();
            errorProvider1.Dispose();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
            
        }

        private void LimpiarCampos()
        {
            CodClienteTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            CalleTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            EsquinaTextBox.Text = string.Empty;

            TelefonoTextBox.Text = string.Empty;
            NumeroNumericUpDown.Text = string.Empty;

            ProvinciaComboBox.SelectedIndex = -1;
            CiudadComboBox.SelectedIndex = -1;
        }

        private void EditarClienteButton_Click(object sender, EventArgs e)
        {

            materialTabControl1.SelectedIndex = 0;

            HabilitarCampos();

            nuevo = false;

            CodClienteTextBox.Text = DgvClientes.SelectedCells[0].Value.ToString();
            NombreTextBox.Text = (string)DgvClientes.SelectedCells[1].Value;
            ApellidoTextBox.Text = (string)DgvClientes.SelectedCells[2].Value;
            TelefonoTextBox.Text = (string)DgvClientes.SelectedCells[3].Value;
            ProvinciaComboBox.SelectedIndex =
                ProvinciaComboBox.Items.IndexOf(DgvClientes.SelectedCells[4].Value.ToString());
            CiudadComboBox.Text = (string)(DgvClientes.SelectedCells[5].Value);
            CalleTextBox.Text = (string)DgvClientes.SelectedCells[6].Value;
            NumeroNumericUpDown.Text = (string)DgvClientes.SelectedCells[7].Value;
            EsquinaTextBox.Text = (string)DgvClientes.SelectedCells[8].Value;

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            DialogResult rta = MessageBox.Show("¿Guardar datos?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            if (nuevo)
            {
                object[] datos = {
                ExecuteQuery.SelectCode(8002,CiudadComboBox.Text),
                CalleTextBox.Text,
                NumeroNumericUpDown.Text,
                EsquinaTextBox.Text,
                NombreTextBox.Text,
                ApellidoTextBox.Text,
                TelefonoTextBox.Text

                };

                ExecuteQuery.InsertInto(300, datos);
                if (MessageException.message == "")
                {
                    //MessageBox.Show("Cliente agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.sql_success1,
                        TitleText = "Mensaje",
                        ContentText = "Cliente agregado correctamente",
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(10)
                    };
                    popup1.Popup();
                    listar_clientes();
                }
            }
            else
                {
                object[] datos = {
                Convert.ToInt32(CodClienteTextBox.Text),
                NombreTextBox.Text,
                ApellidoTextBox.Text,
                TelefonoTextBox.Text,
                ExecuteQuery.SelectCode(8003, Convert.ToInt32(CodClienteTextBox.Text)),
                ExecuteQuery.SelectCode(8002,CiudadComboBox.Text),
                CalleTextBox.Text,
                NumeroNumericUpDown.Text,
                EsquinaTextBox.Text };

                ExecuteQuery.UpdateMany(300000, datos);
                if (MessageException.message == "")
                {
                    //MessageBox.Show("Cliente Modificado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.guardar_usuario64,
                        TitleText = "Mensaje",
                        ContentText = "Cliente modificado correctamente",
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(10)
                    };
                    popup1.Popup();
                    listar_clientes();
                }
            

            }
            DeshabilitarCampos();
            LimpiarCampos();

        }

        private bool ValidarCampos()
        {
            if (NombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese un nombre de cliente");
                NombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (ApellidoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ApellidoTextBox, "Ingrese un apellido de cliente");
                ApellidoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (ProvinciaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(ProvinciaComboBox, "Seleccione una provincia");
                ProvinciaComboBox.Focus();
                return false;
            }

            if (CiudadComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(CiudadComboBox, "Seleccione una ciudad");
                CiudadComboBox.Focus();
                return false;
            }

            if (CalleTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CalleTextBox, "Ingrese una calle");
                CalleTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (EsquinaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(EsquinaTextBox, "Ingrese una esquina");
                EsquinaTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            

            return true;
        }

        private void BusquedaClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(BusquedaClienteTextBox.Text, out int codigo) || BusquedaClienteTextBox.Text == "")
            {
                if (BusquedaClienteTextBox.Text == "")
                    listar_clientes();
                else
                    DgvClientes.DataSource = ExecuteQuery.SelectOne(7002, codigo);
            }
            else
            {
                MessageBox.Show("Introduzca solamente valores numericos enteros.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ProvinciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tab = new DataTable();
            int? codpro = ExecuteQuery.SelectCode(8001, ProvinciaComboBox.Text);
            if (codpro != null)
            {
                tab = ExecuteQuery.SelectOne(7001, 1);
            }
            if (tab != null)
            {
                foreach (string element in tab.Rows[0].ItemArray)
                {
                    CiudadComboBox.Items.Add(element);
                }
            }
        }

        private void listar_clientes()
        {
            DataTable tab;
            tab = ExecuteQuery.SelectAll(3000);
            if (tab != null)
            {
                DgvClientes.DataSource = tab;
            }
        }
    }
}

using CapaDatos;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Compras.Bienes_de_uso
{
    public partial class FrmBienUso : Form
    {
        //private DUsuario usuarioLogueado;
        //public DUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        private bool nuevo;

        DBienUso dBienUso = new DBienUso();

        public FrmBienUso()
        {
            InitializeComponent();
        }

        private void _1_bien_usoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;


            if (nuevo)
            {
                string msg = dBienUso.InsertBienUso(
                    nombreTextBox.Text.Trim(),
                    Convert.ToInt32(stockTextBox.Text.Trim()),
                    descripcionTextBox.Text.Trim(),
                    observacionTextBox.Text.Trim());

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se ingresó el registro correctamente" ? Properties.Resources.sql_success1 : Properties.Resources.sql_error,
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
                string msg = dBienUso.UpdateBienUso(
                    (int)DgvBienesUso.SelectedRows[0].Cells[0].Value,
                    nombreTextBox.Text.Trim(),
                    int.Parse(stockTextBox.Text.Trim()),
                    descripcionTextBox.Text.Trim(),
                    observacionTextBox.Text.Trim());

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se actualizó el registro correctamente" ? Properties.Resources.info100 : Properties.Resources.sql_error,
                    TitleText = "Mensaje",
                    ContentText = msg,
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F)
                };
                popup1.Popup();
            }

            DeshabilitarCampos();
            errorProvider1.Dispose();
            LimpiarCampos();
            CargarGrid();
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

            //Stock óptimo
            if (stockTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(stockTextBox, "Debe ingresar un stock óptimo");
                stockTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (stockTextBox.Text.Trim() != string.Empty)
            {
                if (!int.TryParse(stockTextBox.Text.Trim(), out int f))
                {
                    errorProvider1.SetError(stockTextBox, "Debe ingresar un valor numérico entero");
                    stockTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();


            int stock = Convert.ToInt32(stockTextBox.Text.Trim());
            if (stock <= 0)
            {
                errorProvider1.SetError(stockTextBox, "Debe ingesar un valor mayor a cero (0)");
                stockTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void FrmBienUso_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarGrid();
            CargarMarcas();

            MarcaComboBox.SelectedIndex = -1;
            FrmBienUso_SizeChanged(sender, e);
        }

        private void CargarMarcas()
        {
            DMarca marca = new DMarca();
            MarcaComboBox.DataSource = marca.SelectMarcas();
            MarcaComboBox.DisplayMember = "Nombre";
            MarcaComboBox.ValueMember = "CodMarca";
        }
        
        
        private void CargarGrid()
        {
            dBienUso = new DBienUso();
            DgvBienesUso.DataSource = dBienUso.SelectBienesUso();
            DgvBienesUso.Refresh();
        }

        private void FrmBienUso_SizeChanged(object sender, EventArgs e)
        {
            DgvBienesUso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HabilitarCampos()
        {

            nombreTextBox.ReadOnly = false;
            stockTextBox.ReadOnly = false;
            descripcionTextBox.ReadOnly = false;
            observacionTextBox.ReadOnly = false;

            bindingNavigatorCancel.Enabled = true;
            StockBindingNavigatorSaveItem.Enabled = true;

            AgregarMarcaButton.Enabled = false;

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorEditItem.Enabled = false;

            nombreTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {

            nombreTextBox.ReadOnly = true;
            stockTextBox.ReadOnly = true;
            descripcionTextBox.ReadOnly = true;
            observacionTextBox.ReadOnly = true;

            bindingNavigatorCancel.Enabled = false;
            StockBindingNavigatorSaveItem.Enabled = false;

            AgregarMarcaButton.Enabled = true;

            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorEditItem.Enabled = true;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarCampos();
            GetBienUso();
        }

        private void GetBienUso()
        {
            cod_pro_busoTextBox.Text = DgvBienesUso.SelectedRows[0].Cells[0].Value.ToString();
            nombreTextBox.Text = DgvBienesUso.SelectedRows[0].Cells[1].Value.ToString();
            stockTextBox.Text = DgvBienesUso.SelectedRows[0].Cells[2].Value.ToString();
            descripcionTextBox.Text = DgvBienesUso.SelectedRows[0].Cells[3].Value.ToString();
            observacionTextBox.Text = DgvBienesUso.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de borrar el registro?" + Environment.NewLine +
                "Si continúa, borrará también la asociación del bien con su(s) marca(s)", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            //Comprobamos que el bien de uso no tenga proveedores asociados
            var dproveedores = new DProveedores();

            int codBuso = (int)DgvBienesUso.SelectedRows[0].Cells[0].Value;
            if (dproveedores.ExisteBienUsoProveedor(codBuso))
            {
                MessageBox.Show("El bien de uso tiene proveedores asociados, no puede eliminarse",
                   "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dMarcaBienUso = new DMarcaBienUso();

            string msg = dMarcaBienUso.DeleteMarcaBienUso(codBuso);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var mensaje = dBienUso.DeleteBienUso(codBuso);
            var popup1 = new PopupNotifier()
            {
                Image = mensaje == "Se eliminó el registro correctamente" ? Properties.Resources.info100 : Properties.Resources.sql_error,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F)
            };
            popup1.Popup();



        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            //_1_bien_usoBindingSource.CancelEdit();
            errorProvider1.Dispose();
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cod_pro_busoTextBox.Text = string.Empty;
            nombreTextBox.Text = string.Empty;
            stockTextBox.Text = string.Empty;
            descripcionTextBox.Text = string.Empty;
            observacionTextBox.Text = string.Empty;
        }

        private void AgregarMarcaButton_Click(object sender, EventArgs e)
        {
            _1_bien_usoBindingNavigator.Enabled = false;
            AgregarMarcaButton.Enabled = false;
            GuardarMarcaButton.Enabled = true;
            CancelarMarcaButton.Enabled = true;
            MarcaComboBox.Enabled = true;
            textBox1.ReadOnly = true;
        }

        private void CancelarMarcaButton_Click(object sender, EventArgs e)
        {
            _1_bien_usoBindingNavigator.Enabled = true;
            AgregarMarcaButton.Enabled = true;
            GuardarMarcaButton.Enabled = false;
            CancelarMarcaButton.Enabled = false;
            MarcaComboBox.Enabled = false;
            MarcaComboBox.SelectedIndex = -1;
            textBox1.ReadOnly = false;
        }

        private void GuardarMarcaButton_Click(object sender, EventArgs e)
        {
            if (MarcaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MarcaComboBox, "Debe seleccionar una marca");
                MarcaComboBox.Focus();
                return;
            }

            var dMarcaBienUso = new DMarcaBienUso();

            string msg = dMarcaBienUso.InsertMarcaBienUso((int)MarcaComboBox.SelectedValue,
                (int)DgvBienesUso.SelectedRows[0].Cells[0].Value);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CancelarMarcaButton_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DgvBienesUso.DataSource = dBienUso.SelectBienesUsoByNombre(textBox1.Text.Trim());
            DgvBienesUso.Refresh();
        }
        
    }
}

using CapaDatos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Compras
{
    public partial class FrmStock : Form
    {
        //private DUsuario usuarioLogueado;
        //public DUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        private bool nuevo;


        
        private DStock dStock = new DStock();
        public FrmStock()
        {
            InitializeComponent();
        }


        private void FrmStock_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ActualizarComboBoxes();
            ActualizarListados();

            MarcaComboBox.SelectedIndex = -1;
            FrmStock_SizeChanged(sender, e);
        }


        private void ActualizarListados()
        {
            SelectStock();

            DStockMarca dStockMarca = new DStockMarca();
            DgvStockMarca.DataSource = dStockMarca.SelectStockMarca();
            DgvStockMarca.Refresh();

        }

        private void SelectStock()
        {
            DgvStock.DataSource = dStock.SelectStock(); 
            DgvStock.Refresh();
        }

        private void ActualizarComboBoxes()
        {
            //DMedida dMedida = new DMedida();
            //MedidaComboBox.DataSource = null;
            //MedidaComboBox.DataSource = dMedida.SelectMedidas();
            //MedidaComboBox.DisplayMember = "nombre";
            //MedidaComboBox.ValueMember = "cod_med";

            DMarca dMarca = new DMarca();
            MarcaComboBox.DataSource = null;
            MarcaComboBox.DataSource = dMarca.SelectMarcas();
            MarcaComboBox.DisplayMember = "Nombre";
            MarcaComboBox.ValueMember = "CodMarca";

            DCategorias dCategorias = new DCategorias();
            CategoriaComboBox.DataSource = null;
            CategoriaComboBox.DataSource = dCategorias.SelectCategorias();
            CategoriaComboBox.DisplayMember = "nombre";
            CategoriaComboBox.ValueMember = "cod_cat";

        }


        private void FrmStock_SizeChanged(object sender, EventArgs e)
        {
            DgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvStockMarca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HabilitarCampos()
        {

            NombreTextBox.ReadOnly = false;
            StockOptimoTextBox.ReadOnly = false;
            StockCriticoTextBox.ReadOnly = false;


            MarcaComboBox.SelectedIndex = -1;

            CategoriaComboBox.Enabled = true;
            //MedidaComboBox.DataSource = null;


            AgregarMarcaMedidaButton.Enabled = false;

            CancelarButton.Enabled = true;
            GuardarDatosButton.Enabled = true;

            AgregarProductoButton.Enabled = false;
            ModificarButton.Enabled = false;
            BorrarButton.Enabled = false;

            NombreTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            NombreTextBox.ReadOnly = true;
            StockOptimoTextBox.ReadOnly = true;
            StockCriticoTextBox.ReadOnly = true;

            CategoriaComboBox.Enabled = false;
            MarcaComboBox.Enabled = false;
            MedidaComboBox.Enabled = false;

            CancelarButton.Enabled = false;
            GuardarDatosButton.Enabled = false;


            AgregarMarcaMedidaButton.Enabled = true;

            AgregarProductoButton.Enabled = true;
            ModificarButton.Enabled = true;
            BorrarButton.Enabled = true;
        }


        private bool ValidarCampos()
        {
            //Nombre
            if (NombreTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Debe ingresar un nombre");
                NombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Categoria
            if (CategoriaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(CategoriaComboBox, "Debe seleccionar una categoría");
                CategoriaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            return true;
        }

        private void LimpiarCampos()
        {
            CodProdTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            CategoriaComboBox.SelectedIndex = -1;
            MedidaComboBox.SelectedIndex = -1;
            MarcaComboBox.SelectedIndex = -1;
            StockActualTextBox.Text = string.Empty;
            StockOptimoTextBox.Text = string.Empty;
            StockCriticoTextBox.Text = string.Empty;
        }

        private bool ValidarMarcaMedida()
        {
            ////Marca
            if (MarcaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MarcaComboBox, "Debe seleccionar una marca");
                MarcaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Medida
            if (MedidaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MedidaComboBox, "Debe seleccionar una medida");
                MedidaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }


        private void GetProducto()
        {
            CodProdTextBox.Text = DgvStock.SelectedRows[0].Cells[0].Value.ToString();
            NombreTextBox.Text = DgvStock.SelectedRows[0].Cells[1].Value.ToString();
            CategoriaComboBox.SelectedItem = DgvStock.SelectedRows[0].Cells[5].Value.ToString();
            StockActualTextBox.Text = DgvStock.SelectedRows[0].Cells[2].Value.ToString();
            StockOptimoTextBox.Text = DgvStock.SelectedRows[0].Cells[3].Value.ToString();
            StockCriticoTextBox.Text = DgvStock.SelectedRows[0].Cells[4].Value.ToString();
        }



        private void AgregarProductoButton_Click_1(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            StockActualTextBox.Text = "0";
            NombreTextBox.Focus();
        }

        private void CancelarButton_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            errorProvider1.Dispose();
            DeshabilitarCampos();
        }

        private void GuardarDatosButton_Click_1(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            var rta = MessageBox.Show(nuevo ? "¿Guardar datos?" : "¿Actualizar producto?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (nuevo)
            {

                string msg = dStock.InsertStock(NombreTextBox.Text.Trim(),
                    0,
                    int.Parse(StockOptimoTextBox.Text.Trim()),
                    int.Parse(StockCriticoTextBox.Text.Trim()),
                    (int)CategoriaComboBox.SelectedValue);

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
                string msg = dStock.UpdateStock(int.Parse(CodProdTextBox.Text),
                    NombreTextBox.Text.Trim(),
                    int.Parse(StockOptimoTextBox.Text.Trim()),
                    int.Parse(StockCriticoTextBox.Text.Trim()),
                    (int)CategoriaComboBox.SelectedValue);

                /// CAMBIAR POR POPUPNOTIFIER

                var popup1 = new PopupNotifier()
                {
                    Image = msg == "Se modificó el registro correctamente" ? Properties.Resources.stock_updated64 :
                    Properties.Resources.sql_error,
                    TitleText = "Mensaje",
                    ContentText = "Producto modificado correctamente",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();
            }

            DeshabilitarCampos();
            errorProvider1.Dispose();
            LimpiarCampos();
            ActualizarListados();
        }



        private void BusquedaTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if(BusquedaTextBox.Text.Trim() != string.Empty)
            {
                dStock = new DStock();
                DgvStock.DataSource = dStock.SelectStockByNombre(BusquedaTextBox.Text);
                DgvStock.Refresh();
            }
            else
            {
                SelectStock();
            }
           
        }

        private void BorrarButton_Click_1(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de borrar el registro?" +
               Environment.NewLine + "Si continúa, borrará las asociaciones del producto con marca(s) y/o medida(s)", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            //En el futuro, se deberán agregar comprobaciones de interferencia en transacciones para evitar el borrado

            //Comprobamos que ningún proveedor provea el producto
            var dproveedores = new DProveedores();

            int codProducto = (int)DgvStock.SelectedRows[0].Cells[0].Value;
            if (dproveedores.ExisteStockProveedor(codProducto))
            {
                MessageBox.Show("El producto tiene proveedores asociados, no puede eliminarse",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Borramos primero las referencia en stock_marca y stock_medida
            string msg, msg2;
            var stockMarca = new DStockMarca();
            var stockMedida = new DStockMedida();


            msg = stockMarca.DeleteStockMarca(codProducto);
            msg2 = stockMedida.DeleteStockMedida(codProducto);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show(msg2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                dStock.DeleteStock(codProducto);
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "El producto ha sido borrado con exito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F)

                };
                popup1.Popup();
            }
            catch (Exception ex)
            {
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = $"Error al eliminar: {ex.Message}",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F)

                };
                popup1.Popup();
                return;
            }

            ActualizarListados();
        }

        private void ModificarButton_Click_1(object sender, EventArgs e)
        {
            HabilitarCampos();
            MarcaComboBox.Enabled = false;
            MedidaComboBox.Enabled = false;
            nuevo = false;
            GetProducto();
            materialTabControl1.SelectedTab = tabPage1;
        }

        private void AgregarMarcaMedidaButton_Click_2(object sender, EventArgs e)
        {
            AgregarMarcaMedidaButton.Enabled = false;
            GuardarMarcaMedidaButton.Enabled = true;
            CancelarMarcaMedida.Enabled = true;
            MarcaComboBox.Enabled = true;
            MedidaComboBox.Enabled = true;
            ActualizarButton.Enabled = false;
            ActualizarStockButton.Enabled = false;
            AgregarProductoButton.Enabled = false;
            GuardarDatosButton.Enabled = false;
            CancelarButton.Enabled = false;

            ActualizarMedidas();

            materialTabControl1.SelectedTab = tabPage3;
        }

        private void ActualizarMedidas()
        {
            var medida = new DMedida();
            var categoria = DgvStock.SelectedRows[0].Cells[5].Value.ToString();

            MedidaComboBox.DataSource = null;
            MedidaComboBox.DataSource = medida.SelectCodAndNombreMedidaByCategoria(categoria);
            MedidaComboBox.DisplayMember = "Nombre";
            MedidaComboBox.ValueMember = "CodMed";

        }

        private void ActualizarStockButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                ActualizarListados();
                MessageBox.Show("Lista de productos actualizada", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo actualizar la lista de productos: {ex.Message}", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ActualizarButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                ActualizarListados();
                MessageBox.Show("Lista de productos por marca actualizada", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo actualizar la lista de productos por marca: {ex.Message}",
                    "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void GuardarMarcaMedidaButton_Click(object sender, EventArgs e)
        {
            if (!ValidarMarcaMedida()) return;

            var stockMedida = new DStockMedida();
            var stockMarca = new DStockMarca();

            int codProducto = (int)DgvStock.SelectedRows[0].Cells[0].Value;



            string msg = stockMarca.InsertStockMarca((int)MarcaComboBox.SelectedValue, codProducto);
            string msg2 = stockMedida.InsertStockMedida((int)MedidaComboBox.SelectedValue, codProducto);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show(msg2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CancelarMarcaMedida_Click(sender, e);
            ActualizarButton_Click_1(sender, e);
        }

        private void CancelarMarcaMedida_Click(object sender, EventArgs e)
        {
            MarcaComboBox.SelectedIndex = -1;
            errorProvider1.Dispose();
            AgregarMarcaMedidaButton.Enabled = true;
            GuardarMarcaMedidaButton.Enabled = false;
            CancelarMarcaMedida.Enabled = false;
            MarcaComboBox.Enabled = false;
            MedidaComboBox.Enabled = false;
            ActualizarButton.Enabled = true;
            ActualizarStockButton.Enabled = true;
            AgregarProductoButton.Enabled = true;
            GuardarDatosButton.Enabled = false;
            CancelarButton.Enabled = false;
        }
    }
}

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

namespace CapaUsuario.Compras.Pedidos_de_reaprovisionamiento
{
    public partial class FrmPedidosReaprov : Form
    {
        private BindingList<DetallePedidoReaprov> misDetalles = new BindingList<DetallePedidoReaprov>();
        private DPedidoReaprov dPedidoReaprov;
        private DStock stock;
        private DMarca marca;
        private DMedida medida;

        public FrmPedidosReaprov()
        {
            InitializeComponent();
        }

        private void FrmPedidosReaprov_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FrmPedidosReaprov_SizeChanged(sender, e);
            ActualizarGrid();
            PersonalizarGrid();
            SelectPedidosReaprov();
            SelectComboBoxProveedores();
            SelectStock();
            ProductoComboBox.SelectedIndex = -1;
            MarcaComboBox.SelectedIndex = -1;
            MedidaComboBox.SelectedIndex = -1;
        }

        private void SelectComboBoxProveedores()
        {
            var proveedores = new DProveedores();
            ProveedorComboBox.DataSource = proveedores.SelectNombresProveedores();
            ProveedorComboBox.DisplayMember = "Nombre";
            ProveedorComboBox.ValueMember = "CodProveedor";
        }

        private void PersonalizarGrid()
        {
            DgvStockPedidoReaprov.Columns["CodStock"].HeaderText = "Código de producto";
            DgvStockPedidoReaprov.Columns["NombreStock"].HeaderText = "Nombre";
        }



        private void SelectStock()
        {
            stock = new DStock();
            DgvStock.DataSource = stock.SelectStock();
            DgvStock.Refresh();
        }

        private void FrmPedidosReaprov_SizeChanged(object sender, EventArgs e)
        {
            DgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvStockPedidoReaprov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ActualizarGrid()
        {
            DgvStockPedidoReaprov.DataSource = misDetalles;
            DgvStockPedidoReaprov.Refresh();
        }


        private void FrmPedidosReaprov_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count != 0)
            {
                var rta = MessageBox.Show("Aún tiene productos en el pedido de reaprovisionamiento, ¿desea salir de todas maneras?",
                    "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void InsertStockPedido(int codPedido, int codStock, int cantidad, int codMarca, int codMed)
        {
            var dStockPedidoReaprov = new DStockPedidoReaprov();
            dStockPedidoReaprov.InsertStockPedidoReaprov(codPedido, codStock, cantidad, codMarca, codMed);
        }

        private int InsertPedido(DateTime fecha, bool cancelado, bool automatizado, int cod_proveedor)
        {
            dPedidoReaprov = new DPedidoReaprov();

            int codPedido = dPedidoReaprov.InsertPedidoReaprov(fecha, cancelado, automatizado, cod_proveedor);

            return codPedido;
        }

        private void SelectPedidosReaprov()
        {
            dPedidoReaprov = new DPedidoReaprov();
            DgvListadoPedidos.DataSource = dPedidoReaprov.SelectPedidosReaprov();
            DgvListadoPedidos.Refresh();
        }



        private void BorrarPedidoButton_Click_1(object sender, EventArgs e)
        {

            if (DgvListadoPedidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay pedidos para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Está seguro de borrar el pedido de reaprovisionamiento?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (!(bool)DgvListadoPedidos.SelectedRows[0].Cells[2].Value)
            {
                MessageBox.Show("No se puede borrar el pedido pues está vigente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int codPedido = (int)DgvListadoPedidos.SelectedRows[0].Cells[0].Value;

            var dStockPedidoReaprov = new DStockPedidoReaprov();
            dStockPedidoReaprov.DeleteStockPedidoReaprov(codPedido);

            var dPedidoReaprov = new DPedidoReaprov();
            string msg = dPedidoReaprov.DeletePedidoReaprov(codPedido);

            var popup1 = new PopupNotifier()
            {
                Image = Properties.Resources.info100,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F)
            };
            popup1.Popup();
            SelectPedidosReaprov();
        }

        private void ModificarPedidoButton_Click_1(object sender, EventArgs e)
        {
            if (DgvListadoPedidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay pedidos para modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if ((bool)DgvListadoPedidos.SelectedRows[0].Cells[2].Value)
            {
                MessageBox.Show("No se puede modificar el pedido seleccionado, se encuentra cancelado",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmModificarPedidoReaprov modificarPedidoReaprov = new FrmModificarPedidoReaprov
            {
                CodPedidoReaprov = (int)DgvListadoPedidos.SelectedRows[0].Cells[0].Value,
                IsCancelado = (bool)DgvListadoPedidos.SelectedRows[0].Cells[2].Value
            };
            modificarPedidoReaprov.ShowDialog();

            SelectPedidosReaprov();
        }

        private void AgregarButton_Click_1(object sender, EventArgs e)
        {
            if (ProductoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(ProductoComboBox, "Seleccione un producto");
                ProductoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();


            int codStock = (int)ProductoComboBox.SelectedValue;

            marca = new DMarca();
            medida = new DMedida();

            var detalle = new DetallePedidoReaprov
            {
                CodStock = codStock,
                NombreStock = stock.GetNombreStockByCodStock(codStock),
                Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value),
                Marca = marca.GetNombreMarcaByCodMarca((int)MarcaComboBox.SelectedValue),
                Medida = medida.GetMedidaByCodMedida((int)MedidaComboBox.SelectedValue)
            };

            for (int i = 0; i < misDetalles.Count; i++)
            {
                if (misDetalles[i].CodStock == detalle.CodStock && misDetalles[i].Medida == detalle.Medida)
                {
                    MessageBox.Show("El producto ya se encuentra en el pedido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            misDetalles.Add(detalle);
            ActualizarGrid();
            LimpiarCampos();
            ProductoComboBox.Focus();
        }

        private void GrabarButton_Click_1(object sender, EventArgs e)
        {
            if (misDetalles.Count == 0)
            {
                errorProvider1.SetError(ProductoComboBox, "Debe ingresar productos en el pedido");
                ProductoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            DialogResult rta = MessageBox.Show("¿Está seguro de grabar el pedido de reaprovisionamiento?", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            var fecha = DateTime.Now;

            var codProv = (int)ProveedorComboBox.SelectedValue;
            int codPedido = InsertPedido(fecha, false, false, codProv);

            marca = new DMarca();
            medida = new DMedida();

            for (int i = 0; i < misDetalles.Count; i++)
            {
                int codMarca = marca.GetCodMarcaByNombreMarca(misDetalles[i].Marca);
                int codMed = medida.GetCodMedidaByNombreMedida(misDetalles[i].Medida);

                InsertStockPedido(codPedido, misDetalles[i].CodStock, misDetalles[i].Cantidad,
                    codMarca, codMed);
            }

            var popup1 = new PopupNotifier()
            {
                Image = Properties.Resources.sql_success1,
                TitleText = "Mensaje",
                ContentText = $"El pedido de reaprovisionamiento con código:{codPedido} fue grabado de forma exitosa",
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
                ImagePadding = new Padding(8)
            };
            popup1.Popup();



            misDetalles.Clear();
            ActualizarGrid();
            LimpiarCampos();
            SelectPedidosReaprov();
            DeshabilitarCampos();
        }

        private void CancelarButton_Click_1(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void BorrarLineaButton_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;
            //borramos el registro seleccionado, o el último agregado
            if (DgvStockPedidoReaprov.SelectedRows.Count == 0)
            {
                misDetalles.RemoveAt(misDetalles.Count - 1);
                ActualizarGrid();
            }
            else
            {
                var idBienUso = (int)DgvStockPedidoReaprov.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDetalles.Count; i++)
                {
                    if (misDetalles[i].CodStock == idBienUso)
                    {
                        misDetalles.RemoveAt(i);
                        break;
                    }
                }
            }
            ActualizarGrid();
        }

        private void BorrarTodoButton_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;

            var rta = MessageBox.Show("¿Está seguro de borrar todos los productos de la solicitud?", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            misDetalles.Clear();
            ActualizarGrid();
        }

        private void GenerarPedidosAutoButton_Click_1(object sender, EventArgs e)
        {
            if (ProveedorComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(ProveedorComboBox, "Seleccione un proveedor");
                ProveedorComboBox.Focus();
                return;
            }

            var rta = MessageBox.Show("¿Está seguro de generar un pedido automatizado?", "Confirmación",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            var codProv = (int)ProveedorComboBox.SelectedValue;

            stock = new DStock();
            List<DStockParaPedidosAuto> valoresStock = stock.SelectListadoStockActualMenorAlCritico(codProv);

            if (valoresStock == null)
            {
                MessageBox.Show("No se generó el pedido, no hay productos cuyo stock actual sea menor al crítico", "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

           
            int codPedido = InsertPedido(DateTime.Now, false, true, codProv);


            foreach (var stock in valoresStock)
            {
                InsertStockPedido(codPedido, stock.CodStock, stock.StockCritico - stock.StockActual, 1, 1);
            }

            var popup1 = new PopupNotifier()
            {
                Image = Properties.Resources.sql_success1,
                TitleText = "Mensaje",
                ContentText = $"El pedido automatizado con código:{codPedido} fue grabado de forma exitosa",
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
                ImagePadding = new Padding(8)
            };
            popup1.Popup();

            misDetalles.Clear();
            ActualizarGrid();
            LimpiarCampos();
            DeshabilitarCampos();
            SelectPedidosReaprov();
            ProductoComboBox.Focus();
        }

        private void FiltrarPedidosTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FiltrarPedidosTextBox.Text.Trim() != string.Empty)
            {

                if (!int.TryParse(FiltrarPedidosTextBox.Text.Trim(), out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FiltrarPedidosTextBox.Text = string.Empty;
                    return;
                }

                dPedidoReaprov = new DPedidoReaprov();
                DgvListadoPedidos.DataSource =
                    dPedidoReaprov.SelectPedidosReaprovByCodPedido(int.Parse(FiltrarPedidosTextBox.Text.Trim()));
                DgvListadoPedidos.Refresh();
            }
            else
            {
                SelectPedidosReaprov();
            }
        }

        private void FiltrarStockTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FiltrarStockTextBox.Text.Trim() != string.Empty)
            {
                stock = new DStock();
                DgvStock.DataSource = stock.SelectStockByNombre(FiltrarStockTextBox.Text.Trim());
                DgvStock.Refresh();
            }
            else
            {
                SelectStock();
            }
        }

        private void ActualizarListadoStock_Click_1(object sender, EventArgs e)
        {
            stock = new DStock();
            DgvStock.DataSource = stock.SelectStock();
            DgvStock.Refresh();
        }

        private void NuevoPedidoButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            materialTabControl1.SelectedTab = TabNuevo;
        }

        private void HabilitarCampos()
        {
            ProveedorComboBox.Enabled = true;
            ProductoComboBox.Enabled = true;
            MarcaComboBox.Enabled = true;
            MedidaComboBox.Enabled = true;
            CantidadNumericUpDown.Enabled = true;

            AgregarButton.Enabled = true;
            GrabarButton.Enabled = true;
            CancelarButton.Enabled = true;
            BorrarLineaButton.Enabled = true;
            BorrarTodoButton.Enabled = true;

            GenerarPedidosAutoButton.Enabled = false;
            button1.Enabled = false;

            NuevoPedidoButton.Enabled = false;
            ModificarPedidoButton.Enabled = false;
            BorrarPedidoButton.Enabled = false;

            FiltrarPedidosTextBox.ReadOnly = true;
            FiltrarStockTextBox.ReadOnly = true;

            ProductoComboBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            ProveedorComboBox.Enabled = false;
            ProductoComboBox.Enabled = false;
            MarcaComboBox.Enabled = false;
            MedidaComboBox.Enabled = false;
            CantidadNumericUpDown.Enabled = false;

            AgregarButton.Enabled = false;
            GrabarButton.Enabled = false;
            CancelarButton.Enabled = false;
            BorrarLineaButton.Enabled = false;
            BorrarTodoButton.Enabled = false;

            GenerarPedidosAutoButton.Enabled = false;
            button1.Enabled = true;

            NuevoPedidoButton.Enabled = true;
            ModificarPedidoButton.Enabled = true;
            BorrarPedidoButton.Enabled = true;

            FiltrarPedidosTextBox.ReadOnly = false;
            FiltrarStockTextBox.ReadOnly = false;
        }

        private void LimpiarCampos()
        {
            ProductoComboBox.SelectedIndex = -1;
            MarcaComboBox.SelectedIndex = -1;
            MedidaComboBox.SelectedIndex = -1;
            CantidadNumericUpDown.Value = 1;
        }

        private void ProductoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectMarcaMedidaByStock();
        }

        private void SelectMarcaMedidaByStock()
        {
            try
            {
                var codStock = (int)ProductoComboBox.SelectedValue;

                marca = new DMarca();
                MarcaComboBox.DataSource = marca.SelectMarcasByCodStock(codStock);
                MarcaComboBox.DisplayMember = "Nombre";
                MarcaComboBox.ValueMember = "CodMarca";

                medida = new DMedida();
                MedidaComboBox.DataSource = medida.SelectMedidasByCodStock(codStock);
                MedidaComboBox.DisplayMember = "Nombre";
                MedidaComboBox.ValueMember = "CodMedida";

            }
            catch (Exception)
            {
                return;
            }
        }

        private void ProveedorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SelectNombresStockConMarcaAsociadaByCodProveedor((int)ProveedorComboBox.SelectedValue);
            }
            catch (Exception)
            {
                return;
            }

        }

        private void SelectNombresStockConMarcaAsociadaByCodProveedor(int codProveedor)
        {
            stock = new DStock();
            ProductoComboBox.DataSource =
                stock.SelectNombresStockConMarcaAsociadaByCodProveedor(codProveedor);
            ProductoComboBox.DisplayMember = "Nombre";
            ProductoComboBox.ValueMember = "CodStock";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveedorComboBox.SelectedIndex = -1;
            ProveedorComboBox.Enabled = true;
            button1.Enabled = false;
            GenerarPedidosAutoButton.Enabled = true;
            CancelarButton.Enabled = true;
        }
    }
}

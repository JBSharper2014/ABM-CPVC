using System;
using System.Windows.Forms;
using CapaDatos;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Ventas.Devolucion
{
    public partial class FrmPedidoDevolucion : Form
    {
        private int codPedido;
        private int codPedidoVenta;
        private int codRemito;
        int cantidadDevuelta;
        public FrmPedidoDevolucion()
        {
            InitializeComponent();
        }

        private void FrmPedidoDevolucion_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FrmPedidoDevolucion_SizeChanged(sender, e);

            // Llenar Grids y ComboBox
            ListarRemitos();
            ListarDevoluciones();
        }

        private void ListarRemitos()
        {
            DgvListadoRemitos.DataSource = ExecuteQuery.SelectAll(3012);
        }
        private void ListarDevoluciones()
        {
            DgvListadoPedidos.DataSource = ExecuteQuery.SelectAll(3011);
        }

        private void CrearPedidoDevButton_Click(object sender, EventArgs e)
        {

            if (DgvListadoRemitos.Rows.Count == 0)
            {
                MessageBox.Show("No hay remitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HabilitarCampos();
            materialTabControl1.SelectedTab = TabNuevo;

            codRemito = (int)DgvListadoRemitos.SelectedRows[0].Cells[0].Value;
            codPedidoVenta = (int)ExecuteQuery.SelectCode(8004, codRemito);

            dgvProductosPorRemito.DataSource = ExecuteQuery.SelectOne(7010, codPedidoVenta);

        }

        private void HabilitarCampos()
        {
            ProblemasTextBox.ReadOnly = false;

            DevCreditoRadioButton.Enabled = true;
            DevProductoRadioButton.Enabled = true;
            txtcantidadadevolver.ReadOnly = false;

            CancelarButton.Enabled = true;
            GuardarCambiosButton.Enabled = true;

            CodPedidoBusquedaTextBox.ReadOnly = true;
            CodClienteBusquedaTextBox.ReadOnly = true;
            CodRemitoBusquedaTextBox.ReadOnly = true;

        }

        private void DeshabilitarCampos()
        {
            ProblemasTextBox.ReadOnly = true;
            txtcantidadadevolver.ReadOnly = true;

            DevCreditoRadioButton.Enabled = false;
            DevProductoRadioButton.Enabled = false;

            CancelarButton.Enabled = false;
            GuardarCambiosButton.Enabled = false;

            CodPedidoBusquedaTextBox.ReadOnly = false;
            CodClienteBusquedaTextBox.ReadOnly = false;
            CodRemitoBusquedaTextBox.ReadOnly = false;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {

            txtcantidadadevolver.Text = "";
            ProblemasTextBox.Text = string.Empty;
            DevCreditoRadioButton.Checked = false;
            DevProductoRadioButton.Checked = false;
        }

        private void BorrarPedidoButton_Click(object sender, EventArgs e)
        {
            if (DgvListadoPedidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay pedidos a borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Está seguro de borrar el pedido seleccionado?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            // obtencion del codigo de pedido y borrado

            if (((string)DgvListadoPedidos.SelectedRows[0].Cells[6].Value == "Devolucion por credito") ||
                ((string)DgvListadoPedidos.SelectedRows[0].Cells[6].Value == "Devolucion por producto"))
            {
                ExecuteQuery.DeleteFrom(30007, (int)DgvListadoPedidos.SelectedRows[0].Cells[0].Value);
                if (MessageException.message == "")
                {
                    //MessageBox.Show("El registro fue eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var popup = new PopupNotifier()
                    {
                        Image = Properties.Resources.info100,
                        TitleText = "Mensaje",
                        ContentText = "El registro fue eliminado correctamente",
                        ContentFont = new System.Drawing.Font("Segoe UI Bold", 11F),
                        TitleFont = new System.Drawing.Font("Segoe UI Bold", 10F),
                    };
                    popup.Popup();
                    ListarDevoluciones();
                }
            }
            else
            {
                string mensaje = string.Format("Solo es posible borrar las devoluciones cuyo estado sea {0} o {1} ", "\"Devolucion por credito\"", "\"Devolucion por producto\"");
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void GuardarCambiosButton_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            DialogResult rta = MessageBox.Show("¿Guardar datos?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            // insercion de pedido de devolucion

            string estado = "";

            if (DevCreditoRadioButton.Checked == true)
            {
                estado = "Devolucion por credito";
            }
            else
            {
                estado = "Devolucion por producto";
            }

            object[] parameters =
            {
                codRemito,
                Convert.ToInt32(txtproductoseleccionado.Text),
                cantidadDevuelta,
                ProblemasTextBox.Text,
                estado,
                DateTime.Now.ToShortDateString()
            };

            ExecuteQuery.InsertInto(307, parameters);

            if (MessageException.message == "")
            {
                // MessageBox.Show("Devolucion ingresada correctamente");
                var popup = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_success1,
                    TitleText = "Mensaje",
                    ContentText = "Devolucion ingresada correctamente",
                    ContentFont = new System.Drawing.Font("Segoe UI Bold", 11F),
                    TitleFont = new System.Drawing.Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup.Popup();
                ListarDevoluciones();
            }
            else
            {
                var popup = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_error,
                    TitleText = "Mensaje",
                    ContentText = "Error al ingresar la devolución",
                    ContentFont = new System.Drawing.Font("Segoe UI Bold", 11F),
                    TitleFont = new System.Drawing.Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10, 5, 0, 0)
                };
                popup.Popup();
                ListarDevoluciones();
            }

            DeshabilitarCampos();
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {


            if (ProblemasTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ProblemasTextBox, "Ingrese una descripción de los problemas encontrados");
                ProblemasTextBox.Focus();
                return false;
            }

            if (dgvProductosPorRemito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto el cual devolver"
                    , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtproductoseleccionado.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad a devolver del producto que haya seleccionado"
                    , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (DevCreditoRadioButton.Checked == false && DevProductoRadioButton.Checked == false)
            {
                MessageBox.Show("Debe seleccionar si quiere que sea una devolucion por credito o por producto"
                    , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void CodPedidoBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Filtrar pedidos de devolucion por código de pedido
            int codigo = 0;
            if (CodPedidoBusquedaTextBox.Text != "")
            {

                if (int.TryParse(CodPedidoBusquedaTextBox.Text, out codigo))
                {
                    DgvListadoPedidos.DataSource = ExecuteQuery.SelectOne(7011, codigo);
                }
                else
                {
                    MessageBox.Show("Debe escribir un numero entero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CodPedidoBusquedaTextBox.Text = "";
                    ListarDevoluciones();
                }
            }
        }

        private void CodRemitoBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Filtrar remitos por código de remito
            int codigo = 0;
            if (CodRemitoBusquedaTextBox.Text != "")
            {

                if (int.TryParse(CodRemitoBusquedaTextBox.Text, out codigo))
                {
                    DgvListadoRemitos.DataSource = ExecuteQuery.SelectOne(7005, codigo);
                }
                else
                {
                    MessageBox.Show("Debe escribir un numero entero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CodRemitoBusquedaTextBox.Text = "";
                    ListarRemitos();
                }
            }
        }

        private void CodClienteBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Filtrar remitos por nombrede cliente
            DgvListadoRemitos.DataSource = ExecuteQuery.SelectOne(7006, CodClienteBusquedaTextBox.Text);
        }

        private void dgvProductosPorRemito_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductosPorRemito.SelectedRows.Count > 0)
            {
                txtproductoseleccionado.Text = dgvProductosPorRemito.SelectedRows[0].Cells[0]
                    .Value
                    .ToString();
            }
        }

        private void txtcantidadadevolver_TextChanged(object sender, EventArgs e)
        {
            if (txtcantidadadevolver.Text != "")
            {
                if (!int.TryParse(txtcantidadadevolver.Text, out cantidadDevuelta))
                {
                    MessageBox.Show("Ingrese solamente numeros enteros en cantidad a devolver",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmPedidoDevolucion_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoRemitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

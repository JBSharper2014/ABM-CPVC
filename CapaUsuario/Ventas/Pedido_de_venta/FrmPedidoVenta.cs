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

namespace CapaUsuario.Ventas.Pedido_de_venta
{

    public partial class FrmPedidoVenta : Form
    {

        int cod_cli = 0;

        bool insert = false;
        bool update = false;

        DataTable table_pedido_producto = new DataTable();
        DataColumn cod_pro = new DataColumn("Codigo", System.Type.GetType("System.Int32"));
        DataColumn nombre_pro = new DataColumn("Nombre", System.Type.GetType("System.String"));
        DataColumn cantidad = new DataColumn("Cantidad", System.Type.GetType("System.Int32"));
        DataRow dataRow;


        private void Inicializardgv()
        {
            table_pedido_producto.Columns.Add(cod_pro);
            table_pedido_producto.Columns.Add(nombre_pro);
            table_pedido_producto.Columns.Add(cantidad);

            DgvProductosVenta.DataSource = table_pedido_producto;

        }

        BindingList<DetallePedidoVenta> misDetalles = new BindingList<DetallePedidoVenta>();
        public FrmPedidoVenta()
        {
            InitializeComponent();
            Listar_clientes();
            Listar_pedidos();
            Listar_productos();
            Inicializardgv();




        }

        private void FrmPedidoVenta_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            AlinearColumnasGrids();
        }

        private void AlinearColumnasGrids()
        {
            DgvProductosVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvclientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CrearPedidoButton_Click(object sender, EventArgs e)
        {
            if (dgvclientes.Rows.Count == 0)
            {
                MessageBox.Show("No hay clientes cargados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HabilitarCampos();
            materialTabControl1.SelectedTab = preciototaltext;
            insert = true;
        }

        private void HabilitarCampos()
        {

            CantidadNumericUpDown.Enabled = true;

            txtcodpro.ReadOnly = false;
            AgregarButton.Enabled = true;
            GrabarButton.Enabled = true;
            CancelarButton.Enabled = true;
            BorrarLineaButton.Enabled = true;
            BorrarTodoButton.Enabled = true;

            CrearPedidoButton.Enabled = false;
            ModificarPedidoButton.Enabled = false;
            BorrarPedidoButton.Enabled = false;
        }

        private void DeshabilitarCampos()
        {

            CantidadNumericUpDown.Enabled = false;

            txtcodpro.ReadOnly = true;

            AgregarButton.Enabled = false;
            GrabarButton.Enabled = false;
            CancelarButton.Enabled = false;
            BorrarLineaButton.Enabled = false;
            BorrarTodoButton.Enabled = false;

            CrearPedidoButton.Enabled = true;
            ModificarPedidoButton.Enabled = true;
            BorrarPedidoButton.Enabled = true;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void FrmPedidoVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            // errorProvider1.Clear();
            if (misDetalles.Count != 0)
            {
                DialogResult rta = MessageBox.Show("Aún tiene productos en el pedido de venta, ¿desea salir de todas maneras?",
                    "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BorrarTodoButton_Click(object sender, EventArgs e)
        {
            if (table_pedido_producto.Rows.Count > 0)
            {
                table_pedido_producto.Rows.Clear();
                Actualizar_precio();
            }
            else
                MessageBox.Show("No hay ningun producto para borrar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ActualizarGrid()
        {
            DgvProductosVenta.DataSource = misDetalles;
            DgvProductosVenta.Refresh();
        }

        private void BorrarLineaButton_Click(object sender, EventArgs e)
        {
            if (DgvProductosVenta.Rows.Count > 0)
                DgvProductosVenta.Rows.Remove(DgvProductosVenta.SelectedRows[0]);

            else
                MessageBox.Show("No hay ningun producto para borrar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GrabarButton_Click(object sender, EventArgs e)
        {

            if (misDetalles.Count == 0)
            {
                MessageBox.Show("Ingrese productos en el pedido", "Confirmación",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DialogResult rta = MessageBox.Show("¿Está seguro de grabar el pedido de venta?", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes)
            {

                if (insert)
                {
                    List<int> codigos = new List<int>();
                    List<int> cantidades = new List<int>();
                    for (int i = 0; i <= dgvproductos.Rows.Count - 1; i++)
                    {
                        codigos.Add((int)DgvProductosVenta.Rows[i].Cells[0].Value);
                        cantidades.Add((int)DgvProductosVenta.Rows[i].Cells[2].Value);
                    }



                    object[] parametes = {
                    (int)dgvclientes.SelectedCells[0].Value,
                    DateTime.Now.ToShortDateString(),
                    codigos.ToArray(),
                    cantidades.ToArray()
                    };

                    ExecuteQuery.InsertInto(304, parametes);
                    ExecuteQuery.InsertInto(305, parametes);

                    if (MessageException.message == "")
                    {
                        //MessageBox.Show("Pedido de venta ingresado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var popup1 = new PopupNotifier()
                        {
                            Image = Properties.Resources.sql_success1,
                            TitleText = "Mensaje",
                            ContentText = "Pedido de venta ingresado correctamente",
                            ContentFont = new Font("Segoe UI Bold", 11F),
                            TitleFont = new Font("Segoe UI Bold", 10F),
                            ImagePadding = new Padding(10)
                        };
                        popup1.Popup();
                        Listar_pedidos();
                        DeshabilitarCampos();
                        LimpiarCampos();
                    }

                    insert = false;
                }

                if (update)
                {
                    int cod_ped_vent = (int)DgvPedidos.SelectedRows[0].Cells[0].Value;
                    for (int i = 0; i <= DgvProductosVenta.Rows.Count - 1; i++)
                    {
                        int codigo_producto = (int)DgvProductosVenta.Rows[i].Cells[0].Value;
                        int cantidad = (int)DgvProductosVenta.Rows[i].Cells[2].Value;

                        object[] parameters =
                        {
                            codigo_producto,
                            cod_ped_vent,
                            cantidad
                        };

                        ExecuteQuery.UpdateMany(300001, parameters);
                    }

                    if (MessageException.message == "")
                    {
                       // MessageBox.Show("El pedido de venta fue actualizado correctamente",
                            //"INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var popup1 = new PopupNotifier()
                        {
                            Image = Properties.Resources.guardar_datos64,
                            TitleText = "Mensaje",
                            ContentText = "El pedido de venta fue actualizado correctamente",
                            ContentFont = new Font("Segoe UI Bold", 11F),
                            TitleFont = new Font("Segoe UI Bold", 10F),
                            ImagePadding = new Padding(10)
                        };
                        popup1.Popup();
                        Listar_productos_del_pedido();
                    }

                    update = false;
                }
            }
            DeshabilitarCampos();
            LimpiarCampos();

            // MessageBox.Show(msgExito, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void LimpiarCampos()
        {
            txtcodpro.Text = "";
            CantidadNumericUpDown.Value = 1;
            DgvProductosVenta.DataSource = null;
            labelprecio.Text = "0";
            txtcodpro.Text = "";

        }

        private void ModificarPedidoButton_Click(object sender, EventArgs e)
        {
            if (DgvPedidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay pedidos a modificar", "Información",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Validar_modificacion())
            {
                Listar_productos_del_pedido();
            }
            else
            { return; }
        }

        private bool Validar_modificacion()
        {
            if (DgvPedidos.Rows[0].Cells[0].Value != null)
                if (DgvPedidos.SelectedRows.Count > 0)
                {
                    if (!(bool)DgvPedidos.SelectedRows[0].Cells[3].Value)
                    {
                        materialTabControl1.SelectedTab = preciototaltext;
                        HabilitarCampos();
                        update = true;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El pedido seleccionado ya fue procesado y no puede ser modificado"
                            , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione algún pedido de venta", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            else
            {
                MessageBox.Show("Debe existir un pedido de venta previamente cargado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void BorrarPedidoButton_Click(object sender, EventArgs e)
        {
            if (DgvPedidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay pedidos a borrar", "Información",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                if (DgvPedidos.SelectedRows != null)
                {
                    DialogResult rta = MessageBox.Show("¿Está seguro de borrar el pedido de venta seleccionado?", "Confirmación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (rta == DialogResult.No)
                        return;
                    else
                    {
                        if (!(bool)DgvPedidos.SelectedCells[3].Value)
                        {
                            ExecuteQuery.DeleteFrom(30004, (int)DgvPedidos.SelectedCells[0].Value);

                            if (MessageException.message == "")
                            {
                                //MessageBox.Show("El pedido de venta se borró correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                var popup1 = new PopupNotifier()
                                {
                                    Image = Properties.Resources.info100,
                                    TitleText = "Mensaje",
                                    ContentText = "El pedido de venta se borró correctamente",
                                    ContentFont = new Font("Segoe UI Semilight", 10F),
                                    TitleFont = new Font("Segoe UI Bold", 10F),
                                };
                                popup1.Popup();
                                Listar_pedidos();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mantenga seleccionado un pedido para que ese pueda ser borrado.",
                        "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Sumar_fila()
        {
            dataRow = table_pedido_producto.NewRow();
            dataRow[0] = dgvproductos.SelectedCells[0].Value;
            dataRow[1] = dgvproductos.SelectedCells[1].Value;
            dataRow[2] = (int)CantidadNumericUpDown.Value;

            table_pedido_producto.Rows.Add(dataRow);


            DgvProductosVenta.DataSource = table_pedido_producto;

            // MessageBox.Show(msgExito, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);


        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            Sumar_fila();
            Actualizar_precio();
        }

        public void Listar_clientes()
        {
            dgvclientes.DataSource = ExecuteQuery.SelectAll(3000);
        }

        public void Listar_pedidos()
        {
            DgvPedidos.DataSource = ExecuteQuery.SelectAll(3004);
        }

        public void Listar_productos()
        {
            dgvproductos.DataSource = ExecuteQuery.SelectAll(3005);
        }

        private void txtcodpro_TextChanged(object sender, EventArgs e)
        {
            dgvproductos.DataSource = null;
            dgvproductos.DataSource = ExecuteQuery.SelectOne(7003, txtcodpro.Text);
            dgvproductos.Refresh();
        }

        private void Actualizar_precio()
        {
            int codigo;
            int cantidad;
            double precio = 0;
            int indice = 0;
            for (int i = 0; i <= DgvProductosVenta.Rows.Count - 1; i++)
            {
                codigo = (int)DgvProductosVenta.Rows[i].Cells[0].Value;
                cantidad = (int)DgvProductosVenta.Rows[i].Cells[2].Value;

                for (int j = 0; j <= dgvproductos.Rows.Count - 1; j++)
                {
                    if ((int)dgvproductos.Rows[j].Cells[0].Value == codigo)
                    {
                        indice = j;
                        break;
                    }
                }


                precio += cantidad * Convert.ToDouble(dgvproductos.Rows[indice].Cells[4].Value);

            }
            labelprecio.Text = precio.ToString();
        }

        private void Listar_productos_del_pedido()
        {
            table_pedido_producto =
            ExecuteQuery.SelectOne(7004, DgvPedidos.SelectedRows[0].Cells[0].Value);
            DgvProductosVenta.DataSource = table_pedido_producto;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!int.TryParse(textBox1.Text, out cod_cli))
                {
                    MessageBox.Show("Ingrese solo valores enteros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    dgvclientes.DataSource = ExecuteQuery.SelectOne(7002, cod_cli);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgvclientes.DataSource = ExecuteQuery.SelectOne(7009, txtbuscarpornombre.Text);
        }
    }
}

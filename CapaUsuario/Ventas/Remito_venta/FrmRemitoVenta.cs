using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


using CapaDatos;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Ventas.Remito_venta
{
    public partial class FrmRemitoVenta : Form
    {
        int codigoRemito;
        private bool esDevolucion = false;


        public FrmRemitoVenta()
        {
            InitializeComponent();
            Listar_devoluciones();
            Listar_pedidos();
            Listar_remitos();
        }

        private void Listar_pedidos()
        {
            DgvPedidosVenta.DataSource = ExecuteQuery.SelectAll(3006);
        }
        private void Listar_remitos()
        {
            DgvListadoRemitos.DataSource = ExecuteQuery.SelectAll(3007);
        }
        private void Listar_devoluciones()
        {
            DgvPedidosDevolucion.DataSource = ExecuteQuery.SelectAll(3008);
        }

        private void FrmRemitoVenta_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FrmRemitoVenta_SizeChanged(sender, e);
        }

        private void CrearRemitoDevolucion_Click(object sender, EventArgs e)
        {
            if (!ListaVacia("devolución", DgvPedidosDevolucion)) return;

            esDevolucion = true;
            HabilitarCampos();
            tabcontroloca.SelectedTab = TabAdmin;
        }

        private void HabilitarCampos()
        {
            ObservacionesTextBox.ReadOnly = false;
            CancelarButton.Enabled = true;
            GuardarCambiosButton.Enabled = true;



            CrearRemitoVentaButton.Enabled = false;
            CrearRemitoDevolucion.Enabled = false;

            RemitoBusquedaTextBox.Enabled = false;
            PedidoVentaBusquedaTextBox.Enabled = false;
            PedidoDevBusquedaTextBox.Enabled = false;

            ObservacionesTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            ObservacionesTextBox.ReadOnly = true;
            CancelarButton.Enabled = false;
            GuardarCambiosButton.Enabled = false;



            CrearRemitoVentaButton.Enabled = true;
            CrearRemitoDevolucion.Enabled = true;

            RemitoBusquedaTextBox.Enabled = true;
            PedidoVentaBusquedaTextBox.Enabled = true;
            PedidoDevBusquedaTextBox.Enabled = true;
        }

        private void CrearRemitoVentaButton_Click(object sender, EventArgs e)
        {

            if (!ListaVacia("venta", DgvPedidosVenta)) return;

            esDevolucion = false;
            HabilitarCampos();
            tabcontroloca.SelectedTab = TabAdmin;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            ObservacionesTextBox.Text = string.Empty;
            esDevolucion = false;

        }

        private void EsDevolucionCheckBox_Click(object sender, EventArgs e)
        {
            if (esDevolucion)
            {
            }
            else
            {
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////  FALTARIA AGREGAR LA LOGICA PARA NO DEJAR HACER UN REMITO SI NO HAY STOCK PARA CUBRIR EL PEDIDO  ///////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void GuardarCambiosButton_Click(object sender, EventArgs e)
        {
            int codigo_producto;
            object cantidad_restar;

            DialogResult rta = MessageBox.Show(!esDevolucion ?
                "¿Está seguro de grabar el remito del pedido de venta?"
                : "¿Está seguro de grabar el remito del pedido de devolución?"
                , "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            // Logica para insertar el remito

            if (!esDevolucion)
            {
                object[] datos_alta_remito =
                {
                    DgvPedidosVenta.SelectedRows[0].Cells[0].Value,
                    ObservacionesTextBox.Text,
                    false,
                    DateTime.Now.ToShortDateString(),
                    -1
                };
                ExecuteQuery.InsertInto(306, datos_alta_remito);



                DataTable dt = new DataTable();
                dt = ExecuteQuery.SelectOne(7008, datos_alta_remito[0]);
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    codigo_producto = (int)dt.Rows[i].ItemArray[0];
                    cantidad_restar = dt.Rows[i].ItemArray[1];
                    ExecuteQuery.UpdateOne(400006, codigo_producto, cantidad_restar);
                }

                if (MessageException.message == "")
                {
                    //MessageBox.Show("Remito insertado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.sql_success1,
                        TitleText = "Mensaje",
                        ContentText = "Remito insertado con éxito",
                        ContentFont = new Font("Segoe UI Semilight", 10F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(10)
                    };
                    popup1.Popup();
                    Listar_pedidos();
                }

            }
            else
            {
                object[] datos_alta_devolucion =
                {
                    //// el codigo del pedido de venta tiene que ser resultado de buscar el remito etc.
                    ExecuteQuery.SelectCode(8004,DgvPedidosDevolucion.SelectedRows[0].Cells[1].Value),
                    ObservacionesTextBox.Text,
                    true,
                    DateTime.Now.ToShortDateString(),
                    DgvPedidosDevolucion.SelectedRows[0].Cells[0].Value
                };
                ExecuteQuery.InsertInto(306, datos_alta_devolucion);

                codigo_producto = (int)DgvPedidosDevolucion.SelectedRows[0].Cells[2].Value;
                cantidad_restar = DgvPedidosDevolucion.SelectedRows[0].Cells[3].Value;

                ExecuteQuery.UpdateOne(400006, codigo_producto, cantidad_restar);
                esDevolucion = false;

                if (MessageException.message == "")
                {
                    //MessageBox.Show("Remito insertado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.sql_success1,
                        TitleText = "Mensaje",
                        ContentText = "Remito insertado con éxito",
                        ContentFont = new Font("Segoe UI Semilight", 10F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(10)
                    };
                    popup1.Popup();
                    Listar_devoluciones();
                }

            }
            Listar_remitos();

            DeshabilitarCampos();
            LimpiarCampos();
        }

        private bool ListaVacia(string tipoRemito, DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show($"No hay pedidos de {tipoRemito}", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (DgvPedidosDevolucion.SelectedRows.Count > 0)
            {
                ObservacionesTextBox.Text = (string)DgvPedidosDevolucion.SelectedRows[0].Cells[4].Value;
                tabcontroloca.SelectedTab = TabAdmin;
            }
            else
            {
                SelectRowMessage();
            }
        }

        private void BtnObservacionRemito_Click(object sender, EventArgs e)
        {
            if (DgvListadoRemitos.SelectedRows.Count > 0)
            {
                ObservacionesTextBox.Text = (string)DgvListadoRemitos.SelectedRows[0].Cells[2].Value;
                tabcontroloca.SelectedTab = TabAdmin;
            }
            else
            {
                SelectRowMessage();
            }
        }

        private void SelectRowMessage()
        {
            MessageBox.Show("Primero seleccione un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DgvListadoRemitos.DataSource = ExecuteQuery.SelectOne(7006, textBox1.Text);
        }

        private void RemitoBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {

            if (RemitoBusquedaTextBox.Text != "")
                if (int.TryParse(RemitoBusquedaTextBox.Text, out codigoRemito))
                {

                    DgvListadoRemitos.DataSource = ExecuteQuery.SelectOne(7005, codigoRemito);
                }
                else
                {
                    MessageBox.Show("Solo puede ingresar valores enteros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RemitoBusquedaTextBox.Text = string.Empty;
                }
        }

        private void PedidoVentaBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            DgvPedidosVenta.DataSource = ExecuteQuery.SelectOne(7007, PedidoVentaBusquedaTextBox.Text);
        }

        private void FrmRemitoVenta_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoRemitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidosDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidosVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

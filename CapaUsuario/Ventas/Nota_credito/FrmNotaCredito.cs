using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

using CapaDatos;

namespace CapaUsuario.Ventas.Nota_credito
{
    public partial class FrmNotaCredito : Form
    {


        public FrmNotaCredito()
        {
            InitializeComponent();
        }

        private void FrmNotaCredito_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FrmNotaCredito_SizeChanged(sender, e);

            // Llenar grids
            Listar_Devoluciones();
            Listar_notas();
        }

        private void Listar_notas()
        {
            DgvListadoNotasCredito.DataSource = ExecuteQuery.SelectAll(3014);
        }

        private void Listar_Devoluciones()
        {
            DgvPedidos.DataSource = ExecuteQuery.SelectAll(3013);
        }

        private void FrmNotaCredito_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoNotasCredito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CodNotaCreditoBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Lógica pra filtrado de notas de crédito por código de nota de crédito
        }

        private void BorrarNotaCreditoButton_Click(object sender, EventArgs e)
        {

            if (DgvListadoNotasCredito.Rows.Count == 0)
            {
                MessageBox.Show("No hay notas de crédito a borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if((bool)DgvListadoNotasCredito.SelectedRows[0].Cells[3].Value)
            {
                MessageBox.Show("No se puede borrar la nota de crédito: La misma ya fue sumada a la cuenta corriente del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Está seguro de borrar la nota de crédito seleccionada?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int codPed = (int)DgvListadoNotasCredito.SelectedRows[0].Cells[1].Value;

            ExecuteQuery.UpdateOne(400007, codPed, "relleno");

            int codNota = (int)DgvListadoNotasCredito.SelectedRows[0].Cells[0].Value;

            // Lógica de borrado de nota de crédito
            ExecuteQuery.DeleteFrom(30006, codNota);

            if (MessageException.message == "")
            {
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "Nota de crédito borrada con éxito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                };
                popup1.Popup();
                Listar_notas();
                Listar_Devoluciones();
            }
        }

        private void CrearNotaCredito_Click(object sender, EventArgs e)
        {
            if (DgvPedidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay pedidos de devolución cargados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codPedido = (int)DgvPedidos.Rows[0].Cells[0].Value;

            DialogResult rta = MessageBox.Show($"¿Está seguro de crear una nota de crédito con el pedido con código {codPedido}?", 
                "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            // Obtener precio unitario del producto presente en el pedido y calcular 
            double importeCredito = Convert.ToDouble(ExecuteQuery.SelectOne(7012, codPedido).Rows[0].ItemArray[0]);


            // Lógica de insertado de nota de crédito


           

            object[] parameters =
            {
                codPedido,
                importeCredito.ToString()
            };

            ExecuteQuery.InsertInto(309, parameters);

            if (MessageException.message == "")
            {
                ExecuteQuery.UpdateOne(400004, codPedido, "Parametro de relleno");
                if (MessageException.message == "")
                {
                    var popup1 = new PopupNotifier()
                    {
                        Image = Properties.Resources.sql_success1,
                        TitleText = "Mensaje",
                        ContentText = "Nota de crédito agregada correctamente",
                        ContentFont = new Font("Segoe UI Bold", 11F),
                        TitleFont = new Font("Segoe UI Bold", 10F),
                        ImagePadding = new Padding(10)
                    };
                    popup1.Popup();
                    Listar_Devoluciones();
                    Listar_notas();
                }
            }

            // MessageBox.Show(msgExito, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

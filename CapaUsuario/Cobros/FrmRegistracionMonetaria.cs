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
using CapaDatos;


namespace CapaUsuario.Cobros
{
    public partial class FrmRegistracionMonetaria : Form
    {
        public FrmRegistracionMonetaria()
        {
            InitializeComponent();
            ListarRegistraciones();
            ListarConfirmaciones();
        }

        private void FrmRegistracionMonetaria_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void ListarConfirmaciones()
        {
            DgvConfirmaciones.DataSource = ExecuteQuery.SelectAll(404);
        }

        private void ListarRegistraciones()
        {
            DgvListadoRegistraciones.DataSource = ExecuteQuery.SelectAll(401);
        }

        private void CrearRegistracionButton_Click(object sender, EventArgs e)
        {
            if (DgvConfirmaciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay confirmaciones de cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Está seguro de crear una registración por la confirmación seleccionada?",
                "Confrimación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            var codConfirmacion = (int)DgvConfirmaciones.SelectedRows[0].Cells[0].Value;

            var fechaRegistracion = DateTime.Now;

            // InsertRegistracion(codConfirmacion, fechaRegistracion);

            // En la cuenta corriente del cliente, en el campo << DEBE >> pasará a restársele el valor de << IMPORTE RECIBIDO >> 
            // mientras que en el campo << SALDO >> de la cuenta bancaria cuyo registro se accederá a través de 
            // << COD.CUENTA BANCARIA >> se le sumará el campo << IMPORTE RECIBIDO >>

            object[] parameters =
            {
            codConfirmacion,
            fechaRegistracion.ToShortDateString()
            };

            ExecuteQuery.InsertInto(41, parameters);
            if (MessageException.message == "")
            {
                ExecuteQuery.UpdateOne(40, codConfirmacion, "relleno");
                if (MessageException.message == "")
                {
                    int codCuenta = (int)DgvConfirmaciones.SelectedRows[0].Cells[1].Value;
                    ExecuteQuery.UpdateOne(41, codConfirmacion, codCuenta);
                    if (MessageException.message == "")
                    {
                        var popup1 = new PopupNotifier()
                        {
                            Image = Properties.Resources.sql_success1,
                            TitleText = "Mensaje",
                            ContentText = "La registración ha sido insertada con exito",
                            ContentFont = new Font("Segoe UI Bold", 11F),
                            TitleFont = new Font("Segoe UI Bold", 10F),
                            ImagePadding = new Padding(10)
                        };
                        popup1.Popup();
                        ListarConfirmaciones();
                        ListarRegistraciones();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                ListarRegistraciones();
            }
            else
            {
                int codigo = 0;
                if (Int32.TryParse(textBox1.Text, out codigo))
                {
                    ExecuteQuery.SelectOne(502, codigo);
                }
            }
        }
    }
}

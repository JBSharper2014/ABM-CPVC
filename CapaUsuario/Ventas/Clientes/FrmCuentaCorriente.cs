using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Templates;
using DatosVentas;

using CapaUsuario;

using MaterialSkin.Controls;
using MetroFramework.Forms;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Ventas.Clientes
{
    public partial class FrmCuentaCorriente : MetroForm
    {
        // la idea es que se le pase desde el form de clientes el cod_cliente para el insert
        // y el nombre para mostrar en el label azul

        Timer t1 = new Timer();

        private int idCliente;
        public int IDCliente { get => idCliente; set => idCliente = value; }

        private string nombreCliente;
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }


        public FrmCuentaCorriente()
        {
            InitializeComponent();


            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void FrmCuentaCorriente_Load(object sender, EventArgs e)
        {
            NombreClienteLabel.Text = nombreCliente;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            DialogResult rta = MessageBox.Show("¿Guardar datos?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (SelectCommands.selectExist(4000, idCliente))
            {
                MessageBox.Show("El cliente ya tiene una cuenta corriente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                object[] datos =
                {
                    idCliente,
                    (double)DebeNumericUpDown.Value,
                    (double)HaberNumericUpDown.Value
                };


                // ExecuteQuery.InsertInto(302, datos);

                InsertsCommands.insertInto(302, datos);
            }

            // MessageBox.Show("Cuenta corriente agregada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var popup1 = new PopupNotifier()
            {
                Image = Properties.Resources.sql_success1,
                TitleText = "Mensaje",
                ContentText = "Cuenta corriente agregada correctamente",
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F),
                ImagePadding = new Padding(10),
            };
            popup1.Popup();
            Close();
        }
    }
}

using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DatosVentas;
using CapaUsuario;

namespace CapaUsuario.Ventas.Clientes
{
    public partial class FrmListadoCuentasCorriente : MetroForm
    {
        Timer t1 = new Timer();

        public FrmListadoCuentasCorriente()
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

        private void BorarClienteButton_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de borrar la cuenta corriente seleccionada?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (DgvListadoCuentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay cuentas corriente a borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FrmListadoCuentasCorriente_Load(object sender, EventArgs e)
        {
            DgvListadoCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoCuentas.DataSource = ExecuteQuery.SelectAll(3001);
        }
    }
}

using CapaDatos;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CapaUsuario.Compras.Bancos
{
    public partial class Bancos : MetroForm
    {
        private string razonSocialProv;
        private int codProv;
        public string RazonSocial { get => razonSocialProv; set => razonSocialProv = value; }
        public int CodProv { get => codProv; set => codProv = value; }

        

        DCBU dBancos = new DCBU();
        Timer t1 = new Timer();
        public Bancos()
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

        private void CancelarBancoButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarBancoButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;


            var rta = MessageBox.Show("¿Guardar datos?", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            string msg = dBancos.InsertCBU(CBUTextBox.Text, codProv);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private bool ValidarCampos()
        {
            

            if (CBUTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CBUTextBox, "Ingrese un CBU");
                CBUTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //if (CBUTextBox.Text.Trim() != string.Empty)
            //{
            //    if (!ulong.TryParse(CBUTextBox.Text.Trim(), out ulong f))
            //    {
            //        errorProvider1.SetError(CBUTextBox, "Debe ingresar un CBU válido");
            //        CBUTextBox.Focus();
            //        return false;
            //    }
            //}
            //errorProvider1.Clear();

            if (CBUTextBox.Text.Trim() != string.Empty)
            {
                if(CBUTextBox.Text.Length < 22)
                {
                    errorProvider1.SetError(CBUTextBox, "Debe ingresar un CBU de 22 dígitos");
                    CBUTextBox.Focus();
                    return false;
                }
            }

            return true;

        }

        private void Bancos_Load(object sender, EventArgs e)
        {
            RazonSocialLabel.Text = razonSocialProv;
            DgvCBU.DataSource = dBancos.SelectCBU();
            DgvCBU.Refresh();
            DgvCBU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
    }
}


using CapaDatos;
using MaterialSkin;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class FrmLogin : MetroForm
    {
        Timer t1 = new Timer();
        public FrmLogin()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.BlueGrey700, Primary.BlueGrey700,
            Primary.BlueGrey700, Accent.LightBlue200,
            TextShade.WHITE);

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

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox, "Debe ingresar un usuario");
                return;
            }

            if (ClaveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ClaveTextBox, "Debe ingresar una clave");
                return;
            }

            DUsuario usuario = new DUsuario();


            if (!usuario.ValidarUsuario(UsuarioTextBox.Text, ClaveTextBox.Text))
            {
                MessageBox.Show("Usuario y/o clave incorrectos, o su cuenta se encuentra desactivada", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsuarioTextBox.Text = string.Empty;
                ClaveTextBox.Text = string.Empty;
                return;

            }


            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal
            {
                UsuarioLogueado = usuario.GetUsuario(UsuarioTextBox.Text)
            };
            frmMenuPrincipal.Show();
            Hide();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

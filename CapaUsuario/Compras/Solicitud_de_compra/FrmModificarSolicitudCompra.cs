using System;
using CapaDatos;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CapaUsuario.Compras.Solicitud_de_compra
{
    public partial class FrmModificarSolicitudCompra : MetroForm
    {
        private int codSolicitud;

        public int CodSolicitud { get => codSolicitud; set => codSolicitud = value; }

        private string departamento;

        public string Departamento { get => departamento; set => departamento = value; }

        private bool cancelada;

        public bool IsCancelada { get => cancelada; set => cancelada = value; }

        Timer t1 = new Timer();

        public FrmModificarSolicitudCompra()
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

        private void CancelarModificacionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmModificarSolicitudCompra_Load(object sender, EventArgs e)
        {
            DepartamentoComboBox.SelectedItem = departamento;
            CanceladaCheckBox.Checked = cancelada;
        }

        private void GuardarCambiosButton_Click(object sender, EventArgs e)
        {
            var dSolicitudCompra = new DSolicitudCompra();

            string msg = dSolicitudCompra.UpdateSolicitudCompra(DepartamentoComboBox.SelectedItem.ToString(),
                CanceladaCheckBox.Checked, codSolicitud);

            MessageBox.Show(msg, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();

        }
    }
}

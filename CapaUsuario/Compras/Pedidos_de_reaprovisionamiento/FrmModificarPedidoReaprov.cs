using CapaDatos;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CapaUsuario.Compras.Pedidos_de_reaprovisionamiento
{
    public partial class FrmModificarPedidoReaprov : MetroForm
    {
        private int codPedidoReaprov;

        public int CodPedidoReaprov { get => codPedidoReaprov; set => codPedidoReaprov = value; }

        private bool cancelado;

        public bool IsCancelado { get => cancelado; set => cancelado = value; }
        Timer t1 = new Timer();

        public FrmModificarPedidoReaprov()
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

        private void FrmModificarPedidoReaprov_Load(object sender, EventArgs e)
        {
            CanceladoCheckBox.Checked = cancelado;
        }

        private void GuardarCambiosButton_Click(object sender, EventArgs e)
        {
            var dPedidoReaprov = new DPedidoReaprov();

            string msg = dPedidoReaprov.UpdatePedidoReaprov(codPedidoReaprov, CanceladoCheckBox.Checked);

            MessageBox.Show(msg, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}

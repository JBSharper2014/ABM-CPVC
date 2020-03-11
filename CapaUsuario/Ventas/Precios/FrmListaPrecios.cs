
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

namespace CapaUsuario.Ventas.Precios
{
    public partial class FrmListaPrecios : Form
    {
        public FrmListaPrecios()
        {
            InitializeComponent();
        }

        private void FrmListaPrecios_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DgvListadoPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoStock.DataSource = ExecuteQuery.SelectAll(3002);
        }

        private void AgregarPrecioButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            PrecioNumericUpDown.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            EditarPrecioButton.Enabled = false;
           

            PrecioNumericUpDown.Focus();
        }

        private void DeshabilitarCampos()
        {
            PrecioNumericUpDown.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            EditarPrecioButton.Enabled = true;
 
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            PrecioNumericUpDown.Value = 0;
            ProductoTextBox.Text = string.Empty;
        }

        private void EditarPrecioButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            materialTabControl1.SelectedTab = TabAdmin;
        }

        

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Guardar datos?", "Confirmación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            

            ExecuteQuery.UpdateOne(400002,int.Parse(ProductoTextBox.Text),PrecioNumericUpDown.Value.ToString());
            
            if(CapaDatos.MessageException.message == "")
            {
                // MessageBox.Show("Precio actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "Precio actualizado correctamente",
                    ContentFont = new Font("Segoe UI Semilight", 10F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(10)
                };
                popup1.Popup();
            }

        DeshabilitarCampos();
            LimpiarCampos();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DgvListadoStock.DataSource = ExecuteQuery.SelectOne(7000, txtbuscarprod.Text);
        }

    

        private void DgvListadoStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoTextBox.Text = DgvListadoStock.SelectedCells[0].Value.ToString();
            try { PrecioNumericUpDown.Value = Convert.ToDecimal(DgvListadoStock.SelectedCells[4].Value); }
            catch {  }
            HabilitarCampos();
        }
    }
}

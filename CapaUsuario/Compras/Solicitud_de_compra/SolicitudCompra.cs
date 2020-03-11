using CapaDatos;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace CapaUsuario.Compras.Solicitud_de_compra
{
    public partial class SolicitudCompra : Form
    {
        BindingList<DetalleSolicitud> misDetalles = new BindingList<DetalleSolicitud>();
        DBienUso dBienUso = new DBienUso();
        DMarca marca;
        DSolicitudCompra dSolicitudCompra;

        public SolicitudCompra()
        {
            InitializeComponent();
        }

        private void SolicitudCompra_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            SolicitudCompra_SizeChanged(sender, e);
            ActualizarGrid();
            SelectSolicitudes();
            SelectBienesUso();
            ActualizarComboBoxes();
            PersonalizarGrid();
            LimpiarCampos();
        }

        private void SelectSolicitudes()
        {
            dSolicitudCompra = new DSolicitudCompra();
            DgvSolicitudesCompra.DataSource = dSolicitudCompra.SelectSolicitudesCompra();
            DgvSolicitudesCompra.Refresh();

        }

        private void ActualizarComboBoxes()
        {
            BienDeUsoComboBox.DataSource = dBienUso.SelectNombresBienesUso();
            BienDeUsoComboBox.DisplayMember = "Nombre";
            BienDeUsoComboBox.ValueMember = "CodBienUso";

            marca = new DMarca();
            MarcaComboBox.DataSource = marca.SelectMarcas();
            MarcaComboBox.DisplayMember = "Nombre";
            MarcaComboBox.ValueMember = "CodMarca";
        }

        private void SelectBienesUso()
        {

            DgvListadoBienes.DataSource = dBienUso.SelectBienesUso();
            DgvListadoBienes.Refresh();
        }

        private void PersonalizarGrid()
        {
            DgvSolicitudBienUso.Columns["CodBienUso"].HeaderText = "Código de Bien de uso";

            DgvSolicitudBienUso.Columns["Cantidad"].HeaderText = "Cantidad";

            DgvSolicitudBienUso.Columns["NombreBienUso"].HeaderText = "Nombre";
        }

        private void ActualizarGrid()
        {
            DgvSolicitudBienUso.DataSource = misDetalles;
            DgvSolicitudBienUso.Refresh();
        }

        private void SolicitudCompra_SizeChanged(object sender, EventArgs e)
        {
            DgvSolicitudBienUso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvSolicitudesCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvListadoBienes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void SolicitudCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count != 0)
            {
                DialogResult rta = MessageBox.Show("Aún tiene bienes en la solicitud de compra, ¿desea salir de todas maneras?",
                    "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        public void ActualizarListado()
        {
            dSolicitudCompra = new DSolicitudCompra();
            DgvSolicitudesCompra.DataSource = dSolicitudCompra.SelectSolicitudesCompra();
            DgvSolicitudesCompra.Refresh();
        }

        private void AgregarButton_Click_1(object sender, EventArgs e)
        {
            if (BienDeUsoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(BienDeUsoComboBox, "Seleccione un bien de uso");
                BienDeUsoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (MarcaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MarcaComboBox, "Seleccione una marca");
                BienDeUsoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            DMarcaBienUso dMarcaBienUso = new DMarcaBienUso();
            int codBienUso = (int)BienDeUsoComboBox.SelectedValue;

            if (!dMarcaBienUso.BienUsoTieneMarcaAsociada(codBienUso))
            {
                MessageBox.Show("El bien de uso seleccionado no tiene una marca asociada, no se puede agregar a la solicitud",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BienDeUsoComboBox.SelectedIndex = -1;
                MarcaComboBox.SelectedIndex = -1;
                CantidadNumericUpDown.Value = 1;
                return;
            }



            var detalle = new DetalleSolicitud
            {
                CodBienUso = codBienUso,
                NombreBienUso = dBienUso.GetNombreBienUsoByCodBienUso((int)BienDeUsoComboBox.SelectedValue),
                Marca = marca.GetNombreMarcaByCodMarca((int)MarcaComboBox.SelectedValue),
                Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value)
            };


            misDetalles.Add(detalle);
            ActualizarGrid();
            BienDeUsoComboBox.SelectedIndex = -1;
            CantidadNumericUpDown.Value = 1;
            MarcaComboBox.SelectedIndex = -1;
            BienDeUsoComboBox.Focus();
        }

        private void CancelarButton_Click_1(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            LimpiarCampos();
            misDetalles.Clear();
            ActualizarGrid();
        }

        private void BorrarTodoButton_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;

            var rta = MessageBox.Show("¿Está seguro de borrar todos los bienes de uso de la solicitud?", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            misDetalles.Clear();
            ActualizarGrid();
        }

        private void BorrarLineaButton_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;
            //borramos el registro seleccionado, o el último agregado
            if (DgvSolicitudBienUso.SelectedRows.Count == 0)
            {
                misDetalles.RemoveAt(misDetalles.Count - 1);
                ActualizarGrid();
            }
            else
            {
                var idBienUso = (int)DgvSolicitudBienUso.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDetalles.Count; i++)
                {
                    if (misDetalles[i].CodBienUso == idBienUso)
                    {
                        misDetalles.RemoveAt(i);
                        break;
                    }
                }
            }
            ActualizarGrid();
        }

        private void GrabarButton_Click_1(object sender, EventArgs e)
        {
            if (DepartamentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(DepartamentoComboBox, "Seleccione un departamento");
                DepartamentoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (misDetalles.Count == 0)
            {
                errorProvider1.SetError(BienDeUsoComboBox, "Debe ingresar bienes de uso en la solicitud");
                BienDeUsoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            DialogResult rta = MessageBox.Show("¿Está seguro de grabar la solicitud de compra?", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            try
            {
                var fecha = DateTime.Now;
                dSolicitudCompra = new DSolicitudCompra();
                var solicitudBienUso = new DSolicitudBienUso();

                int codSolicitud = dSolicitudCompra.InsertSolicitudCompra(fecha, DepartamentoComboBox.SelectedItem.ToString(),
                    false);

                marca = new DMarca(); 

                for (int i = 0; i < misDetalles.Count; i++)
                {
                    solicitudBienUso.InsertSolicitudBienDeUso(
                        codSolicitud, 
                        misDetalles[i].CodBienUso, 
                        misDetalles[i].Cantidad,
                        marca.GetCodMarcaByNombreMarca(misDetalles[i].Marca));
                }

                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_success1,
                    TitleText = "Mensaje",
                    ContentText = $"Se ingresó la solicitud con código:{codSolicitud} correctamente",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(8)
                };
                popup1.Popup();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ingresar la solicitud: {ex.Message}");
            }



            DepartamentoComboBox.SelectedIndex = -1;
            BienDeUsoComboBox.SelectedIndex = -1;
            MarcaComboBox.SelectedIndex = -1;
            misDetalles.Clear();
            ActualizarGrid();
            ActualizarListado();
            DepartamentoComboBox.Focus();

        }

        private void NuevaSolicitudButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            materialTabControl1.SelectedTab = TabNueva;
        }

        private void HabilitarCampos()
        {
            DepartamentoComboBox.Enabled = true;
            BienDeUsoComboBox.Enabled = true;
            CantidadNumericUpDown.Enabled = true;
            MarcaComboBox.Enabled = true;

            AgregarButton.Enabled = true;
            GrabarButton.Enabled = true;
            CancelarButton.Enabled = true;
            BorrarLineaButton.Enabled = true;
            BorrarTodoButton.Enabled = true;

            DepartamentoComboBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            DepartamentoComboBox.Enabled = false;
            BienDeUsoComboBox.Enabled = false;
            CantidadNumericUpDown.Enabled = false;
            MarcaComboBox.Enabled = false;

            AgregarButton.Enabled = false;
            GrabarButton.Enabled = false;
            CancelarButton.Enabled = false;
            BorrarLineaButton.Enabled = false;
            BorrarTodoButton.Enabled = false;
        }

        private void LimpiarCampos()
        {
            DepartamentoComboBox.SelectedIndex = -1;
            BienDeUsoComboBox.SelectedIndex = -1;
            MarcaComboBox.SelectedIndex = -1;
            CantidadNumericUpDown.Value = 1;
        }

        private void FiltrarBienesTextBox_TextChanged(object sender, EventArgs e)
        {
            DgvListadoBienes.DataSource = dBienUso.SelectBienesUsoByNombre(FiltrarBienesTextBox.Text.Trim());
            DgvListadoBienes.Refresh();
        }

        private void BienDeUsoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (MarcaComboBox.SelectedValue == null) return;

            try
            {
                marca = new DMarca();


                MarcaComboBox.DataSource = marca.SelectMarcasByCodProducto((int)BienDeUsoComboBox.SelectedValue);
                MarcaComboBox.DisplayMember = "Nombre";
                MarcaComboBox.ValueMember = "CodMarca";
            }
            catch (Exception)
            {
                return;
            }


        }

        private void ModificarSolicitudCompraButton_Click_1(object sender, EventArgs e)
        {
            if (DgvSolicitudesCompra.Rows.Count == 0)
            {
                MessageBox.Show("No hay solicitudes para modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((bool)DgvSolicitudesCompra.SelectedRows[0].Cells[3].Value)
            {
                MessageBox.Show("No se puede modificar la solicitud seleccionada, se encuentra cancelada",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            FrmModificarSolicitudCompra frmModificarSolicitud = new FrmModificarSolicitudCompra
            {
                CodSolicitud = (int)DgvSolicitudesCompra.SelectedRows[0].Cells[0].Value,
                Departamento = DgvSolicitudesCompra.SelectedRows[0].Cells[2].Value.ToString(),
                IsCancelada = (bool)DgvSolicitudesCompra.SelectedRows[0].Cells[3].Value
            };
            frmModificarSolicitud.ShowDialog();

            ActualizarListado();
        }

        private void BorrarSolicitudCompraButton_Click_1(object sender, EventArgs e)
        {

            if (DgvSolicitudesCompra.Rows.Count == 0)
            {
                MessageBox.Show("No hay solicitudes para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rta = MessageBox.Show("¿Está seguro de borrar la solicitud de compra?", "Confirmación",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            if (!(bool)DgvSolicitudesCompra.SelectedRows[0].Cells[3].Value)
            {
                MessageBox.Show("No se puede borrar la solicitud pues está vigente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int codSolicitud = (int)DgvSolicitudesCompra.SelectedRows[0].Cells[0].Value;

            var dSolicitudBienUso = new DSolicitudBienUso();
            dSolicitudBienUso.DeleteBienesPorSolcitudCompra(codSolicitud);

            dSolicitudCompra = new DSolicitudCompra();

            string msg = dSolicitudCompra.DeleteSolicitudCompra(codSolicitud);


            var popup1 = new PopupNotifier()
            {
                Image = msg == "Se eliminó la solicitud correctamente" ? Properties.Resources.info100 : Properties.Resources.sql_error,
                TitleText = "Mensaje",
                ContentText = msg,
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 10F)
            };
            popup1.Popup();

            ActualizarListado();
        }

        private void FiltrarSolicitudesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FiltrarSolicitudesTextBox.Text != "")
            {

                if (!int.TryParse(FiltrarSolicitudesTextBox.Text, out int codigo))
                {
                    MessageBox.Show("Ingrese solo códigos numéricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FiltrarSolicitudesTextBox.Text = string.Empty;
                    return;
                }

                dSolicitudCompra = new DSolicitudCompra();
                DgvSolicitudesCompra.DataSource = 
                    dSolicitudCompra.SelectSolicitudesComprasByCodSolicitud(int.Parse(FiltrarSolicitudesTextBox.Text.Trim()));
            }
            else
            {
                SelectSolicitudes();
            }
        }
    }
}

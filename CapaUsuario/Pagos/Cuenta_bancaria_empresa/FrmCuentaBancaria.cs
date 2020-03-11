using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using CapaDatos;
using System.Data;

namespace CapaUsuario.Pagos.Cuenta_bancaria_empresa
{
    public partial class FrmCuentaBancaria : Form
    {

        float saldo;
        public FrmCuentaBancaria()
        {
            InitializeComponent();
        }

        private void FrmCuentaBancaria_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            // ListarGrids();
            ListarCuentas();
            ListarOrdenes();

            FrmCuentaBancaria_SizeChanged(sender, e);
        }

        private void ListarCuentas()
        {
            DgvListadoCuentas.DataSource = ExecuteQuery.SelectAll(205);
        }

        private void ListarOrdenes()
        {
            DgvOrdenesPago.DataSource = ExecuteQuery.SelectAll(204);
        }

        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            CbuTextBox.ReadOnly = false;
            SaldoTextBox.ReadOnly = false;

            GuardarDatosButton.Enabled = true;
            CancelarButton.Enabled = true;

            SaldoBusquedaTextBox.ReadOnly = true;
            CodCuentaBusquedaTextBox.ReadOnly = true;

            CbuTextBox.Focus();

            materialTabControl1.SelectedTab = TabNueva;
        }

        private void DesabilitarCampos()
        {
            CbuTextBox.ReadOnly = true;
            SaldoTextBox.ReadOnly = true;

            GuardarDatosButton.Enabled = false;
            CancelarButton.Enabled = false;

            SaldoBusquedaTextBox.ReadOnly = false;
            CodCuentaBusquedaTextBox.ReadOnly = false;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            CbuTextBox.Text = string.Empty;
            SaldoTextBox.Text = string.Empty;
        }

        private bool FijarseSiPuedeBorrarLaCuentaQueQuiereBorrarORealmenteNoPuedeHacerloPorDistintosMotivos()
        {
            if (Convert.ToInt32(DgvListadoCuentas.SelectedRows[0].Cells[2].Value) > 0)
            {
                MessageBox.Show("Debería darle verguenza... Intentar borrar una cuenta bancaria que tiene saldo... Mala persona");
                return true;
            }
            else
            {
                DataTable dt = ExecuteQuery.SelectOne(205, (int)DgvListadoCuentas.SelectedRows[0].Cells[0].Value);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Amigo... La verdad es que la cuenta bancaria está asociada a una Orden de pago. Por favor no nos haga reir y no intente borrarla. Lo lamentamos mucho.");
                    return true;
                }

                return false;
            }

        }

        private void BorrarCuentaButton_Click(object sender, EventArgs e)
        {
            if (DgvListadoCuentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay cuentas corriente a borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FijarseSiPuedeBorrarLaCuentaQueQuiereBorrarORealmenteNoPuedeHacerloPorDistintosMotivos())
            {
                return;
            }

            var rta = MessageBox.Show("¿Está seguro de borrar la cuenta corriente?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            int codCuenta = (int)DgvListadoCuentas.SelectedRows[0].Cells[0].Value;

            // Logica de borrado de cuenta, comprobando antes que ésta no registre ningún importe y 
            // no tenga asociación con una orden de pago

            ExecuteQuery.DeleteFrom(3, codCuenta);

            if (MessageException.message == "")
            {
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.info100,
                    TitleText = "Mensaje",
                    ContentText = "La cuenta corriente ha sido borrada con exito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F)

                };
                popup1.Popup();
                ListarCuentas();
            }

         
        }

        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var rta = MessageBox.Show("¿Guardar datos?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (RevisarCBU())
            {
                MessageBox.Show("La cuenta que quiere ingresar ya existe");
                return;
            }

            var cbu = Convert.ToInt64( CbuTextBox.Text.Trim());
            var saldo = Convert.ToInt32(SaldoTextBox.Text.Trim());

            object[] parameters =
            {
                cbu,
                saldo
            };


            // InsertCuentaBancaria(cbu, saldo);
            ExecuteQuery.InsertInto(22, parameters);

            if (MessageException.message == "")
            {
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.sql_success1,
                    TitleText = "Mensaje",
                    ContentText = "La cuenta corriente ha sido ingresada con exito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(8)
                };
                popup1.Popup();

                DesabilitarCampos();

                ListarCuentas();
                LimpiarCampos();
            }

        }

        //REVISA SI EL CBU QUE SE QUIERE INGRESAR YA EXISTE
        private bool RevisarCBU()
        {
            
            foreach (DataGridViewRow row in DgvListadoCuentas.Rows)
            {
                if (Convert.ToInt64(row.Cells[1].Value) == Convert.ToInt64(CbuTextBox.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private bool ValidarCampos()
        {
            if (CbuTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(CbuTextBox, "Ingrese un CBU");
                CbuTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (!Int64.TryParse(CbuTextBox.Text.Trim(), out Int64 cod))
            {
                errorProvider1.SetError(CbuTextBox, "Ingrese un CBU válido");
                CbuTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (SaldoTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(DineroLabel, "Ingrese un saldo");
                SaldoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (!int.TryParse(SaldoTextBox.Text.Trim(), out int val))
            {
                errorProvider1.SetError(DineroLabel, "Ingrese un valor numérico");
                SaldoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void CodCuentaBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodCuentaBusquedaTextBox.Text.Trim() != string.Empty)
            {
                if (!int.TryParse(CodCuentaBusquedaTextBox.Text.Trim(), out int val))
                {
                    MessageBox.Show("Ingrese solo valores numéricos", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    CodCuentaBusquedaTextBox.Text = string.Empty;
                    return;
                }

                DgvListadoCuentas.DataSource = ExecuteQuery.SelectOne(206, val);
            }
            else
            {
                ListarCuentas();
            }

            // Lógica de filtrado de cuentas por código de cuentas
        }

        private void FrmCuentaBancaria_SizeChanged(object sender, EventArgs e)
        {
            DgvListadoCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrdenesPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AsociarOrdenButton_Click(object sender, EventArgs e)
        {
            if (DgvOrdenesPago.Rows.Count == 0)
            {
                MessageBox.Show("No hay órdenes de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DgvListadoCuentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay cuentas corriente para asociar a la orden de pago", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float saldoEmpresa = Convert.ToSingle( DgvListadoCuentas.SelectedRows[0].Cells[2].Value);

            float importe = Convert.ToSingle(DgvOrdenesPago.SelectedRows[0].Cells[2].Value);


            if (saldoEmpresa < importe)
            {
                MessageBox.Show("Elija una cuenta cuyo saldo sea mayor o igual al importe de la factura asociada a la orden de pago",
                    "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codCuenta = (int)DgvListadoCuentas.SelectedRows[0].Cells[0].Value;

            var rta = MessageBox.Show($"¿Esta seguro de asociar la orden de pago seleccionada a la cuenta con código {codCuenta}?"
                , "Confirmación", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int codOrdenPago = (int)DgvOrdenesPago.SelectedRows[0].Cells[0].Value;

            // Logica de modificacion de la orden de pago, asociandola con la cuenta de la empresa

            ExecuteQuery.UpdateOne(5, codOrdenPago, codCuenta);
            if (MessageException.message == "")
            {
                var popup1 = new PopupNotifier()
                {
                    Image = Properties.Resources.orden_64,
                    TitleText = "Mensaje",
                    ContentText = "La orden de pago fue asociada a la cuenta de la empresa con éxito",
                    ContentFont = new Font("Segoe UI Bold", 11F),
                    TitleFont = new Font("Segoe UI Bold", 10F),
                    ImagePadding = new Padding(8)
                };
                popup1.Popup();

                // ListarGrids();
                ListarOrdenes();
            }


        }

        private void SaldoBusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SaldoBusquedaTextBox.Text.Trim() != string.Empty)
            {
                if (!int.TryParse(SaldoBusquedaTextBox.Text.Trim(), out int val))
                {
                    MessageBox.Show("Ingrese solo valores numéricos", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    SaldoBusquedaTextBox.Text = string.Empty;
                    return;
                }

                saldo = int.Parse(SaldoBusquedaTextBox.Text.Trim());

                if (MenorRadioButton.Checked)
                {
                    // Logica de filtrado de cuentas por saldos menor al ingresado
                    DgvListadoCuentas.DataSource = ExecuteQuery.SelectOne(208, val);
                }
                else if (MayorRadioButton.Checked)
                {
                    // Logica de filtrado de cuentas por saldos mayor al ingresado
                    DgvListadoCuentas.DataSource = ExecuteQuery.SelectOne(207, val);
                }
                else
                {
                    // Logica de filtrado de cuentas por saldos igual al ingresdo
                    DgvListadoCuentas.DataSource = ExecuteQuery.SelectOne(209, val);
                }
            }
            else
            {
                // ListarTodasLasCuentas();
                ListarCuentas();
            }
        }

        private void MenorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MenorRadioButton.Checked)
            {
                if(SaldoBusquedaTextBox.Text.Trim() != string.Empty)
                {
                    saldo = float.Parse(SaldoBusquedaTextBox.Text.Trim());
                    // Logica de filtrado de cuentas por saldos menor al ingresado
                }
                else
                {
                   // ListarTodasLasCuentas();
                }
            }
        }

        private void MayorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MayorRadioButton.Checked)
            {
                if (SaldoBusquedaTextBox.Text.Trim() != string.Empty)
                {
                    saldo = float.Parse(SaldoBusquedaTextBox.Text.Trim());
                    // Logica de filtrado de cuentas por saldos mayor al ingresado
                }
                else
                {
                    // ListarTodasLasCuentas();
                }
            }
        }

        private void IgualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (IgualRadioButton.Checked)
            {
                if (SaldoBusquedaTextBox.Text.Trim() != string.Empty)
                {
                    saldo = float.Parse(SaldoBusquedaTextBox.Text.Trim());
                    // Logica de filtrado de cuentas por saldos igual al ingresado
                }
                else
                {
                    ListarCuentas();
                }
            }
        }

        private void DgvListadoCuentas_SelectionChanged(object sender, EventArgs e)
        {
            string mensaje = "";
            if (DgvListadoCuentas.SelectedRows.Count > 0)
            {
                mensaje += "Codigo: ";
                mensaje += DgvListadoCuentas.SelectedRows[0].Cells[0].Value.ToString();
                mensaje += ", CBU: ";
                mensaje += DgvListadoCuentas.SelectedRows[0].Cells[1].Value.ToString();
                mensaje += ", Saldo: ";
                mensaje += DgvListadoCuentas.SelectedRows[0].Cells[2].Value.ToString();
                lblSelectedCount.Text = mensaje;
            }
        }
    }
}

namespace CapaUsuario.Compras.Cuenta_corriente
{
    partial class FrmCuentasCorriente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabCuentasCorriente = new System.Windows.Forms.TabPage();
            this.TabNuevaCuenta = new System.Windows.Forms.TabPage();
            this.TabSaldos = new System.Windows.Forms.TabPage();
            this.ModificarSaldosButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ModificarCuentaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BorrarCuentaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvCuentas = new System.Windows.Forms.DataGridView();
            this.CancelarNuevoButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.HaberTextBox = new System.Windows.Forms.TextBox();
            this.DebeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevaCuentaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.DgvNotas = new System.Windows.Forms.DataGridView();
            this.ModifDebeFacturaButton = new System.Windows.Forms.Button();
            this.ModifHaberNotaButton = new System.Windows.Forms.Button();
            this.ModificarManualButton = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.TabCuentasCorriente.SuspendLayout();
            this.TabNuevaCuenta.SuspendLayout();
            this.TabSaldos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1093, 44);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabCuentasCorriente);
            this.materialTabControl1.Controls.Add(this.TabNuevaCuenta);
            this.materialTabControl1.Controls.Add(this.TabSaldos);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 44);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1093, 471);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabCuentasCorriente
            // 
            this.TabCuentasCorriente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabCuentasCorriente.Controls.Add(this.NuevaCuentaButton);
            this.TabCuentasCorriente.Controls.Add(this.ModificarSaldosButton);
            this.TabCuentasCorriente.Controls.Add(this.ModificarCuentaButton);
            this.TabCuentasCorriente.Controls.Add(this.BorrarCuentaButton);
            this.TabCuentasCorriente.Controls.Add(this.DgvCuentas);
            this.TabCuentasCorriente.Location = new System.Drawing.Point(4, 29);
            this.TabCuentasCorriente.Name = "TabCuentasCorriente";
            this.TabCuentasCorriente.Padding = new System.Windows.Forms.Padding(3);
            this.TabCuentasCorriente.Size = new System.Drawing.Size(1085, 438);
            this.TabCuentasCorriente.TabIndex = 0;
            this.TabCuentasCorriente.Text = "Cuentas corriente";
            // 
            // TabNuevaCuenta
            // 
            this.TabNuevaCuenta.Controls.Add(this.CancelarNuevoButton);
            this.TabNuevaCuenta.Controls.Add(this.GuardarDatosButton);
            this.TabNuevaCuenta.Controls.Add(this.HaberTextBox);
            this.TabNuevaCuenta.Controls.Add(this.DebeTextBox);
            this.TabNuevaCuenta.Controls.Add(this.label3);
            this.TabNuevaCuenta.Controls.Add(this.label2);
            this.TabNuevaCuenta.Controls.Add(this.ProveedorComboBox);
            this.TabNuevaCuenta.Controls.Add(this.label1);
            this.TabNuevaCuenta.Location = new System.Drawing.Point(4, 29);
            this.TabNuevaCuenta.Name = "TabNuevaCuenta";
            this.TabNuevaCuenta.Padding = new System.Windows.Forms.Padding(3);
            this.TabNuevaCuenta.Size = new System.Drawing.Size(1085, 438);
            this.TabNuevaCuenta.TabIndex = 1;
            this.TabNuevaCuenta.Text = "Nueva cuenta / editar cuenta";
            this.TabNuevaCuenta.UseVisualStyleBackColor = true;
            // 
            // TabSaldos
            // 
            this.TabSaldos.Controls.Add(this.ModificarManualButton);
            this.TabSaldos.Controls.Add(this.ModifHaberNotaButton);
            this.TabSaldos.Controls.Add(this.ModifDebeFacturaButton);
            this.TabSaldos.Controls.Add(this.DgvNotas);
            this.TabSaldos.Controls.Add(this.DgvFacturas);
            this.TabSaldos.Location = new System.Drawing.Point(4, 29);
            this.TabSaldos.Name = "TabSaldos";
            this.TabSaldos.Padding = new System.Windows.Forms.Padding(3);
            this.TabSaldos.Size = new System.Drawing.Size(1085, 438);
            this.TabSaldos.TabIndex = 2;
            this.TabSaldos.Text = "Modificar saldos";
            this.TabSaldos.UseVisualStyleBackColor = true;
            // 
            // ModificarSaldosButton
            // 
            this.ModificarSaldosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModificarSaldosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarSaldosButton.Depth = 0;
            this.ModificarSaldosButton.Location = new System.Drawing.Point(886, 39);
            this.ModificarSaldosButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarSaldosButton.Name = "ModificarSaldosButton";
            this.ModificarSaldosButton.Primary = true;
            this.ModificarSaldosButton.Size = new System.Drawing.Size(157, 41);
            this.ModificarSaldosButton.TabIndex = 11;
            this.ModificarSaldosButton.Text = "Modificar saldos";
            this.ModificarSaldosButton.UseVisualStyleBackColor = true;
            this.ModificarSaldosButton.Click += new System.EventHandler(this.ModificarSaldosButton_Click);
            // 
            // ModificarCuentaButton
            // 
            this.ModificarCuentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModificarCuentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarCuentaButton.Depth = 0;
            this.ModificarCuentaButton.Location = new System.Drawing.Point(706, 39);
            this.ModificarCuentaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarCuentaButton.Name = "ModificarCuentaButton";
            this.ModificarCuentaButton.Primary = true;
            this.ModificarCuentaButton.Size = new System.Drawing.Size(157, 41);
            this.ModificarCuentaButton.TabIndex = 10;
            this.ModificarCuentaButton.Text = "Modificar cuenta";
            this.ModificarCuentaButton.UseVisualStyleBackColor = true;
            this.ModificarCuentaButton.Click += new System.EventHandler(this.ModificarCuentaButton_Click);
            // 
            // BorrarCuentaButton
            // 
            this.BorrarCuentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarCuentaButton.AutoSize = true;
            this.BorrarCuentaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarCuentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarCuentaButton.Depth = 0;
            this.BorrarCuentaButton.Location = new System.Drawing.Point(598, 44);
            this.BorrarCuentaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarCuentaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarCuentaButton.Name = "BorrarCuentaButton";
            this.BorrarCuentaButton.Primary = false;
            this.BorrarCuentaButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarCuentaButton.TabIndex = 9;
            this.BorrarCuentaButton.Text = "Borrar";
            this.BorrarCuentaButton.UseVisualStyleBackColor = true;
            this.BorrarCuentaButton.Click += new System.EventHandler(this.BorrarCuentaButton_Click);
            // 
            // DgvCuentas
            // 
            this.DgvCuentas.AllowUserToAddRows = false;
            this.DgvCuentas.AllowUserToDeleteRows = false;
            this.DgvCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCuentas.Location = new System.Drawing.Point(8, 109);
            this.DgvCuentas.MultiSelect = false;
            this.DgvCuentas.Name = "DgvCuentas";
            this.DgvCuentas.ReadOnly = true;
            this.DgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCuentas.Size = new System.Drawing.Size(1069, 323);
            this.DgvCuentas.TabIndex = 8;
            // 
            // CancelarNuevoButton
            // 
            this.CancelarNuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarNuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarNuevoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarNuevoButton.Enabled = false;
            this.CancelarNuevoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarNuevoButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarNuevoButton.Location = new System.Drawing.Point(369, 298);
            this.CancelarNuevoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarNuevoButton.Name = "CancelarNuevoButton";
            this.CancelarNuevoButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarNuevoButton.TabIndex = 24;
            this.CancelarNuevoButton.Text = "Cancelar";
            this.CancelarNuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarNuevoButton.UseVisualStyleBackColor = true;
            this.CancelarNuevoButton.Click += new System.EventHandler(this.CancelarNuevoButton_Click);
            // 
            // GuardarDatosButton
            // 
            this.GuardarDatosButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarDatosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarDatosButton.Enabled = false;
            this.GuardarDatosButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarDatosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GuardarDatosButton.Location = new System.Drawing.Point(566, 298);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarDatosButton.TabIndex = 25;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // HaberTextBox
            // 
            this.HaberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HaberTextBox.Location = new System.Drawing.Point(463, 202);
            this.HaberTextBox.Name = "HaberTextBox";
            this.HaberTextBox.ReadOnly = true;
            this.HaberTextBox.Size = new System.Drawing.Size(171, 27);
            this.HaberTextBox.TabIndex = 23;
            // 
            // DebeTextBox
            // 
            this.DebeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DebeTextBox.Location = new System.Drawing.Point(463, 137);
            this.DebeTextBox.Name = "DebeTextBox";
            this.DebeTextBox.ReadOnly = true;
            this.DebeTextBox.Size = new System.Drawing.Size(171, 27);
            this.DebeTextBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Haber:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Debe:";
            // 
            // ProveedorComboBox
            // 
            this.ProveedorComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProveedorComboBox.Enabled = false;
            this.ProveedorComboBox.FormattingEnabled = true;
            this.ProveedorComboBox.Location = new System.Drawing.Point(463, 71);
            this.ProveedorComboBox.Name = "ProveedorComboBox";
            this.ProveedorComboBox.Size = new System.Drawing.Size(183, 28);
            this.ProveedorComboBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Proveedor:";
            // 
            // NuevaCuentaButton
            // 
            this.NuevaCuentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevaCuentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevaCuentaButton.Depth = 0;
            this.NuevaCuentaButton.Location = new System.Drawing.Point(380, 39);
            this.NuevaCuentaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NuevaCuentaButton.Name = "NuevaCuentaButton";
            this.NuevaCuentaButton.Primary = true;
            this.NuevaCuentaButton.Size = new System.Drawing.Size(157, 41);
            this.NuevaCuentaButton.TabIndex = 12;
            this.NuevaCuentaButton.Text = "Nueva cuenta";
            this.NuevaCuentaButton.UseVisualStyleBackColor = true;
            this.NuevaCuentaButton.Click += new System.EventHandler(this.NuevaCuentaButton_Click);
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.AllowUserToAddRows = false;
            this.DgvFacturas.AllowUserToDeleteRows = false;
            this.DgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(29, 178);
            this.DgvFacturas.MultiSelect = false;
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.ReadOnly = true;
            this.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFacturas.Size = new System.Drawing.Size(466, 252);
            this.DgvFacturas.TabIndex = 0;
            // 
            // DgvNotas
            // 
            this.DgvNotas.AllowUserToAddRows = false;
            this.DgvNotas.AllowUserToDeleteRows = false;
            this.DgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNotas.Location = new System.Drawing.Point(594, 178);
            this.DgvNotas.MultiSelect = false;
            this.DgvNotas.Name = "DgvNotas";
            this.DgvNotas.ReadOnly = true;
            this.DgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvNotas.Size = new System.Drawing.Size(466, 252);
            this.DgvNotas.TabIndex = 1;
            // 
            // ModifDebeFacturaButton
            // 
            this.ModifDebeFacturaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifDebeFacturaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifDebeFacturaButton.Enabled = false;
            this.ModifDebeFacturaButton.Location = new System.Drawing.Point(195, 132);
            this.ModifDebeFacturaButton.Name = "ModifDebeFacturaButton";
            this.ModifDebeFacturaButton.Size = new System.Drawing.Size(300, 40);
            this.ModifDebeFacturaButton.TabIndex = 2;
            this.ModifDebeFacturaButton.Text = "Modificar debe con factura seleccionada";
            this.ModifDebeFacturaButton.UseVisualStyleBackColor = true;
            this.ModifDebeFacturaButton.Click += new System.EventHandler(this.ModifDebeFacturaButton_Click);
            // 
            // ModifHaberNotaButton
            // 
            this.ModifHaberNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifHaberNotaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifHaberNotaButton.Enabled = false;
            this.ModifHaberNotaButton.Location = new System.Drawing.Point(709, 132);
            this.ModifHaberNotaButton.Name = "ModifHaberNotaButton";
            this.ModifHaberNotaButton.Size = new System.Drawing.Size(351, 40);
            this.ModifHaberNotaButton.TabIndex = 3;
            this.ModifHaberNotaButton.Text = "Modificar haber con nota de crédito seleccionada";
            this.ModifHaberNotaButton.UseVisualStyleBackColor = true;
            this.ModifHaberNotaButton.Click += new System.EventHandler(this.ModifHaberNotaButton_Click);
            // 
            // ModificarManualButton
            // 
            this.ModificarManualButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarManualButton.Enabled = false;
            this.ModificarManualButton.Location = new System.Drawing.Point(29, 32);
            this.ModificarManualButton.Name = "ModificarManualButton";
            this.ModificarManualButton.Size = new System.Drawing.Size(300, 40);
            this.ModificarManualButton.TabIndex = 4;
            this.ModificarManualButton.Text = "Modificar manualmente";
            this.ModificarManualButton.UseVisualStyleBackColor = true;
            this.ModificarManualButton.Click += new System.EventHandler(this.ModificarManualButton_Click);
            // 
            // FrmCuentasCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 515);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCuentasCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas corriente";
            this.Load += new System.EventHandler(this.FrmCuentasCorriente_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCuentasCorriente_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabCuentasCorriente.ResumeLayout(false);
            this.TabCuentasCorriente.PerformLayout();
            this.TabNuevaCuenta.ResumeLayout(false);
            this.TabNuevaCuenta.PerformLayout();
            this.TabSaldos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabCuentasCorriente;
        private System.Windows.Forms.TabPage TabNuevaCuenta;
        private System.Windows.Forms.TabPage TabSaldos;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarSaldosButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarCuentaButton;
        private MaterialSkin.Controls.MaterialFlatButton BorrarCuentaButton;
        private System.Windows.Forms.DataGridView DgvCuentas;
        private System.Windows.Forms.Button CancelarNuevoButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.TextBox HaberTextBox;
        private System.Windows.Forms.TextBox DebeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProveedorComboBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton NuevaCuentaButton;
        private System.Windows.Forms.Button ModifHaberNotaButton;
        private System.Windows.Forms.Button ModifDebeFacturaButton;
        private System.Windows.Forms.DataGridView DgvNotas;
        private System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.Button ModificarManualButton;
    }
}
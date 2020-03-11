namespace CapaUsuario.Cobros
{
    partial class FrmConfirmacionCobro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmacionCobro));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabListadoConfirmaciones = new System.Windows.Forms.TabPage();
            this.CodCuentaBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodConfirmacionBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarConfirmacionButton = new System.Windows.Forms.Button();
            this.DgvListadoConfirmaciones = new System.Windows.Forms.DataGridView();
            this.TabFacturas = new System.Windows.Forms.TabPage();
            this.CrearConfirmacionButton = new System.Windows.Forms.Button();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.dgvCuentasEmpresa = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DineroLabel = new System.Windows.Forms.Label();
            this.ImporteRecibidoNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaDebitacionPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.TabListadoConfirmaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoConfirmaciones)).BeginInit();
            this.TabFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            this.TabNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteRecibidoNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(990, 45);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListadoConfirmaciones);
            this.materialTabControl1.Controls.Add(this.TabFacturas);
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 45);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(990, 494);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListadoConfirmaciones
            // 
            this.TabListadoConfirmaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListadoConfirmaciones.Controls.Add(this.CodCuentaBusquedaTextBox);
            this.TabListadoConfirmaciones.Controls.Add(this.label3);
            this.TabListadoConfirmaciones.Controls.Add(this.materialCheckBox1);
            this.TabListadoConfirmaciones.Controls.Add(this.label2);
            this.TabListadoConfirmaciones.Controls.Add(this.CodConfirmacionBusquedaTextBox);
            this.TabListadoConfirmaciones.Controls.Add(this.label1);
            this.TabListadoConfirmaciones.Controls.Add(this.BorrarConfirmacionButton);
            this.TabListadoConfirmaciones.Controls.Add(this.DgvListadoConfirmaciones);
            this.TabListadoConfirmaciones.Location = new System.Drawing.Point(4, 29);
            this.TabListadoConfirmaciones.Name = "TabListadoConfirmaciones";
            this.TabListadoConfirmaciones.Padding = new System.Windows.Forms.Padding(3);
            this.TabListadoConfirmaciones.Size = new System.Drawing.Size(982, 461);
            this.TabListadoConfirmaciones.TabIndex = 0;
            this.TabListadoConfirmaciones.Text = "Listado";
            // 
            // CodCuentaBusquedaTextBox
            // 
            this.CodCuentaBusquedaTextBox.Location = new System.Drawing.Point(652, 48);
            this.CodCuentaBusquedaTextBox.MaxLength = 5;
            this.CodCuentaBusquedaTextBox.Name = "CodCuentaBusquedaTextBox";
            this.CodCuentaBusquedaTextBox.Size = new System.Drawing.Size(105, 27);
            this.CodCuentaBusquedaTextBox.TabIndex = 7;
            this.CodCuentaBusquedaTextBox.TextChanged += new System.EventHandler(this.CodCuentaBusquedaTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código de cuenta bancaria:";
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(397, 46);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(26, 30);
            this.materialCheckBox1.TabIndex = 5;
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sumada:";
            // 
            // CodConfirmacionBusquedaTextBox
            // 
            this.CodConfirmacionBusquedaTextBox.Location = new System.Drawing.Point(196, 48);
            this.CodConfirmacionBusquedaTextBox.MaxLength = 5;
            this.CodConfirmacionBusquedaTextBox.Name = "CodConfirmacionBusquedaTextBox";
            this.CodConfirmacionBusquedaTextBox.Size = new System.Drawing.Size(105, 27);
            this.CodConfirmacionBusquedaTextBox.TabIndex = 3;
            this.CodConfirmacionBusquedaTextBox.TextChanged += new System.EventHandler(this.CodConfirmacionBusquedaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de confirmación:";
            // 
            // BorrarConfirmacionButton
            // 
            this.BorrarConfirmacionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorrarConfirmacionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarConfirmacionButton.Image = global::CapaUsuario.Properties.Resources.borrar_confirmacion_cobro44;
            this.BorrarConfirmacionButton.Location = new System.Drawing.Point(846, 25);
            this.BorrarConfirmacionButton.Name = "BorrarConfirmacionButton";
            this.BorrarConfirmacionButton.Size = new System.Drawing.Size(79, 63);
            this.BorrarConfirmacionButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.BorrarConfirmacionButton, "Borrar confirmacion");
            this.BorrarConfirmacionButton.UseVisualStyleBackColor = true;
            this.BorrarConfirmacionButton.Click += new System.EventHandler(this.BorrarConfirmacionButton_Click);
            // 
            // DgvListadoConfirmaciones
            // 
            this.DgvListadoConfirmaciones.AllowUserToAddRows = false;
            this.DgvListadoConfirmaciones.AllowUserToDeleteRows = false;
            this.DgvListadoConfirmaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoConfirmaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoConfirmaciones.Location = new System.Drawing.Point(8, 94);
            this.DgvListadoConfirmaciones.MultiSelect = false;
            this.DgvListadoConfirmaciones.Name = "DgvListadoConfirmaciones";
            this.DgvListadoConfirmaciones.ReadOnly = true;
            this.DgvListadoConfirmaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoConfirmaciones.Size = new System.Drawing.Size(966, 329);
            this.DgvListadoConfirmaciones.TabIndex = 0;
            // 
            // TabFacturas
            // 
            this.TabFacturas.Controls.Add(this.CrearConfirmacionButton);
            this.TabFacturas.Controls.Add(this.DgvFacturas);
            this.TabFacturas.Location = new System.Drawing.Point(4, 29);
            this.TabFacturas.Name = "TabFacturas";
            this.TabFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.TabFacturas.Size = new System.Drawing.Size(982, 461);
            this.TabFacturas.TabIndex = 1;
            this.TabFacturas.Text = "Facturas";
            this.TabFacturas.UseVisualStyleBackColor = true;
            // 
            // CrearConfirmacionButton
            // 
            this.CrearConfirmacionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearConfirmacionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearConfirmacionButton.Image = global::CapaUsuario.Properties.Resources.crear_confirmacion_cobro44;
            this.CrearConfirmacionButton.Location = new System.Drawing.Point(680, 18);
            this.CrearConfirmacionButton.Name = "CrearConfirmacionButton";
            this.CrearConfirmacionButton.Size = new System.Drawing.Size(268, 54);
            this.CrearConfirmacionButton.TabIndex = 2;
            this.CrearConfirmacionButton.Text = "Crear confirmación de cobro";
            this.CrearConfirmacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CrearConfirmacionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CrearConfirmacionButton.UseVisualStyleBackColor = true;
            this.CrearConfirmacionButton.Click += new System.EventHandler(this.CrearConfirmacionButton_Click);
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.AllowUserToAddRows = false;
            this.DgvFacturas.AllowUserToDeleteRows = false;
            this.DgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(6, 85);
            this.DgvFacturas.MultiSelect = false;
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.ReadOnly = true;
            this.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFacturas.Size = new System.Drawing.Size(970, 345);
            this.DgvFacturas.TabIndex = 1;
            // 
            // TabNueva
            // 
            this.TabNueva.Controls.Add(this.dgvCuentasEmpresa);
            this.TabNueva.Controls.Add(this.CancelarButton);
            this.TabNueva.Controls.Add(this.GuardarDatosButton);
            this.TabNueva.Controls.Add(this.label7);
            this.TabNueva.Controls.Add(this.DineroLabel);
            this.TabNueva.Controls.Add(this.ImporteRecibidoNumeric);
            this.TabNueva.Controls.Add(this.label5);
            this.TabNueva.Controls.Add(this.FechaDebitacionPicker);
            this.TabNueva.Controls.Add(this.label4);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(982, 461);
            this.TabNueva.TabIndex = 2;
            this.TabNueva.Text = "Nueva confirmación de cobro";
            this.TabNueva.UseVisualStyleBackColor = true;
            // 
            // dgvCuentasEmpresa
            // 
            this.dgvCuentasEmpresa.AllowUserToAddRows = false;
            this.dgvCuentasEmpresa.AllowUserToDeleteRows = false;
            this.dgvCuentasEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvCuentasEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasEmpresa.Location = new System.Drawing.Point(321, 231);
            this.dgvCuentasEmpresa.MultiSelect = false;
            this.dgvCuentasEmpresa.Name = "dgvCuentasEmpresa";
            this.dgvCuentasEmpresa.ReadOnly = true;
            this.dgvCuentasEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentasEmpresa.Size = new System.Drawing.Size(349, 137);
            this.dgvCuentasEmpresa.TabIndex = 12;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(321, 391);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarButton.TabIndex = 10;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarDatosButton
            // 
            this.GuardarDatosButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarDatosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarDatosButton.Enabled = false;
            this.GuardarDatosButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarDatosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GuardarDatosButton.Location = new System.Drawing.Point(513, 391);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarDatosButton.TabIndex = 11;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Código o número de cuenta bancaria:";
            // 
            // DineroLabel
            // 
            this.DineroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DineroLabel.AutoSize = true;
            this.DineroLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.DineroLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.errorProvider1.SetIconPadding(this.DineroLabel, 5);
            this.DineroLabel.Location = new System.Drawing.Point(556, 109);
            this.DineroLabel.Name = "DineroLabel";
            this.DineroLabel.Size = new System.Drawing.Size(23, 28);
            this.DineroLabel.TabIndex = 7;
            this.DineroLabel.Text = "$";
            // 
            // ImporteRecibidoNumeric
            // 
            this.ImporteRecibidoNumeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImporteRecibidoNumeric.Enabled = false;
            this.ImporteRecibidoNumeric.Location = new System.Drawing.Point(430, 110);
            this.ImporteRecibidoNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ImporteRecibidoNumeric.Name = "ImporteRecibidoNumeric";
            this.ImporteRecibidoNumeric.Size = new System.Drawing.Size(120, 27);
            this.ImporteRecibidoNumeric.TabIndex = 6;
            this.ImporteRecibidoNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Importe recibido:";
            // 
            // FechaDebitacionPicker
            // 
            this.FechaDebitacionPicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FechaDebitacionPicker.Enabled = false;
            this.FechaDebitacionPicker.Location = new System.Drawing.Point(430, 54);
            this.FechaDebitacionPicker.Name = "FechaDebitacionPicker";
            this.FechaDebitacionPicker.Size = new System.Drawing.Size(267, 27);
            this.FechaDebitacionPicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha en la que el débito ingresó:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmConfirmacionCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 539);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConfirmacionCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmaciones de Cobro";
            this.Load += new System.EventHandler(this.FrmConfirmacionCobro_Load);
            this.SizeChanged += new System.EventHandler(this.FrmConfirmacionCobro_SizeChanged);
            this.Resize += new System.EventHandler(this.FrmConfirmacionCobro_Resize);
            this.materialTabControl1.ResumeLayout(false);
            this.TabListadoConfirmaciones.ResumeLayout(false);
            this.TabListadoConfirmaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoConfirmaciones)).EndInit();
            this.TabFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImporteRecibidoNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListadoConfirmaciones;
        private System.Windows.Forms.TabPage TabFacturas;
        private System.Windows.Forms.TabPage TabNueva;
        private System.Windows.Forms.Button BorrarConfirmacionButton;
        private System.Windows.Forms.DataGridView DgvListadoConfirmaciones;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox CodCuentaBusquedaTextBox;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodConfirmacionBusquedaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.Button CrearConfirmacionButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DineroLabel;
        private System.Windows.Forms.NumericUpDown ImporteRecibidoNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaDebitacionPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvCuentasEmpresa;
    }
}
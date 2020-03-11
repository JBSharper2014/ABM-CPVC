namespace CapaUsuario.Pagos.Cuenta_bancaria_empresa
{
    partial class FrmCuentaBancaria
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IgualRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.MayorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MenorRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.SaldoBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.CodCuentaBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CrearCuentaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BorrarCuentaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvListadoCuentas = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.DineroLabel = new System.Windows.Forms.Label();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.CbuTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabOrdenesPago = new System.Windows.Forms.TabPage();
            this.AsociarOrdenButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvOrdenesPago = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.TabListado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoCuentas)).BeginInit();
            this.TabNueva.SuspendLayout();
            this.TabOrdenesPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesPago)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(999, 43);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Controls.Add(this.TabOrdenesPago);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 43);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(999, 476);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListado
            // 
            this.TabListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListado.Controls.Add(this.groupBox1);
            this.TabListado.Controls.Add(this.CodCuentaBusquedaTextBox);
            this.TabListado.Controls.Add(this.label4);
            this.TabListado.Controls.Add(this.CrearCuentaButton);
            this.TabListado.Controls.Add(this.BorrarCuentaButton);
            this.TabListado.Controls.Add(this.DgvListadoCuentas);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(991, 443);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "Listado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.IgualRadioButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MayorRadioButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MenorRadioButton);
            this.groupBox1.Controls.Add(this.SaldoBusquedaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Igual a";
            // 
            // IgualRadioButton
            // 
            this.IgualRadioButton.AutoSize = true;
            this.IgualRadioButton.Checked = true;
            this.IgualRadioButton.Depth = 0;
            this.IgualRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.IgualRadioButton.Location = new System.Drawing.Point(257, 25);
            this.IgualRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.IgualRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IgualRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.IgualRadioButton.Name = "IgualRadioButton";
            this.IgualRadioButton.Ripple = true;
            this.IgualRadioButton.Size = new System.Drawing.Size(25, 30);
            this.IgualRadioButton.TabIndex = 11;
            this.IgualRadioButton.TabStop = true;
            this.IgualRadioButton.UseVisualStyleBackColor = true;
            this.IgualRadioButton.CheckedChanged += new System.EventHandler(this.IgualRadioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mayor que";
            // 
            // MayorRadioButton
            // 
            this.MayorRadioButton.AutoSize = true;
            this.MayorRadioButton.Depth = 0;
            this.MayorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.MayorRadioButton.Location = new System.Drawing.Point(139, 24);
            this.MayorRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.MayorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MayorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MayorRadioButton.Name = "MayorRadioButton";
            this.MayorRadioButton.Ripple = true;
            this.MayorRadioButton.Size = new System.Drawing.Size(25, 30);
            this.MayorRadioButton.TabIndex = 9;
            this.MayorRadioButton.UseVisualStyleBackColor = true;
            this.MayorRadioButton.CheckedChanged += new System.EventHandler(this.MayorRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Menor que";
            // 
            // MenorRadioButton
            // 
            this.MenorRadioButton.AutoSize = true;
            this.MenorRadioButton.Depth = 0;
            this.MenorRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.MenorRadioButton.Location = new System.Drawing.Point(15, 24);
            this.MenorRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.MenorRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MenorRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenorRadioButton.Name = "MenorRadioButton";
            this.MenorRadioButton.Ripple = true;
            this.MenorRadioButton.Size = new System.Drawing.Size(25, 30);
            this.MenorRadioButton.TabIndex = 7;
            this.MenorRadioButton.UseVisualStyleBackColor = true;
            this.MenorRadioButton.CheckedChanged += new System.EventHandler(this.MenorRadioButton_CheckedChanged);
            // 
            // SaldoBusquedaTextBox
            // 
            this.SaldoBusquedaTextBox.Location = new System.Drawing.Point(373, 26);
            this.SaldoBusquedaTextBox.MaxLength = 6;
            this.SaldoBusquedaTextBox.Name = "SaldoBusquedaTextBox";
            this.SaldoBusquedaTextBox.Size = new System.Drawing.Size(106, 27);
            this.SaldoBusquedaTextBox.TabIndex = 6;
            this.SaldoBusquedaTextBox.TextChanged += new System.EventHandler(this.SaldoBusquedaTextBox_TextChanged);
            // 
            // CodCuentaBusquedaTextBox
            // 
            this.CodCuentaBusquedaTextBox.Location = new System.Drawing.Point(155, 40);
            this.CodCuentaBusquedaTextBox.MaxLength = 6;
            this.CodCuentaBusquedaTextBox.Name = "CodCuentaBusquedaTextBox";
            this.CodCuentaBusquedaTextBox.Size = new System.Drawing.Size(106, 27);
            this.CodCuentaBusquedaTextBox.TabIndex = 4;
            this.CodCuentaBusquedaTextBox.TextChanged += new System.EventHandler(this.CodCuentaBusquedaTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de cuenta:";
            // 
            // CrearCuentaButton
            // 
            this.CrearCuentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearCuentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearCuentaButton.Depth = 0;
            this.CrearCuentaButton.Location = new System.Drawing.Point(815, 35);
            this.CrearCuentaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearCuentaButton.Name = "CrearCuentaButton";
            this.CrearCuentaButton.Primary = true;
            this.CrearCuentaButton.Size = new System.Drawing.Size(128, 36);
            this.CrearCuentaButton.TabIndex = 2;
            this.CrearCuentaButton.Text = "Crear cuenta";
            this.CrearCuentaButton.UseVisualStyleBackColor = true;
            this.CrearCuentaButton.Click += new System.EventHandler(this.CrearCuentaButton_Click);
            // 
            // BorrarCuentaButton
            // 
            this.BorrarCuentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarCuentaButton.AutoSize = true;
            this.BorrarCuentaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarCuentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarCuentaButton.Depth = 0;
            this.BorrarCuentaButton.Location = new System.Drawing.Point(676, 35);
            this.BorrarCuentaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarCuentaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarCuentaButton.Name = "BorrarCuentaButton";
            this.BorrarCuentaButton.Primary = false;
            this.BorrarCuentaButton.Size = new System.Drawing.Size(121, 36);
            this.BorrarCuentaButton.TabIndex = 1;
            this.BorrarCuentaButton.Text = "Borrar cuenta";
            this.BorrarCuentaButton.UseVisualStyleBackColor = true;
            this.BorrarCuentaButton.Click += new System.EventHandler(this.BorrarCuentaButton_Click);
            // 
            // DgvListadoCuentas
            // 
            this.DgvListadoCuentas.AllowUserToAddRows = false;
            this.DgvListadoCuentas.AllowUserToDeleteRows = false;
            this.DgvListadoCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoCuentas.Location = new System.Drawing.Point(8, 175);
            this.DgvListadoCuentas.MultiSelect = false;
            this.DgvListadoCuentas.Name = "DgvListadoCuentas";
            this.DgvListadoCuentas.ReadOnly = true;
            this.DgvListadoCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoCuentas.Size = new System.Drawing.Size(975, 260);
            this.DgvListadoCuentas.TabIndex = 0;
            this.DgvListadoCuentas.SelectionChanged += new System.EventHandler(this.DgvListadoCuentas_SelectionChanged);
            // 
            // TabNueva
            // 
            this.TabNueva.Controls.Add(this.CancelarButton);
            this.TabNueva.Controls.Add(this.GuardarDatosButton);
            this.TabNueva.Controls.Add(this.DineroLabel);
            this.TabNueva.Controls.Add(this.SaldoTextBox);
            this.TabNueva.Controls.Add(this.CbuTextBox);
            this.TabNueva.Controls.Add(this.label2);
            this.TabNueva.Controls.Add(this.label1);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(991, 443);
            this.TabNueva.TabIndex = 1;
            this.TabNueva.Text = "Nueva cuenta";
            this.TabNueva.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(270, 194);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarButton.TabIndex = 22;
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
            this.GuardarDatosButton.Location = new System.Drawing.Point(458, 194);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(204, 54);
            this.GuardarDatosButton.TabIndex = 21;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // DineroLabel
            // 
            this.DineroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DineroLabel.AutoSize = true;
            this.DineroLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.DineroLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.DineroLabel.Location = new System.Drawing.Point(544, 115);
            this.DineroLabel.Name = "DineroLabel";
            this.DineroLabel.Size = new System.Drawing.Size(21, 25);
            this.DineroLabel.TabIndex = 4;
            this.DineroLabel.Text = "$";
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaldoTextBox.Location = new System.Drawing.Point(401, 114);
            this.SaldoTextBox.MaxLength = 8;
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.ReadOnly = true;
            this.SaldoTextBox.Size = new System.Drawing.Size(137, 27);
            this.SaldoTextBox.TabIndex = 3;
            this.SaldoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbuTextBox
            // 
            this.CbuTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbuTextBox.Location = new System.Drawing.Point(401, 61);
            this.CbuTextBox.MaxLength = 19;
            this.CbuTextBox.Name = "CbuTextBox";
            this.CbuTextBox.ReadOnly = true;
            this.CbuTextBox.Size = new System.Drawing.Size(198, 27);
            this.CbuTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CBU:";
            // 
            // TabOrdenesPago
            // 
            this.TabOrdenesPago.Controls.Add(this.lblSelectedCount);
            this.TabOrdenesPago.Controls.Add(this.label3);
            this.TabOrdenesPago.Controls.Add(this.AsociarOrdenButton);
            this.TabOrdenesPago.Controls.Add(this.DgvOrdenesPago);
            this.TabOrdenesPago.Location = new System.Drawing.Point(4, 29);
            this.TabOrdenesPago.Name = "TabOrdenesPago";
            this.TabOrdenesPago.Padding = new System.Windows.Forms.Padding(3);
            this.TabOrdenesPago.Size = new System.Drawing.Size(991, 443);
            this.TabOrdenesPago.TabIndex = 2;
            this.TabOrdenesPago.Text = "Ordenes de pago";
            this.TabOrdenesPago.UseVisualStyleBackColor = true;
            // 
            // AsociarOrdenButton
            // 
            this.AsociarOrdenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AsociarOrdenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsociarOrdenButton.Depth = 0;
            this.AsociarOrdenButton.Location = new System.Drawing.Point(647, 21);
            this.AsociarOrdenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AsociarOrdenButton.Name = "AsociarOrdenButton";
            this.AsociarOrdenButton.Primary = true;
            this.AsociarOrdenButton.Size = new System.Drawing.Size(336, 50);
            this.AsociarOrdenButton.TabIndex = 3;
            this.AsociarOrdenButton.Text = "Asociar orden de pago a cuenta de la empresa seleccionada";
            this.AsociarOrdenButton.UseVisualStyleBackColor = true;
            this.AsociarOrdenButton.Click += new System.EventHandler(this.AsociarOrdenButton_Click);
            // 
            // DgvOrdenesPago
            // 
            this.DgvOrdenesPago.AllowUserToAddRows = false;
            this.DgvOrdenesPago.AllowUserToDeleteRows = false;
            this.DgvOrdenesPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrdenesPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenesPago.Location = new System.Drawing.Point(8, 91);
            this.DgvOrdenesPago.MultiSelect = false;
            this.DgvOrdenesPago.Name = "DgvOrdenesPago";
            this.DgvOrdenesPago.ReadOnly = true;
            this.DgvOrdenesPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrdenesPago.Size = new System.Drawing.Size(975, 339);
            this.DgvOrdenesPago.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuenta bancaria seleccionada:";
            // 
            // lblSelectedCount
            // 
            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCount.Location = new System.Drawing.Point(19, 51);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Size = new System.Drawing.Size(30, 20);
            this.lblSelectedCount.TabIndex = 5;
            this.lblSelectedCount.Text = "---";
            // 
            // FrmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 519);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCuentaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas Bancarias de empresa";
            this.Load += new System.EventHandler(this.FrmCuentaBancaria_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCuentaBancaria_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoCuentas)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            this.TabOrdenesPago.ResumeLayout(false);
            this.TabOrdenesPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.TabPage TabNueva;
        private MaterialSkin.Controls.MaterialRaisedButton CrearCuentaButton;
        private MaterialSkin.Controls.MaterialFlatButton BorrarCuentaButton;
        private System.Windows.Forms.DataGridView DgvListadoCuentas;
        private System.Windows.Forms.Label DineroLabel;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.TextBox CbuTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox CodCuentaBusquedaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage TabOrdenesPago;
        private System.Windows.Forms.DataGridView DgvOrdenesPago;
        private MaterialSkin.Controls.MaterialRaisedButton AsociarOrdenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRadioButton MenorRadioButton;
        private System.Windows.Forms.TextBox SaldoBusquedaTextBox;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialRadioButton IgualRadioButton;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRadioButton MayorRadioButton;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Label label3;
    }
}
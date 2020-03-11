


namespace CapaUsuario.Ventas.Clientes
{
    
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabAdmin = new System.Windows.Forms.TabPage();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.NumeroNumericUpDown = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.EsquinaTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CalleTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CiudadComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarCuentaButton = new System.Windows.Forms.Button();
            this.ListadoCuentasButton = new System.Windows.Forms.Button();
            this.ProvinciaComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AgregarClienteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodClienteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabListadoClientes = new System.Windows.Forms.TabPage();
            this.BusquedaClienteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.BorarClienteButton = new System.Windows.Forms.Button();
            this.EditarClienteButton = new System.Windows.Forms.Button();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabListadoClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabAdmin);
            this.materialTabControl1.Controls.Add(this.TabListadoClientes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1183, 528);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabAdmin
            // 
            this.TabAdmin.Controls.Add(this.TelefonoTextBox);
            this.TabAdmin.Controls.Add(this.NumeroNumericUpDown);
            this.TabAdmin.Controls.Add(this.GuardarButton);
            this.TabAdmin.Controls.Add(this.label10);
            this.TabAdmin.Controls.Add(this.EsquinaTextBox);
            this.TabAdmin.Controls.Add(this.label9);
            this.TabAdmin.Controls.Add(this.CalleTextBox);
            this.TabAdmin.Controls.Add(this.label8);
            this.TabAdmin.Controls.Add(this.CiudadComboBox);
            this.TabAdmin.Controls.Add(this.label6);
            this.TabAdmin.Controls.Add(this.groupBox1);
            this.TabAdmin.Controls.Add(this.ListadoCuentasButton);
            this.TabAdmin.Controls.Add(this.ProvinciaComboBox);
            this.TabAdmin.Controls.Add(this.label7);
            this.TabAdmin.Controls.Add(this.CancelarButton);
            this.TabAdmin.Controls.Add(this.AgregarClienteButton);
            this.TabAdmin.Controls.Add(this.label4);
            this.TabAdmin.Controls.Add(this.ApellidoTextBox);
            this.TabAdmin.Controls.Add(this.label3);
            this.TabAdmin.Controls.Add(this.NombreTextBox);
            this.TabAdmin.Controls.Add(this.label2);
            this.TabAdmin.Controls.Add(this.CodClienteTextBox);
            this.TabAdmin.Controls.Add(this.label1);
            this.TabAdmin.Location = new System.Drawing.Point(4, 29);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.TabAdmin.Size = new System.Drawing.Size(1175, 495);
            this.TabAdmin.TabIndex = 0;
            this.TabAdmin.Text = "Administracion";
            this.TabAdmin.UseVisualStyleBackColor = true;
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.TelefonoTextBox, 5);
            this.TelefonoTextBox.Location = new System.Drawing.Point(708, 52);
            this.TelefonoTextBox.MaxLength = 10;
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.ReadOnly = true;
            this.TelefonoTextBox.Size = new System.Drawing.Size(167, 27);
            this.TelefonoTextBox.TabIndex = 8;
            // 
            // NumeroNumericUpDown
            // 
            this.NumeroNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.NumeroNumericUpDown, 5);
            this.NumeroNumericUpDown.Location = new System.Drawing.Point(981, 104);
            this.NumeroNumericUpDown.MaxLength = 10;
            this.NumeroNumericUpDown.Name = "NumeroNumericUpDown";
            this.NumeroNumericUpDown.ReadOnly = true;
            this.NumeroNumericUpDown.Size = new System.Drawing.Size(136, 27);
            this.NumeroNumericUpDown.TabIndex = 16;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Image = global::CapaUsuario.Properties.Resources.save_client32;
            this.GuardarButton.Location = new System.Drawing.Point(80, 286);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(145, 47);
            this.GuardarButton.TabIndex = 20;
            this.GuardarButton.Text = "Guardar datos";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(935, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nº:";
            // 
            // EsquinaTextBox
            // 
            this.EsquinaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.EsquinaTextBox, 5);
            this.EsquinaTextBox.Location = new System.Drawing.Point(981, 160);
            this.EsquinaTextBox.MaxLength = 10;
            this.EsquinaTextBox.Name = "EsquinaTextBox";
            this.EsquinaTextBox.ReadOnly = true;
            this.EsquinaTextBox.Size = new System.Drawing.Size(136, 27);
            this.EsquinaTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(902, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Esquina:";
            // 
            // CalleTextBox
            // 
            this.CalleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.CalleTextBox, 5);
            this.CalleTextBox.Location = new System.Drawing.Point(981, 52);
            this.CalleTextBox.MaxLength = 10;
            this.CalleTextBox.Name = "CalleTextBox";
            this.CalleTextBox.ReadOnly = true;
            this.CalleTextBox.Size = new System.Drawing.Size(136, 27);
            this.CalleTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(921, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Calle:";
            // 
            // CiudadComboBox
            // 
            this.CiudadComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CiudadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadComboBox.Enabled = false;
            this.CiudadComboBox.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.CiudadComboBox, 5);
            this.CiudadComboBox.Location = new System.Drawing.Point(708, 160);
            this.CiudadComboBox.Name = "CiudadComboBox";
            this.CiudadComboBox.Size = new System.Drawing.Size(167, 28);
            this.CiudadComboBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ciudad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.AgregarCuentaButton);
            this.groupBox1.Location = new System.Drawing.Point(277, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 180);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta corriente ( con cliente seleccionado )";
            // 
            // AgregarCuentaButton
            // 
            this.AgregarCuentaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgregarCuentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarCuentaButton.Image = global::CapaUsuario.Properties.Resources.cuenta_corriente_2_64;
            this.AgregarCuentaButton.Location = new System.Drawing.Point(80, 36);
            this.AgregarCuentaButton.Name = "AgregarCuentaButton";
            this.AgregarCuentaButton.Size = new System.Drawing.Size(213, 122);
            this.AgregarCuentaButton.TabIndex = 0;
            this.AgregarCuentaButton.Text = "Agregar cuenta corriente";
            this.AgregarCuentaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarCuentaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarCuentaButton.UseVisualStyleBackColor = true;
            this.AgregarCuentaButton.Click += new System.EventHandler(this.AgregarCuentaButton_Click);
            // 
            // ListadoCuentasButton
            // 
            this.ListadoCuentasButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListadoCuentasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListadoCuentasButton.Image = global::CapaUsuario.Properties.Resources.cuenta_corriente641;
            this.ListadoCuentasButton.Location = new System.Drawing.Point(719, 322);
            this.ListadoCuentasButton.Name = "ListadoCuentasButton";
            this.ListadoCuentasButton.Size = new System.Drawing.Size(213, 122);
            this.ListadoCuentasButton.TabIndex = 22;
            this.ListadoCuentasButton.Text = "Listado cuentas corriente";
            this.ListadoCuentasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ListadoCuentasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ListadoCuentasButton.UseVisualStyleBackColor = true;
            this.ListadoCuentasButton.Click += new System.EventHandler(this.ListadoCuentasButton_Click);
            // 
            // ProvinciaComboBox
            // 
            this.ProvinciaComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProvinciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvinciaComboBox.Enabled = false;
            this.ProvinciaComboBox.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.ProvinciaComboBox, 5);
            this.ProvinciaComboBox.Location = new System.Drawing.Point(708, 104);
            this.ProvinciaComboBox.Name = "ProvinciaComboBox";
            this.ProvinciaComboBox.Size = new System.Drawing.Size(167, 28);
            this.ProvinciaComboBox.TabIndex = 10;
            this.ProvinciaComboBox.SelectedIndexChanged += new System.EventHandler(this.ProvinciaComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Provincia:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.CancelarButton.Location = new System.Drawing.Point(80, 217);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(145, 43);
            this.CancelarButton.TabIndex = 19;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AgregarClienteButton
            // 
            this.AgregarClienteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgregarClienteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarClienteButton.Image = global::CapaUsuario.Properties.Resources.add_client64;
            this.AgregarClienteButton.Location = new System.Drawing.Point(80, 52);
            this.AgregarClienteButton.Name = "AgregarClienteButton";
            this.AgregarClienteButton.Size = new System.Drawing.Size(126, 122);
            this.AgregarClienteButton.TabIndex = 0;
            this.AgregarClienteButton.Text = "Agregar cliente";
            this.AgregarClienteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarClienteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarClienteButton.UseVisualStyleBackColor = true;
            this.AgregarClienteButton.Click += new System.EventHandler(this.AgregarClienteButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono:";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.ApellidoTextBox, 5);
            this.ApellidoTextBox.Location = new System.Drawing.Point(415, 160);
            this.ApellidoTextBox.MaxLength = 30;
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.ReadOnly = true;
            this.ApellidoTextBox.Size = new System.Drawing.Size(167, 27);
            this.ApellidoTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer apellido:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.NombreTextBox, 5);
            this.NombreTextBox.Location = new System.Drawing.Point(415, 104);
            this.NombreTextBox.MaxLength = 30;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(167, 27);
            this.NombreTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer nombre:";
            // 
            // CodClienteTextBox
            // 
            this.CodClienteTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CodClienteTextBox.Location = new System.Drawing.Point(415, 52);
            this.CodClienteTextBox.Name = "CodClienteTextBox";
            this.CodClienteTextBox.ReadOnly = true;
            this.CodClienteTextBox.Size = new System.Drawing.Size(167, 27);
            this.CodClienteTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de cliente:";
            // 
            // TabListadoClientes
            // 
            this.TabListadoClientes.BackColor = System.Drawing.Color.White;
            this.TabListadoClientes.Controls.Add(this.BusquedaClienteTextBox);
            this.TabListadoClientes.Controls.Add(this.label5);
            this.TabListadoClientes.Controls.Add(this.DgvClientes);
            this.TabListadoClientes.Controls.Add(this.BorarClienteButton);
            this.TabListadoClientes.Controls.Add(this.EditarClienteButton);
            this.TabListadoClientes.Location = new System.Drawing.Point(4, 29);
            this.TabListadoClientes.Name = "TabListadoClientes";
            this.TabListadoClientes.Padding = new System.Windows.Forms.Padding(3);
            this.TabListadoClientes.Size = new System.Drawing.Size(1175, 495);
            this.TabListadoClientes.TabIndex = 1;
            this.TabListadoClientes.Text = "Listado";
            // 
            // BusquedaClienteTextBox
            // 
            this.BusquedaClienteTextBox.Location = new System.Drawing.Point(175, 53);
            this.BusquedaClienteTextBox.MaxLength = 10;
            this.BusquedaClienteTextBox.Name = "BusquedaClienteTextBox";
            this.BusquedaClienteTextBox.Size = new System.Drawing.Size(167, 27);
            this.BusquedaClienteTextBox.TabIndex = 1;
            this.BusquedaClienteTextBox.TextChanged += new System.EventHandler(this.BusquedaClienteTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código de cliente:";
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(8, 109);
            this.DgvClientes.MultiSelect = false;
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(1159, 358);
            this.DgvClientes.TabIndex = 4;
            // 
            // BorarClienteButton
            // 
            this.BorarClienteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorarClienteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorarClienteButton.Image = global::CapaUsuario.Properties.Resources.delete_client32;
            this.BorarClienteButton.Location = new System.Drawing.Point(970, 39);
            this.BorarClienteButton.Name = "BorarClienteButton";
            this.BorarClienteButton.Size = new System.Drawing.Size(136, 41);
            this.BorarClienteButton.TabIndex = 3;
            this.BorarClienteButton.Text = "Borrar cliente";
            this.BorarClienteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorarClienteButton.UseVisualStyleBackColor = true;
            this.BorarClienteButton.Click += new System.EventHandler(this.BorarClienteButton_Click);
            // 
            // EditarClienteButton
            // 
            this.EditarClienteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarClienteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarClienteButton.Image = global::CapaUsuario.Properties.Resources.edit_client32;
            this.EditarClienteButton.Location = new System.Drawing.Point(774, 39);
            this.EditarClienteButton.Name = "EditarClienteButton";
            this.EditarClienteButton.Size = new System.Drawing.Size(136, 41);
            this.EditarClienteButton.TabIndex = 2;
            this.EditarClienteButton.Text = "Editar cliente";
            this.EditarClienteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarClienteButton.UseVisualStyleBackColor = true;
            this.EditarClienteButton.Click += new System.EventHandler(this.EditarClienteButton_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1183, 34);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 528);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.TabAdmin.ResumeLayout(false);
            this.TabAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TabListadoClientes.ResumeLayout(false);
            this.TabListadoClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabAdmin;
        private System.Windows.Forms.TabPage TabListadoClientes;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Button AgregarClienteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodClienteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorarClienteButton;
        private System.Windows.Forms.Button EditarClienteButton;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.TextBox BusquedaClienteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ListadoCuentasButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarCuentaButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EsquinaTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CalleTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CiudadComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox ProvinciaComboBox;
        private System.Windows.Forms.TextBox NumeroNumericUpDown;
        private System.Windows.Forms.TextBox TelefonoTextBox;
    }
}
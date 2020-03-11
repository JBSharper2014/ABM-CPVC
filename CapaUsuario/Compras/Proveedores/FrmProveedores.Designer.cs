namespace CapaUsuario.Compras.Proveedores
{
    partial class FrmProveedores
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
            System.Windows.Forms.Label razon_socialLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label direccion_fisicaLabel;
            System.Windows.Forms.Label numero_telefonoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cod_proveedorLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CodPostalTextBox = new System.Windows.Forms.TextBox();
            this.CancelarNuevoButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.AgregarProveedorButton = new System.Windows.Forms.Button();
            this.DireccionComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.GuardarStockButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.StockComboBox = new System.Windows.Forms.ComboBox();
            this.razon_socialTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.numero_telefonoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cod_proveedorTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BorrarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ModificarButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AgregarBienUsoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AgregarStockButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.AgregarBancoButton = new System.Windows.Forms.Button();
            razon_socialLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            direccion_fisicaLabel = new System.Windows.Forms.Label();
            numero_telefonoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cod_proveedorLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // razon_socialLabel
            // 
            razon_socialLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            razon_socialLabel.AutoSize = true;
            razon_socialLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            razon_socialLabel.Location = new System.Drawing.Point(712, 157);
            razon_socialLabel.Name = "razon_socialLabel";
            razon_socialLabel.Size = new System.Drawing.Size(93, 20);
            razon_socialLabel.TabIndex = 46;
            razon_socialLabel.Text = "Razón social:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            emailLabel.Location = new System.Drawing.Point(758, 101);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 20);
            emailLabel.TabIndex = 44;
            emailLabel.Text = "Email:";
            // 
            // direccion_fisicaLabel
            // 
            direccion_fisicaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            direccion_fisicaLabel.AutoSize = true;
            direccion_fisicaLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            direccion_fisicaLabel.Location = new System.Drawing.Point(312, 216);
            direccion_fisicaLabel.Name = "direccion_fisicaLabel";
            direccion_fisicaLabel.Size = new System.Drawing.Size(72, 20);
            direccion_fisicaLabel.TabIndex = 43;
            direccion_fisicaLabel.Text = "Dirección:";
            // 
            // numero_telefonoLabel
            // 
            numero_telefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            numero_telefonoLabel.AutoSize = true;
            numero_telefonoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            numero_telefonoLabel.Location = new System.Drawing.Point(317, 157);
            numero_telefonoLabel.Name = "numero_telefonoLabel";
            numero_telefonoLabel.Size = new System.Drawing.Size(67, 20);
            numero_telefonoLabel.TabIndex = 41;
            numero_telefonoLabel.Text = "Teléfono:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            nombreLabel.Location = new System.Drawing.Point(317, 101);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 39;
            nombreLabel.Text = "Nombre:";
            // 
            // cod_proveedorLabel
            // 
            cod_proveedorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cod_proveedorLabel.AutoSize = true;
            cod_proveedorLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            cod_proveedorLabel.Location = new System.Drawing.Point(229, 45);
            cod_proveedorLabel.Name = "cod_proveedorLabel";
            cod_proveedorLabel.Size = new System.Drawing.Size(155, 20);
            cod_proveedorLabel.TabIndex = 36;
            cod_proveedorLabel.Text = "Código de proveedor:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            label2.Location = new System.Drawing.Point(701, 215);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 59;
            label2.Text = "Código postal:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1103, 45);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 45);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1103, 533);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.CodPostalTextBox);
            this.tabPage1.Controls.Add(this.CancelarNuevoButton);
            this.tabPage1.Controls.Add(this.GuardarDatosButton);
            this.tabPage1.Controls.Add(this.AgregarProveedorButton);
            this.tabPage1.Controls.Add(this.DireccionComboBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(razon_socialLabel);
            this.tabPage1.Controls.Add(this.razon_socialTextBox);
            this.tabPage1.Controls.Add(emailLabel);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(direccion_fisicaLabel);
            this.tabPage1.Controls.Add(numero_telefonoLabel);
            this.tabPage1.Controls.Add(this.numero_telefonoTextBox);
            this.tabPage1.Controls.Add(nombreLabel);
            this.tabPage1.Controls.Add(this.nombreTextBox);
            this.tabPage1.Controls.Add(cod_proveedorLabel);
            this.tabPage1.Controls.Add(this.cod_proveedorTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1095, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administración";
            // 
            // CodPostalTextBox
            // 
            this.CodPostalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CodPostalTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.CodPostalTextBox.Location = new System.Drawing.Point(824, 212);
            this.CodPostalTextBox.MaxLength = 50;
            this.CodPostalTextBox.Name = "CodPostalTextBox";
            this.CodPostalTextBox.ReadOnly = true;
            this.CodPostalTextBox.Size = new System.Drawing.Size(213, 27);
            this.CodPostalTextBox.TabIndex = 60;
            // 
            // CancelarNuevoButton
            // 
            this.CancelarNuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarNuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarNuevoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarNuevoButton.Enabled = false;
            this.CancelarNuevoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarNuevoButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarNuevoButton.Location = new System.Drawing.Point(56, 245);
            this.CancelarNuevoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarNuevoButton.Name = "CancelarNuevoButton";
            this.CancelarNuevoButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarNuevoButton.TabIndex = 57;
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
            this.GuardarDatosButton.Location = new System.Drawing.Point(56, 327);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarDatosButton.TabIndex = 58;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // AgregarProveedorButton
            // 
            this.AgregarProveedorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgregarProveedorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarProveedorButton.Image = global::CapaUsuario.Properties.Resources.add_proveedor64;
            this.AgregarProveedorButton.Location = new System.Drawing.Point(72, 82);
            this.AgregarProveedorButton.Name = "AgregarProveedorButton";
            this.AgregarProveedorButton.Size = new System.Drawing.Size(115, 120);
            this.AgregarProveedorButton.TabIndex = 51;
            this.AgregarProveedorButton.Text = "Agregar proveedor";
            this.AgregarProveedorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarProveedorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarProveedorButton.UseVisualStyleBackColor = true;
            this.AgregarProveedorButton.Click += new System.EventHandler(this.AgregarProveedorButton_Click);
            // 
            // DireccionComboBox
            // 
            this.DireccionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DireccionComboBox.Enabled = false;
            this.DireccionComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.DireccionComboBox.FormattingEnabled = true;
            this.DireccionComboBox.Location = new System.Drawing.Point(412, 212);
            this.DireccionComboBox.Name = "DireccionComboBox";
            this.DireccionComboBox.Size = new System.Drawing.Size(218, 28);
            this.DireccionComboBox.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.CancelarButton);
            this.groupBox1.Controls.Add(this.GuardarStockButton);
            this.groupBox1.Controls.Add(this.StockComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.groupBox1.Location = new System.Drawing.Point(299, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 181);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar producto o bien de uso";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.AutoSize = true;
            this.CancelarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.Depth = 0;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(27, 119);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Primary = false;
            this.CancelarButton.Size = new System.Drawing.Size(82, 36);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click_1);
            // 
            // GuardarStockButton
            // 
            this.GuardarStockButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarStockButton.Depth = 0;
            this.GuardarStockButton.Enabled = false;
            this.GuardarStockButton.Location = new System.Drawing.Point(138, 119);
            this.GuardarStockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarStockButton.Name = "GuardarStockButton";
            this.GuardarStockButton.Primary = true;
            this.GuardarStockButton.Size = new System.Drawing.Size(137, 34);
            this.GuardarStockButton.TabIndex = 2;
            this.GuardarStockButton.Text = "Guardar";
            this.GuardarStockButton.UseVisualStyleBackColor = true;
            this.GuardarStockButton.Click += new System.EventHandler(this.GuardarStockButton_Click);
            // 
            // StockComboBox
            // 
            this.StockComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StockComboBox.DisplayMember = "cod_pro_buso";
            this.StockComboBox.Enabled = false;
            this.StockComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.StockComboBox.FormattingEnabled = true;
            this.StockComboBox.Location = new System.Drawing.Point(25, 48);
            this.StockComboBox.Name = "StockComboBox";
            this.StockComboBox.Size = new System.Drawing.Size(250, 28);
            this.StockComboBox.TabIndex = 1;
            this.StockComboBox.ValueMember = "cod_pro_buso";
            // 
            // razon_socialTextBox
            // 
            this.razon_socialTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.razon_socialTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.razon_socialTextBox.Location = new System.Drawing.Point(824, 154);
            this.razon_socialTextBox.MaxLength = 50;
            this.razon_socialTextBox.Name = "razon_socialTextBox";
            this.razon_socialTextBox.ReadOnly = true;
            this.razon_socialTextBox.Size = new System.Drawing.Size(213, 27);
            this.razon_socialTextBox.TabIndex = 47;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.emailTextBox.Location = new System.Drawing.Point(824, 98);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(213, 27);
            this.emailTextBox.TabIndex = 45;
            // 
            // numero_telefonoTextBox
            // 
            this.numero_telefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numero_telefonoTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.numero_telefonoTextBox.Location = new System.Drawing.Point(412, 154);
            this.numero_telefonoTextBox.MaxLength = 50;
            this.numero_telefonoTextBox.Name = "numero_telefonoTextBox";
            this.numero_telefonoTextBox.ReadOnly = true;
            this.numero_telefonoTextBox.Size = new System.Drawing.Size(218, 27);
            this.numero_telefonoTextBox.TabIndex = 42;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.nombreTextBox.Location = new System.Drawing.Point(412, 98);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(218, 27);
            this.nombreTextBox.TabIndex = 40;
            // 
            // cod_proveedorTextBox
            // 
            this.cod_proveedorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cod_proveedorTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cod_proveedorTextBox.Location = new System.Drawing.Point(412, 42);
            this.cod_proveedorTextBox.Name = "cod_proveedorTextBox";
            this.cod_proveedorTextBox.ReadOnly = true;
            this.cod_proveedorTextBox.Size = new System.Drawing.Size(218, 27);
            this.cod_proveedorTextBox.TabIndex = 38;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.AgregarBancoButton);
            this.tabPage2.Controls.Add(this.BorrarButton);
            this.tabPage2.Controls.Add(this.ModificarButton);
            this.tabPage2.Controls.Add(this.AgregarBienUsoButton);
            this.tabPage2.Controls.Add(this.AgregarStockButton);
            this.tabPage2.Controls.Add(this.BuscarTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.DgvProveedores);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1095, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorrarButton.AutoSize = true;
            this.BorrarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Depth = 0;
            this.BorrarButton.Location = new System.Drawing.Point(469, 31);
            this.BorrarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Primary = false;
            this.BorrarButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarButton.TabIndex = 23;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click_1);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModificarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarButton.Depth = 0;
            this.ModificarButton.Location = new System.Drawing.Point(557, 32);
            this.ModificarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Primary = true;
            this.ModificarButton.Size = new System.Drawing.Size(158, 34);
            this.ModificarButton.TabIndex = 22;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click_1);
            // 
            // AgregarBienUsoButton
            // 
            this.AgregarBienUsoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarBienUsoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarBienUsoButton.Depth = 0;
            this.AgregarBienUsoButton.Location = new System.Drawing.Point(917, 32);
            this.AgregarBienUsoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarBienUsoButton.Name = "AgregarBienUsoButton";
            this.AgregarBienUsoButton.Primary = true;
            this.AgregarBienUsoButton.Size = new System.Drawing.Size(158, 34);
            this.AgregarBienUsoButton.TabIndex = 21;
            this.AgregarBienUsoButton.Text = "Agregar bien de uso";
            this.AgregarBienUsoButton.UseVisualStyleBackColor = true;
            this.AgregarBienUsoButton.Click += new System.EventHandler(this.AgregarBienUsoButton_Click_1);
            // 
            // AgregarStockButton
            // 
            this.AgregarStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarStockButton.Depth = 0;
            this.AgregarStockButton.Location = new System.Drawing.Point(738, 32);
            this.AgregarStockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarStockButton.Name = "AgregarStockButton";
            this.AgregarStockButton.Primary = true;
            this.AgregarStockButton.Size = new System.Drawing.Size(158, 34);
            this.AgregarStockButton.TabIndex = 20;
            this.AgregarStockButton.Text = "Agregar producto";
            this.AgregarStockButton.UseVisualStyleBackColor = true;
            this.AgregarStockButton.Click += new System.EventHandler(this.AgregarStockButton_Click_1);
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.BuscarTextBox.Location = new System.Drawing.Point(88, 36);
            this.BuscarTextBox.MaxLength = 50;
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(161, 27);
            this.BuscarTextBox.TabIndex = 19;
            this.BuscarTextBox.TextChanged += new System.EventHandler(this.BuscarTextBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Buscar:";
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.AllowUserToAddRows = false;
            this.DgvProveedores.AllowUserToDeleteRows = false;
            this.DgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Location = new System.Drawing.Point(10, 93);
            this.DgvProveedores.MultiSelect = false;
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            this.DgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProveedores.Size = new System.Drawing.Size(1077, 399);
            this.DgvProveedores.TabIndex = 17;
            // 
            // AgregarBancoButton
            // 
            this.AgregarBancoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarBancoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.AgregarBancoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarBancoButton.Location = new System.Drawing.Point(277, 30);
            this.AgregarBancoButton.Name = "AgregarBancoButton";
            this.AgregarBancoButton.Size = new System.Drawing.Size(175, 38);
            this.AgregarBancoButton.TabIndex = 50;
            this.AgregarBancoButton.Text = "Administrar CBU";
            this.AgregarBancoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBancoButton.UseVisualStyleBackColor = true;
            this.AgregarBancoButton.Click += new System.EventHandler(this.AgregarBancoButton_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 578);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.SizeChanged += new System.EventHandler(this.FrmProveedores_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ComboBox DireccionComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton CancelarButton;
        private MaterialSkin.Controls.MaterialRaisedButton GuardarStockButton;
        private System.Windows.Forms.ComboBox StockComboBox;
        private System.Windows.Forms.TextBox razon_socialTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox numero_telefonoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cod_proveedorTextBox;
        private MaterialSkin.Controls.MaterialFlatButton BorrarButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarButton;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarBienUsoButton;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarStockButton;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.Button AgregarProveedorButton;
        private System.Windows.Forms.Button CancelarNuevoButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.TextBox CodPostalTextBox;
        private System.Windows.Forms.Button AgregarBancoButton;
    }
}
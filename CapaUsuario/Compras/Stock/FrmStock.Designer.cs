namespace CapaUsuario.Compras
{
    partial class FrmStock
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
            System.Windows.Forms.Label stk_criLabel;
            System.Windows.Forms.Label stk_optLabel;
            System.Windows.Forms.Label stk_actLabel;
            System.Windows.Forms.Label cod_catLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cod_pro_stockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.AgregarProductoButton = new System.Windows.Forms.Button();
            this.StockCriticoTextBox = new System.Windows.Forms.TextBox();
            this.StockOptimoTextBox = new System.Windows.Forms.TextBox();
            this.StockActualTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CodProdTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarMarcaMedidaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ModificarButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BorrarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ActualizarStockButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvStock = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelarMarcaMedida = new MaterialSkin.Controls.MaterialFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.GuardarMarcaMedidaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.MedidaComboBox = new System.Windows.Forms.ComboBox();
            this.ActualizarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvStockMarca = new System.Windows.Forms.DataGridView();
            stk_criLabel = new System.Windows.Forms.Label();
            stk_optLabel = new System.Windows.Forms.Label();
            stk_actLabel = new System.Windows.Forms.Label();
            cod_catLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cod_pro_stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // stk_criLabel
            // 
            stk_criLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            stk_criLabel.AutoSize = true;
            stk_criLabel.Location = new System.Drawing.Point(413, 393);
            stk_criLabel.Name = "stk_criLabel";
            stk_criLabel.Size = new System.Drawing.Size(91, 20);
            stk_criLabel.TabIndex = 51;
            stk_criLabel.Text = "Stock crítico:";
            // 
            // stk_optLabel
            // 
            stk_optLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            stk_optLabel.AutoSize = true;
            stk_optLabel.Location = new System.Drawing.Point(404, 326);
            stk_optLabel.Name = "stk_optLabel";
            stk_optLabel.Size = new System.Drawing.Size(100, 20);
            stk_optLabel.TabIndex = 50;
            stk_optLabel.Text = "Stock óptimo:";
            // 
            // stk_actLabel
            // 
            stk_actLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            stk_actLabel.AutoSize = true;
            stk_actLabel.Location = new System.Drawing.Point(413, 257);
            stk_actLabel.Name = "stk_actLabel";
            stk_actLabel.Size = new System.Drawing.Size(91, 20);
            stk_actLabel.TabIndex = 48;
            stk_actLabel.Text = "Stock actual:";
            // 
            // cod_catLabel
            // 
            cod_catLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cod_catLabel.AutoSize = true;
            cod_catLabel.Location = new System.Drawing.Point(428, 192);
            cod_catLabel.Name = "cod_catLabel";
            cod_catLabel.Size = new System.Drawing.Size(76, 20);
            cod_catLabel.TabIndex = 46;
            cod_catLabel.Text = "Categoría:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(437, 129);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 44;
            nombreLabel.Text = "Nombre:";
            // 
            // cod_pro_stockLabel
            // 
            cod_pro_stockLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cod_pro_stockLabel.AutoSize = true;
            cod_pro_stockLabel.Location = new System.Drawing.Point(358, 58);
            cod_pro_stockLabel.Name = "cod_pro_stockLabel";
            cod_pro_stockLabel.Size = new System.Drawing.Size(146, 20);
            cod_pro_stockLabel.TabIndex = 42;
            cod_pro_stockLabel.Text = "Código de producto:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoriaComboBox.DisplayMember = "cod_cat";
            this.CategoriaComboBox.Enabled = false;
            this.CategoriaComboBox.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.CategoriaComboBox, 5);
            this.CategoriaComboBox.Location = new System.Drawing.Point(510, 188);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(202, 28);
            this.CategoriaComboBox.TabIndex = 47;
            this.CategoriaComboBox.ValueMember = "cod_cat";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1062, 39);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 39);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1062, 492);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CancelarButton);
            this.tabPage1.Controls.Add(this.GuardarDatosButton);
            this.tabPage1.Controls.Add(this.AgregarProductoButton);
            this.tabPage1.Controls.Add(this.StockCriticoTextBox);
            this.tabPage1.Controls.Add(this.StockOptimoTextBox);
            this.tabPage1.Controls.Add(stk_criLabel);
            this.tabPage1.Controls.Add(stk_optLabel);
            this.tabPage1.Controls.Add(stk_actLabel);
            this.tabPage1.Controls.Add(this.StockActualTextBox);
            this.tabPage1.Controls.Add(this.NombreTextBox);
            this.tabPage1.Controls.Add(this.CodProdTextBox);
            this.tabPage1.Controls.Add(cod_catLabel);
            this.tabPage1.Controls.Add(this.CategoriaComboBox);
            this.tabPage1.Controls.Add(nombreLabel);
            this.tabPage1.Controls.Add(cod_pro_stockLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1054, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(92, 145);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarButton.TabIndex = 55;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click_1);
            // 
            // GuardarDatosButton
            // 
            this.GuardarDatosButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarDatosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarDatosButton.Enabled = false;
            this.GuardarDatosButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarDatosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GuardarDatosButton.Location = new System.Drawing.Point(92, 227);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarDatosButton.TabIndex = 56;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click_1);
            // 
            // AgregarProductoButton
            // 
            this.AgregarProductoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgregarProductoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarProductoButton.Image = global::CapaUsuario.Properties.Resources.add_stock64;
            this.AgregarProductoButton.Location = new System.Drawing.Point(73, 33);
            this.AgregarProductoButton.Name = "AgregarProductoButton";
            this.AgregarProductoButton.Size = new System.Drawing.Size(214, 76);
            this.AgregarProductoButton.TabIndex = 54;
            this.AgregarProductoButton.Text = "Agregar producto";
            this.AgregarProductoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarProductoButton.UseVisualStyleBackColor = true;
            this.AgregarProductoButton.Click += new System.EventHandler(this.AgregarProductoButton_Click_1);
            // 
            // StockCriticoTextBox
            // 
            this.StockCriticoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StockCriticoTextBox.Location = new System.Drawing.Point(510, 390);
            this.StockCriticoTextBox.MaxLength = 4;
            this.StockCriticoTextBox.Name = "StockCriticoTextBox";
            this.StockCriticoTextBox.ReadOnly = true;
            this.StockCriticoTextBox.Size = new System.Drawing.Size(202, 27);
            this.StockCriticoTextBox.TabIndex = 53;
            // 
            // StockOptimoTextBox
            // 
            this.StockOptimoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StockOptimoTextBox.Location = new System.Drawing.Point(510, 323);
            this.StockOptimoTextBox.MaxLength = 4;
            this.StockOptimoTextBox.Name = "StockOptimoTextBox";
            this.StockOptimoTextBox.ReadOnly = true;
            this.StockOptimoTextBox.Size = new System.Drawing.Size(202, 27);
            this.StockOptimoTextBox.TabIndex = 52;
            // 
            // StockActualTextBox
            // 
            this.StockActualTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StockActualTextBox.Location = new System.Drawing.Point(510, 254);
            this.StockActualTextBox.MaxLength = 4;
            this.StockActualTextBox.Name = "StockActualTextBox";
            this.StockActualTextBox.ReadOnly = true;
            this.StockActualTextBox.Size = new System.Drawing.Size(202, 27);
            this.StockActualTextBox.TabIndex = 49;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NombreTextBox.Location = new System.Drawing.Point(510, 127);
            this.NombreTextBox.MaxLength = 50;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(202, 27);
            this.NombreTextBox.TabIndex = 45;
            // 
            // CodProdTextBox
            // 
            this.CodProdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CodProdTextBox.Location = new System.Drawing.Point(510, 58);
            this.CodProdTextBox.Name = "CodProdTextBox";
            this.CodProdTextBox.ReadOnly = true;
            this.CodProdTextBox.Size = new System.Drawing.Size(202, 27);
            this.CodProdTextBox.TabIndex = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.BusquedaTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.AgregarMarcaMedidaButton);
            this.tabPage2.Controls.Add(this.ModificarButton);
            this.tabPage2.Controls.Add(this.BorrarButton);
            this.tabPage2.Controls.Add(this.ActualizarStockButton);
            this.tabPage2.Controls.Add(this.DgvStock);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1054, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            // 
            // BusquedaTextBox
            // 
            this.BusquedaTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.BusquedaTextBox.Location = new System.Drawing.Point(175, 38);
            this.BusquedaTextBox.Name = "BusquedaTextBox";
            this.BusquedaTextBox.Size = new System.Drawing.Size(166, 27);
            this.BusquedaTextBox.TabIndex = 32;
            this.BusquedaTextBox.TextChanged += new System.EventHandler(this.BusquedaTextBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Buscar por nombre:";
            // 
            // AgregarMarcaMedidaButton
            // 
            this.AgregarMarcaMedidaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarMarcaMedidaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarMarcaMedidaButton.Depth = 0;
            this.AgregarMarcaMedidaButton.Location = new System.Drawing.Point(647, 33);
            this.AgregarMarcaMedidaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarMarcaMedidaButton.Name = "AgregarMarcaMedidaButton";
            this.AgregarMarcaMedidaButton.Primary = true;
            this.AgregarMarcaMedidaButton.Size = new System.Drawing.Size(230, 36);
            this.AgregarMarcaMedidaButton.TabIndex = 30;
            this.AgregarMarcaMedidaButton.Text = "Agregar una marca y medida";
            this.AgregarMarcaMedidaButton.UseVisualStyleBackColor = true;
            this.AgregarMarcaMedidaButton.Click += new System.EventHandler(this.AgregarMarcaMedidaButton_Click_2);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModificarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarButton.Depth = 0;
            this.ModificarButton.Location = new System.Drawing.Point(465, 35);
            this.ModificarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Primary = true;
            this.ModificarButton.Size = new System.Drawing.Size(99, 32);
            this.ModificarButton.TabIndex = 29;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click_1);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorrarButton.AutoSize = true;
            this.BorrarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Depth = 0;
            this.BorrarButton.Location = new System.Drawing.Point(383, 33);
            this.BorrarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Primary = false;
            this.BorrarButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarButton.TabIndex = 28;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click_1);
            // 
            // ActualizarStockButton
            // 
            this.ActualizarStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActualizarStockButton.AutoSize = true;
            this.ActualizarStockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarStockButton.Depth = 0;
            this.ActualizarStockButton.Location = new System.Drawing.Point(919, 33);
            this.ActualizarStockButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActualizarStockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarStockButton.Name = "ActualizarStockButton";
            this.ActualizarStockButton.Primary = false;
            this.ActualizarStockButton.Size = new System.Drawing.Size(94, 36);
            this.ActualizarStockButton.TabIndex = 27;
            this.ActualizarStockButton.Text = "Actualizar";
            this.ActualizarStockButton.UseVisualStyleBackColor = true;
            this.ActualizarStockButton.Click += new System.EventHandler(this.ActualizarStockButton_Click_1);
            // 
            // DgvStock
            // 
            this.DgvStock.AllowUserToAddRows = false;
            this.DgvStock.AllowUserToDeleteRows = false;
            this.DgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStock.Location = new System.Drawing.Point(8, 88);
            this.DgvStock.MultiSelect = false;
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.ReadOnly = true;
            this.DgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStock.Size = new System.Drawing.Size(1038, 363);
            this.DgvStock.TabIndex = 26;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.ActualizarButton);
            this.tabPage3.Controls.Add(this.DgvStockMarca);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1054, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos por marca";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.CancelarMarcaMedida);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GuardarMarcaMedidaButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MarcaComboBox);
            this.groupBox1.Controls.Add(this.MedidaComboBox);
            this.groupBox1.Location = new System.Drawing.Point(544, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 286);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca y medida";
            // 
            // CancelarMarcaMedida
            // 
            this.CancelarMarcaMedida.AutoSize = true;
            this.CancelarMarcaMedida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarMarcaMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarMarcaMedida.Depth = 0;
            this.CancelarMarcaMedida.Enabled = false;
            this.CancelarMarcaMedida.Location = new System.Drawing.Point(94, 197);
            this.CancelarMarcaMedida.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelarMarcaMedida.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarMarcaMedida.Name = "CancelarMarcaMedida";
            this.CancelarMarcaMedida.Primary = false;
            this.CancelarMarcaMedida.Size = new System.Drawing.Size(82, 36);
            this.CancelarMarcaMedida.TabIndex = 19;
            this.CancelarMarcaMedida.Text = "Cancelar";
            this.CancelarMarcaMedida.UseVisualStyleBackColor = true;
            this.CancelarMarcaMedida.Click += new System.EventHandler(this.CancelarMarcaMedida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medida:";
            // 
            // GuardarMarcaMedidaButton
            // 
            this.GuardarMarcaMedidaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarMarcaMedidaButton.Depth = 0;
            this.GuardarMarcaMedidaButton.Enabled = false;
            this.GuardarMarcaMedidaButton.Location = new System.Drawing.Point(207, 197);
            this.GuardarMarcaMedidaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarMarcaMedidaButton.Name = "GuardarMarcaMedidaButton";
            this.GuardarMarcaMedidaButton.Primary = true;
            this.GuardarMarcaMedidaButton.Size = new System.Drawing.Size(130, 36);
            this.GuardarMarcaMedidaButton.TabIndex = 18;
            this.GuardarMarcaMedidaButton.Text = "Guardar";
            this.GuardarMarcaMedidaButton.UseVisualStyleBackColor = true;
            this.GuardarMarcaMedidaButton.Click += new System.EventHandler(this.GuardarMarcaMedidaButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca:";
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DisplayMember = "cod_mar";
            this.MarcaComboBox.Enabled = false;
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Location = new System.Drawing.Point(120, 65);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(230, 28);
            this.MarcaComboBox.TabIndex = 7;
            this.MarcaComboBox.ValueMember = "cod_mar";
            // 
            // MedidaComboBox
            // 
            this.MedidaComboBox.DisplayMember = "cod_med";
            this.MedidaComboBox.Enabled = false;
            this.MedidaComboBox.FormattingEnabled = true;
            this.MedidaComboBox.Location = new System.Drawing.Point(120, 122);
            this.MedidaComboBox.Name = "MedidaComboBox";
            this.MedidaComboBox.Size = new System.Drawing.Size(230, 28);
            this.MedidaComboBox.TabIndex = 9;
            this.MedidaComboBox.ValueMember = "cod_med";
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.AutoSize = true;
            this.ActualizarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarButton.Depth = 0;
            this.ActualizarButton.Location = new System.Drawing.Point(39, 36);
            this.ActualizarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActualizarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Primary = false;
            this.ActualizarButton.Size = new System.Drawing.Size(94, 36);
            this.ActualizarButton.TabIndex = 26;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click_1);
            // 
            // DgvStockMarca
            // 
            this.DgvStockMarca.AllowUserToAddRows = false;
            this.DgvStockMarca.AllowUserToDeleteRows = false;
            this.DgvStockMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvStockMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStockMarca.Location = new System.Drawing.Point(21, 81);
            this.DgvStockMarca.MultiSelect = false;
            this.DgvStockMarca.Name = "DgvStockMarca";
            this.DgvStockMarca.ReadOnly = true;
            this.DgvStockMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStockMarca.Size = new System.Drawing.Size(482, 300);
            this.DgvStockMarca.TabIndex = 25;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 531);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.SizeChanged += new System.EventHandler(this.FrmStock_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.Button AgregarProductoButton;
        private System.Windows.Forms.TextBox StockCriticoTextBox;
        private System.Windows.Forms.TextBox StockOptimoTextBox;
        private System.Windows.Forms.TextBox StockActualTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox CodProdTextBox;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.TextBox BusquedaTextBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarMarcaMedidaButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarButton;
        private MaterialSkin.Controls.MaterialFlatButton BorrarButton;
        private MaterialSkin.Controls.MaterialFlatButton ActualizarStockButton;
        private System.Windows.Forms.DataGridView DgvStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton CancelarMarcaMedida;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton GuardarMarcaMedidaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private System.Windows.Forms.ComboBox MedidaComboBox;
        private MaterialSkin.Controls.MaterialFlatButton ActualizarButton;
        private System.Windows.Forms.DataGridView DgvStockMarca;
    }
}
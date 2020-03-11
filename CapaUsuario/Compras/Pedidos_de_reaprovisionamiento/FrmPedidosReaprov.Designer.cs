namespace CapaUsuario.Compras.Pedidos_de_reaprovisionamiento
{
    partial class FrmPedidosReaprov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosReaprov));
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.NuevoPedidoButton = new System.Windows.Forms.Button();
            this.FiltrarPedidosTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BorrarPedidoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ModificarPedidoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvListadoPedidos = new System.Windows.Forms.DataGridView();
            this.TabNuevo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MedidaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarTodoButton = new System.Windows.Forms.Button();
            this.BorrarLineaButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GrabarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DgvStockPedidoReaprov = new System.Windows.Forms.DataGridView();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerarPedidosAutoButton = new System.Windows.Forms.Button();
            this.TabStock = new System.Windows.Forms.TabPage();
            this.FiltrarStockTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ActualizarListadoStock = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPedidos)).BeginInit();
            this.TabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockPedidoReaprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            this.TabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1178, 44);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Controls.Add(this.TabNuevo);
            this.materialTabControl1.Controls.Add(this.TabStock);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 44);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1178, 547);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListado
            // 
            this.TabListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListado.Controls.Add(this.NuevoPedidoButton);
            this.TabListado.Controls.Add(this.FiltrarPedidosTextBox);
            this.TabListado.Controls.Add(this.label5);
            this.TabListado.Controls.Add(this.BorrarPedidoButton);
            this.TabListado.Controls.Add(this.ModificarPedidoButton);
            this.TabListado.Controls.Add(this.DgvListadoPedidos);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(1170, 514);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "Listado";
            // 
            // NuevoPedidoButton
            // 
            this.NuevoPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevoPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoPedidoButton.Image = global::CapaUsuario.Properties.Resources.add_solicitud_compra32;
            this.NuevoPedidoButton.Location = new System.Drawing.Point(926, 26);
            this.NuevoPedidoButton.Name = "NuevoPedidoButton";
            this.NuevoPedidoButton.Size = new System.Drawing.Size(177, 50);
            this.NuevoPedidoButton.TabIndex = 17;
            this.NuevoPedidoButton.Text = "Nuevo pedido";
            this.NuevoPedidoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoPedidoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoPedidoButton.UseVisualStyleBackColor = true;
            this.NuevoPedidoButton.Click += new System.EventHandler(this.NuevoPedidoButton_Click);
            // 
            // FiltrarPedidosTextBox
            // 
            this.FiltrarPedidosTextBox.Location = new System.Drawing.Point(163, 38);
            this.FiltrarPedidosTextBox.Name = "FiltrarPedidosTextBox";
            this.FiltrarPedidosTextBox.Size = new System.Drawing.Size(160, 27);
            this.FiltrarPedidosTextBox.TabIndex = 16;
            this.FiltrarPedidosTextBox.TextChanged += new System.EventHandler(this.FiltrarPedidosTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código de pedido:";
            // 
            // BorrarPedidoButton
            // 
            this.BorrarPedidoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorrarPedidoButton.AutoSize = true;
            this.BorrarPedidoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarPedidoButton.Depth = 0;
            this.BorrarPedidoButton.Location = new System.Drawing.Point(441, 33);
            this.BorrarPedidoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarPedidoButton.Name = "BorrarPedidoButton";
            this.BorrarPedidoButton.Primary = false;
            this.BorrarPedidoButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarPedidoButton.TabIndex = 14;
            this.BorrarPedidoButton.Text = "Borrar";
            this.BorrarPedidoButton.UseVisualStyleBackColor = true;
            this.BorrarPedidoButton.Click += new System.EventHandler(this.BorrarPedidoButton_Click_1);
            // 
            // ModificarPedidoButton
            // 
            this.ModificarPedidoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModificarPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarPedidoButton.Depth = 0;
            this.ModificarPedidoButton.Location = new System.Drawing.Point(546, 33);
            this.ModificarPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarPedidoButton.Name = "ModificarPedidoButton";
            this.ModificarPedidoButton.Primary = true;
            this.ModificarPedidoButton.Size = new System.Drawing.Size(120, 37);
            this.ModificarPedidoButton.TabIndex = 13;
            this.ModificarPedidoButton.Text = "Modificar";
            this.ModificarPedidoButton.UseVisualStyleBackColor = true;
            this.ModificarPedidoButton.Click += new System.EventHandler(this.ModificarPedidoButton_Click_1);
            // 
            // DgvListadoPedidos
            // 
            this.DgvListadoPedidos.AllowUserToAddRows = false;
            this.DgvListadoPedidos.AllowUserToDeleteRows = false;
            this.DgvListadoPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoPedidos.Location = new System.Drawing.Point(8, 82);
            this.DgvListadoPedidos.MultiSelect = false;
            this.DgvListadoPedidos.Name = "DgvListadoPedidos";
            this.DgvListadoPedidos.ReadOnly = true;
            this.DgvListadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoPedidos.Size = new System.Drawing.Size(1154, 341);
            this.DgvListadoPedidos.TabIndex = 11;
            // 
            // TabNuevo
            // 
            this.TabNuevo.Controls.Add(this.button1);
            this.TabNuevo.Controls.Add(this.ProveedorComboBox);
            this.TabNuevo.Controls.Add(this.label7);
            this.TabNuevo.Controls.Add(this.MarcaComboBox);
            this.TabNuevo.Controls.Add(this.label3);
            this.TabNuevo.Controls.Add(this.MedidaComboBox);
            this.TabNuevo.Controls.Add(this.label1);
            this.TabNuevo.Controls.Add(this.BorrarTodoButton);
            this.TabNuevo.Controls.Add(this.BorrarLineaButton);
            this.TabNuevo.Controls.Add(this.CancelarButton);
            this.TabNuevo.Controls.Add(this.GrabarButton);
            this.TabNuevo.Controls.Add(this.AgregarButton);
            this.TabNuevo.Controls.Add(this.DgvStockPedidoReaprov);
            this.TabNuevo.Controls.Add(this.CantidadNumericUpDown);
            this.TabNuevo.Controls.Add(this.label4);
            this.TabNuevo.Controls.Add(this.ProductoComboBox);
            this.TabNuevo.Controls.Add(this.label2);
            this.TabNuevo.Controls.Add(this.GenerarPedidosAutoButton);
            this.TabNuevo.Location = new System.Drawing.Point(4, 29);
            this.TabNuevo.Name = "TabNuevo";
            this.TabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.TabNuevo.Size = new System.Drawing.Size(1170, 514);
            this.TabNuevo.TabIndex = 1;
            this.TabNuevo.Text = "Nuevo pedido";
            this.TabNuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(953, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 39);
            this.button1.TabIndex = 50;
            this.button1.Text = "Pedido automatizado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProveedorComboBox
            // 
            this.ProveedorComboBox.DisplayMember = "cod_pro_stock";
            this.ProveedorComboBox.Enabled = false;
            this.ProveedorComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorComboBox.FormattingEnabled = true;
            this.ProveedorComboBox.Location = new System.Drawing.Point(167, 23);
            this.ProveedorComboBox.Name = "ProveedorComboBox";
            this.ProveedorComboBox.Size = new System.Drawing.Size(262, 28);
            this.ProveedorComboBox.TabIndex = 49;
            this.ProveedorComboBox.ValueMember = "cod_pro_stock";
            this.ProveedorComboBox.SelectedValueChanged += new System.EventHandler(this.ProveedorComboBox_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Proveedor:";
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DisplayMember = "cod_pro_stock";
            this.MarcaComboBox.Enabled = false;
            this.MarcaComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Location = new System.Drawing.Point(167, 151);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(262, 28);
            this.MarcaComboBox.TabIndex = 47;
            this.MarcaComboBox.ValueMember = "cod_pro_stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Marca:";
            // 
            // MedidaComboBox
            // 
            this.MedidaComboBox.DisplayMember = "cod_pro_stock";
            this.MedidaComboBox.Enabled = false;
            this.MedidaComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedidaComboBox.FormattingEnabled = true;
            this.MedidaComboBox.Location = new System.Drawing.Point(167, 216);
            this.MedidaComboBox.Name = "MedidaComboBox";
            this.MedidaComboBox.Size = new System.Drawing.Size(262, 28);
            this.MedidaComboBox.TabIndex = 45;
            this.MedidaComboBox.ValueMember = "cod_pro_stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Medida:";
            // 
            // BorrarTodoButton
            // 
            this.BorrarTodoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarTodoButton.Enabled = false;
            this.BorrarTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BorrarTodoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarTodoButton.Image = global::CapaUsuario.Properties.Resources.borrar_todo48x48;
            this.BorrarTodoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BorrarTodoButton.Location = new System.Drawing.Point(426, 360);
            this.BorrarTodoButton.Name = "BorrarTodoButton";
            this.BorrarTodoButton.Size = new System.Drawing.Size(82, 75);
            this.BorrarTodoButton.TabIndex = 41;
            this.BorrarTodoButton.Text = "Borrar todo";
            this.BorrarTodoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrarTodoButton.UseVisualStyleBackColor = true;
            this.BorrarTodoButton.Click += new System.EventHandler(this.BorrarTodoButton_Click_1);
            // 
            // BorrarLineaButton
            // 
            this.BorrarLineaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarLineaButton.Enabled = false;
            this.BorrarLineaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BorrarLineaButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarLineaButton.Image = global::CapaUsuario.Properties.Resources.delete_row_32x32;
            this.BorrarLineaButton.Location = new System.Drawing.Point(336, 360);
            this.BorrarLineaButton.Name = "BorrarLineaButton";
            this.BorrarLineaButton.Size = new System.Drawing.Size(74, 75);
            this.BorrarLineaButton.TabIndex = 40;
            this.BorrarLineaButton.Text = "Borrar";
            this.BorrarLineaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrarLineaButton.UseVisualStyleBackColor = true;
            this.BorrarLineaButton.Click += new System.EventHandler(this.BorrarLineaButton_Click_1);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(246, 360);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(74, 75);
            this.CancelarButton.TabIndex = 39;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click_1);
            // 
            // GrabarButton
            // 
            this.GrabarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrabarButton.Enabled = false;
            this.GrabarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrabarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrabarButton.Image = global::CapaUsuario.Properties.Resources.cool_save_32;
            this.GrabarButton.Location = new System.Drawing.Point(156, 360);
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(74, 75);
            this.GrabarButton.TabIndex = 38;
            this.GrabarButton.Text = "Grabar";
            this.GrabarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GrabarButton.UseVisualStyleBackColor = true;
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click_1);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarButton.Enabled = false;
            this.AgregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Image = global::CapaUsuario.Properties.Resources.add_light_green_32;
            this.AgregarButton.Location = new System.Drawing.Point(66, 360);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(74, 75);
            this.AgregarButton.TabIndex = 37;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click_1);
            // 
            // DgvStockPedidoReaprov
            // 
            this.DgvStockPedidoReaprov.AllowUserToAddRows = false;
            this.DgvStockPedidoReaprov.AllowUserToDeleteRows = false;
            this.DgvStockPedidoReaprov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStockPedidoReaprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStockPedidoReaprov.Location = new System.Drawing.Point(571, 23);
            this.DgvStockPedidoReaprov.MultiSelect = false;
            this.DgvStockPedidoReaprov.Name = "DgvStockPedidoReaprov";
            this.DgvStockPedidoReaprov.ReadOnly = true;
            this.DgvStockPedidoReaprov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStockPedidoReaprov.Size = new System.Drawing.Size(568, 286);
            this.DgvStockPedidoReaprov.TabIndex = 42;
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Enabled = false;
            this.CantidadNumericUpDown.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(167, 281);
            this.CantidadNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.CantidadNumericUpDown.TabIndex = 36;
            this.CantidadNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CantidadNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label4.Location = new System.Drawing.Point(78, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cantidad:";
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.DisplayMember = "cod_pro_stock";
            this.ProductoComboBox.Enabled = false;
            this.ProductoComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(167, 86);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(262, 28);
            this.ProductoComboBox.TabIndex = 34;
            this.ProductoComboBox.ValueMember = "cod_pro_stock";
            this.ProductoComboBox.SelectedValueChanged += new System.EventHandler(this.ProductoComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Producto:";
            // 
            // GenerarPedidosAutoButton
            // 
            this.GenerarPedidosAutoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerarPedidosAutoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerarPedidosAutoButton.Enabled = false;
            this.GenerarPedidosAutoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.GenerarPedidosAutoButton.Image = global::CapaUsuario.Properties.Resources.automatizados80;
            this.GenerarPedidosAutoButton.Location = new System.Drawing.Point(825, 418);
            this.GenerarPedidosAutoButton.Name = "GenerarPedidosAutoButton";
            this.GenerarPedidosAutoButton.Size = new System.Drawing.Size(314, 87);
            this.GenerarPedidosAutoButton.TabIndex = 43;
            this.GenerarPedidosAutoButton.Text = "Generar pedido automatizado";
            this.GenerarPedidosAutoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GenerarPedidosAutoButton.UseVisualStyleBackColor = true;
            this.GenerarPedidosAutoButton.Click += new System.EventHandler(this.GenerarPedidosAutoButton_Click_1);
            // 
            // TabStock
            // 
            this.TabStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabStock.Controls.Add(this.FiltrarStockTextBox);
            this.TabStock.Controls.Add(this.label6);
            this.TabStock.Controls.Add(this.ActualizarListadoStock);
            this.TabStock.Controls.Add(this.DgvStock);
            this.TabStock.Location = new System.Drawing.Point(4, 29);
            this.TabStock.Name = "TabStock";
            this.TabStock.Padding = new System.Windows.Forms.Padding(3);
            this.TabStock.Size = new System.Drawing.Size(1170, 514);
            this.TabStock.TabIndex = 2;
            this.TabStock.Text = "Productos en stock";
            // 
            // FiltrarStockTextBox
            // 
            this.FiltrarStockTextBox.Location = new System.Drawing.Point(191, 27);
            this.FiltrarStockTextBox.Name = "FiltrarStockTextBox";
            this.FiltrarStockTextBox.Size = new System.Drawing.Size(160, 27);
            this.FiltrarStockTextBox.TabIndex = 18;
            this.FiltrarStockTextBox.TextChanged += new System.EventHandler(this.FiltrarStockTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre de producto:";
            // 
            // ActualizarListadoStock
            // 
            this.ActualizarListadoStock.AutoSize = true;
            this.ActualizarListadoStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarListadoStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarListadoStock.Depth = 0;
            this.ActualizarListadoStock.Location = new System.Drawing.Point(413, 22);
            this.ActualizarListadoStock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActualizarListadoStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarListadoStock.Name = "ActualizarListadoStock";
            this.ActualizarListadoStock.Primary = false;
            this.ActualizarListadoStock.Size = new System.Drawing.Size(94, 36);
            this.ActualizarListadoStock.TabIndex = 5;
            this.ActualizarListadoStock.Text = "Actualizar";
            this.ActualizarListadoStock.UseVisualStyleBackColor = true;
            this.ActualizarListadoStock.Click += new System.EventHandler(this.ActualizarListadoStock_Click_1);
            // 
            // DgvStock
            // 
            this.DgvStock.AllowUserToAddRows = false;
            this.DgvStock.AllowUserToDeleteRows = false;
            this.DgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStock.Location = new System.Drawing.Point(8, 76);
            this.DgvStock.MultiSelect = false;
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.ReadOnly = true;
            this.DgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStock.Size = new System.Drawing.Size(1154, 347);
            this.DgvStock.TabIndex = 4;
            // 
            // FrmPedidosReaprov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 591);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmPedidosReaprov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos de Reaprovisionamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedidosReaprov_FormClosing);
            this.Load += new System.EventHandler(this.FrmPedidosReaprov_Load);
            this.SizeChanged += new System.EventHandler(this.FrmPedidosReaprov_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPedidos)).EndInit();
            this.TabNuevo.ResumeLayout(false);
            this.TabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockPedidoReaprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            this.TabStock.ResumeLayout(false);
            this.TabStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprostockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkoptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkcriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codcatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn automatizadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codordcprDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.TabPage TabNuevo;
        private System.Windows.Forms.TabPage TabStock;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton BorrarPedidoButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarPedidoButton;
        private System.Windows.Forms.DataGridView DgvListadoPedidos;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MedidaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorrarTodoButton;
        private System.Windows.Forms.Button BorrarLineaButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GrabarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView DgvStockPedidoReaprov;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerarPedidosAutoButton;
        private System.Windows.Forms.TextBox FiltrarPedidosTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FiltrarStockTextBox;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialFlatButton ActualizarListadoStock;
        private System.Windows.Forms.DataGridView DgvStock;
        private System.Windows.Forms.Button NuevoPedidoButton;
        private System.Windows.Forms.ComboBox ProveedorComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}
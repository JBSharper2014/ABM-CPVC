namespace CapaUsuario.Ventas.Pedido_de_venta
{
    partial class FrmPedidoVenta
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
            this.preciototaltext = new System.Windows.Forms.TabPage();
            this.txtcodpro = new System.Windows.Forms.TextBox();
            this.labelprecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.BorrarTodoButton = new System.Windows.Forms.Button();
            this.BorrarLineaButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GrabarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TabListadoPedidos = new System.Windows.Forms.TabPage();
            this.ModificarPedidoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BorrarPedidoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.TabClientes = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbuscarpornombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CrearPedidoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.preciototaltext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            this.TabListadoPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.TabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1059, 41);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.preciototaltext);
            this.materialTabControl1.Controls.Add(this.TabListadoPedidos);
            this.materialTabControl1.Controls.Add(this.TabClientes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 41);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1059, 521);
            this.materialTabControl1.TabIndex = 1;
            // 
            // preciototaltext
            // 
            this.preciototaltext.Controls.Add(this.txtcodpro);
            this.preciototaltext.Controls.Add(this.labelprecio);
            this.preciototaltext.Controls.Add(this.label3);
            this.preciototaltext.Controls.Add(this.dgvproductos);
            this.preciototaltext.Controls.Add(this.BorrarTodoButton);
            this.preciototaltext.Controls.Add(this.BorrarLineaButton);
            this.preciototaltext.Controls.Add(this.CancelarButton);
            this.preciototaltext.Controls.Add(this.GrabarButton);
            this.preciototaltext.Controls.Add(this.AgregarButton);
            this.preciototaltext.Controls.Add(this.DgvProductosVenta);
            this.preciototaltext.Controls.Add(this.label2);
            this.preciototaltext.Controls.Add(this.CantidadNumericUpDown);
            this.preciototaltext.Controls.Add(this.label1);
            this.preciototaltext.Location = new System.Drawing.Point(4, 29);
            this.preciototaltext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preciototaltext.Name = "preciototaltext";
            this.preciototaltext.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preciototaltext.Size = new System.Drawing.Size(1051, 488);
            this.preciototaltext.TabIndex = 0;
            this.preciototaltext.Text = "Administracion";
            this.preciototaltext.UseVisualStyleBackColor = true;
            // 
            // txtcodpro
            // 
            this.txtcodpro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtcodpro.Location = new System.Drawing.Point(300, 43);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.ReadOnly = true;
            this.txtcodpro.Size = new System.Drawing.Size(148, 27);
            this.txtcodpro.TabIndex = 21;
            this.txtcodpro.TextChanged += new System.EventHandler(this.txtcodpro_TextChanged);
            // 
            // labelprecio
            // 
            this.labelprecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelprecio.AutoSize = true;
            this.labelprecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelprecio.ForeColor = System.Drawing.Color.Green;
            this.labelprecio.Location = new System.Drawing.Point(513, 432);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(17, 20);
            this.labelprecio.TabIndex = 20;
            this.labelprecio.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Precio total";
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.AllowUserToDeleteRows = false;
            this.dgvproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(20, 184);
            this.dgvproductos.MultiSelect = false;
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            this.dgvproductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductos.Size = new System.Drawing.Size(440, 187);
            this.dgvproductos.TabIndex = 18;
            // 
            // BorrarTodoButton
            // 
            this.BorrarTodoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorrarTodoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarTodoButton.Enabled = false;
            this.BorrarTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BorrarTodoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarTodoButton.Image = global::CapaUsuario.Properties.Resources.borrar_todo48x48;
            this.BorrarTodoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BorrarTodoButton.Location = new System.Drawing.Point(466, 211);
            this.BorrarTodoButton.Name = "BorrarTodoButton";
            this.BorrarTodoButton.Size = new System.Drawing.Size(112, 75);
            this.BorrarTodoButton.TabIndex = 17;
            this.BorrarTodoButton.Text = "Borrar todo";
            this.BorrarTodoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip1.SetToolTip(this.BorrarTodoButton, "Borrar todos los prodcutos del pedido");
            this.BorrarTodoButton.UseVisualStyleBackColor = true;
            this.BorrarTodoButton.Click += new System.EventHandler(this.BorrarTodoButton_Click);
            // 
            // BorrarLineaButton
            // 
            this.BorrarLineaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorrarLineaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarLineaButton.Enabled = false;
            this.BorrarLineaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BorrarLineaButton.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarLineaButton.Image = global::CapaUsuario.Properties.Resources.delete_row_32x32;
            this.BorrarLineaButton.Location = new System.Drawing.Point(466, 130);
            this.BorrarLineaButton.Name = "BorrarLineaButton";
            this.BorrarLineaButton.Size = new System.Drawing.Size(112, 75);
            this.BorrarLineaButton.TabIndex = 16;
            this.BorrarLineaButton.Text = "Borrar seleccionado";
            this.BorrarLineaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip1.SetToolTip(this.BorrarLineaButton, "Borrar item de pedido");
            this.BorrarLineaButton.UseVisualStyleBackColor = true;
            this.BorrarLineaButton.Click += new System.EventHandler(this.BorrarLineaButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(466, 292);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(112, 79);
            this.CancelarButton.TabIndex = 15;
            this.CancelarButton.Text = "Cancelar pedido";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip1.SetToolTip(this.CancelarButton, "Cancelar este pedido (cierra el formulario)");
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GrabarButton
            // 
            this.GrabarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrabarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrabarButton.Enabled = false;
            this.GrabarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrabarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrabarButton.Image = global::CapaUsuario.Properties.Resources.cool_save_32;
            this.GrabarButton.Location = new System.Drawing.Point(466, 34);
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(112, 84);
            this.GrabarButton.TabIndex = 14;
            this.GrabarButton.Text = "Grabar pedido";
            this.GrabarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip1.SetToolTip(this.GrabarButton, "Grabar pedido de venta");
            this.GrabarButton.UseVisualStyleBackColor = true;
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarButton.Enabled = false;
            this.AgregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Image = global::CapaUsuario.Properties.Resources.add_light_green_32;
            this.AgregarButton.Location = new System.Drawing.Point(300, 99);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(148, 65);
            this.AgregarButton.TabIndex = 13;
            this.AgregarButton.Text = "Agregar producto";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip1.SetToolTip(this.AgregarButton, "Agregar producto al pedido de venta");
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DgvProductosVenta
            // 
            this.DgvProductosVenta.AllowUserToAddRows = false;
            this.DgvProductosVenta.AllowUserToDeleteRows = false;
            this.DgvProductosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosVenta.Location = new System.Drawing.Point(584, 34);
            this.DgvProductosVenta.MultiSelect = false;
            this.DgvProductosVenta.Name = "DgvProductosVenta";
            this.DgvProductosVenta.ReadOnly = true;
            this.DgvProductosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductosVenta.Size = new System.Drawing.Size(391, 337);
            this.DgvProductosVenta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CantidadNumericUpDown.Enabled = false;
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(125, 128);
            this.CantidadNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.CantidadNumericUpDown.TabIndex = 2;
            this.CantidadNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar producto por nombre";
            // 
            // TabListadoPedidos
            // 
            this.TabListadoPedidos.Controls.Add(this.ModificarPedidoButton);
            this.TabListadoPedidos.Controls.Add(this.BorrarPedidoButton);
            this.TabListadoPedidos.Controls.Add(this.DgvPedidos);
            this.TabListadoPedidos.Location = new System.Drawing.Point(4, 29);
            this.TabListadoPedidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabListadoPedidos.Name = "TabListadoPedidos";
            this.TabListadoPedidos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabListadoPedidos.Size = new System.Drawing.Size(1051, 488);
            this.TabListadoPedidos.TabIndex = 1;
            this.TabListadoPedidos.Text = "Listado de pedidos";
            this.TabListadoPedidos.UseVisualStyleBackColor = true;
            // 
            // ModificarPedidoButton
            // 
            this.ModificarPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModificarPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarPedidoButton.Depth = 0;
            this.ModificarPedidoButton.Location = new System.Drawing.Point(538, 32);
            this.ModificarPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarPedidoButton.Name = "ModificarPedidoButton";
            this.ModificarPedidoButton.Primary = true;
            this.ModificarPedidoButton.Size = new System.Drawing.Size(304, 33);
            this.ModificarPedidoButton.TabIndex = 2;
            this.ModificarPedidoButton.Text = "Administrar productos por pedido";
            this.ModificarPedidoButton.UseVisualStyleBackColor = true;
            this.ModificarPedidoButton.Click += new System.EventHandler(this.ModificarPedidoButton_Click);
            // 
            // BorrarPedidoButton
            // 
            this.BorrarPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarPedidoButton.Depth = 0;
            this.BorrarPedidoButton.Location = new System.Drawing.Point(873, 32);
            this.BorrarPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarPedidoButton.Name = "BorrarPedidoButton";
            this.BorrarPedidoButton.Primary = true;
            this.BorrarPedidoButton.Size = new System.Drawing.Size(124, 33);
            this.BorrarPedidoButton.TabIndex = 1;
            this.BorrarPedidoButton.Text = "Borrar pedido";
            this.BorrarPedidoButton.UseVisualStyleBackColor = true;
            this.BorrarPedidoButton.Click += new System.EventHandler(this.BorrarPedidoButton_Click);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvPedidos.Location = new System.Drawing.Point(8, 90);
            this.DgvPedidos.MultiSelect = false;
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.RowHeadersVisible = false;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(1035, 390);
            this.DgvPedidos.TabIndex = 0;
            // 
            // TabClientes
            // 
            this.TabClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabClientes.Controls.Add(this.label5);
            this.TabClientes.Controls.Add(this.txtbuscarpornombre);
            this.TabClientes.Controls.Add(this.label4);
            this.TabClientes.Controls.Add(this.textBox1);
            this.TabClientes.Controls.Add(this.CrearPedidoButton);
            this.TabClientes.Controls.Add(this.dgvclientes);
            this.TabClientes.Location = new System.Drawing.Point(4, 29);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.TabClientes.Size = new System.Drawing.Size(1051, 488);
            this.TabClientes.TabIndex = 2;
            this.TabClientes.Text = "Listado de clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar por nombre";
            // 
            // txtbuscarpornombre
            // 
            this.txtbuscarpornombre.Location = new System.Drawing.Point(572, 31);
            this.txtbuscarpornombre.Name = "txtbuscarpornombre";
            this.txtbuscarpornombre.Size = new System.Drawing.Size(142, 27);
            this.txtbuscarpornombre.TabIndex = 7;
            this.txtbuscarpornombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buscar por codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CrearPedidoButton
            // 
            this.CrearPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearPedidoButton.AutoSize = true;
            this.CrearPedidoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearPedidoButton.Depth = 0;
            this.CrearPedidoButton.Location = new System.Drawing.Point(856, 30);
            this.CrearPedidoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearPedidoButton.Name = "CrearPedidoButton";
            this.CrearPedidoButton.Primary = false;
            this.CrearPedidoButton.Size = new System.Drawing.Size(106, 36);
            this.CrearPedidoButton.TabIndex = 3;
            this.CrearPedidoButton.Text = "Crear pedido";
            this.CrearPedidoButton.UseVisualStyleBackColor = true;
            this.CrearPedidoButton.Click += new System.EventHandler(this.CrearPedidoButton_Click);
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToAddRows = false;
            this.dgvclientes.AllowUserToDeleteRows = false;
            this.dgvclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(10, 85);
            this.dgvclientes.MultiSelect = false;
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.ReadOnly = true;
            this.dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclientes.Size = new System.Drawing.Size(1033, 380);
            this.dgvclientes.TabIndex = 1;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPedidoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 562);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPedidoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedidoVenta_FormClosing);
            this.Load += new System.EventHandler(this.FrmPedidoVenta_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.preciototaltext.ResumeLayout(false);
            this.preciototaltext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            this.TabListadoPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.TabClientes.ResumeLayout(false);
            this.TabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage preciototaltext;
        private System.Windows.Forms.TabPage TabListadoPedidos;
        private System.Windows.Forms.TabPage TabClientes;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.DataGridView dgvclientes;
        private MaterialSkin.Controls.MaterialFlatButton CrearPedidoButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarPedidoButton;
        private MaterialSkin.Controls.MaterialRaisedButton BorrarPedidoButton;
        private System.Windows.Forms.DataGridView DgvProductosVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorrarTodoButton;
        private System.Windows.Forms.Button BorrarLineaButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GrabarButton;
        private System.Windows.Forms.Button AgregarButton;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.TextBox txtcodpro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbuscarpornombre;
    }
}
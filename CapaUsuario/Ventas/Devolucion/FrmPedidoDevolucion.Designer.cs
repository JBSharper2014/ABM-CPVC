namespace CapaUsuario.Ventas.Devolucion
{
    partial class FrmPedidoDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoDevolucion));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.CodPedidoBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarPedidoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvListadoPedidos = new System.Windows.Forms.DataGridView();
            this.TabNuevo = new System.Windows.Forms.TabPage();
            this.txtcantidadadevolver = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproductoseleccionado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProductosPorRemito = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.DevProductoRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.DevCreditoRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.ProblemasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabListadoRemitos = new System.Windows.Forms.TabPage();
            this.CodClienteBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodRemitoBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CrearPedidoDevButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvListadoRemitos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarCambiosButton = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPedidos)).BeginInit();
            this.TabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPorRemito)).BeginInit();
            this.TabListadoRemitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRemitos)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1078, 43);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Controls.Add(this.TabNuevo);
            this.materialTabControl1.Controls.Add(this.TabListadoRemitos);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 43);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1078, 482);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListado
            // 
            this.TabListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListado.Controls.Add(this.CodPedidoBusquedaTextBox);
            this.TabListado.Controls.Add(this.label1);
            this.TabListado.Controls.Add(this.BorrarPedidoButton);
            this.TabListado.Controls.Add(this.DgvListadoPedidos);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(1070, 449);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "Listado de pedidos";
            // 
            // CodPedidoBusquedaTextBox
            // 
            this.CodPedidoBusquedaTextBox.Location = new System.Drawing.Point(205, 39);
            this.CodPedidoBusquedaTextBox.Name = "CodPedidoBusquedaTextBox";
            this.CodPedidoBusquedaTextBox.Size = new System.Drawing.Size(140, 27);
            this.CodPedidoBusquedaTextBox.TabIndex = 3;
            this.CodPedidoBusquedaTextBox.TextChanged += new System.EventHandler(this.CodPedidoBusquedaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de devolucion";
            // 
            // BorrarPedidoButton
            // 
            this.BorrarPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarPedidoButton.AutoSize = true;
            this.BorrarPedidoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarPedidoButton.Depth = 0;
            this.BorrarPedidoButton.Location = new System.Drawing.Point(894, 34);
            this.BorrarPedidoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarPedidoButton.Name = "BorrarPedidoButton";
            this.BorrarPedidoButton.Primary = false;
            this.BorrarPedidoButton.Size = new System.Drawing.Size(116, 36);
            this.BorrarPedidoButton.TabIndex = 1;
            this.BorrarPedidoButton.Text = "Borrar pedido";
            this.BorrarPedidoButton.UseVisualStyleBackColor = true;
            this.BorrarPedidoButton.Click += new System.EventHandler(this.BorrarPedidoButton_Click);
            // 
            // DgvListadoPedidos
            // 
            this.DgvListadoPedidos.AllowUserToAddRows = false;
            this.DgvListadoPedidos.AllowUserToDeleteRows = false;
            this.DgvListadoPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoPedidos.Location = new System.Drawing.Point(8, 89);
            this.DgvListadoPedidos.MultiSelect = false;
            this.DgvListadoPedidos.Name = "DgvListadoPedidos";
            this.DgvListadoPedidos.ReadOnly = true;
            this.DgvListadoPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoPedidos.Size = new System.Drawing.Size(1054, 347);
            this.DgvListadoPedidos.TabIndex = 0;
            // 
            // TabNuevo
            // 
            this.TabNuevo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabNuevo.Controls.Add(this.txtcantidadadevolver);
            this.TabNuevo.Controls.Add(this.label9);
            this.TabNuevo.Controls.Add(this.txtproductoseleccionado);
            this.TabNuevo.Controls.Add(this.label8);
            this.TabNuevo.Controls.Add(this.dgvProductosPorRemito);
            this.TabNuevo.Controls.Add(this.CancelarButton);
            this.TabNuevo.Controls.Add(this.GuardarCambiosButton);
            this.TabNuevo.Controls.Add(this.label7);
            this.TabNuevo.Controls.Add(this.DevProductoRadioButton);
            this.TabNuevo.Controls.Add(this.label6);
            this.TabNuevo.Controls.Add(this.DevCreditoRadioButton);
            this.TabNuevo.Controls.Add(this.ProblemasTextBox);
            this.TabNuevo.Controls.Add(this.label5);
            this.TabNuevo.Controls.Add(this.label4);
            this.TabNuevo.Location = new System.Drawing.Point(4, 29);
            this.TabNuevo.Name = "TabNuevo";
            this.TabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.TabNuevo.Size = new System.Drawing.Size(1070, 449);
            this.TabNuevo.TabIndex = 1;
            this.TabNuevo.Text = "Nuevo pedido";
            // 
            // txtcantidadadevolver
            // 
            this.txtcantidadadevolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcantidadadevolver.Location = new System.Drawing.Point(522, 232);
            this.txtcantidadadevolver.Name = "txtcantidadadevolver";
            this.txtcantidadadevolver.Size = new System.Drawing.Size(95, 27);
            this.txtcantidadadevolver.TabIndex = 14;
            this.txtcantidadadevolver.TextChanged += new System.EventHandler(this.txtcantidadadevolver_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cantidad a devolver:";
            // 
            // txtproductoseleccionado
            // 
            this.txtproductoseleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproductoseleccionado.Location = new System.Drawing.Point(225, 232);
            this.txtproductoseleccionado.Name = "txtproductoseleccionado";
            this.txtproductoseleccionado.ReadOnly = true;
            this.txtproductoseleccionado.Size = new System.Drawing.Size(95, 27);
            this.txtproductoseleccionado.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Producto seleccionado:";
            // 
            // dgvProductosPorRemito
            // 
            this.dgvProductosPorRemito.AllowUserToAddRows = false;
            this.dgvProductosPorRemito.AllowUserToDeleteRows = false;
            this.dgvProductosPorRemito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvProductosPorRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosPorRemito.Location = new System.Drawing.Point(62, 50);
            this.dgvProductosPorRemito.MultiSelect = false;
            this.dgvProductosPorRemito.Name = "dgvProductosPorRemito";
            this.dgvProductosPorRemito.ReadOnly = true;
            this.dgvProductosPorRemito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosPorRemito.Size = new System.Drawing.Size(456, 158);
            this.dgvProductosPorRemito.TabIndex = 10;
            this.dgvProductosPorRemito.SelectionChanged += new System.EventHandler(this.dgvProductosPorRemito_SelectionChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Devolución por producto";
            // 
            // DevProductoRadioButton
            // 
            this.DevProductoRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DevProductoRadioButton.AutoSize = true;
            this.DevProductoRadioButton.Depth = 0;
            this.DevProductoRadioButton.Enabled = false;
            this.DevProductoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DevProductoRadioButton.Location = new System.Drawing.Point(739, 102);
            this.DevProductoRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.DevProductoRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DevProductoRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DevProductoRadioButton.Name = "DevProductoRadioButton";
            this.DevProductoRadioButton.Ripple = true;
            this.DevProductoRadioButton.Size = new System.Drawing.Size(25, 30);
            this.DevProductoRadioButton.TabIndex = 6;
            this.DevProductoRadioButton.TabStop = true;
            this.DevProductoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Devolución por crédito";
            // 
            // DevCreditoRadioButton
            // 
            this.DevCreditoRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DevCreditoRadioButton.AutoSize = true;
            this.DevCreditoRadioButton.Depth = 0;
            this.DevCreditoRadioButton.Enabled = false;
            this.DevCreditoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DevCreditoRadioButton.Location = new System.Drawing.Point(739, 56);
            this.DevCreditoRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.DevCreditoRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DevCreditoRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DevCreditoRadioButton.Name = "DevCreditoRadioButton";
            this.DevCreditoRadioButton.Ripple = true;
            this.DevCreditoRadioButton.Size = new System.Drawing.Size(25, 30);
            this.DevCreditoRadioButton.TabIndex = 4;
            this.DevCreditoRadioButton.TabStop = true;
            this.DevCreditoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProblemasTextBox
            // 
            this.ProblemasTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.ProblemasTextBox, 5);
            this.ProblemasTextBox.Location = new System.Drawing.Point(62, 309);
            this.ProblemasTextBox.Multiline = true;
            this.ProblemasTextBox.Name = "ProblemasTextBox";
            this.ProblemasTextBox.ReadOnly = true;
            this.ProblemasTextBox.Size = new System.Drawing.Size(815, 93);
            this.ProblemasTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Problemas encontrados:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Productos en remito seleccionado";
            // 
            // TabListadoRemitos
            // 
            this.TabListadoRemitos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListadoRemitos.Controls.Add(this.CodClienteBusquedaTextBox);
            this.TabListadoRemitos.Controls.Add(this.label3);
            this.TabListadoRemitos.Controls.Add(this.CodRemitoBusquedaTextBox);
            this.TabListadoRemitos.Controls.Add(this.label2);
            this.TabListadoRemitos.Controls.Add(this.CrearPedidoDevButton);
            this.TabListadoRemitos.Controls.Add(this.DgvListadoRemitos);
            this.TabListadoRemitos.Location = new System.Drawing.Point(4, 29);
            this.TabListadoRemitos.Name = "TabListadoRemitos";
            this.TabListadoRemitos.Padding = new System.Windows.Forms.Padding(3);
            this.TabListadoRemitos.Size = new System.Drawing.Size(1070, 449);
            this.TabListadoRemitos.TabIndex = 2;
            this.TabListadoRemitos.Text = "Listado de remitos";
            // 
            // CodClienteBusquedaTextBox
            // 
            this.CodClienteBusquedaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CodClienteBusquedaTextBox.Location = new System.Drawing.Point(561, 38);
            this.CodClienteBusquedaTextBox.Name = "CodClienteBusquedaTextBox";
            this.CodClienteBusquedaTextBox.Size = new System.Drawing.Size(140, 27);
            this.CodClienteBusquedaTextBox.TabIndex = 7;
            this.CodClienteBusquedaTextBox.TextChanged += new System.EventHandler(this.CodClienteBusquedaTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtrar por nombre de cliente";
            // 
            // CodRemitoBusquedaTextBox
            // 
            this.CodRemitoBusquedaTextBox.Location = new System.Drawing.Point(154, 38);
            this.CodRemitoBusquedaTextBox.Name = "CodRemitoBusquedaTextBox";
            this.CodRemitoBusquedaTextBox.Size = new System.Drawing.Size(140, 27);
            this.CodRemitoBusquedaTextBox.TabIndex = 5;
            this.CodRemitoBusquedaTextBox.TextChanged += new System.EventHandler(this.CodRemitoBusquedaTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código de remito:";
            // 
            // CrearPedidoDevButton
            // 
            this.CrearPedidoDevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearPedidoDevButton.AutoSize = true;
            this.CrearPedidoDevButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearPedidoDevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearPedidoDevButton.Depth = 0;
            this.CrearPedidoDevButton.Location = new System.Drawing.Point(821, 33);
            this.CrearPedidoDevButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearPedidoDevButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearPedidoDevButton.Name = "CrearPedidoDevButton";
            this.CrearPedidoDevButton.Primary = false;
            this.CrearPedidoDevButton.Size = new System.Drawing.Size(213, 36);
            this.CrearPedidoDevButton.TabIndex = 2;
            this.CrearPedidoDevButton.Text = "Crear pedido de devolucion";
            this.CrearPedidoDevButton.UseVisualStyleBackColor = true;
            this.CrearPedidoDevButton.Click += new System.EventHandler(this.CrearPedidoDevButton_Click);
            // 
            // DgvListadoRemitos
            // 
            this.DgvListadoRemitos.AllowUserToAddRows = false;
            this.DgvListadoRemitos.AllowUserToDeleteRows = false;
            this.DgvListadoRemitos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoRemitos.Location = new System.Drawing.Point(8, 87);
            this.DgvListadoRemitos.MultiSelect = false;
            this.DgvListadoRemitos.Name = "DgvListadoRemitos";
            this.DgvListadoRemitos.ReadOnly = true;
            this.DgvListadoRemitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoRemitos.Size = new System.Drawing.Size(1054, 354);
            this.DgvListadoRemitos.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(720, 154);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarCambiosButton
            // 
            this.GuardarCambiosButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarCambiosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarCambiosButton.Enabled = false;
            this.GuardarCambiosButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarCambiosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GuardarCambiosButton.Location = new System.Drawing.Point(555, 154);
            this.GuardarCambiosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarCambiosButton.Name = "GuardarCambiosButton";
            this.GuardarCambiosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarCambiosButton.TabIndex = 9;
            this.GuardarCambiosButton.Text = "Guardar datos";
            this.GuardarCambiosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarCambiosButton.UseVisualStyleBackColor = true;
            this.GuardarCambiosButton.Click += new System.EventHandler(this.GuardarCambiosButton_Click);
            // 
            // FrmPedidoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 525);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPedidoDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos de Devolucion";
            this.Load += new System.EventHandler(this.FrmPedidoDevolucion_Load);
            this.SizeChanged += new System.EventHandler(this.FrmPedidoDevolucion_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPedidos)).EndInit();
            this.TabNuevo.ResumeLayout(false);
            this.TabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPorRemito)).EndInit();
            this.TabListadoRemitos.ResumeLayout(false);
            this.TabListadoRemitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRemitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListado;
        private MaterialSkin.Controls.MaterialFlatButton BorrarPedidoButton;
        private System.Windows.Forms.DataGridView DgvListadoPedidos;
        private System.Windows.Forms.TabPage TabNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodPedidoBusquedaTextBox;
        private System.Windows.Forms.TabPage TabListadoRemitos;
        private MaterialSkin.Controls.MaterialFlatButton CrearPedidoDevButton;
        private System.Windows.Forms.DataGridView DgvListadoRemitos;
        private System.Windows.Forms.TextBox CodClienteBusquedaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodRemitoBusquedaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialRadioButton DevProductoRadioButton;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRadioButton DevCreditoRadioButton;
        private System.Windows.Forms.TextBox ProblemasTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarCambiosButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvProductosPorRemito;
        private System.Windows.Forms.TextBox txtcantidadadevolver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtproductoseleccionado;
        private System.Windows.Forms.Label label8;
    }
}
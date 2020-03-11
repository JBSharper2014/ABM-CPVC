namespace CapaUsuario.Compras.Orden_de_Compra
{
    partial class FrmOrdenDeCompra
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SolicitudRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.PedidoRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.EmitirButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BorrarOrdenButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CrearOrdenPedidoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CrearOrdenSolicitudButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.CancelarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConfirmarOrdenButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Dgv2 = new System.Windows.Forms.DataGridView();
            this.DgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesCompra)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).BeginInit();
            this.TabNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleCompra)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1061, 47);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 47);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1061, 457);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SolicitudRadioButton);
            this.tabPage1.Controls.Add(this.PedidoRadioButton);
            this.tabPage1.Controls.Add(this.EmitirButton);
            this.tabPage1.Controls.Add(this.BorrarOrdenButton);
            this.tabPage1.Controls.Add(this.DgvOrdenesCompra);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solicitudes de compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pedidos de reapov.";
            // 
            // SolicitudRadioButton
            // 
            this.SolicitudRadioButton.AutoSize = true;
            this.SolicitudRadioButton.Depth = 0;
            this.SolicitudRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.SolicitudRadioButton.Location = new System.Drawing.Point(273, 47);
            this.SolicitudRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.SolicitudRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SolicitudRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SolicitudRadioButton.Name = "SolicitudRadioButton";
            this.SolicitudRadioButton.Ripple = true;
            this.SolicitudRadioButton.Size = new System.Drawing.Size(25, 30);
            this.SolicitudRadioButton.TabIndex = 4;
            this.SolicitudRadioButton.TabStop = true;
            this.SolicitudRadioButton.UseVisualStyleBackColor = true;
            this.SolicitudRadioButton.CheckedChanged += new System.EventHandler(this.SolicitudRadioButton_CheckedChanged);
            // 
            // PedidoRadioButton
            // 
            this.PedidoRadioButton.AutoSize = true;
            this.PedidoRadioButton.Depth = 0;
            this.PedidoRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.PedidoRadioButton.Location = new System.Drawing.Point(58, 47);
            this.PedidoRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.PedidoRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PedidoRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PedidoRadioButton.Name = "PedidoRadioButton";
            this.PedidoRadioButton.Ripple = true;
            this.PedidoRadioButton.Size = new System.Drawing.Size(25, 30);
            this.PedidoRadioButton.TabIndex = 3;
            this.PedidoRadioButton.TabStop = true;
            this.PedidoRadioButton.UseVisualStyleBackColor = true;
            this.PedidoRadioButton.CheckedChanged += new System.EventHandler(this.PedidoRadioButton_CheckedChanged);
            // 
            // EmitirButton
            // 
            this.EmitirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmitirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmitirButton.Depth = 0;
            this.EmitirButton.Location = new System.Drawing.Point(894, 44);
            this.EmitirButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmitirButton.Name = "EmitirButton";
            this.EmitirButton.Primary = true;
            this.EmitirButton.Size = new System.Drawing.Size(94, 36);
            this.EmitirButton.TabIndex = 2;
            this.EmitirButton.Text = "Emitir";
            this.EmitirButton.UseVisualStyleBackColor = true;
            this.EmitirButton.Click += new System.EventHandler(this.EmitirButton_Click);
            // 
            // BorrarOrdenButton
            // 
            this.BorrarOrdenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarOrdenButton.AutoSize = true;
            this.BorrarOrdenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarOrdenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarOrdenButton.Depth = 0;
            this.BorrarOrdenButton.Location = new System.Drawing.Point(769, 44);
            this.BorrarOrdenButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarOrdenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarOrdenButton.Name = "BorrarOrdenButton";
            this.BorrarOrdenButton.Primary = false;
            this.BorrarOrdenButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarOrdenButton.TabIndex = 1;
            this.BorrarOrdenButton.Text = "Borrar";
            this.BorrarOrdenButton.UseVisualStyleBackColor = true;
            this.BorrarOrdenButton.Click += new System.EventHandler(this.BorrarOrdenButton_Click);
            // 
            // DgvOrdenesCompra
            // 
            this.DgvOrdenesCompra.AllowUserToAddRows = false;
            this.DgvOrdenesCompra.AllowUserToDeleteRows = false;
            this.DgvOrdenesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenesCompra.Location = new System.Drawing.Point(8, 101);
            this.DgvOrdenesCompra.MultiSelect = false;
            this.DgvOrdenesCompra.Name = "DgvOrdenesCompra";
            this.DgvOrdenesCompra.ReadOnly = true;
            this.DgvOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrdenesCompra.Size = new System.Drawing.Size(1037, 315);
            this.DgvOrdenesCompra.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CrearOrdenPedidoButton);
            this.tabPage2.Controls.Add(this.DgvPedidos);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1053, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedidos de reaprovisionamiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenPedidoButton
            // 
            this.CrearOrdenPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearOrdenPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearOrdenPedidoButton.Depth = 0;
            this.CrearOrdenPedidoButton.Location = new System.Drawing.Point(791, 44);
            this.CrearOrdenPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearOrdenPedidoButton.Name = "CrearOrdenPedidoButton";
            this.CrearOrdenPedidoButton.Primary = true;
            this.CrearOrdenPedidoButton.Size = new System.Drawing.Size(197, 36);
            this.CrearOrdenPedidoButton.TabIndex = 3;
            this.CrearOrdenPedidoButton.Text = "Crear orden de compra";
            this.CrearOrdenPedidoButton.UseVisualStyleBackColor = true;
            this.CrearOrdenPedidoButton.Click += new System.EventHandler(this.CrearOrdenPedidoButton_Click);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Location = new System.Drawing.Point(8, 101);
            this.DgvPedidos.MultiSelect = false;
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(1037, 315);
            this.DgvPedidos.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CrearOrdenSolicitudButton);
            this.tabPage3.Controls.Add(this.DgvSolicitudes);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1053, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Solicitudes de compra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenSolicitudButton
            // 
            this.CrearOrdenSolicitudButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearOrdenSolicitudButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearOrdenSolicitudButton.Depth = 0;
            this.CrearOrdenSolicitudButton.Location = new System.Drawing.Point(791, 44);
            this.CrearOrdenSolicitudButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearOrdenSolicitudButton.Name = "CrearOrdenSolicitudButton";
            this.CrearOrdenSolicitudButton.Primary = true;
            this.CrearOrdenSolicitudButton.Size = new System.Drawing.Size(197, 36);
            this.CrearOrdenSolicitudButton.TabIndex = 4;
            this.CrearOrdenSolicitudButton.Text = "Crear orden de compra";
            this.CrearOrdenSolicitudButton.UseVisualStyleBackColor = true;
            this.CrearOrdenSolicitudButton.Click += new System.EventHandler(this.CrearOrdenSolicitudButton_Click);
            // 
            // DgvSolicitudes
            // 
            this.DgvSolicitudes.AllowUserToAddRows = false;
            this.DgvSolicitudes.AllowUserToDeleteRows = false;
            this.DgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSolicitudes.Location = new System.Drawing.Point(8, 101);
            this.DgvSolicitudes.MultiSelect = false;
            this.DgvSolicitudes.Name = "DgvSolicitudes";
            this.DgvSolicitudes.ReadOnly = true;
            this.DgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSolicitudes.Size = new System.Drawing.Size(1037, 315);
            this.DgvSolicitudes.TabIndex = 2;
            // 
            // TabNueva
            // 
            this.TabNueva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabNueva.Controls.Add(this.CancelarButton);
            this.TabNueva.Controls.Add(this.ConfirmarOrdenButton);
            this.TabNueva.Controls.Add(this.Dgv2);
            this.TabNueva.Controls.Add(this.DgvDetalleCompra);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(1053, 424);
            this.TabNueva.TabIndex = 3;
            this.TabNueva.Text = "Nueva orden de compra";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.AutoSize = true;
            this.CancelarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.Depth = 0;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(372, 345);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Primary = false;
            this.CancelarButton.Size = new System.Drawing.Size(82, 36);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ConfirmarOrdenButton
            // 
            this.ConfirmarOrdenButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmarOrdenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmarOrdenButton.Depth = 0;
            this.ConfirmarOrdenButton.Enabled = false;
            this.ConfirmarOrdenButton.Location = new System.Drawing.Point(518, 339);
            this.ConfirmarOrdenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmarOrdenButton.Name = "ConfirmarOrdenButton";
            this.ConfirmarOrdenButton.Primary = true;
            this.ConfirmarOrdenButton.Size = new System.Drawing.Size(223, 49);
            this.ConfirmarOrdenButton.TabIndex = 2;
            this.ConfirmarOrdenButton.Text = "Confirmar orden de compra";
            this.ConfirmarOrdenButton.UseVisualStyleBackColor = true;
            this.ConfirmarOrdenButton.Click += new System.EventHandler(this.ConfirmarOrdenButton_Click);
            // 
            // Dgv2
            // 
            this.Dgv2.AllowUserToAddRows = false;
            this.Dgv2.AllowUserToDeleteRows = false;
            this.Dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv2.Location = new System.Drawing.Point(559, 47);
            this.Dgv2.MultiSelect = false;
            this.Dgv2.Name = "Dgv2";
            this.Dgv2.ReadOnly = true;
            this.Dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv2.Size = new System.Drawing.Size(445, 214);
            this.Dgv2.TabIndex = 1;
            // 
            // DgvDetalleCompra
            // 
            this.DgvDetalleCompra.AllowUserToAddRows = false;
            this.DgvDetalleCompra.AllowUserToDeleteRows = false;
            this.DgvDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleCompra.Location = new System.Drawing.Point(39, 47);
            this.DgvDetalleCompra.MultiSelect = false;
            this.DgvDetalleCompra.Name = "DgvDetalleCompra";
            this.DgvDetalleCompra.ReadOnly = true;
            this.DgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalleCompra.Size = new System.Drawing.Size(445, 214);
            this.DgvDetalleCompra.TabIndex = 0;
            this.DgvDetalleCompra.SelectionChanged += new System.EventHandler(this.DgvDetalleCompra_SelectionChanged);
            // 
            // FrmOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 504);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrdenDeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.FrmOrdenDeCompra_Load);
            this.SizeChanged += new System.EventHandler(this.FrmOrdenDeCompra_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesCompra)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn codprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn automatizadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codordcprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codordcprDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codordcprDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emitidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage TabNueva;
        private MaterialSkin.Controls.MaterialRadioButton SolicitudRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton PedidoRadioButton;
        private MaterialSkin.Controls.MaterialRaisedButton EmitirButton;
        private MaterialSkin.Controls.MaterialFlatButton BorrarOrdenButton;
        private System.Windows.Forms.DataGridView DgvOrdenesCompra;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.DataGridView DgvSolicitudes;
        private MaterialSkin.Controls.MaterialRaisedButton CrearOrdenPedidoButton;
        private MaterialSkin.Controls.MaterialRaisedButton CrearOrdenSolicitudButton;
        private System.Windows.Forms.DataGridView Dgv2;
        private System.Windows.Forms.DataGridView DgvDetalleCompra;
        private MaterialSkin.Controls.MaterialFlatButton CancelarButton;
        private MaterialSkin.Controls.MaterialRaisedButton ConfirmarOrdenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
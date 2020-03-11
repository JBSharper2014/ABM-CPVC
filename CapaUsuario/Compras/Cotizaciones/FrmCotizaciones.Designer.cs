namespace CapaUsuario.Cotizaciones
{
    partial class FrmCotizaciones
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.CotizarProductoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvProductosPorCotizar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TabSolicitudes = new System.Windows.Forms.TabPage();
            this.AgregarCotizacionSolicitudButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.TabPedidos = new System.Windows.Forms.TabPage();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.AgregarCotizacionPedidoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabCotizacionesPedido = new System.Windows.Forms.TabPage();
            this.BorrarCotizacionPedidoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvCotizacionesPedidos = new System.Windows.Forms.DataGridView();
            this.TabCotizacionesSolicitud = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvCotizacionesSolicitud = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.TabNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosPorCotizar)).BeginInit();
            this.TabSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).BeginInit();
            this.TabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.TabCotizacionesPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCotizacionesPedidos)).BeginInit();
            this.TabCotizacionesSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCotizacionesSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Controls.Add(this.TabSolicitudes);
            this.materialTabControl1.Controls.Add(this.TabPedidos);
            this.materialTabControl1.Controls.Add(this.TabCotizacionesPedido);
            this.materialTabControl1.Controls.Add(this.TabCotizacionesSolicitud);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1082, 532);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabNueva
            // 
            this.TabNueva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabNueva.Controls.Add(this.CotizarProductoButton);
            this.TabNueva.Controls.Add(this.DgvProductosPorCotizar);
            this.TabNueva.Controls.Add(this.label2);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(1074, 499);
            this.TabNueva.TabIndex = 0;
            this.TabNueva.Text = "Nueva cotización";
            // 
            // CotizarProductoButton
            // 
            this.CotizarProductoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CotizarProductoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CotizarProductoButton.Depth = 0;
            this.CotizarProductoButton.Enabled = false;
            this.CotizarProductoButton.Location = new System.Drawing.Point(471, 426);
            this.CotizarProductoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CotizarProductoButton.Name = "CotizarProductoButton";
            this.CotizarProductoButton.Primary = true;
            this.CotizarProductoButton.Size = new System.Drawing.Size(157, 37);
            this.CotizarProductoButton.TabIndex = 4;
            this.CotizarProductoButton.Text = "Cotizar producto";
            this.CotizarProductoButton.UseVisualStyleBackColor = true;
            this.CotizarProductoButton.Click += new System.EventHandler(this.CotizarProductoButton_Click);
            // 
            // DgvProductosPorCotizar
            // 
            this.DgvProductosPorCotizar.AllowUserToAddRows = false;
            this.DgvProductosPorCotizar.AllowUserToDeleteRows = false;
            this.DgvProductosPorCotizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProductosPorCotizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosPorCotizar.Location = new System.Drawing.Point(296, 128);
            this.DgvProductosPorCotizar.MultiSelect = false;
            this.DgvProductosPorCotizar.Name = "DgvProductosPorCotizar";
            this.DgvProductosPorCotizar.ReadOnly = true;
            this.DgvProductosPorCotizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductosPorCotizar.Size = new System.Drawing.Size(503, 250);
            this.DgvProductosPorCotizar.TabIndex = 3;
            this.DgvProductosPorCotizar.SelectionChanged += new System.EventHandler(this.DgvProductosPorCotizar_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el producto a cotizar:";
            // 
            // TabSolicitudes
            // 
            this.TabSolicitudes.Controls.Add(this.AgregarCotizacionSolicitudButton);
            this.TabSolicitudes.Controls.Add(this.DgvSolicitudes);
            this.TabSolicitudes.Location = new System.Drawing.Point(4, 29);
            this.TabSolicitudes.Name = "TabSolicitudes";
            this.TabSolicitudes.Padding = new System.Windows.Forms.Padding(3);
            this.TabSolicitudes.Size = new System.Drawing.Size(1074, 499);
            this.TabSolicitudes.TabIndex = 1;
            this.TabSolicitudes.Text = "Solicitudes de compra";
            this.TabSolicitudes.UseVisualStyleBackColor = true;
            // 
            // AgregarCotizacionSolicitudButton
            // 
            this.AgregarCotizacionSolicitudButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarCotizacionSolicitudButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarCotizacionSolicitudButton.Depth = 0;
            this.AgregarCotizacionSolicitudButton.Location = new System.Drawing.Point(858, 60);
            this.AgregarCotizacionSolicitudButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarCotizacionSolicitudButton.Name = "AgregarCotizacionSolicitudButton";
            this.AgregarCotizacionSolicitudButton.Primary = true;
            this.AgregarCotizacionSolicitudButton.Size = new System.Drawing.Size(167, 40);
            this.AgregarCotizacionSolicitudButton.TabIndex = 3;
            this.AgregarCotizacionSolicitudButton.Text = "Agregar cotizacion";
            this.AgregarCotizacionSolicitudButton.UseVisualStyleBackColor = true;
            this.AgregarCotizacionSolicitudButton.Click += new System.EventHandler(this.AgregarCotizacionSolicitudButton_Click);
            // 
            // DgvSolicitudes
            // 
            this.DgvSolicitudes.AllowUserToAddRows = false;
            this.DgvSolicitudes.AllowUserToDeleteRows = false;
            this.DgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSolicitudes.Location = new System.Drawing.Point(8, 116);
            this.DgvSolicitudes.MultiSelect = false;
            this.DgvSolicitudes.Name = "DgvSolicitudes";
            this.DgvSolicitudes.ReadOnly = true;
            this.DgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSolicitudes.Size = new System.Drawing.Size(1058, 375);
            this.DgvSolicitudes.TabIndex = 2;
            // 
            // TabPedidos
            // 
            this.TabPedidos.Controls.Add(this.DgvPedidos);
            this.TabPedidos.Controls.Add(this.AgregarCotizacionPedidoButton);
            this.TabPedidos.Location = new System.Drawing.Point(4, 29);
            this.TabPedidos.Name = "TabPedidos";
            this.TabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPedidos.Size = new System.Drawing.Size(1074, 499);
            this.TabPedidos.TabIndex = 2;
            this.TabPedidos.Text = "Pedidos de reaprovisionamiento";
            this.TabPedidos.UseVisualStyleBackColor = true;
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Location = new System.Drawing.Point(8, 116);
            this.DgvPedidos.MultiSelect = false;
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(1058, 375);
            this.DgvPedidos.TabIndex = 5;
            // 
            // AgregarCotizacionPedidoButton
            // 
            this.AgregarCotizacionPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarCotizacionPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarCotizacionPedidoButton.Depth = 0;
            this.AgregarCotizacionPedidoButton.Location = new System.Drawing.Point(858, 60);
            this.AgregarCotizacionPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarCotizacionPedidoButton.Name = "AgregarCotizacionPedidoButton";
            this.AgregarCotizacionPedidoButton.Primary = true;
            this.AgregarCotizacionPedidoButton.Size = new System.Drawing.Size(167, 40);
            this.AgregarCotizacionPedidoButton.TabIndex = 4;
            this.AgregarCotizacionPedidoButton.Text = "Agregar cotizacion";
            this.AgregarCotizacionPedidoButton.UseVisualStyleBackColor = true;
            this.AgregarCotizacionPedidoButton.Click += new System.EventHandler(this.AgregarCotizacionPedidoButton_Click);
            // 
            // TabCotizacionesPedido
            // 
            this.TabCotizacionesPedido.Controls.Add(this.BorrarCotizacionPedidoButton);
            this.TabCotizacionesPedido.Controls.Add(this.DgvCotizacionesPedidos);
            this.TabCotizacionesPedido.Location = new System.Drawing.Point(4, 29);
            this.TabCotizacionesPedido.Name = "TabCotizacionesPedido";
            this.TabCotizacionesPedido.Padding = new System.Windows.Forms.Padding(3);
            this.TabCotizacionesPedido.Size = new System.Drawing.Size(1074, 499);
            this.TabCotizacionesPedido.TabIndex = 3;
            this.TabCotizacionesPedido.Text = "Cotizaciones por pedido";
            this.TabCotizacionesPedido.UseVisualStyleBackColor = true;
            // 
            // BorrarCotizacionPedidoButton
            // 
            this.BorrarCotizacionPedidoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarCotizacionPedidoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarCotizacionPedidoButton.Depth = 0;
            this.BorrarCotizacionPedidoButton.Location = new System.Drawing.Point(827, 61);
            this.BorrarCotizacionPedidoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarCotizacionPedidoButton.Name = "BorrarCotizacionPedidoButton";
            this.BorrarCotizacionPedidoButton.Primary = true;
            this.BorrarCotizacionPedidoButton.Size = new System.Drawing.Size(172, 39);
            this.BorrarCotizacionPedidoButton.TabIndex = 4;
            this.BorrarCotizacionPedidoButton.Text = "Borrar cotizacion";
            this.BorrarCotizacionPedidoButton.UseVisualStyleBackColor = true;
            this.BorrarCotizacionPedidoButton.Click += new System.EventHandler(this.BorrarCotizacionPedidoButton_Click);
            // 
            // DgvCotizacionesPedidos
            // 
            this.DgvCotizacionesPedidos.AllowUserToAddRows = false;
            this.DgvCotizacionesPedidos.AllowUserToDeleteRows = false;
            this.DgvCotizacionesPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCotizacionesPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCotizacionesPedidos.Location = new System.Drawing.Point(8, 116);
            this.DgvCotizacionesPedidos.MultiSelect = false;
            this.DgvCotizacionesPedidos.Name = "DgvCotizacionesPedidos";
            this.DgvCotizacionesPedidos.ReadOnly = true;
            this.DgvCotizacionesPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCotizacionesPedidos.Size = new System.Drawing.Size(1058, 364);
            this.DgvCotizacionesPedidos.TabIndex = 3;
            // 
            // TabCotizacionesSolicitud
            // 
            this.TabCotizacionesSolicitud.Controls.Add(this.materialRaisedButton1);
            this.TabCotizacionesSolicitud.Controls.Add(this.DgvCotizacionesSolicitud);
            this.TabCotizacionesSolicitud.Location = new System.Drawing.Point(4, 29);
            this.TabCotizacionesSolicitud.Name = "TabCotizacionesSolicitud";
            this.TabCotizacionesSolicitud.Padding = new System.Windows.Forms.Padding(3);
            this.TabCotizacionesSolicitud.Size = new System.Drawing.Size(1074, 499);
            this.TabCotizacionesSolicitud.TabIndex = 4;
            this.TabCotizacionesSolicitud.Text = "Cotizaciones por solicitud";
            this.TabCotizacionesSolicitud.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(827, 61);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(172, 39);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Borrar cotizacion";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // DgvCotizacionesSolicitud
            // 
            this.DgvCotizacionesSolicitud.AllowUserToAddRows = false;
            this.DgvCotizacionesSolicitud.AllowUserToDeleteRows = false;
            this.DgvCotizacionesSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCotizacionesSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCotizacionesSolicitud.Location = new System.Drawing.Point(8, 116);
            this.DgvCotizacionesSolicitud.MultiSelect = false;
            this.DgvCotizacionesSolicitud.Name = "DgvCotizacionesSolicitud";
            this.DgvCotizacionesSolicitud.ReadOnly = true;
            this.DgvCotizacionesSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCotizacionesSolicitud.Size = new System.Drawing.Size(1058, 364);
            this.DgvCotizacionesSolicitud.TabIndex = 3;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1082, 44);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // FrmCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 532);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCotizaciones_FormClosing);
            this.Load += new System.EventHandler(this.FrmCotizaciones_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCotizaciones_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosPorCotizar)).EndInit();
            this.TabSolicitudes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).EndInit();
            this.TabPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.TabCotizacionesPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCotizacionesPedidos)).EndInit();
            this.TabCotizacionesSolicitud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCotizacionesSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn codscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codordcprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn automatizadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codordcprDataGridViewTextBoxColumn1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabNueva;
        private System.Windows.Forms.TabPage TabSolicitudes;
        private System.Windows.Forms.TabPage TabPedidos;
        private System.Windows.Forms.DataGridView DgvSolicitudes;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarCotizacionSolicitudButton;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarCotizacionPedidoButton;
        private System.Windows.Forms.TabPage TabCotizacionesPedido;
        private System.Windows.Forms.DataGridView DgvCotizacionesPedidos;
        private System.Windows.Forms.DataGridView DgvProductosPorCotizar;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage TabCotizacionesSolicitud;
        private System.Windows.Forms.DataGridView DgvCotizacionesSolicitud;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private MaterialSkin.Controls.MaterialRaisedButton CotizarProductoButton;
        private MaterialSkin.Controls.MaterialRaisedButton BorrarCotizacionPedidoButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}
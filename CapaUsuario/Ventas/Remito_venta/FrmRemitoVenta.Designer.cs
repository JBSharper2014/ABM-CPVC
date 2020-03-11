namespace CapaUsuario.Ventas.Remito_venta
{
    partial class FrmRemitoVenta
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
            this.tabcontroloca = new MaterialSkin.Controls.MaterialTabControl();
            this.TabAdmin = new System.Windows.Forms.TabPage();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarCambiosButton = new System.Windows.Forms.Button();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.BtnObservacionRemito = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemitoBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvListadoRemitos = new System.Windows.Forms.DataGridView();
            this.TabPedidosVenta = new System.Windows.Forms.TabPage();
            this.PedidoVentaBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CrearRemitoVentaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvPedidosVenta = new System.Windows.Forms.DataGridView();
            this.TabPedidosDevolucion = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PedidoDevBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CrearRemitoDevolucion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvPedidosDevolucion = new System.Windows.Forms.DataGridView();
            this.tabcontroloca.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRemitos)).BeginInit();
            this.TabPedidosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosVenta)).BeginInit();
            this.TabPedidosDevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabcontroloca;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1062, 43);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabcontroloca
            // 
            this.tabcontroloca.Controls.Add(this.TabAdmin);
            this.tabcontroloca.Controls.Add(this.TabListado);
            this.tabcontroloca.Controls.Add(this.TabPedidosVenta);
            this.tabcontroloca.Controls.Add(this.TabPedidosDevolucion);
            this.tabcontroloca.Depth = 0;
            this.tabcontroloca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontroloca.Location = new System.Drawing.Point(0, 43);
            this.tabcontroloca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabcontroloca.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontroloca.Name = "tabcontroloca";
            this.tabcontroloca.SelectedIndex = 0;
            this.tabcontroloca.Size = new System.Drawing.Size(1062, 495);
            this.tabcontroloca.TabIndex = 1;
            // 
            // TabAdmin
            // 
            this.TabAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabAdmin.Controls.Add(this.CancelarButton);
            this.TabAdmin.Controls.Add(this.GuardarCambiosButton);
            this.TabAdmin.Controls.Add(this.ObservacionesTextBox);
            this.TabAdmin.Controls.Add(this.label1);
            this.TabAdmin.Location = new System.Drawing.Point(4, 29);
            this.TabAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabAdmin.Size = new System.Drawing.Size(1054, 462);
            this.TabAdmin.TabIndex = 0;
            this.TabAdmin.Text = "Administracion";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(210, 372);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarButton.TabIndex = 12;
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
            this.GuardarCambiosButton.Location = new System.Drawing.Point(398, 372);
            this.GuardarCambiosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarCambiosButton.Name = "GuardarCambiosButton";
            this.GuardarCambiosButton.Size = new System.Drawing.Size(204, 54);
            this.GuardarCambiosButton.TabIndex = 11;
            this.GuardarCambiosButton.Text = "Guardar datos";
            this.GuardarCambiosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarCambiosButton.UseVisualStyleBackColor = true;
            this.GuardarCambiosButton.Click += new System.EventHandler(this.GuardarCambiosButton_Click);
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ObservacionesTextBox.Location = new System.Drawing.Point(214, 74);
            this.ObservacionesTextBox.MaxLength = 200;
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.ReadOnly = true;
            this.ObservacionesTextBox.Size = new System.Drawing.Size(464, 146);
            this.ObservacionesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observaciones:";
            // 
            // TabListado
            // 
            this.TabListado.Controls.Add(this.BtnObservacionRemito);
            this.TabListado.Controls.Add(this.textBox1);
            this.TabListado.Controls.Add(this.label6);
            this.TabListado.Controls.Add(this.RemitoBusquedaTextBox);
            this.TabListado.Controls.Add(this.label3);
            this.TabListado.Controls.Add(this.DgvListadoRemitos);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabListado.Size = new System.Drawing.Size(1054, 462);
            this.TabListado.TabIndex = 1;
            this.TabListado.Text = "Listado";
            this.TabListado.UseVisualStyleBackColor = true;
            // 
            // BtnObservacionRemito
            // 
            this.BtnObservacionRemito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnObservacionRemito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnObservacionRemito.Depth = 0;
            this.BtnObservacionRemito.Location = new System.Drawing.Point(882, 26);
            this.BtnObservacionRemito.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnObservacionRemito.Name = "BtnObservacionRemito";
            this.BtnObservacionRemito.Primary = true;
            this.BtnObservacionRemito.Size = new System.Drawing.Size(148, 33);
            this.BtnObservacionRemito.TabIndex = 13;
            this.BtnObservacionRemito.Text = "Leer observacion";
            this.BtnObservacionRemito.UseVisualStyleBackColor = true;
            this.BtnObservacionRemito.Click += new System.EventHandler(this.BtnObservacionRemito_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 29);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Filtrar remito por nombre de cliente:";
            // 
            // RemitoBusquedaTextBox
            // 
            this.RemitoBusquedaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemitoBusquedaTextBox.Location = new System.Drawing.Point(649, 29);
            this.RemitoBusquedaTextBox.MaxLength = 3;
            this.RemitoBusquedaTextBox.Name = "RemitoBusquedaTextBox";
            this.RemitoBusquedaTextBox.Size = new System.Drawing.Size(171, 27);
            this.RemitoBusquedaTextBox.TabIndex = 6;
            this.RemitoBusquedaTextBox.TextChanged += new System.EventHandler(this.RemitoBusquedaTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtrar remito por su código:";
            // 
            // DgvListadoRemitos
            // 
            this.DgvListadoRemitos.AllowUserToAddRows = false;
            this.DgvListadoRemitos.AllowUserToDeleteRows = false;
            this.DgvListadoRemitos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoRemitos.Location = new System.Drawing.Point(8, 81);
            this.DgvListadoRemitos.MultiSelect = false;
            this.DgvListadoRemitos.Name = "DgvListadoRemitos";
            this.DgvListadoRemitos.ReadOnly = true;
            this.DgvListadoRemitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoRemitos.Size = new System.Drawing.Size(1039, 373);
            this.DgvListadoRemitos.TabIndex = 0;
            // 
            // TabPedidosVenta
            // 
            this.TabPedidosVenta.Controls.Add(this.PedidoVentaBusquedaTextBox);
            this.TabPedidosVenta.Controls.Add(this.label4);
            this.TabPedidosVenta.Controls.Add(this.CrearRemitoVentaButton);
            this.TabPedidosVenta.Controls.Add(this.DgvPedidosVenta);
            this.TabPedidosVenta.Location = new System.Drawing.Point(4, 29);
            this.TabPedidosVenta.Name = "TabPedidosVenta";
            this.TabPedidosVenta.Padding = new System.Windows.Forms.Padding(3);
            this.TabPedidosVenta.Size = new System.Drawing.Size(1054, 462);
            this.TabPedidosVenta.TabIndex = 2;
            this.TabPedidosVenta.Text = "Pedidos de venta";
            this.TabPedidosVenta.UseVisualStyleBackColor = true;
            // 
            // PedidoVentaBusquedaTextBox
            // 
            this.PedidoVentaBusquedaTextBox.Location = new System.Drawing.Point(337, 30);
            this.PedidoVentaBusquedaTextBox.MaxLength = 3;
            this.PedidoVentaBusquedaTextBox.Name = "PedidoVentaBusquedaTextBox";
            this.PedidoVentaBusquedaTextBox.Size = new System.Drawing.Size(171, 27);
            this.PedidoVentaBusquedaTextBox.TabIndex = 8;
            this.PedidoVentaBusquedaTextBox.TextChanged += new System.EventHandler(this.PedidoVentaBusquedaTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filtrar pedido de venta por nombre de cliente";
            // 
            // CrearRemitoVentaButton
            // 
            this.CrearRemitoVentaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearRemitoVentaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearRemitoVentaButton.Depth = 0;
            this.CrearRemitoVentaButton.Location = new System.Drawing.Point(727, 27);
            this.CrearRemitoVentaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearRemitoVentaButton.Name = "CrearRemitoVentaButton";
            this.CrearRemitoVentaButton.Primary = true;
            this.CrearRemitoVentaButton.Size = new System.Drawing.Size(270, 33);
            this.CrearRemitoVentaButton.TabIndex = 5;
            this.CrearRemitoVentaButton.Text = "Crear remito por pedido de venta";
            this.CrearRemitoVentaButton.UseVisualStyleBackColor = true;
            this.CrearRemitoVentaButton.Click += new System.EventHandler(this.CrearRemitoVentaButton_Click);
            // 
            // DgvPedidosVenta
            // 
            this.DgvPedidosVenta.AllowUserToAddRows = false;
            this.DgvPedidosVenta.AllowUserToDeleteRows = false;
            this.DgvPedidosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosVenta.Location = new System.Drawing.Point(8, 78);
            this.DgvPedidosVenta.MultiSelect = false;
            this.DgvPedidosVenta.Name = "DgvPedidosVenta";
            this.DgvPedidosVenta.ReadOnly = true;
            this.DgvPedidosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidosVenta.Size = new System.Drawing.Size(1038, 376);
            this.DgvPedidosVenta.TabIndex = 0;
            // 
            // TabPedidosDevolucion
            // 
            this.TabPedidosDevolucion.Controls.Add(this.materialRaisedButton1);
            this.TabPedidosDevolucion.Controls.Add(this.PedidoDevBusquedaTextBox);
            this.TabPedidosDevolucion.Controls.Add(this.label5);
            this.TabPedidosDevolucion.Controls.Add(this.CrearRemitoDevolucion);
            this.TabPedidosDevolucion.Controls.Add(this.DgvPedidosDevolucion);
            this.TabPedidosDevolucion.Location = new System.Drawing.Point(4, 29);
            this.TabPedidosDevolucion.Name = "TabPedidosDevolucion";
            this.TabPedidosDevolucion.Padding = new System.Windows.Forms.Padding(3);
            this.TabPedidosDevolucion.Size = new System.Drawing.Size(1054, 462);
            this.TabPedidosDevolucion.TabIndex = 3;
            this.TabPedidosDevolucion.Text = "Pedidos de devolucion";
            this.TabPedidosDevolucion.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(530, 28);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(148, 33);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "Leer observacion";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // PedidoDevBusquedaTextBox
            // 
            this.PedidoDevBusquedaTextBox.Location = new System.Drawing.Point(314, 31);
            this.PedidoDevBusquedaTextBox.MaxLength = 3;
            this.PedidoDevBusquedaTextBox.Name = "PedidoDevBusquedaTextBox";
            this.PedidoDevBusquedaTextBox.Size = new System.Drawing.Size(171, 27);
            this.PedidoDevBusquedaTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filtrar por código de pedido de devolución:";
            // 
            // CrearRemitoDevolucion
            // 
            this.CrearRemitoDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearRemitoDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearRemitoDevolucion.Depth = 0;
            this.CrearRemitoDevolucion.Location = new System.Drawing.Point(716, 28);
            this.CrearRemitoDevolucion.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearRemitoDevolucion.Name = "CrearRemitoDevolucion";
            this.CrearRemitoDevolucion.Primary = true;
            this.CrearRemitoDevolucion.Size = new System.Drawing.Size(305, 33);
            this.CrearRemitoDevolucion.TabIndex = 7;
            this.CrearRemitoDevolucion.Text = "Crear remito por pedido de devolucion";
            this.CrearRemitoDevolucion.UseVisualStyleBackColor = true;
            this.CrearRemitoDevolucion.Click += new System.EventHandler(this.CrearRemitoDevolucion_Click);
            // 
            // DgvPedidosDevolucion
            // 
            this.DgvPedidosDevolucion.AllowUserToAddRows = false;
            this.DgvPedidosDevolucion.AllowUserToDeleteRows = false;
            this.DgvPedidosDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidosDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosDevolucion.Location = new System.Drawing.Point(8, 77);
            this.DgvPedidosDevolucion.MultiSelect = false;
            this.DgvPedidosDevolucion.Name = "DgvPedidosDevolucion";
            this.DgvPedidosDevolucion.ReadOnly = true;
            this.DgvPedidosDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidosDevolucion.Size = new System.Drawing.Size(1038, 377);
            this.DgvPedidosDevolucion.TabIndex = 6;
            // 
            // FrmRemitoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 538);
            this.Controls.Add(this.tabcontroloca);
            this.Controls.Add(this.materialTabSelector1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRemitoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remito por Venta";
            this.Load += new System.EventHandler(this.FrmRemitoVenta_Load);
            this.SizeChanged += new System.EventHandler(this.FrmRemitoVenta_SizeChanged);
            this.tabcontroloca.ResumeLayout(false);
            this.TabAdmin.ResumeLayout(false);
            this.TabAdmin.PerformLayout();
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRemitos)).EndInit();
            this.TabPedidosVenta.ResumeLayout(false);
            this.TabPedidosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosVenta)).EndInit();
            this.TabPedidosDevolucion.ResumeLayout(false);
            this.TabPedidosDevolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabcontroloca;
        private System.Windows.Forms.TabPage TabAdmin;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.DataGridView DgvListadoRemitos;
        private System.Windows.Forms.TabPage TabPedidosVenta;
        private MaterialSkin.Controls.MaterialRaisedButton CrearRemitoVentaButton;
        private System.Windows.Forms.DataGridView DgvPedidosVenta;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarCambiosButton;
        private System.Windows.Forms.TabPage TabPedidosDevolucion;
        private MaterialSkin.Controls.MaterialRaisedButton CrearRemitoDevolucion;
        private System.Windows.Forms.DataGridView DgvPedidosDevolucion;
        private System.Windows.Forms.TextBox RemitoBusquedaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PedidoVentaBusquedaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PedidoDevBusquedaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnObservacionRemito;
    }
}
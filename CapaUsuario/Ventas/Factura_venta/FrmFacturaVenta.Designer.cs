namespace CapaUsuario.Ventas.Factura_venta
{
    partial class FrmFacturaVenta
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
            this.TabAdmin = new System.Windows.Forms.TabPage();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarCambiosButton = new System.Windows.Forms.Button();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabListadoFacturas = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvListadoFacturas = new System.Windows.Forms.DataGridView();
            this.TabRemitosVenta = new System.Windows.Forms.TabPage();
            this.CrearFacturaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvRemitosVenta = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.TabListadoFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoFacturas)).BeginInit();
            this.TabRemitosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRemitosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabAdmin);
            this.materialTabControl1.Controls.Add(this.TabListadoFacturas);
            this.materialTabControl1.Controls.Add(this.TabRemitosVenta);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1042, 525);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabAdmin
            // 
            this.TabAdmin.Controls.Add(this.CancelarButton);
            this.TabAdmin.Controls.Add(this.GuardarCambiosButton);
            this.TabAdmin.Controls.Add(this.ObservacionesTextBox);
            this.TabAdmin.Controls.Add(this.label1);
            this.TabAdmin.Location = new System.Drawing.Point(4, 29);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.TabAdmin.Size = new System.Drawing.Size(1034, 492);
            this.TabAdmin.TabIndex = 0;
            this.TabAdmin.Text = "Administración";
            this.TabAdmin.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(225, 392);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarButton.TabIndex = 16;
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
            this.GuardarCambiosButton.Location = new System.Drawing.Point(413, 392);
            this.GuardarCambiosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarCambiosButton.Name = "GuardarCambiosButton";
            this.GuardarCambiosButton.Size = new System.Drawing.Size(204, 54);
            this.GuardarCambiosButton.TabIndex = 15;
            this.GuardarCambiosButton.Text = "Grabar factura";
            this.GuardarCambiosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarCambiosButton.UseVisualStyleBackColor = true;
            this.GuardarCambiosButton.Click += new System.EventHandler(this.GuardarCambiosButton_Click);
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ObservacionesTextBox.Location = new System.Drawing.Point(229, 94);
            this.ObservacionesTextBox.MaxLength = 200;
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.ReadOnly = true;
            this.ObservacionesTextBox.Size = new System.Drawing.Size(526, 203);
            this.ObservacionesTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Observaciones:";
            // 
            // TabListadoFacturas
            // 
            this.TabListadoFacturas.Controls.Add(this.materialRaisedButton1);
            this.TabListadoFacturas.Controls.Add(this.DgvListadoFacturas);
            this.TabListadoFacturas.Location = new System.Drawing.Point(4, 29);
            this.TabListadoFacturas.Name = "TabListadoFacturas";
            this.TabListadoFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.TabListadoFacturas.Size = new System.Drawing.Size(1034, 492);
            this.TabListadoFacturas.TabIndex = 1;
            this.TabListadoFacturas.Text = "Facturas";
            this.TabListadoFacturas.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(878, 75);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(148, 33);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "Leer observacion";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // DgvListadoFacturas
            // 
            this.DgvListadoFacturas.AllowUserToAddRows = false;
            this.DgvListadoFacturas.AllowUserToDeleteRows = false;
            this.DgvListadoFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoFacturas.Location = new System.Drawing.Point(8, 125);
            this.DgvListadoFacturas.MultiSelect = false;
            this.DgvListadoFacturas.Name = "DgvListadoFacturas";
            this.DgvListadoFacturas.ReadOnly = true;
            this.DgvListadoFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoFacturas.Size = new System.Drawing.Size(1018, 359);
            this.DgvListadoFacturas.TabIndex = 0;
            // 
            // TabRemitosVenta
            // 
            this.TabRemitosVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabRemitosVenta.Controls.Add(this.CrearFacturaButton);
            this.TabRemitosVenta.Controls.Add(this.DgvRemitosVenta);
            this.TabRemitosVenta.Location = new System.Drawing.Point(4, 29);
            this.TabRemitosVenta.Name = "TabRemitosVenta";
            this.TabRemitosVenta.Padding = new System.Windows.Forms.Padding(3);
            this.TabRemitosVenta.Size = new System.Drawing.Size(1034, 492);
            this.TabRemitosVenta.TabIndex = 2;
            this.TabRemitosVenta.Text = "Remitos de venta";
            // 
            // CrearFacturaButton
            // 
            this.CrearFacturaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearFacturaButton.AutoSize = true;
            this.CrearFacturaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearFacturaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearFacturaButton.Depth = 0;
            this.CrearFacturaButton.Location = new System.Drawing.Point(861, 72);
            this.CrearFacturaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearFacturaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearFacturaButton.Name = "CrearFacturaButton";
            this.CrearFacturaButton.Primary = false;
            this.CrearFacturaButton.Size = new System.Drawing.Size(119, 36);
            this.CrearFacturaButton.TabIndex = 3;
            this.CrearFacturaButton.Text = "Crear factura";
            this.CrearFacturaButton.UseVisualStyleBackColor = true;
            this.CrearFacturaButton.Click += new System.EventHandler(this.CrearFacturaButton_Click);
            // 
            // DgvRemitosVenta
            // 
            this.DgvRemitosVenta.AllowUserToAddRows = false;
            this.DgvRemitosVenta.AllowUserToDeleteRows = false;
            this.DgvRemitosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRemitosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRemitosVenta.Location = new System.Drawing.Point(10, 127);
            this.DgvRemitosVenta.MultiSelect = false;
            this.DgvRemitosVenta.Name = "DgvRemitosVenta";
            this.DgvRemitosVenta.ReadOnly = true;
            this.DgvRemitosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRemitosVenta.Size = new System.Drawing.Size(1018, 357);
            this.DgvRemitosVenta.TabIndex = 2;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1042, 46);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // FrmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 525);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFacturaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas por Venta";
            this.Load += new System.EventHandler(this.FrmFacturaVenta_Load);
            this.SizeChanged += new System.EventHandler(this.FrmFacturaVenta_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabAdmin.ResumeLayout(false);
            this.TabAdmin.PerformLayout();
            this.TabListadoFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoFacturas)).EndInit();
            this.TabRemitosVenta.ResumeLayout(false);
            this.TabRemitosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRemitosVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabAdmin;
        private System.Windows.Forms.TabPage TabListadoFacturas;
        private System.Windows.Forms.DataGridView DgvListadoFacturas;
        private System.Windows.Forms.TabPage TabRemitosVenta;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton CrearFacturaButton;
        private System.Windows.Forms.DataGridView DgvRemitosVenta;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarCambiosButton;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}
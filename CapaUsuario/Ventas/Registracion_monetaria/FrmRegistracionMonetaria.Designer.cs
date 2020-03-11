namespace CapaUsuario.Ventas.Registracion_monetaria
{
    partial class FrmRegistracionMonetaria
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
            this.TabListado = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CodRegisTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListadoRegistraciones = new System.Windows.Forms.DataGridView();
            this.TabFacturas = new System.Windows.Forms.TabPage();
            this.CrearRegisFacturaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvListadoFacturas = new System.Windows.Forms.DataGridView();
            this.TabNotasCredito = new System.Windows.Forms.TabPage();
            this.CrearRegisNotaCreditoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvListadoNotasCredito = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRegistraciones)).BeginInit();
            this.TabFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoFacturas)).BeginInit();
            this.TabNotasCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoNotasCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // TabListado
            // 
            this.TabListado.BaseTabControl = this.materialTabControl1;
            this.TabListado.Depth = 0;
            this.TabListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabListado.Location = new System.Drawing.Point(0, 0);
            this.TabListado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabListado.Name = "TabListado";
            this.TabListado.Size = new System.Drawing.Size(971, 47);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.TabFacturas);
            this.materialTabControl1.Controls.Add(this.TabNotasCredito);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 47);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(971, 467);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CodRegisTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DgvListadoRegistraciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CodRegisTextBox
            // 
            this.CodRegisTextBox.Location = new System.Drawing.Point(265, 37);
            this.CodRegisTextBox.Name = "CodRegisTextBox";
            this.CodRegisTextBox.Size = new System.Drawing.Size(150, 27);
            this.CodRegisTextBox.TabIndex = 2;
            this.CodRegisTextBox.TextChanged += new System.EventHandler(this.CodRegisTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por código de registración:";
            // 
            // DgvListadoRegistraciones
            // 
            this.DgvListadoRegistraciones.AllowUserToAddRows = false;
            this.DgvListadoRegistraciones.AllowUserToDeleteRows = false;
            this.DgvListadoRegistraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoRegistraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoRegistraciones.Location = new System.Drawing.Point(8, 78);
            this.DgvListadoRegistraciones.MultiSelect = false;
            this.DgvListadoRegistraciones.Name = "DgvListadoRegistraciones";
            this.DgvListadoRegistraciones.ReadOnly = true;
            this.DgvListadoRegistraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoRegistraciones.Size = new System.Drawing.Size(947, 348);
            this.DgvListadoRegistraciones.TabIndex = 0;
            // 
            // TabFacturas
            // 
            this.TabFacturas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabFacturas.Controls.Add(this.CrearRegisFacturaButton);
            this.TabFacturas.Controls.Add(this.DgvListadoFacturas);
            this.TabFacturas.Location = new System.Drawing.Point(4, 29);
            this.TabFacturas.Name = "TabFacturas";
            this.TabFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.TabFacturas.Size = new System.Drawing.Size(963, 434);
            this.TabFacturas.TabIndex = 1;
            this.TabFacturas.Text = "Facturas";
            // 
            // CrearRegisFacturaButton
            // 
            this.CrearRegisFacturaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearRegisFacturaButton.AutoSize = true;
            this.CrearRegisFacturaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearRegisFacturaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearRegisFacturaButton.Depth = 0;
            this.CrearRegisFacturaButton.Location = new System.Drawing.Point(608, 33);
            this.CrearRegisFacturaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearRegisFacturaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearRegisFacturaButton.Name = "CrearRegisFacturaButton";
            this.CrearRegisFacturaButton.Primary = false;
            this.CrearRegisFacturaButton.Size = new System.Drawing.Size(330, 36);
            this.CrearRegisFacturaButton.TabIndex = 2;
            this.CrearRegisFacturaButton.Text = "Crear registración monetaria por factura";
            this.CrearRegisFacturaButton.UseVisualStyleBackColor = true;
            this.CrearRegisFacturaButton.Click += new System.EventHandler(this.CrearRegisFacturaButton_Click);
            // 
            // DgvListadoFacturas
            // 
            this.DgvListadoFacturas.AllowUserToAddRows = false;
            this.DgvListadoFacturas.AllowUserToDeleteRows = false;
            this.DgvListadoFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoFacturas.Location = new System.Drawing.Point(8, 78);
            this.DgvListadoFacturas.MultiSelect = false;
            this.DgvListadoFacturas.Name = "DgvListadoFacturas";
            this.DgvListadoFacturas.ReadOnly = true;
            this.DgvListadoFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoFacturas.Size = new System.Drawing.Size(947, 348);
            this.DgvListadoFacturas.TabIndex = 1;
            // 
            // TabNotasCredito
            // 
            this.TabNotasCredito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabNotasCredito.Controls.Add(this.CrearRegisNotaCreditoButton);
            this.TabNotasCredito.Controls.Add(this.DgvListadoNotasCredito);
            this.TabNotasCredito.Location = new System.Drawing.Point(4, 29);
            this.TabNotasCredito.Name = "TabNotasCredito";
            this.TabNotasCredito.Padding = new System.Windows.Forms.Padding(3);
            this.TabNotasCredito.Size = new System.Drawing.Size(963, 434);
            this.TabNotasCredito.TabIndex = 2;
            this.TabNotasCredito.Text = "Notas de crédito";
            // 
            // CrearRegisNotaCreditoButton
            // 
            this.CrearRegisNotaCreditoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearRegisNotaCreditoButton.AutoSize = true;
            this.CrearRegisNotaCreditoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearRegisNotaCreditoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearRegisNotaCreditoButton.Depth = 0;
            this.CrearRegisNotaCreditoButton.Location = new System.Drawing.Point(556, 33);
            this.CrearRegisNotaCreditoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearRegisNotaCreditoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearRegisNotaCreditoButton.Name = "CrearRegisNotaCreditoButton";
            this.CrearRegisNotaCreditoButton.Primary = false;
            this.CrearRegisNotaCreditoButton.Size = new System.Drawing.Size(386, 36);
            this.CrearRegisNotaCreditoButton.TabIndex = 3;
            this.CrearRegisNotaCreditoButton.Text = "Crear registración monetaria por nota de crédito";
            this.CrearRegisNotaCreditoButton.UseVisualStyleBackColor = true;
            this.CrearRegisNotaCreditoButton.Click += new System.EventHandler(this.CrearRegisNotaCreditoButton_Click);
            // 
            // DgvListadoNotasCredito
            // 
            this.DgvListadoNotasCredito.AllowUserToAddRows = false;
            this.DgvListadoNotasCredito.AllowUserToDeleteRows = false;
            this.DgvListadoNotasCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoNotasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoNotasCredito.Location = new System.Drawing.Point(10, 78);
            this.DgvListadoNotasCredito.MultiSelect = false;
            this.DgvListadoNotasCredito.Name = "DgvListadoNotasCredito";
            this.DgvListadoNotasCredito.ReadOnly = true;
            this.DgvListadoNotasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoNotasCredito.Size = new System.Drawing.Size(947, 348);
            this.DgvListadoNotasCredito.TabIndex = 1;
            // 
            // FrmRegistracionMonetaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 514);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.TabListado);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistracionMonetaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registración Monetaria";
            this.Load += new System.EventHandler(this.FrmRegistracionMonetaria_Load);
            this.SizeChanged += new System.EventHandler(this.FrmRegistracionMonetaria_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRegistraciones)).EndInit();
            this.TabFacturas.ResumeLayout(false);
            this.TabFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoFacturas)).EndInit();
            this.TabNotasCredito.ResumeLayout(false);
            this.TabNotasCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoNotasCredito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector TabListado;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvListadoRegistraciones;
        private System.Windows.Forms.TabPage TabFacturas;
        private System.Windows.Forms.DataGridView DgvListadoFacturas;
        private System.Windows.Forms.TabPage TabNotasCredito;
        private System.Windows.Forms.DataGridView DgvListadoNotasCredito;
        private System.Windows.Forms.TextBox CodRegisTextBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton CrearRegisFacturaButton;
        private MaterialSkin.Controls.MaterialFlatButton CrearRegisNotaCreditoButton;
    }
}
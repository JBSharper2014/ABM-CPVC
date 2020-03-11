namespace CapaUsuario.Pagos.Registracion_debito
{
    partial class FrmRegistracionDebito
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvOrdenesPago = new System.Windows.Forms.DataGridView();
            this.CrearRegistracionButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvListadoRegistraciones = new System.Windows.Forms.DataGridView();
            this.CodOrdenBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRegistraciones)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(980, 45);
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
            this.materialTabControl1.Size = new System.Drawing.Size(980, 473);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.CodOrdenBusquedaTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CrearRegistracionButton);
            this.tabPage1.Controls.Add(this.DgvOrdenesPago);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ordenes de pago";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DgvListadoRegistraciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgvOrdenesPago
            // 
            this.DgvOrdenesPago.AllowUserToAddRows = false;
            this.DgvOrdenesPago.AllowUserToDeleteRows = false;
            this.DgvOrdenesPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrdenesPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenesPago.Location = new System.Drawing.Point(8, 92);
            this.DgvOrdenesPago.MultiSelect = false;
            this.DgvOrdenesPago.Name = "DgvOrdenesPago";
            this.DgvOrdenesPago.ReadOnly = true;
            this.DgvOrdenesPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrdenesPago.Size = new System.Drawing.Size(956, 340);
            this.DgvOrdenesPago.TabIndex = 1;
            // 
            // CrearRegistracionButton
            // 
            this.CrearRegistracionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearRegistracionButton.AutoSize = true;
            this.CrearRegistracionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearRegistracionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearRegistracionButton.Depth = 0;
            this.CrearRegistracionButton.Location = new System.Drawing.Point(697, 37);
            this.CrearRegistracionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearRegistracionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearRegistracionButton.Name = "CrearRegistracionButton";
            this.CrearRegistracionButton.Primary = false;
            this.CrearRegistracionButton.Size = new System.Drawing.Size(193, 36);
            this.CrearRegistracionButton.TabIndex = 2;
            this.CrearRegistracionButton.Text = "Registrar orden de pago";
            this.CrearRegistracionButton.UseVisualStyleBackColor = true;
            this.CrearRegistracionButton.Click += new System.EventHandler(this.CrearRegistracionButton_Click);
            // 
            // DgvListadoRegistraciones
            // 
            this.DgvListadoRegistraciones.AllowUserToAddRows = false;
            this.DgvListadoRegistraciones.AllowUserToDeleteRows = false;
            this.DgvListadoRegistraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoRegistraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoRegistraciones.Location = new System.Drawing.Point(8, 92);
            this.DgvListadoRegistraciones.MultiSelect = false;
            this.DgvListadoRegistraciones.Name = "DgvListadoRegistraciones";
            this.DgvListadoRegistraciones.ReadOnly = true;
            this.DgvListadoRegistraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoRegistraciones.Size = new System.Drawing.Size(956, 340);
            this.DgvListadoRegistraciones.TabIndex = 2;
            // 
            // CodOrdenBusquedaTextBox
            // 
            this.CodOrdenBusquedaTextBox.Location = new System.Drawing.Point(207, 42);
            this.CodOrdenBusquedaTextBox.MaxLength = 6;
            this.CodOrdenBusquedaTextBox.Name = "CodOrdenBusquedaTextBox";
            this.CodOrdenBusquedaTextBox.Size = new System.Drawing.Size(106, 27);
            this.CodOrdenBusquedaTextBox.TabIndex = 6;
            this.CodOrdenBusquedaTextBox.TextChanged += new System.EventHandler(this.CodOrdenBusquedaTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código de orden de pago:";
            // 
            // FrmRegistracionDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 518);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistracionDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registraciones de Débito";
            this.Load += new System.EventHandler(this.FrmRegistracionDebito_Load);
            this.SizeChanged += new System.EventHandler(this.FrmRegistracionDebito_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRegistraciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvOrdenesPago;
        private MaterialSkin.Controls.MaterialFlatButton CrearRegistracionButton;
        private System.Windows.Forms.DataGridView DgvListadoRegistraciones;
        private System.Windows.Forms.TextBox CodOrdenBusquedaTextBox;
        private System.Windows.Forms.Label label4;
    }
}
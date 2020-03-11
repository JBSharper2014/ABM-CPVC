namespace CapaUsuario.Cobros
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListadoRegistraciones = new System.Windows.Forms.DataGridView();
            this.TabConfirmaciones = new System.Windows.Forms.TabPage();
            this.CrearRegistracionButton = new System.Windows.Forms.Button();
            this.DgvConfirmaciones = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRegistraciones)).BeginInit();
            this.TabConfirmaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConfirmaciones)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(971, 43);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Controls.Add(this.TabConfirmaciones);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 43);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(971, 467);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListado
            // 
            this.TabListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListado.Controls.Add(this.textBox1);
            this.TabListado.Controls.Add(this.label1);
            this.TabListado.Controls.Add(this.DgvListadoRegistraciones);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(963, 434);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "Listado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 39);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de registración:";
            // 
            // DgvListadoRegistraciones
            // 
            this.DgvListadoRegistraciones.AllowUserToAddRows = false;
            this.DgvListadoRegistraciones.AllowUserToDeleteRows = false;
            this.DgvListadoRegistraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoRegistraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoRegistraciones.Location = new System.Drawing.Point(8, 84);
            this.DgvListadoRegistraciones.MultiSelect = false;
            this.DgvListadoRegistraciones.Name = "DgvListadoRegistraciones";
            this.DgvListadoRegistraciones.ReadOnly = true;
            this.DgvListadoRegistraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoRegistraciones.Size = new System.Drawing.Size(947, 335);
            this.DgvListadoRegistraciones.TabIndex = 0;
            // 
            // TabConfirmaciones
            // 
            this.TabConfirmaciones.Controls.Add(this.CrearRegistracionButton);
            this.TabConfirmaciones.Controls.Add(this.DgvConfirmaciones);
            this.TabConfirmaciones.Location = new System.Drawing.Point(4, 29);
            this.TabConfirmaciones.Name = "TabConfirmaciones";
            this.TabConfirmaciones.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfirmaciones.Size = new System.Drawing.Size(963, 434);
            this.TabConfirmaciones.TabIndex = 1;
            this.TabConfirmaciones.Text = "Confirmaciones de cobro";
            this.TabConfirmaciones.UseVisualStyleBackColor = true;
            // 
            // CrearRegistracionButton
            // 
            this.CrearRegistracionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearRegistracionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearRegistracionButton.Image = global::CapaUsuario.Properties.Resources.crear_registracion44;
            this.CrearRegistracionButton.Location = new System.Drawing.Point(638, 15);
            this.CrearRegistracionButton.Name = "CrearRegistracionButton";
            this.CrearRegistracionButton.Size = new System.Drawing.Size(274, 54);
            this.CrearRegistracionButton.TabIndex = 2;
            this.CrearRegistracionButton.Text = "Crear registración monetaria";
            this.CrearRegistracionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CrearRegistracionButton.UseVisualStyleBackColor = true;
            this.CrearRegistracionButton.Click += new System.EventHandler(this.CrearRegistracionButton_Click);
            // 
            // DgvConfirmaciones
            // 
            this.DgvConfirmaciones.AllowUserToAddRows = false;
            this.DgvConfirmaciones.AllowUserToDeleteRows = false;
            this.DgvConfirmaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvConfirmaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConfirmaciones.Location = new System.Drawing.Point(8, 81);
            this.DgvConfirmaciones.MultiSelect = false;
            this.DgvConfirmaciones.Name = "DgvConfirmaciones";
            this.DgvConfirmaciones.ReadOnly = true;
            this.DgvConfirmaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvConfirmaciones.Size = new System.Drawing.Size(947, 345);
            this.DgvConfirmaciones.TabIndex = 1;
            // 
            // FrmRegistracionMonetaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 510);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistracionMonetaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registración Monetaria (cobros)";
            this.Load += new System.EventHandler(this.FrmRegistracionMonetaria_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoRegistraciones)).EndInit();
            this.TabConfirmaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConfirmaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListadoRegistraciones;
        private System.Windows.Forms.TabPage TabConfirmaciones;
        private System.Windows.Forms.Button CrearRegistracionButton;
        private System.Windows.Forms.DataGridView DgvConfirmaciones;
    }
}
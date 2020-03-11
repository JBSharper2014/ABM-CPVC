namespace CapaUsuario.Compras.Registracion
{
    partial class FrmRegistracion
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
            this.TabRegistraciones = new System.Windows.Forms.TabPage();
            this.CodRegistracionBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvRegistraciones = new System.Windows.Forms.DataGridView();
            this.TabInformes = new System.Windows.Forms.TabPage();
            this.DgvInformes = new System.Windows.Forms.DataGridView();
            this.CrearRegistracionButton = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.TabRegistraciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistraciones)).BeginInit();
            this.TabInformes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformes)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1085, 41);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabRegistraciones);
            this.materialTabControl1.Controls.Add(this.TabInformes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 41);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1085, 463);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabRegistraciones
            // 
            this.TabRegistraciones.Controls.Add(this.CodRegistracionBusquedaTextBox);
            this.TabRegistraciones.Controls.Add(this.label1);
            this.TabRegistraciones.Controls.Add(this.DgvRegistraciones);
            this.TabRegistraciones.Location = new System.Drawing.Point(4, 29);
            this.TabRegistraciones.Name = "TabRegistraciones";
            this.TabRegistraciones.Padding = new System.Windows.Forms.Padding(3);
            this.TabRegistraciones.Size = new System.Drawing.Size(1077, 430);
            this.TabRegistraciones.TabIndex = 0;
            this.TabRegistraciones.Text = "Registraciones";
            this.TabRegistraciones.UseVisualStyleBackColor = true;
            // 
            // CodRegistracionBusquedaTextBox
            // 
            this.CodRegistracionBusquedaTextBox.Location = new System.Drawing.Point(157, 39);
            this.CodRegistracionBusquedaTextBox.MaxLength = 6;
            this.CodRegistracionBusquedaTextBox.Name = "CodRegistracionBusquedaTextBox";
            this.CodRegistracionBusquedaTextBox.Size = new System.Drawing.Size(114, 27);
            this.CodRegistracionBusquedaTextBox.TabIndex = 2;
            this.CodRegistracionBusquedaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CodRegistracionBusquedaTextBox.TextChanged += new System.EventHandler(this.CodRegistracionBusquedaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod. Registración";
            // 
            // DgvRegistraciones
            // 
            this.DgvRegistraciones.AllowUserToAddRows = false;
            this.DgvRegistraciones.AllowUserToDeleteRows = false;
            this.DgvRegistraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRegistraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistraciones.Location = new System.Drawing.Point(8, 83);
            this.DgvRegistraciones.MultiSelect = false;
            this.DgvRegistraciones.Name = "DgvRegistraciones";
            this.DgvRegistraciones.ReadOnly = true;
            this.DgvRegistraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistraciones.Size = new System.Drawing.Size(1061, 339);
            this.DgvRegistraciones.TabIndex = 0;
            // 
            // TabInformes
            // 
            this.TabInformes.Controls.Add(this.DgvInformes);
            this.TabInformes.Controls.Add(this.CrearRegistracionButton);
            this.TabInformes.Location = new System.Drawing.Point(4, 29);
            this.TabInformes.Name = "TabInformes";
            this.TabInformes.Padding = new System.Windows.Forms.Padding(3);
            this.TabInformes.Size = new System.Drawing.Size(1077, 430);
            this.TabInformes.TabIndex = 1;
            this.TabInformes.Text = "Informes de recepción";
            this.TabInformes.UseVisualStyleBackColor = true;
            // 
            // DgvInformes
            // 
            this.DgvInformes.AllowUserToAddRows = false;
            this.DgvInformes.AllowUserToDeleteRows = false;
            this.DgvInformes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInformes.Location = new System.Drawing.Point(8, 83);
            this.DgvInformes.MultiSelect = false;
            this.DgvInformes.Name = "DgvInformes";
            this.DgvInformes.ReadOnly = true;
            this.DgvInformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInformes.Size = new System.Drawing.Size(1061, 339);
            this.DgvInformes.TabIndex = 5;
            // 
            // CrearRegistracionButton
            // 
            this.CrearRegistracionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearRegistracionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearRegistracionButton.Image = global::CapaUsuario.Properties.Resources.crear_registracion44;
            this.CrearRegistracionButton.Location = new System.Drawing.Point(776, 23);
            this.CrearRegistracionButton.Name = "CrearRegistracionButton";
            this.CrearRegistracionButton.Size = new System.Drawing.Size(274, 54);
            this.CrearRegistracionButton.TabIndex = 4;
            this.CrearRegistracionButton.Text = "Crear registración monetaria";
            this.CrearRegistracionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CrearRegistracionButton.UseVisualStyleBackColor = true;
            this.CrearRegistracionButton.Click += new System.EventHandler(this.CrearRegistracionButton_Click);
            // 
            // FrmRegistracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 504);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistracion";
            this.Text = "Registracion";
            this.Load += new System.EventHandler(this.FrmRegistracion_Load);
            this.SizeChanged += new System.EventHandler(this.FrmRegistracion_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabRegistraciones.ResumeLayout(false);
            this.TabRegistraciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistraciones)).EndInit();
            this.TabInformes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabRegistraciones;
        private System.Windows.Forms.TextBox CodRegistracionBusquedaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvRegistraciones;
        private System.Windows.Forms.TabPage TabInformes;
        private System.Windows.Forms.Button CrearRegistracionButton;
        private System.Windows.Forms.DataGridView DgvInformes;
    }
}
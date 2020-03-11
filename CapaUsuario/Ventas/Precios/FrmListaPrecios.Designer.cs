namespace CapaUsuario.Ventas.Precios
{
    partial class FrmListaPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaPrecios));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabAdmin = new System.Windows.Forms.TabPage();
            this.txtbuscarprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.DgvListadoStock = new System.Windows.Forms.DataGridView();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.EditarPrecioButton = new System.Windows.Forms.Button();
            this.DgvListadoPrecios = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoStock)).BeginInit();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabAdmin);
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(996, 528);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabAdmin
            // 
            this.TabAdmin.Controls.Add(this.txtbuscarprod);
            this.TabAdmin.Controls.Add(this.label3);
            this.TabAdmin.Controls.Add(this.PrecioNumericUpDown);
            this.TabAdmin.Controls.Add(this.label2);
            this.TabAdmin.Controls.Add(this.ProductoTextBox);
            this.TabAdmin.Controls.Add(this.label1);
            this.TabAdmin.Controls.Add(this.GuardarButton);
            this.TabAdmin.Controls.Add(this.CancelarButton);
            this.TabAdmin.Controls.Add(this.DgvListadoStock);
            this.TabAdmin.Location = new System.Drawing.Point(4, 29);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.TabAdmin.Size = new System.Drawing.Size(988, 495);
            this.TabAdmin.TabIndex = 0;
            this.TabAdmin.Text = "Administracion";
            this.TabAdmin.UseVisualStyleBackColor = true;
            // 
            // txtbuscarprod
            // 
            this.txtbuscarprod.Location = new System.Drawing.Point(160, 263);
            this.txtbuscarprod.Name = "txtbuscarprod";
            this.txtbuscarprod.Size = new System.Drawing.Size(169, 27);
            this.txtbuscarprod.TabIndex = 32;
            this.txtbuscarprod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Listar por producto";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrecioNumericUpDown.DecimalPlaces = 2;
            this.PrecioNumericUpDown.Enabled = false;
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(519, 121);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(169, 27);
            this.PrecioNumericUpDown.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Precio:";
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductoTextBox.Location = new System.Drawing.Point(519, 48);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.ReadOnly = true;
            this.ProductoTextBox.Size = new System.Drawing.Size(169, 27);
            this.ProductoTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Producto seleccionado:";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GuardarButton.Location = new System.Drawing.Point(590, 206);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(199, 47);
            this.GuardarButton.TabIndex = 26;
            this.GuardarButton.Text = "Modificar precio";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.CancelarButton.Location = new System.Drawing.Point(403, 206);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(145, 47);
            this.CancelarButton.TabIndex = 25;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // DgvListadoStock
            // 
            this.DgvListadoStock.AllowUserToAddRows = false;
            this.DgvListadoStock.AllowUserToDeleteRows = false;
            this.DgvListadoStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoStock.Location = new System.Drawing.Point(12, 298);
            this.DgvListadoStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvListadoStock.MultiSelect = false;
            this.DgvListadoStock.Name = "DgvListadoStock";
            this.DgvListadoStock.ReadOnly = true;
            this.DgvListadoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoStock.Size = new System.Drawing.Size(964, 180);
            this.DgvListadoStock.TabIndex = 23;
            this.DgvListadoStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoStock_CellClick);
            // 
            // TabListado
            // 
            this.TabListado.Controls.Add(this.EditarPrecioButton);
            this.TabListado.Controls.Add(this.DgvListadoPrecios);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(988, 495);
            this.TabListado.TabIndex = 1;
            this.TabListado.Text = "Listado de precios";
            this.TabListado.UseVisualStyleBackColor = true;
            // 
            // EditarPrecioButton
            // 
            this.EditarPrecioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarPrecioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarPrecioButton.Image = global::CapaUsuario.Properties.Resources.editWhite32;
            this.EditarPrecioButton.Location = new System.Drawing.Point(716, 50);
            this.EditarPrecioButton.Name = "EditarPrecioButton";
            this.EditarPrecioButton.Size = new System.Drawing.Size(153, 41);
            this.EditarPrecioButton.TabIndex = 2;
            this.EditarPrecioButton.Text = "Editar precio";
            this.EditarPrecioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditarPrecioButton.UseVisualStyleBackColor = true;
            this.EditarPrecioButton.Click += new System.EventHandler(this.EditarPrecioButton_Click);
            // 
            // DgvListadoPrecios
            // 
            this.DgvListadoPrecios.AllowUserToAddRows = false;
            this.DgvListadoPrecios.AllowUserToDeleteRows = false;
            this.DgvListadoPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoPrecios.Location = new System.Drawing.Point(79, 107);
            this.DgvListadoPrecios.MultiSelect = false;
            this.DgvListadoPrecios.Name = "DgvListadoPrecios";
            this.DgvListadoPrecios.ReadOnly = true;
            this.DgvListadoPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoPrecios.Size = new System.Drawing.Size(790, 351);
            this.DgvListadoPrecios.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(996, 38);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 528);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListaPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de precios";
            this.Load += new System.EventHandler(this.FrmListaPrecios_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.TabAdmin.ResumeLayout(false);
            this.TabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoStock)).EndInit();
            this.TabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabAdmin;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridView DgvListadoStock;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListadoPrecios;
        private System.Windows.Forms.Button EditarPrecioButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtbuscarprod;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}
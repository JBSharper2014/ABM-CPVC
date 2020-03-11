namespace CapaUsuario.Compras.Pedido_dev
{
    partial class FrmPedidoDev
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
            this.TabPedidos = new System.Windows.Forms.TabPage();
            this.BorrarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.TabInformes = new System.Windows.Forms.TabPage();
            this.CrearPedidoButon = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvInformes = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.CodPedidoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.TabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.TabInformes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabPedidos);
            this.materialTabControl1.Controls.Add(this.TabInformes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1076, 497);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabPedidos
            // 
            this.TabPedidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPedidos.Controls.Add(this.CodPedidoTextBox);
            this.TabPedidos.Controls.Add(this.label1);
            this.TabPedidos.Controls.Add(this.BorrarButton);
            this.TabPedidos.Controls.Add(this.DgvPedidos);
            this.TabPedidos.Location = new System.Drawing.Point(4, 29);
            this.TabPedidos.Name = "TabPedidos";
            this.TabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPedidos.Size = new System.Drawing.Size(1068, 464);
            this.TabPedidos.TabIndex = 0;
            this.TabPedidos.Text = "Pedidos de devolucion";
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarButton.AutoSize = true;
            this.BorrarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Depth = 0;
            this.BorrarButton.Location = new System.Drawing.Point(928, 87);
            this.BorrarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Primary = false;
            this.BorrarButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarButton.TabIndex = 1;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Location = new System.Drawing.Point(8, 141);
            this.DgvPedidos.MultiSelect = false;
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(1054, 315);
            this.DgvPedidos.TabIndex = 0;
            // 
            // TabInformes
            // 
            this.TabInformes.Controls.Add(this.CrearPedidoButon);
            this.TabInformes.Controls.Add(this.DgvInformes);
            this.TabInformes.Location = new System.Drawing.Point(4, 29);
            this.TabInformes.Name = "TabInformes";
            this.TabInformes.Padding = new System.Windows.Forms.Padding(3);
            this.TabInformes.Size = new System.Drawing.Size(1068, 464);
            this.TabInformes.TabIndex = 1;
            this.TabInformes.Text = "Informes de recepcion";
            this.TabInformes.UseVisualStyleBackColor = true;
            // 
            // CrearPedidoButon
            // 
            this.CrearPedidoButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearPedidoButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearPedidoButon.Depth = 0;
            this.CrearPedidoButon.Location = new System.Drawing.Point(881, 86);
            this.CrearPedidoButon.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearPedidoButon.Name = "CrearPedidoButon";
            this.CrearPedidoButon.Primary = true;
            this.CrearPedidoButon.Size = new System.Drawing.Size(133, 32);
            this.CrearPedidoButon.TabIndex = 3;
            this.CrearPedidoButon.Text = "Crear pedido";
            this.CrearPedidoButon.UseVisualStyleBackColor = true;
            this.CrearPedidoButon.Click += new System.EventHandler(this.CrearPedidoButon_Click);
            // 
            // DgvInformes
            // 
            this.DgvInformes.AllowUserToAddRows = false;
            this.DgvInformes.AllowUserToDeleteRows = false;
            this.DgvInformes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInformes.Location = new System.Drawing.Point(6, 141);
            this.DgvInformes.MultiSelect = false;
            this.DgvInformes.Name = "DgvInformes";
            this.DgvInformes.ReadOnly = true;
            this.DgvInformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInformes.Size = new System.Drawing.Size(1054, 315);
            this.DgvInformes.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1076, 46);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // CodPedidoTextBox
            // 
            this.CodPedidoTextBox.Location = new System.Drawing.Point(123, 92);
            this.CodPedidoTextBox.MaxLength = 5;
            this.CodPedidoTextBox.Name = "CodPedidoTextBox";
            this.CodPedidoTextBox.Size = new System.Drawing.Size(113, 27);
            this.CodPedidoTextBox.TabIndex = 7;
            this.CodPedidoTextBox.TextChanged += new System.EventHandler(this.CodPedidoTextBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cod pedido:";
            // 
            // FrmPedidoDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 497);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPedidoDev";
            this.Text = "Pedidos de devolución";
            this.Load += new System.EventHandler(this.FrmPedidoDev_Load);
            this.SizeChanged += new System.EventHandler(this.FrmPedidoDev_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabPedidos.ResumeLayout(false);
            this.TabPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.TabInformes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabPedidos;
        private MaterialSkin.Controls.MaterialFlatButton BorrarButton;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.TabPage TabInformes;
        private System.Windows.Forms.DataGridView DgvInformes;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton CrearPedidoButon;
        private System.Windows.Forms.TextBox CodPedidoTextBox;
        private System.Windows.Forms.Label label1;
    }
}
namespace CapaUsuario.Ventas.Nota_credito
{
    partial class FrmNotaCredito
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
            this.TabListadoNotasCredito = new System.Windows.Forms.TabPage();
            this.TabPedidosDev = new System.Windows.Forms.TabPage();
            this.DgvListadoNotasCredito = new System.Windows.Forms.DataGridView();
            this.BorrarNotaCreditoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CrearNotaCredito = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CodNotaCreditoBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.TabListadoNotasCredito.SuspendLayout();
            this.TabPedidosDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoNotasCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(998, 45);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListadoNotasCredito);
            this.materialTabControl1.Controls.Add(this.TabPedidosDev);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 45);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(998, 471);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListadoNotasCredito
            // 
            this.TabListadoNotasCredito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListadoNotasCredito.Controls.Add(this.CodNotaCreditoBusquedaTextBox);
            this.TabListadoNotasCredito.Controls.Add(this.label1);
            this.TabListadoNotasCredito.Controls.Add(this.BorrarNotaCreditoButton);
            this.TabListadoNotasCredito.Controls.Add(this.DgvListadoNotasCredito);
            this.TabListadoNotasCredito.Location = new System.Drawing.Point(4, 29);
            this.TabListadoNotasCredito.Name = "TabListadoNotasCredito";
            this.TabListadoNotasCredito.Padding = new System.Windows.Forms.Padding(3);
            this.TabListadoNotasCredito.Size = new System.Drawing.Size(990, 438);
            this.TabListadoNotasCredito.TabIndex = 0;
            this.TabListadoNotasCredito.Text = "Listado";
            // 
            // TabPedidosDev
            // 
            this.TabPedidosDev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPedidosDev.Controls.Add(this.CrearNotaCredito);
            this.TabPedidosDev.Controls.Add(this.DgvPedidos);
            this.TabPedidosDev.Location = new System.Drawing.Point(4, 29);
            this.TabPedidosDev.Name = "TabPedidosDev";
            this.TabPedidosDev.Padding = new System.Windows.Forms.Padding(3);
            this.TabPedidosDev.Size = new System.Drawing.Size(990, 438);
            this.TabPedidosDev.TabIndex = 1;
            this.TabPedidosDev.Text = "Pedidos de devolución";
            // 
            // DgvListadoNotasCredito
            // 
            this.DgvListadoNotasCredito.AllowUserToAddRows = false;
            this.DgvListadoNotasCredito.AllowUserToDeleteRows = false;
            this.DgvListadoNotasCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoNotasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoNotasCredito.Location = new System.Drawing.Point(8, 99);
            this.DgvListadoNotasCredito.MultiSelect = false;
            this.DgvListadoNotasCredito.Name = "DgvListadoNotasCredito";
            this.DgvListadoNotasCredito.ReadOnly = true;
            this.DgvListadoNotasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoNotasCredito.Size = new System.Drawing.Size(974, 331);
            this.DgvListadoNotasCredito.TabIndex = 0;
            // 
            // BorrarNotaCreditoButton
            // 
            this.BorrarNotaCreditoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarNotaCreditoButton.AutoSize = true;
            this.BorrarNotaCreditoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarNotaCreditoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarNotaCreditoButton.Depth = 0;
            this.BorrarNotaCreditoButton.Location = new System.Drawing.Point(768, 45);
            this.BorrarNotaCreditoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarNotaCreditoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarNotaCreditoButton.Name = "BorrarNotaCreditoButton";
            this.BorrarNotaCreditoButton.Primary = false;
            this.BorrarNotaCreditoButton.Size = new System.Drawing.Size(185, 36);
            this.BorrarNotaCreditoButton.TabIndex = 1;
            this.BorrarNotaCreditoButton.Text = "Borrar nota de crédito";
            this.BorrarNotaCreditoButton.UseVisualStyleBackColor = true;
            this.BorrarNotaCreditoButton.Click += new System.EventHandler(this.BorrarNotaCreditoButton_Click);
            // 
            // CrearNotaCredito
            // 
            this.CrearNotaCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearNotaCredito.AutoSize = true;
            this.CrearNotaCredito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearNotaCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearNotaCredito.Depth = 0;
            this.CrearNotaCredito.Location = new System.Drawing.Point(770, 45);
            this.CrearNotaCredito.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearNotaCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearNotaCredito.Name = "CrearNotaCredito";
            this.CrearNotaCredito.Primary = false;
            this.CrearNotaCredito.Size = new System.Drawing.Size(175, 36);
            this.CrearNotaCredito.TabIndex = 3;
            this.CrearNotaCredito.Text = "Crear nota de crédito";
            this.CrearNotaCredito.UseVisualStyleBackColor = true;
            this.CrearNotaCredito.Click += new System.EventHandler(this.CrearNotaCredito_Click);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Location = new System.Drawing.Point(10, 99);
            this.DgvPedidos.MultiSelect = false;
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(974, 331);
            this.DgvPedidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por código de nota de crédito:";
            // 
            // CodNotaCreditoBusquedaTextBox
            // 
            this.CodNotaCreditoBusquedaTextBox.Location = new System.Drawing.Point(281, 50);
            this.CodNotaCreditoBusquedaTextBox.Name = "CodNotaCreditoBusquedaTextBox";
            this.CodNotaCreditoBusquedaTextBox.Size = new System.Drawing.Size(139, 27);
            this.CodNotaCreditoBusquedaTextBox.TabIndex = 3;
            this.CodNotaCreditoBusquedaTextBox.TextChanged += new System.EventHandler(this.CodNotaCreditoBusquedaTextBox_TextChanged);
            // 
            // FrmNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 516);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNotaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Crédito (ventas)";
            this.Load += new System.EventHandler(this.FrmNotaCredito_Load);
            this.SizeChanged += new System.EventHandler(this.FrmNotaCredito_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabListadoNotasCredito.ResumeLayout(false);
            this.TabListadoNotasCredito.PerformLayout();
            this.TabPedidosDev.ResumeLayout(false);
            this.TabPedidosDev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoNotasCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListadoNotasCredito;
        private System.Windows.Forms.TextBox CodNotaCreditoBusquedaTextBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton BorrarNotaCreditoButton;
        private System.Windows.Forms.DataGridView DgvListadoNotasCredito;
        private System.Windows.Forms.TabPage TabPedidosDev;
        private MaterialSkin.Controls.MaterialFlatButton CrearNotaCredito;
        private System.Windows.Forms.DataGridView DgvPedidos;
    }
}
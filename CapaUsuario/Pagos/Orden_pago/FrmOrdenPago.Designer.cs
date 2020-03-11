namespace CapaUsuario.Pagos.Orden_pago
{
    partial class FrmOrdenPago
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
            this.LeerObservacionesButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BorrarOrdenPagoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CodOrdenPagoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListadoOrdenes = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBancosProveedor = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GrabarOrdenButton = new System.Windows.Forms.Button();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TabFacturas = new System.Windows.Forms.TabPage();
            this.CrearOrdenPagoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoOrdenes)).BeginInit();
            this.TabNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancosProveedor)).BeginInit();
            this.TabFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(997, 46);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Controls.Add(this.TabFacturas);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 46);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(997, 465);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListado
            // 
            this.TabListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListado.Controls.Add(this.LeerObservacionesButton);
            this.TabListado.Controls.Add(this.BorrarOrdenPagoButton);
            this.TabListado.Controls.Add(this.CodOrdenPagoTextBox);
            this.TabListado.Controls.Add(this.label1);
            this.TabListado.Controls.Add(this.DgvListadoOrdenes);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(989, 432);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "Listado";
            // 
            // LeerObservacionesButton
            // 
            this.LeerObservacionesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeerObservacionesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeerObservacionesButton.Depth = 0;
            this.LeerObservacionesButton.Location = new System.Drawing.Point(742, 38);
            this.LeerObservacionesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeerObservacionesButton.Name = "LeerObservacionesButton";
            this.LeerObservacionesButton.Primary = true;
            this.LeerObservacionesButton.Size = new System.Drawing.Size(203, 38);
            this.LeerObservacionesButton.TabIndex = 4;
            this.LeerObservacionesButton.Text = "Leer observaciones";
            this.LeerObservacionesButton.UseVisualStyleBackColor = true;
            this.LeerObservacionesButton.Click += new System.EventHandler(this.LeerObservacionesButton_Click);
            // 
            // BorrarOrdenPagoButton
            // 
            this.BorrarOrdenPagoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarOrdenPagoButton.AutoSize = true;
            this.BorrarOrdenPagoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarOrdenPagoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarOrdenPagoButton.Depth = 0;
            this.BorrarOrdenPagoButton.Location = new System.Drawing.Point(553, 39);
            this.BorrarOrdenPagoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarOrdenPagoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarOrdenPagoButton.Name = "BorrarOrdenPagoButton";
            this.BorrarOrdenPagoButton.Primary = false;
            this.BorrarOrdenPagoButton.Size = new System.Drawing.Size(173, 36);
            this.BorrarOrdenPagoButton.TabIndex = 3;
            this.BorrarOrdenPagoButton.Text = "Borrar orden de pago";
            this.BorrarOrdenPagoButton.UseVisualStyleBackColor = true;
            this.BorrarOrdenPagoButton.Click += new System.EventHandler(this.BorrarOrdenPagoButton_Click);
            // 
            // CodOrdenPagoTextBox
            // 
            this.CodOrdenPagoTextBox.Location = new System.Drawing.Point(185, 44);
            this.CodOrdenPagoTextBox.MaxLength = 5;
            this.CodOrdenPagoTextBox.Name = "CodOrdenPagoTextBox";
            this.CodOrdenPagoTextBox.Size = new System.Drawing.Size(117, 27);
            this.CodOrdenPagoTextBox.TabIndex = 2;
            this.CodOrdenPagoTextBox.TextChanged += new System.EventHandler(this.CodOrdenPagoTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código orden de pago:";
            // 
            // DgvListadoOrdenes
            // 
            this.DgvListadoOrdenes.AllowUserToAddRows = false;
            this.DgvListadoOrdenes.AllowUserToDeleteRows = false;
            this.DgvListadoOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoOrdenes.Location = new System.Drawing.Point(8, 93);
            this.DgvListadoOrdenes.MultiSelect = false;
            this.DgvListadoOrdenes.Name = "DgvListadoOrdenes";
            this.DgvListadoOrdenes.ReadOnly = true;
            this.DgvListadoOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoOrdenes.Size = new System.Drawing.Size(973, 324);
            this.DgvListadoOrdenes.TabIndex = 0;
            // 
            // TabNueva
            // 
            this.TabNueva.Controls.Add(this.label3);
            this.TabNueva.Controls.Add(this.dgvBancosProveedor);
            this.TabNueva.Controls.Add(this.CancelarButton);
            this.TabNueva.Controls.Add(this.GrabarOrdenButton);
            this.TabNueva.Controls.Add(this.ObservacionesTextBox);
            this.TabNueva.Controls.Add(this.label2);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(989, 432);
            this.TabNueva.TabIndex = 1;
            this.TabNueva.Text = "Nueva orden";
            this.TabNueva.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seleccione una cuenta bancaria donde pagar";
            // 
            // dgvBancosProveedor
            // 
            this.dgvBancosProveedor.AllowUserToAddRows = false;
            this.dgvBancosProveedor.AllowUserToDeleteRows = false;
            this.dgvBancosProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvBancosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancosProveedor.Location = new System.Drawing.Point(27, 58);
            this.dgvBancosProveedor.MultiSelect = false;
            this.dgvBancosProveedor.Name = "dgvBancosProveedor";
            this.dgvBancosProveedor.ReadOnly = true;
            this.dgvBancosProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBancosProveedor.Size = new System.Drawing.Size(444, 195);
            this.dgvBancosProveedor.TabIndex = 21;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(264, 338);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarButton.TabIndex = 20;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GrabarOrdenButton
            // 
            this.GrabarOrdenButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrabarOrdenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrabarOrdenButton.Enabled = false;
            this.GrabarOrdenButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrabarOrdenButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GrabarOrdenButton.Location = new System.Drawing.Point(444, 338);
            this.GrabarOrdenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrabarOrdenButton.Name = "GrabarOrdenButton";
            this.GrabarOrdenButton.Size = new System.Drawing.Size(204, 54);
            this.GrabarOrdenButton.TabIndex = 19;
            this.GrabarOrdenButton.Text = "Grabar orden";
            this.GrabarOrdenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GrabarOrdenButton.UseVisualStyleBackColor = true;
            this.GrabarOrdenButton.Click += new System.EventHandler(this.GrabarOrdenButton_Click);
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ObservacionesTextBox.Location = new System.Drawing.Point(477, 58);
            this.ObservacionesTextBox.MaxLength = 400;
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.ReadOnly = true;
            this.ObservacionesTextBox.Size = new System.Drawing.Size(493, 195);
            this.ObservacionesTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Observaciones:";
            // 
            // TabFacturas
            // 
            this.TabFacturas.Controls.Add(this.CrearOrdenPagoButton);
            this.TabFacturas.Controls.Add(this.DgvFacturas);
            this.TabFacturas.Location = new System.Drawing.Point(4, 29);
            this.TabFacturas.Name = "TabFacturas";
            this.TabFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.TabFacturas.Size = new System.Drawing.Size(989, 432);
            this.TabFacturas.TabIndex = 2;
            this.TabFacturas.Text = "Facturas a proveedores";
            this.TabFacturas.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenPagoButton
            // 
            this.CrearOrdenPagoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearOrdenPagoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearOrdenPagoButton.Depth = 0;
            this.CrearOrdenPagoButton.Location = new System.Drawing.Point(726, 33);
            this.CrearOrdenPagoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearOrdenPagoButton.Name = "CrearOrdenPagoButton";
            this.CrearOrdenPagoButton.Primary = true;
            this.CrearOrdenPagoButton.Size = new System.Drawing.Size(189, 38);
            this.CrearOrdenPagoButton.TabIndex = 2;
            this.CrearOrdenPagoButton.Text = "Crear orden de pago";
            this.CrearOrdenPagoButton.UseVisualStyleBackColor = true;
            this.CrearOrdenPagoButton.Click += new System.EventHandler(this.CrearOrdenPagoButton_Click);
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.AllowUserToAddRows = false;
            this.DgvFacturas.AllowUserToDeleteRows = false;
            this.DgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(8, 93);
            this.DgvFacturas.MultiSelect = false;
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.ReadOnly = true;
            this.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFacturas.Size = new System.Drawing.Size(973, 331);
            this.DgvFacturas.TabIndex = 1;
            // 
            // FrmOrdenPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 511);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrdenPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Pago";
            this.Load += new System.EventHandler(this.FrmOrdenPago_Load);
            this.SizeChanged += new System.EventHandler(this.FrmOrdenPago_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoOrdenes)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancosProveedor)).EndInit();
            this.TabFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.TabPage TabNueva;
        private System.Windows.Forms.TabPage TabFacturas;
        private System.Windows.Forms.TextBox CodOrdenPagoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListadoOrdenes;
        private System.Windows.Forms.DataGridView DgvFacturas;
        private MaterialSkin.Controls.MaterialFlatButton BorrarOrdenPagoButton;
        private MaterialSkin.Controls.MaterialRaisedButton CrearOrdenPagoButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GrabarOrdenButton;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton LeerObservacionesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBancosProveedor;
    }
}
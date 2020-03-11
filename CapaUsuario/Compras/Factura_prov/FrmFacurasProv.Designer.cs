namespace CapaUsuario.Compras.Factura_prov
{
    partial class FrmFacurasProv
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CodFacturaBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarFacturaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ModificarFacturaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NuevaFacturaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelarNuevoButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.NumFacTextBox = new System.Windows.Forms.TextBox();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesCompra)).BeginInit();
            this.TabNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1059, 46);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 46);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1059, 478);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.CodFacturaBusquedaTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BorrarFacturaButton);
            this.tabPage1.Controls.Add(this.ModificarFacturaButton);
            this.tabPage1.Controls.Add(this.DgvFacturas);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Facturas";
            // 
            // CodFacturaBusquedaTextBox
            // 
            this.CodFacturaBusquedaTextBox.Location = new System.Drawing.Point(161, 26);
            this.CodFacturaBusquedaTextBox.Name = "CodFacturaBusquedaTextBox";
            this.CodFacturaBusquedaTextBox.Size = new System.Drawing.Size(124, 27);
            this.CodFacturaBusquedaTextBox.TabIndex = 4;
            this.CodFacturaBusquedaTextBox.TextChanged += new System.EventHandler(this.CodFacturaBusquedaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código de factura:";
            // 
            // BorrarFacturaButton
            // 
            this.BorrarFacturaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarFacturaButton.AutoSize = true;
            this.BorrarFacturaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarFacturaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarFacturaButton.Depth = 0;
            this.BorrarFacturaButton.Location = new System.Drawing.Point(775, 21);
            this.BorrarFacturaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarFacturaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarFacturaButton.Name = "BorrarFacturaButton";
            this.BorrarFacturaButton.Primary = false;
            this.BorrarFacturaButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarFacturaButton.TabIndex = 2;
            this.BorrarFacturaButton.Text = "Borrar";
            this.BorrarFacturaButton.UseVisualStyleBackColor = true;
            this.BorrarFacturaButton.Click += new System.EventHandler(this.BorrarFacturaButton_Click);
            // 
            // ModificarFacturaButton
            // 
            this.ModificarFacturaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModificarFacturaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarFacturaButton.Depth = 0;
            this.ModificarFacturaButton.Location = new System.Drawing.Point(875, 21);
            this.ModificarFacturaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarFacturaButton.Name = "ModificarFacturaButton";
            this.ModificarFacturaButton.Primary = true;
            this.ModificarFacturaButton.Size = new System.Drawing.Size(112, 37);
            this.ModificarFacturaButton.TabIndex = 1;
            this.ModificarFacturaButton.Text = "Modificar";
            this.ModificarFacturaButton.UseVisualStyleBackColor = true;
            this.ModificarFacturaButton.Click += new System.EventHandler(this.ModificarFacturaButton_Click);
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.AllowUserToAddRows = false;
            this.DgvFacturas.AllowUserToDeleteRows = false;
            this.DgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(8, 76);
            this.DgvFacturas.MultiSelect = false;
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.ReadOnly = true;
            this.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFacturas.Size = new System.Drawing.Size(1035, 361);
            this.DgvFacturas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NuevaFacturaButton);
            this.tabPage2.Controls.Add(this.DgvOrdenesCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ordenes de compra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NuevaFacturaButton
            // 
            this.NuevaFacturaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevaFacturaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevaFacturaButton.Depth = 0;
            this.NuevaFacturaButton.Location = new System.Drawing.Point(852, 21);
            this.NuevaFacturaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NuevaFacturaButton.Name = "NuevaFacturaButton";
            this.NuevaFacturaButton.Primary = true;
            this.NuevaFacturaButton.Size = new System.Drawing.Size(135, 37);
            this.NuevaFacturaButton.TabIndex = 2;
            this.NuevaFacturaButton.Text = "Nueva factura";
            this.NuevaFacturaButton.UseVisualStyleBackColor = true;
            this.NuevaFacturaButton.Click += new System.EventHandler(this.NuevaFacturaButton_Click);
            // 
            // DgvOrdenesCompra
            // 
            this.DgvOrdenesCompra.AllowUserToAddRows = false;
            this.DgvOrdenesCompra.AllowUserToDeleteRows = false;
            this.DgvOrdenesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenesCompra.Location = new System.Drawing.Point(8, 76);
            this.DgvOrdenesCompra.MultiSelect = false;
            this.DgvOrdenesCompra.Name = "DgvOrdenesCompra";
            this.DgvOrdenesCompra.ReadOnly = true;
            this.DgvOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrdenesCompra.Size = new System.Drawing.Size(1035, 361);
            this.DgvOrdenesCompra.TabIndex = 1;
            // 
            // TabNueva
            // 
            this.TabNueva.Controls.Add(this.label6);
            this.TabNueva.Controls.Add(this.label5);
            this.TabNueva.Controls.Add(this.CancelarNuevoButton);
            this.TabNueva.Controls.Add(this.GuardarDatosButton);
            this.TabNueva.Controls.Add(this.ObservacionesTextBox);
            this.TabNueva.Controls.Add(this.NumFacTextBox);
            this.TabNueva.Controls.Add(this.ImporteTextBox);
            this.TabNueva.Controls.Add(this.label4);
            this.TabNueva.Controls.Add(this.label3);
            this.TabNueva.Controls.Add(this.label2);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(1051, 445);
            this.TabNueva.TabIndex = 2;
            this.TabNueva.Text = "Nueva factura / Editar factura";
            this.TabNueva.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "**calculado a partir de cotizaciones";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(426, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "$";
            // 
            // CancelarNuevoButton
            // 
            this.CancelarNuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarNuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarNuevoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarNuevoButton.Enabled = false;
            this.CancelarNuevoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarNuevoButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarNuevoButton.Location = new System.Drawing.Point(290, 377);
            this.CancelarNuevoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarNuevoButton.Name = "CancelarNuevoButton";
            this.CancelarNuevoButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarNuevoButton.TabIndex = 6;
            this.CancelarNuevoButton.Text = "Cancelar";
            this.CancelarNuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarNuevoButton.UseVisualStyleBackColor = true;
            this.CancelarNuevoButton.Click += new System.EventHandler(this.CancelarNuevoButton_Click);
            // 
            // GuardarDatosButton
            // 
            this.GuardarDatosButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuardarDatosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarDatosButton.Enabled = false;
            this.GuardarDatosButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarDatosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GuardarDatosButton.Location = new System.Drawing.Point(487, 377);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarDatosButton.TabIndex = 7;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ObservacionesTextBox.Location = new System.Drawing.Point(235, 153);
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.ReadOnly = true;
            this.ObservacionesTextBox.Size = new System.Drawing.Size(500, 196);
            this.ObservacionesTextBox.TabIndex = 5;
            // 
            // NumFacTextBox
            // 
            this.NumFacTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.NumFacTextBox, 5);
            this.NumFacTextBox.Location = new System.Drawing.Point(235, 97);
            this.NumFacTextBox.MaxLength = 8;
            this.NumFacTextBox.Name = "NumFacTextBox";
            this.NumFacTextBox.ReadOnly = true;
            this.NumFacTextBox.Size = new System.Drawing.Size(181, 27);
            this.NumFacTextBox.TabIndex = 3;
            this.NumFacTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorProvider1.SetIconPadding(this.ImporteTextBox, 5);
            this.ImporteTextBox.Location = new System.Drawing.Point(235, 41);
            this.ImporteTextBox.MaxLength = 8;
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.ReadOnly = true;
            this.ImporteTextBox.Size = new System.Drawing.Size(181, 27);
            this.ImporteTextBox.TabIndex = 1;
            this.ImporteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observaciones:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de factura:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Importe**:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmFacurasProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 524);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFacurasProv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas Proveedores";
            this.Load += new System.EventHandler(this.FrmFacurasProv_Load);
            this.SizeChanged += new System.EventHandler(this.FrmFacurasProv_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesCompra)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TabNueva;
        private System.Windows.Forms.TextBox CodFacturaBusquedaTextBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton BorrarFacturaButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarFacturaButton;
        private System.Windows.Forms.DataGridView DgvFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton NuevaFacturaButton;
        private System.Windows.Forms.DataGridView DgvOrdenesCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.TextBox NumFacTextBox;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button CancelarNuevoButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
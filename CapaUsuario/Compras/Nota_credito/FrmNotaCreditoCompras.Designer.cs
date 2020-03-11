namespace CapaUsuario.Compras.Nota_credito
{
    partial class FrmNotaCreditoCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotaCreditoCompras));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.SumadoCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.CodNotaBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarNotaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ModificarNotaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvNotas = new System.Windows.Forms.DataGridView();
            this.TabPedidos = new System.Windows.Forms.TabPage();
            this.CrearNotaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.CancelarNuevoButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.ImporteLabel = new System.Windows.Forms.Label();
            this.DetalleTextBox = new System.Windows.Forms.TextBox();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).BeginInit();
            this.TabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
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
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1017, 42);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Controls.Add(this.TabPedidos);
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 42);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1017, 481);
            this.materialTabControl1.TabIndex = 1;
            // 
            // TabListado
            // 
            this.TabListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListado.Controls.Add(this.label2);
            this.TabListado.Controls.Add(this.SumadoCheckBox);
            this.TabListado.Controls.Add(this.CodNotaBusquedaTextBox);
            this.TabListado.Controls.Add(this.label1);
            this.TabListado.Controls.Add(this.BorrarNotaButton);
            this.TabListado.Controls.Add(this.ModificarNotaButton);
            this.TabListado.Controls.Add(this.DgvNotas);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(1009, 448);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "Listado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sumado";
            // 
            // SumadoCheckBox
            // 
            this.SumadoCheckBox.AutoSize = true;
            this.SumadoCheckBox.Depth = 0;
            this.SumadoCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.SumadoCheckBox.Location = new System.Drawing.Point(301, 40);
            this.SumadoCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.SumadoCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SumadoCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SumadoCheckBox.Name = "SumadoCheckBox";
            this.SumadoCheckBox.Ripple = true;
            this.SumadoCheckBox.Size = new System.Drawing.Size(26, 30);
            this.SumadoCheckBox.TabIndex = 6;
            this.SumadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CodNotaBusquedaTextBox
            // 
            this.CodNotaBusquedaTextBox.Location = new System.Drawing.Point(133, 42);
            this.CodNotaBusquedaTextBox.MaxLength = 5;
            this.CodNotaBusquedaTextBox.Name = "CodNotaBusquedaTextBox";
            this.CodNotaBusquedaTextBox.Size = new System.Drawing.Size(121, 27);
            this.CodNotaBusquedaTextBox.TabIndex = 5;
            this.CodNotaBusquedaTextBox.TextChanged += new System.EventHandler(this.CodNotaBusquedaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código nota:";
            // 
            // BorrarNotaButton
            // 
            this.BorrarNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarNotaButton.AutoSize = true;
            this.BorrarNotaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarNotaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarNotaButton.Depth = 0;
            this.BorrarNotaButton.Location = new System.Drawing.Point(685, 37);
            this.BorrarNotaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarNotaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarNotaButton.Name = "BorrarNotaButton";
            this.BorrarNotaButton.Primary = false;
            this.BorrarNotaButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarNotaButton.TabIndex = 3;
            this.BorrarNotaButton.Text = "Borrar";
            this.BorrarNotaButton.UseVisualStyleBackColor = true;
            this.BorrarNotaButton.Click += new System.EventHandler(this.BorrarNotaButton_Click);
            // 
            // ModificarNotaButton
            // 
            this.ModificarNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModificarNotaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarNotaButton.Depth = 0;
            this.ModificarNotaButton.Location = new System.Drawing.Point(787, 35);
            this.ModificarNotaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarNotaButton.Name = "ModificarNotaButton";
            this.ModificarNotaButton.Primary = true;
            this.ModificarNotaButton.Size = new System.Drawing.Size(153, 40);
            this.ModificarNotaButton.TabIndex = 2;
            this.ModificarNotaButton.Text = "Modificar";
            this.ModificarNotaButton.UseVisualStyleBackColor = true;
            this.ModificarNotaButton.Click += new System.EventHandler(this.ModificarNotaButton_Click);
            // 
            // DgvNotas
            // 
            this.DgvNotas.AllowUserToAddRows = false;
            this.DgvNotas.AllowUserToDeleteRows = false;
            this.DgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNotas.Location = new System.Drawing.Point(8, 97);
            this.DgvNotas.MultiSelect = false;
            this.DgvNotas.Name = "DgvNotas";
            this.DgvNotas.ReadOnly = true;
            this.DgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvNotas.Size = new System.Drawing.Size(993, 343);
            this.DgvNotas.TabIndex = 1;
            // 
            // TabPedidos
            // 
            this.TabPedidos.Controls.Add(this.CrearNotaButton);
            this.TabPedidos.Controls.Add(this.DgvPedidos);
            this.TabPedidos.Location = new System.Drawing.Point(4, 29);
            this.TabPedidos.Name = "TabPedidos";
            this.TabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPedidos.Size = new System.Drawing.Size(1009, 448);
            this.TabPedidos.TabIndex = 1;
            this.TabPedidos.Text = "Pedidos de devolucion";
            this.TabPedidos.UseVisualStyleBackColor = true;
            // 
            // CrearNotaButton
            // 
            this.CrearNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearNotaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearNotaButton.Depth = 0;
            this.CrearNotaButton.Location = new System.Drawing.Point(787, 35);
            this.CrearNotaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearNotaButton.Name = "CrearNotaButton";
            this.CrearNotaButton.Primary = true;
            this.CrearNotaButton.Size = new System.Drawing.Size(153, 40);
            this.CrearNotaButton.TabIndex = 3;
            this.CrearNotaButton.Text = "Crear nota";
            this.CrearNotaButton.UseVisualStyleBackColor = true;
            this.CrearNotaButton.Click += new System.EventHandler(this.CrearNotaButton_Click);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Location = new System.Drawing.Point(8, 97);
            this.DgvPedidos.MultiSelect = false;
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(993, 343);
            this.DgvPedidos.TabIndex = 0;
            // 
            // TabNueva
            // 
            this.TabNueva.Controls.Add(this.CancelarNuevoButton);
            this.TabNueva.Controls.Add(this.GuardarDatosButton);
            this.TabNueva.Controls.Add(this.ImporteLabel);
            this.TabNueva.Controls.Add(this.DetalleTextBox);
            this.TabNueva.Controls.Add(this.ImporteTextBox);
            this.TabNueva.Controls.Add(this.label4);
            this.TabNueva.Controls.Add(this.label3);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(1009, 448);
            this.TabNueva.TabIndex = 2;
            this.TabNueva.Text = "Nueva nota / Editar nota";
            this.TabNueva.UseVisualStyleBackColor = true;
            // 
            // CancelarNuevoButton
            // 
            this.CancelarNuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarNuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarNuevoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarNuevoButton.Enabled = false;
            this.CancelarNuevoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarNuevoButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarNuevoButton.Location = new System.Drawing.Point(357, 371);
            this.CancelarNuevoButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 20);
            this.CancelarNuevoButton.Name = "CancelarNuevoButton";
            this.CancelarNuevoButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarNuevoButton.TabIndex = 28;
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
            this.GuardarDatosButton.Location = new System.Drawing.Point(554, 371);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 20);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarDatosButton.TabIndex = 29;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.AutoSize = true;
            this.ImporteLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.ImporteLabel.ForeColor = System.Drawing.Color.Green;
            this.ImporteLabel.Location = new System.Drawing.Point(498, 46);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(22, 25);
            this.ImporteLabel.TabIndex = 4;
            this.ImporteLabel.Text = "$";
            // 
            // DetalleTextBox
            // 
            this.DetalleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleTextBox.Location = new System.Drawing.Point(311, 112);
            this.DetalleTextBox.MaxLength = 400;
            this.DetalleTextBox.Multiline = true;
            this.DetalleTextBox.Name = "DetalleTextBox";
            this.DetalleTextBox.ReadOnly = true;
            this.DetalleTextBox.Size = new System.Drawing.Size(523, 231);
            this.DetalleTextBox.TabIndex = 3;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Location = new System.Drawing.Point(311, 48);
            this.ImporteTextBox.MaxLength = 8;
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.ReadOnly = true;
            this.ImporteTextBox.Size = new System.Drawing.Size(168, 27);
            this.ImporteTextBox.TabIndex = 2;
            this.ImporteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Detalle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Importe:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmNotaCreditoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 523);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNotaCreditoCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas de crédito";
            this.Load += new System.EventHandler(this.FrmNotaCreditoCompras_Load);
            this.SizeChanged += new System.EventHandler(this.FrmNotaCreditoCompras_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).EndInit();
            this.TabPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.TabPage TabPedidos;
        private System.Windows.Forms.TabPage TabNueva;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.DataGridView DgvNotas;
        private MaterialSkin.Controls.MaterialFlatButton BorrarNotaButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarNotaButton;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCheckBox SumadoCheckBox;
        private System.Windows.Forms.TextBox CodNotaBusquedaTextBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton CrearNotaButton;
        private System.Windows.Forms.TextBox DetalleTextBox;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ImporteLabel;
        private System.Windows.Forms.Button CancelarNuevoButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
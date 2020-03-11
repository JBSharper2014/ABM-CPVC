namespace CapaUsuario.Compras.Solicitud_de_compra
{
    partial class FrmModificarSolicitudCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarSolicitudCompra));
            this.DepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CanceladaCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.GuardarCambiosButton = new System.Windows.Forms.Button();
            this.CancelarModificacionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartamentoComboBox
            // 
            this.DepartamentoComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.DepartamentoComboBox.FormattingEnabled = true;
            this.DepartamentoComboBox.Items.AddRange(new object[] {
            "Logística",
            "Facturación",
            "Recepción",
            "Contaduría",
            "Cajeros"});
            this.DepartamentoComboBox.Location = new System.Drawing.Point(187, 87);
            this.DepartamentoComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartamentoComboBox.Name = "DepartamentoComboBox";
            this.DepartamentoComboBox.Size = new System.Drawing.Size(219, 28);
            this.DepartamentoComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departamento:";
            // 
            // CanceladaCheckBox
            // 
            this.CanceladaCheckBox.AutoSize = true;
            this.CanceladaCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanceladaCheckBox.Depth = 0;
            this.CanceladaCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.CanceladaCheckBox.Location = new System.Drawing.Point(187, 146);
            this.CanceladaCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.CanceladaCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CanceladaCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CanceladaCheckBox.Name = "CanceladaCheckBox";
            this.CanceladaCheckBox.Ripple = true;
            this.CanceladaCheckBox.Size = new System.Drawing.Size(95, 30);
            this.CanceladaCheckBox.TabIndex = 7;
            this.CanceladaCheckBox.Text = "Cancelada";
            this.CanceladaCheckBox.UseVisualStyleBackColor = true;
            // 
            // GuardarCambiosButton
            // 
            this.GuardarCambiosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarCambiosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_32;
            this.GuardarCambiosButton.Location = new System.Drawing.Point(258, 213);
            this.GuardarCambiosButton.Name = "GuardarCambiosButton";
            this.GuardarCambiosButton.Size = new System.Drawing.Size(175, 44);
            this.GuardarCambiosButton.TabIndex = 9;
            this.GuardarCambiosButton.Text = "Guardar datos";
            this.GuardarCambiosButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarCambiosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarCambiosButton.UseVisualStyleBackColor = true;
            this.GuardarCambiosButton.Click += new System.EventHandler(this.GuardarCambiosButton_Click);
            // 
            // CancelarModificacionButton
            // 
            this.CancelarModificacionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarModificacionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarModificacionButton.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.CancelarModificacionButton.Location = new System.Drawing.Point(95, 213);
            this.CancelarModificacionButton.Name = "CancelarModificacionButton";
            this.CancelarModificacionButton.Size = new System.Drawing.Size(118, 44);
            this.CancelarModificacionButton.TabIndex = 8;
            this.CancelarModificacionButton.Text = "Cancelar";
            this.CancelarModificacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarModificacionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarModificacionButton.UseVisualStyleBackColor = true;
            this.CancelarModificacionButton.Click += new System.EventHandler(this.CancelarModificacionButton_Click);
            // 
            // FrmModificarSolicitudCompra
            // 
            this.AcceptButton = this.GuardarCambiosButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarModificacionButton;
            this.ClientSize = new System.Drawing.Size(484, 283);
            this.Controls.Add(this.GuardarCambiosButton);
            this.Controls.Add(this.CancelarModificacionButton);
            this.Controls.Add(this.CanceladaCheckBox);
            this.Controls.Add(this.DepartamentoComboBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarSolicitudCompra";
            this.Text = "Modificar Solicitud de Compra";
            this.Load += new System.EventHandler(this.FrmModificarSolicitudCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartamentoComboBox;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCheckBox CanceladaCheckBox;
        private System.Windows.Forms.Button GuardarCambiosButton;
        private System.Windows.Forms.Button CancelarModificacionButton;
    }
}
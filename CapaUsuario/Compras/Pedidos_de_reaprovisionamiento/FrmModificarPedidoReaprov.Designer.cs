namespace CapaUsuario.Compras.Pedidos_de_reaprovisionamiento
{
    partial class FrmModificarPedidoReaprov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarPedidoReaprov));
            this.GuardarCambiosButton = new System.Windows.Forms.Button();
            this.CancelarModificacionButton = new System.Windows.Forms.Button();
            this.CanceladoCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // GuardarCambiosButton
            // 
            this.GuardarCambiosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarCambiosButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarCambiosButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.GuardarCambiosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_32;
            this.GuardarCambiosButton.Location = new System.Drawing.Point(224, 152);
            this.GuardarCambiosButton.Name = "GuardarCambiosButton";
            this.GuardarCambiosButton.Size = new System.Drawing.Size(175, 44);
            this.GuardarCambiosButton.TabIndex = 12;
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
            this.CancelarModificacionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarModificacionButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.CancelarModificacionButton.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.CancelarModificacionButton.Location = new System.Drawing.Point(81, 152);
            this.CancelarModificacionButton.Name = "CancelarModificacionButton";
            this.CancelarModificacionButton.Size = new System.Drawing.Size(118, 44);
            this.CancelarModificacionButton.TabIndex = 11;
            this.CancelarModificacionButton.Text = "Cancelar";
            this.CancelarModificacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarModificacionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarModificacionButton.UseVisualStyleBackColor = true;
            this.CancelarModificacionButton.Click += new System.EventHandler(this.CancelarModificacionButton_Click);
            // 
            // CanceladoCheckBox
            // 
            this.CanceladoCheckBox.AutoSize = true;
            this.CanceladoCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanceladoCheckBox.Depth = 0;
            this.CanceladoCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.CanceladoCheckBox.Location = new System.Drawing.Point(173, 90);
            this.CanceladoCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.CanceladoCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CanceladoCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CanceladoCheckBox.Name = "CanceladoCheckBox";
            this.CanceladoCheckBox.Ripple = true;
            this.CanceladoCheckBox.Size = new System.Drawing.Size(95, 30);
            this.CanceladoCheckBox.TabIndex = 10;
            this.CanceladoCheckBox.Text = "Cancelado";
            this.CanceladoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmModificarPedidoReaprov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 230);
            this.Controls.Add(this.GuardarCambiosButton);
            this.Controls.Add(this.CancelarModificacionButton);
            this.Controls.Add(this.CanceladoCheckBox);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarPedidoReaprov";
            this.Text = "Modificar Pedido de Reaprovisionamiento";
            this.Load += new System.EventHandler(this.FrmModificarPedidoReaprov_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarCambiosButton;
        private System.Windows.Forms.Button CancelarModificacionButton;
        private MaterialSkin.Controls.MaterialCheckBox CanceladoCheckBox;
    }
}
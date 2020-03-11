namespace CapaUsuario.Compras.Bancos
{
    partial class Bancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bancos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBUTextBox = new System.Windows.Forms.TextBox();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.CancelarBancoButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DgvCBU = new System.Windows.Forms.DataGridView();
            this.RazonSocialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCBU)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CBU:";
            // 
            // CBUTextBox
            // 
            this.errorProvider1.SetIconPadding(this.CBUTextBox, 5);
            this.CBUTextBox.Location = new System.Drawing.Point(275, 173);
            this.CBUTextBox.MaxLength = 22;
            this.CBUTextBox.Name = "CBUTextBox";
            this.CBUTextBox.Size = new System.Drawing.Size(178, 27);
            this.CBUTextBox.TabIndex = 3;
            // 
            // GuardarDatosButton
            // 
            this.GuardarDatosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarDatosButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarDatosButton.Image = global::CapaUsuario.Properties.Resources.cool_save_32;
            this.GuardarDatosButton.Location = new System.Drawing.Point(304, 249);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(175, 44);
            this.GuardarDatosButton.TabIndex = 5;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarBancoButton_Click);
            // 
            // CancelarBancoButton
            // 
            this.CancelarBancoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarBancoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBancoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarBancoButton.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.CancelarBancoButton.Location = new System.Drawing.Point(141, 249);
            this.CancelarBancoButton.Name = "CancelarBancoButton";
            this.CancelarBancoButton.Size = new System.Drawing.Size(118, 44);
            this.CancelarBancoButton.TabIndex = 4;
            this.CancelarBancoButton.Text = "Cancelar";
            this.CancelarBancoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarBancoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarBancoButton.UseVisualStyleBackColor = true;
            this.CancelarBancoButton.Click += new System.EventHandler(this.CancelarBancoButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // DgvCBU
            // 
            this.DgvCBU.AllowUserToAddRows = false;
            this.DgvCBU.AllowUserToDeleteRows = false;
            this.DgvCBU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCBU.Location = new System.Drawing.Point(65, 331);
            this.DgvCBU.MultiSelect = false;
            this.DgvCBU.Name = "DgvCBU";
            this.DgvCBU.ReadOnly = true;
            this.DgvCBU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCBU.Size = new System.Drawing.Size(528, 186);
            this.DgvCBU.TabIndex = 6;
            // 
            // RazonSocialLabel
            // 
            this.RazonSocialLabel.AutoSize = true;
            this.RazonSocialLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RazonSocialLabel.Location = new System.Drawing.Point(271, 105);
            this.RazonSocialLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RazonSocialLabel.Name = "RazonSocialLabel";
            this.RazonSocialLabel.Size = new System.Drawing.Size(90, 20);
            this.RazonSocialLabel.TabIndex = 7;
            this.RazonSocialLabel.Text = "Razon social";
            // 
            // Bancos
            // 
            this.AcceptButton = this.GuardarDatosButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBancoButton;
            this.ClientSize = new System.Drawing.Size(658, 540);
            this.Controls.Add(this.RazonSocialLabel);
            this.Controls.Add(this.DgvCBU);
            this.Controls.Add(this.GuardarDatosButton);
            this.Controls.Add(this.CancelarBancoButton);
            this.Controls.Add(this.CBUTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bancos";
            this.Text = "Agregar CBU";
            this.Load += new System.EventHandler(this.Bancos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCBU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CBUTextBox;
        private System.Windows.Forms.Button CancelarBancoButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView DgvCBU;
        private System.Windows.Forms.Label RazonSocialLabel;
    }
}
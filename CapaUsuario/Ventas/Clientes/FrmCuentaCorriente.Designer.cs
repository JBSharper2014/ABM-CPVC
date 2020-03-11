namespace CapaUsuario.Ventas.Clientes
{
    partial class FrmCuentaCorriente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuentaCorriente));
            this.label1 = new System.Windows.Forms.Label();
            this.NombreClienteLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.DebeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HaberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DebeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // NombreClienteLabel
            // 
            this.NombreClienteLabel.AutoSize = true;
            this.NombreClienteLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NombreClienteLabel.Location = new System.Drawing.Point(183, 91);
            this.NombreClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreClienteLabel.Name = "NombreClienteLabel";
            this.NombreClienteLabel.Size = new System.Drawing.Size(107, 20);
            this.NombreClienteLabel.TabIndex = 1;
            this.NombreClienteLabel.Text = "nombre cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Debe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Haber:";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarButton.Image = global::CapaUsuario.Properties.Resources.cool_save_light_32;
            this.GuardarButton.Location = new System.Drawing.Point(240, 274);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(118, 44);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.CancelarButton.Location = new System.Drawing.Point(93, 274);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(118, 44);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // DebeNumericUpDown
            // 
            this.DebeNumericUpDown.DecimalPlaces = 2;
            this.DebeNumericUpDown.Location = new System.Drawing.Point(187, 145);
            this.DebeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DebeNumericUpDown.Name = "DebeNumericUpDown";
            this.DebeNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.DebeNumericUpDown.TabIndex = 8;
            this.DebeNumericUpDown.ThousandsSeparator = true;
            // 
            // HaberNumericUpDown
            // 
            this.HaberNumericUpDown.DecimalPlaces = 2;
            this.HaberNumericUpDown.Location = new System.Drawing.Point(187, 199);
            this.HaberNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.HaberNumericUpDown.Name = "HaberNumericUpDown";
            this.HaberNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.HaberNumericUpDown.TabIndex = 9;
            this.HaberNumericUpDown.ThousandsSeparator = true;
            // 
            // FrmCuentaCorriente
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(477, 355);
            this.Controls.Add(this.HaberNumericUpDown);
            this.Controls.Add(this.DebeNumericUpDown);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreClienteLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCuentaCorriente";
            this.Text = "Cuenta Corriente";
            this.Load += new System.EventHandler(this.FrmCuentaCorriente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DebeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreClienteLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.NumericUpDown DebeNumericUpDown;
        private System.Windows.Forms.NumericUpDown HaberNumericUpDown;
    }
}
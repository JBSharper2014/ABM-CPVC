namespace CapaUsuario.Ventas.Clientes
{
    partial class FrmListadoCuentasCorriente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoCuentasCorriente));
            this.DgvListadoCuentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListadoCuentas
            // 
            this.DgvListadoCuentas.AllowUserToAddRows = false;
            this.DgvListadoCuentas.AllowUserToDeleteRows = false;
            this.DgvListadoCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoCuentas.Location = new System.Drawing.Point(20, 112);
            this.DgvListadoCuentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvListadoCuentas.MultiSelect = false;
            this.DgvListadoCuentas.Name = "DgvListadoCuentas";
            this.DgvListadoCuentas.ReadOnly = true;
            this.DgvListadoCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoCuentas.Size = new System.Drawing.Size(660, 343);
            this.DgvListadoCuentas.TabIndex = 0;
            // 
            // FrmListadoCuentasCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 491);
            this.Controls.Add(this.DgvListadoCuentas);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListadoCuentasCorriente";
            this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
            this.Text = "Listado Cuentas Corriente";
            this.Load += new System.EventHandler(this.FrmListadoCuentasCorriente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListadoCuentas;
    }
}
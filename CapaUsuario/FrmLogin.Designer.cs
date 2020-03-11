namespace CapaUsuario
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.ButtonIngresar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UsuarioTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ClaveTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonIngresar
            // 
            this.ButtonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonIngresar.Depth = 0;
            this.ButtonIngresar.Location = new System.Drawing.Point(101, 230);
            this.ButtonIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonIngresar.Name = "ButtonIngresar";
            this.ButtonIngresar.Primary = true;
            this.ButtonIngresar.Size = new System.Drawing.Size(163, 34);
            this.ButtonIngresar.TabIndex = 4;
            this.ButtonIngresar.Text = "Ingresar";
            this.ButtonIngresar.UseVisualStyleBackColor = true;
            this.ButtonIngresar.Click += new System.EventHandler(this.ButtonIngresar_Click);
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalir.Depth = 0;
            this.ButtonSalir.Location = new System.Drawing.Point(331, 230);
            this.ButtonSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Primary = true;
            this.ButtonSalir.Size = new System.Drawing.Size(163, 34);
            this.ButtonSalir.TabIndex = 5;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Depth = 0;
            this.UsuarioTextBox.Hint = "Usuario";
            this.UsuarioTextBox.Location = new System.Drawing.Point(132, 99);
            this.UsuarioTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.PasswordChar = '\0';
            this.UsuarioTextBox.SelectedText = "";
            this.UsuarioTextBox.SelectionLength = 0;
            this.UsuarioTextBox.SelectionStart = 0;
            this.UsuarioTextBox.Size = new System.Drawing.Size(312, 23);
            this.UsuarioTextBox.TabIndex = 6;
            this.UsuarioTextBox.Text = "nacho";
            this.UsuarioTextBox.UseSystemPasswordChar = false;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Depth = 0;
            this.ClaveTextBox.Hint = "Clave";
            this.ClaveTextBox.Location = new System.Drawing.Point(132, 155);
            this.ClaveTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.SelectedText = "";
            this.ClaveTextBox.SelectionLength = 0;
            this.ClaveTextBox.SelectionStart = 0;
            this.ClaveTextBox.Size = new System.Drawing.Size(312, 23);
            this.ClaveTextBox.TabIndex = 7;
            this.ClaveTextBox.Text = "123";
            this.ClaveTextBox.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.ButtonIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 335);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.ButtonIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton ButtonIngresar;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField UsuarioTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField ClaveTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
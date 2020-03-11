namespace CapaUsuario.Compras.Bienes_de_uso
{
    partial class FrmBienUso
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
            System.Windows.Forms.Label cod_pro_busoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label observacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienUso));
            this._1_bien_usoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.StockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.DgvBienesUso = new System.Windows.Forms.DataGridView();
            this.cod_pro_busoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelarMarcaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.GuardarMarcaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AgregarMarcaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            cod_pro_busoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoBindingNavigator)).BeginInit();
            this._1_bien_usoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBienesUso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_pro_busoLabel
            // 
            cod_pro_busoLabel.AutoSize = true;
            cod_pro_busoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_pro_busoLabel.Location = new System.Drawing.Point(123, 79);
            cod_pro_busoLabel.Name = "cod_pro_busoLabel";
            cod_pro_busoLabel.Size = new System.Drawing.Size(167, 20);
            cod_pro_busoLabel.TabIndex = 2;
            cod_pro_busoLabel.Text = "Código de bien de uso*:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(217, 133);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 20);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre*:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(236, 187);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(54, 20);
            stockLabel.TabIndex = 6;
            stockLabel.Text = "Stock*:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(660, 79);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(87, 20);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripción:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacionLabel.Location = new System.Drawing.Point(639, 133);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(108, 20);
            observacionLabel.TabIndex = 10;
            observacionLabel.Text = "Observaciones:";
            // 
            // _1_bien_usoBindingNavigator
            // 
            this._1_bien_usoBindingNavigator.AddNewItem = null;
            this._1_bien_usoBindingNavigator.CountItem = null;
            this._1_bien_usoBindingNavigator.DeleteItem = null;
            this._1_bien_usoBindingNavigator.ImageScalingSize = new System.Drawing.Size(26, 26);
            this._1_bien_usoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorEditItem,
            this.StockBindingNavigatorSaveItem,
            this.bindingNavigatorCancel});
            this._1_bien_usoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._1_bien_usoBindingNavigator.MoveFirstItem = null;
            this._1_bien_usoBindingNavigator.MoveLastItem = null;
            this._1_bien_usoBindingNavigator.MoveNextItem = null;
            this._1_bien_usoBindingNavigator.MovePreviousItem = null;
            this._1_bien_usoBindingNavigator.Name = "_1_bien_usoBindingNavigator";
            this._1_bien_usoBindingNavigator.PositionItem = null;
            this._1_bien_usoBindingNavigator.Size = new System.Drawing.Size(1152, 33);
            this._1_bien_usoBindingNavigator.TabIndex = 0;
            this._1_bien_usoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::CapaUsuario.Properties.Resources.Nuevo;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::CapaUsuario.Properties.Resources.Borrar2;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = global::CapaUsuario.Properties.Resources.editWhite32;
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorEditItem.Text = "Editar";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // StockBindingNavigatorSaveItem
            // 
            this.StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StockBindingNavigatorSaveItem.Enabled = false;
            this.StockBindingNavigatorSaveItem.Image = global::CapaUsuario.Properties.Resources.save3;
            this.StockBindingNavigatorSaveItem.Name = "StockBindingNavigatorSaveItem";
            this.StockBindingNavigatorSaveItem.Size = new System.Drawing.Size(30, 30);
            this.StockBindingNavigatorSaveItem.Text = "Guardar datos";
            this.StockBindingNavigatorSaveItem.Click += new System.EventHandler(this._1_bien_usoBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancel
            // 
            this.bindingNavigatorCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancel.Enabled = false;
            this.bindingNavigatorCancel.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.bindingNavigatorCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancel.Name = "bindingNavigatorCancel";
            this.bindingNavigatorCancel.Size = new System.Drawing.Size(30, 30);
            this.bindingNavigatorCancel.Text = "Cancelar operación";
            this.bindingNavigatorCancel.Click += new System.EventHandler(this.bindingNavigatorCancel_Click);
            // 
            // DgvBienesUso
            // 
            this.DgvBienesUso.AllowUserToAddRows = false;
            this.DgvBienesUso.AllowUserToDeleteRows = false;
            this.DgvBienesUso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBienesUso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBienesUso.Location = new System.Drawing.Point(14, 478);
            this.DgvBienesUso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvBienesUso.MultiSelect = false;
            this.DgvBienesUso.Name = "DgvBienesUso";
            this.DgvBienesUso.ReadOnly = true;
            this.DgvBienesUso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBienesUso.Size = new System.Drawing.Size(1124, 250);
            this.DgvBienesUso.TabIndex = 1;
            // 
            // cod_pro_busoTextBox
            // 
            this.cod_pro_busoTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_pro_busoTextBox.Location = new System.Drawing.Point(301, 76);
            this.cod_pro_busoTextBox.Name = "cod_pro_busoTextBox";
            this.cod_pro_busoTextBox.ReadOnly = true;
            this.cod_pro_busoTextBox.Size = new System.Drawing.Size(268, 27);
            this.cod_pro_busoTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconPadding(this.nombreTextBox, 5);
            this.nombreTextBox.Location = new System.Drawing.Point(301, 130);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(268, 27);
            this.nombreTextBox.TabIndex = 5;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconPadding(this.stockTextBox, 5);
            this.stockTextBox.Location = new System.Drawing.Point(301, 184);
            this.stockTextBox.MaxLength = 4;
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(268, 27);
            this.stockTextBox.TabIndex = 7;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(764, 76);
            this.descripcionTextBox.MaxLength = 50;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(268, 27);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionTextBox.Location = new System.Drawing.Point(764, 130);
            this.observacionTextBox.MaxLength = 200;
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.ReadOnly = true;
            this.observacionTextBox.Size = new System.Drawing.Size(325, 81);
            this.observacionTextBox.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DisplayMember = "cod_mar";
            this.MarcaComboBox.Enabled = false;
            this.MarcaComboBox.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.MarcaComboBox, 5);
            this.MarcaComboBox.Location = new System.Drawing.Point(35, 98);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(267, 28);
            this.MarcaComboBox.TabIndex = 1;
            this.MarcaComboBox.ValueMember = "cod_mar";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.CancelarMarcaButton);
            this.groupBox1.Controls.Add(this.GuardarMarcaButton);
            this.groupBox1.Controls.Add(this.MarcaComboBox);
            this.groupBox1.Controls.Add(this.AgregarMarcaButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.groupBox1.Location = new System.Drawing.Point(342, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar marca";
            // 
            // CancelarMarcaButton
            // 
            this.CancelarMarcaButton.AutoSize = true;
            this.CancelarMarcaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarMarcaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarMarcaButton.Depth = 0;
            this.CancelarMarcaButton.Enabled = false;
            this.CancelarMarcaButton.Location = new System.Drawing.Point(186, 36);
            this.CancelarMarcaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelarMarcaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarMarcaButton.Name = "CancelarMarcaButton";
            this.CancelarMarcaButton.Primary = false;
            this.CancelarMarcaButton.Size = new System.Drawing.Size(82, 36);
            this.CancelarMarcaButton.TabIndex = 3;
            this.CancelarMarcaButton.Text = "CANCELAR";
            this.CancelarMarcaButton.UseVisualStyleBackColor = true;
            this.CancelarMarcaButton.Click += new System.EventHandler(this.CancelarMarcaButton_Click);
            // 
            // GuardarMarcaButton
            // 
            this.GuardarMarcaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarMarcaButton.Depth = 0;
            this.GuardarMarcaButton.Enabled = false;
            this.GuardarMarcaButton.Location = new System.Drawing.Point(342, 96);
            this.GuardarMarcaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarMarcaButton.Name = "GuardarMarcaButton";
            this.GuardarMarcaButton.Primary = true;
            this.GuardarMarcaButton.Size = new System.Drawing.Size(117, 30);
            this.GuardarMarcaButton.TabIndex = 2;
            this.GuardarMarcaButton.Text = "Guardar";
            this.GuardarMarcaButton.UseVisualStyleBackColor = true;
            this.GuardarMarcaButton.Click += new System.EventHandler(this.GuardarMarcaButton_Click);
            // 
            // AgregarMarcaButton
            // 
            this.AgregarMarcaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarMarcaButton.Depth = 0;
            this.AgregarMarcaButton.Location = new System.Drawing.Point(35, 39);
            this.AgregarMarcaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarMarcaButton.Name = "AgregarMarcaButton";
            this.AgregarMarcaButton.Primary = true;
            this.AgregarMarcaButton.Size = new System.Drawing.Size(117, 30);
            this.AgregarMarcaButton.TabIndex = 0;
            this.AgregarMarcaButton.Text = "Agregar";
            this.AgregarMarcaButton.UseVisualStyleBackColor = true;
            this.AgregarMarcaButton.Click += new System.EventHandler(this.AgregarMarcaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label1.Location = new System.Drawing.Point(22, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtrar por nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.textBox1.Location = new System.Drawing.Point(159, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmBienUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 741);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(observacionLabel);
            this.Controls.Add(this.observacionTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(cod_pro_busoLabel);
            this.Controls.Add(this.cod_pro_busoTextBox);
            this.Controls.Add(this.DgvBienesUso);
            this.Controls.Add(this._1_bien_usoBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBienUso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienes de Uso";
            this.Load += new System.EventHandler(this.FrmBienUso_Load);
            this.SizeChanged += new System.EventHandler(this.FrmBienUso_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoBindingNavigator)).EndInit();
            this._1_bien_usoBindingNavigator.ResumeLayout(false);
            this._1_bien_usoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBienesUso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator _1_bien_usoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton StockBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView DgvBienesUso;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.TextBox cod_pro_busoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarMarcaButton;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private MaterialSkin.Controls.MaterialFlatButton CancelarMarcaButton;
        private MaterialSkin.Controls.MaterialRaisedButton GuardarMarcaButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
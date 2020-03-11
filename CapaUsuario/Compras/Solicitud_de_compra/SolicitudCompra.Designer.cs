namespace CapaUsuario.Compras.Solicitud_de_compra
{
    partial class SolicitudCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudCompra));
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TabListado = new System.Windows.Forms.TabPage();
            this.FiltrarSolicitudesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NuevaSolicitudButton = new System.Windows.Forms.Button();
            this.BorrarSolicitudCompraButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ModificarSolicitudCompraButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvSolicitudesCompra = new System.Windows.Forms.DataGridView();
            this.TabNueva = new System.Windows.Forms.TabPage();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BorrarTodoButton = new System.Windows.Forms.Button();
            this.BorrarLineaButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GrabarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BienDeUsoComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvSolicitudBienUso = new System.Windows.Forms.DataGridView();
            this.TabBienes = new System.Windows.Forms.TabPage();
            this.FiltrarBienesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListadoBienes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.TabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudesCompra)).BeginInit();
            this.TabNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudBienUso)).BeginInit();
            this.TabBienes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoBienes)).BeginInit();
            this.SuspendLayout();
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1056, 44);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TabListado);
            this.materialTabControl1.Controls.Add(this.TabNueva);
            this.materialTabControl1.Controls.Add(this.TabBienes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 44);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1056, 468);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TabListado
            // 
            this.TabListado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabListado.Controls.Add(this.FiltrarSolicitudesTextBox);
            this.TabListado.Controls.Add(this.label5);
            this.TabListado.Controls.Add(this.NuevaSolicitudButton);
            this.TabListado.Controls.Add(this.BorrarSolicitudCompraButton);
            this.TabListado.Controls.Add(this.ModificarSolicitudCompraButton);
            this.TabListado.Controls.Add(this.DgvSolicitudesCompra);
            this.TabListado.Location = new System.Drawing.Point(4, 29);
            this.TabListado.Name = "TabListado";
            this.TabListado.Padding = new System.Windows.Forms.Padding(3);
            this.TabListado.Size = new System.Drawing.Size(1048, 435);
            this.TabListado.TabIndex = 0;
            this.TabListado.Text = "Listado";
            // 
            // FiltrarSolicitudesTextBox
            // 
            this.FiltrarSolicitudesTextBox.Location = new System.Drawing.Point(170, 36);
            this.FiltrarSolicitudesTextBox.MaxLength = 30;
            this.FiltrarSolicitudesTextBox.Name = "FiltrarSolicitudesTextBox";
            this.FiltrarSolicitudesTextBox.Size = new System.Drawing.Size(149, 27);
            this.FiltrarSolicitudesTextBox.TabIndex = 11;
            this.FiltrarSolicitudesTextBox.TextChanged += new System.EventHandler(this.FiltrarSolicitudesTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filtrar por código:";
            // 
            // NuevaSolicitudButton
            // 
            this.NuevaSolicitudButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevaSolicitudButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevaSolicitudButton.Image = global::CapaUsuario.Properties.Resources.add_solicitud_compra32;
            this.NuevaSolicitudButton.Location = new System.Drawing.Point(800, 24);
            this.NuevaSolicitudButton.Name = "NuevaSolicitudButton";
            this.NuevaSolicitudButton.Size = new System.Drawing.Size(177, 50);
            this.NuevaSolicitudButton.TabIndex = 9;
            this.NuevaSolicitudButton.Text = "Nueva solicitud";
            this.NuevaSolicitudButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevaSolicitudButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevaSolicitudButton.UseVisualStyleBackColor = true;
            this.NuevaSolicitudButton.Click += new System.EventHandler(this.NuevaSolicitudButton_Click);
            // 
            // BorrarSolicitudCompraButton
            // 
            this.BorrarSolicitudCompraButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorrarSolicitudCompraButton.AutoSize = true;
            this.BorrarSolicitudCompraButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarSolicitudCompraButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrarSolicitudCompraButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarSolicitudCompraButton.Depth = 0;
            this.BorrarSolicitudCompraButton.Location = new System.Drawing.Point(411, 31);
            this.BorrarSolicitudCompraButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarSolicitudCompraButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarSolicitudCompraButton.Name = "BorrarSolicitudCompraButton";
            this.BorrarSolicitudCompraButton.Primary = false;
            this.BorrarSolicitudCompraButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarSolicitudCompraButton.TabIndex = 8;
            this.BorrarSolicitudCompraButton.Text = "Borrar";
            this.BorrarSolicitudCompraButton.UseVisualStyleBackColor = false;
            this.BorrarSolicitudCompraButton.Click += new System.EventHandler(this.BorrarSolicitudCompraButton_Click_1);
            // 
            // ModificarSolicitudCompraButton
            // 
            this.ModificarSolicitudCompraButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModificarSolicitudCompraButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarSolicitudCompraButton.Depth = 0;
            this.ModificarSolicitudCompraButton.Location = new System.Drawing.Point(504, 31);
            this.ModificarSolicitudCompraButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarSolicitudCompraButton.Name = "ModificarSolicitudCompraButton";
            this.ModificarSolicitudCompraButton.Primary = true;
            this.ModificarSolicitudCompraButton.Size = new System.Drawing.Size(131, 36);
            this.ModificarSolicitudCompraButton.TabIndex = 7;
            this.ModificarSolicitudCompraButton.Text = "Modificar";
            this.ModificarSolicitudCompraButton.UseVisualStyleBackColor = true;
            this.ModificarSolicitudCompraButton.Click += new System.EventHandler(this.ModificarSolicitudCompraButton_Click_1);
            // 
            // DgvSolicitudesCompra
            // 
            this.DgvSolicitudesCompra.AllowUserToAddRows = false;
            this.DgvSolicitudesCompra.AllowUserToDeleteRows = false;
            this.DgvSolicitudesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSolicitudesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSolicitudesCompra.Location = new System.Drawing.Point(8, 84);
            this.DgvSolicitudesCompra.MultiSelect = false;
            this.DgvSolicitudesCompra.Name = "DgvSolicitudesCompra";
            this.DgvSolicitudesCompra.ReadOnly = true;
            this.DgvSolicitudesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSolicitudesCompra.Size = new System.Drawing.Size(1032, 343);
            this.DgvSolicitudesCompra.TabIndex = 6;
            // 
            // TabNueva
            // 
            this.TabNueva.Controls.Add(this.MarcaComboBox);
            this.TabNueva.Controls.Add(this.label6);
            this.TabNueva.Controls.Add(this.BorrarTodoButton);
            this.TabNueva.Controls.Add(this.BorrarLineaButton);
            this.TabNueva.Controls.Add(this.CancelarButton);
            this.TabNueva.Controls.Add(this.GrabarButton);
            this.TabNueva.Controls.Add(this.AgregarButton);
            this.TabNueva.Controls.Add(this.CantidadNumericUpDown);
            this.TabNueva.Controls.Add(this.label4);
            this.TabNueva.Controls.Add(this.BienDeUsoComboBox);
            this.TabNueva.Controls.Add(this.label3);
            this.TabNueva.Controls.Add(this.DepartamentoComboBox);
            this.TabNueva.Controls.Add(this.label2);
            this.TabNueva.Controls.Add(this.DgvSolicitudBienUso);
            this.TabNueva.Location = new System.Drawing.Point(4, 29);
            this.TabNueva.Name = "TabNueva";
            this.TabNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TabNueva.Size = new System.Drawing.Size(1048, 435);
            this.TabNueva.TabIndex = 1;
            this.TabNueva.Text = "Nueva solicitud";
            this.TabNueva.UseVisualStyleBackColor = true;
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DisplayMember = "cod_pro_buso";
            this.MarcaComboBox.Enabled = false;
            this.MarcaComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Location = new System.Drawing.Point(184, 183);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(262, 28);
            this.MarcaComboBox.TabIndex = 5;
            this.MarcaComboBox.ValueMember = "cod_pro_buso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label6.Location = new System.Drawing.Point(115, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Marca :";
            // 
            // BorrarTodoButton
            // 
            this.BorrarTodoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarTodoButton.Enabled = false;
            this.BorrarTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BorrarTodoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarTodoButton.Image = global::CapaUsuario.Properties.Resources.borrar_todo48x48;
            this.BorrarTodoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BorrarTodoButton.Location = new System.Drawing.Point(398, 319);
            this.BorrarTodoButton.Name = "BorrarTodoButton";
            this.BorrarTodoButton.Size = new System.Drawing.Size(82, 75);
            this.BorrarTodoButton.TabIndex = 12;
            this.BorrarTodoButton.Text = "Borrar todo";
            this.BorrarTodoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrarTodoButton.UseVisualStyleBackColor = true;
            this.BorrarTodoButton.Click += new System.EventHandler(this.BorrarTodoButton_Click_1);
            // 
            // BorrarLineaButton
            // 
            this.BorrarLineaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarLineaButton.Enabled = false;
            this.BorrarLineaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BorrarLineaButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarLineaButton.Image = global::CapaUsuario.Properties.Resources.delete_row_32x32;
            this.BorrarLineaButton.Location = new System.Drawing.Point(308, 319);
            this.BorrarLineaButton.Name = "BorrarLineaButton";
            this.BorrarLineaButton.Size = new System.Drawing.Size(74, 75);
            this.BorrarLineaButton.TabIndex = 11;
            this.BorrarLineaButton.Text = "Borrar";
            this.BorrarLineaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrarLineaButton.UseVisualStyleBackColor = true;
            this.BorrarLineaButton.Click += new System.EventHandler(this.BorrarLineaButton_Click_1);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarButton.Location = new System.Drawing.Point(218, 319);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(74, 75);
            this.CancelarButton.TabIndex = 10;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click_1);
            // 
            // GrabarButton
            // 
            this.GrabarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrabarButton.Enabled = false;
            this.GrabarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrabarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrabarButton.Image = global::CapaUsuario.Properties.Resources.cool_save_32;
            this.GrabarButton.Location = new System.Drawing.Point(128, 319);
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(74, 75);
            this.GrabarButton.TabIndex = 9;
            this.GrabarButton.Text = "Grabar";
            this.GrabarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GrabarButton.UseVisualStyleBackColor = true;
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click_1);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarButton.Enabled = false;
            this.AgregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Image = global::CapaUsuario.Properties.Resources.add_light_green_32;
            this.AgregarButton.Location = new System.Drawing.Point(38, 319);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(74, 75);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click_1);
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Enabled = false;
            this.CantidadNumericUpDown.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(184, 237);
            this.CantidadNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.CantidadNumericUpDown.TabIndex = 7;
            this.CantidadNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CantidadNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label4.Location = new System.Drawing.Point(97, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad :";
            // 
            // BienDeUsoComboBox
            // 
            this.BienDeUsoComboBox.DisplayMember = "cod_pro_buso";
            this.BienDeUsoComboBox.Enabled = false;
            this.BienDeUsoComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.BienDeUsoComboBox.FormattingEnabled = true;
            this.BienDeUsoComboBox.Location = new System.Drawing.Point(184, 129);
            this.BienDeUsoComboBox.Name = "BienDeUsoComboBox";
            this.BienDeUsoComboBox.Size = new System.Drawing.Size(262, 28);
            this.BienDeUsoComboBox.TabIndex = 3;
            this.BienDeUsoComboBox.ValueMember = "cod_pro_buso";
            this.BienDeUsoComboBox.SelectedValueChanged += new System.EventHandler(this.BienDeUsoComboBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label3.Location = new System.Drawing.Point(79, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bien de Uso :";
            // 
            // DepartamentoComboBox
            // 
            this.DepartamentoComboBox.Enabled = false;
            this.DepartamentoComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.DepartamentoComboBox.FormattingEnabled = true;
            this.DepartamentoComboBox.Items.AddRange(new object[] {
            "Logística",
            "Facturación",
            "Recepción",
            "Contaduría",
            "Cajeros"});
            this.DepartamentoComboBox.Location = new System.Drawing.Point(184, 75);
            this.DepartamentoComboBox.Name = "DepartamentoComboBox";
            this.DepartamentoComboBox.Size = new System.Drawing.Size(262, 28);
            this.DepartamentoComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Departamento :";
            // 
            // DgvSolicitudBienUso
            // 
            this.DgvSolicitudBienUso.AllowUserToAddRows = false;
            this.DgvSolicitudBienUso.AllowUserToDeleteRows = false;
            this.DgvSolicitudBienUso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSolicitudBienUso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSolicitudBienUso.Location = new System.Drawing.Point(559, 16);
            this.DgvSolicitudBienUso.MultiSelect = false;
            this.DgvSolicitudBienUso.Name = "DgvSolicitudBienUso";
            this.DgvSolicitudBienUso.ReadOnly = true;
            this.DgvSolicitudBienUso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSolicitudBienUso.Size = new System.Drawing.Size(470, 402);
            this.DgvSolicitudBienUso.TabIndex = 27;
            // 
            // TabBienes
            // 
            this.TabBienes.Controls.Add(this.FiltrarBienesTextBox);
            this.TabBienes.Controls.Add(this.label1);
            this.TabBienes.Controls.Add(this.DgvListadoBienes);
            this.TabBienes.Location = new System.Drawing.Point(4, 29);
            this.TabBienes.Name = "TabBienes";
            this.TabBienes.Padding = new System.Windows.Forms.Padding(3);
            this.TabBienes.Size = new System.Drawing.Size(1048, 435);
            this.TabBienes.TabIndex = 2;
            this.TabBienes.Text = "Bienes de uso";
            this.TabBienes.UseVisualStyleBackColor = true;
            // 
            // FiltrarBienesTextBox
            // 
            this.FiltrarBienesTextBox.Location = new System.Drawing.Point(173, 28);
            this.FiltrarBienesTextBox.MaxLength = 30;
            this.FiltrarBienesTextBox.Name = "FiltrarBienesTextBox";
            this.FiltrarBienesTextBox.Size = new System.Drawing.Size(149, 27);
            this.FiltrarBienesTextBox.TabIndex = 4;
            this.FiltrarBienesTextBox.TextChanged += new System.EventHandler(this.FiltrarBienesTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por nombre:";
            // 
            // DgvListadoBienes
            // 
            this.DgvListadoBienes.AllowUserToAddRows = false;
            this.DgvListadoBienes.AllowUserToDeleteRows = false;
            this.DgvListadoBienes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListadoBienes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoBienes.Location = new System.Drawing.Point(8, 69);
            this.DgvListadoBienes.MultiSelect = false;
            this.DgvListadoBienes.Name = "DgvListadoBienes";
            this.DgvListadoBienes.ReadOnly = true;
            this.DgvListadoBienes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoBienes.Size = new System.Drawing.Size(1032, 358);
            this.DgvListadoBienes.TabIndex = 2;
            // 
            // SolicitudCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 512);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SolicitudCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes de Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SolicitudCompra_FormClosing);
            this.Load += new System.EventHandler(this.SolicitudCompra_Load);
            this.SizeChanged += new System.EventHandler(this.SolicitudCompra_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.TabListado.ResumeLayout(false);
            this.TabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudesCompra)).EndInit();
            this.TabNueva.ResumeLayout(false);
            this.TabNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudBienUso)).EndInit();
            this.TabBienes.ResumeLayout(false);
            this.TabBienes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoBienes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codordcprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprobusoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage TabListado;
        private System.Windows.Forms.TabPage TabNueva;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage TabBienes;
        private MaterialSkin.Controls.MaterialFlatButton BorrarSolicitudCompraButton;
        private MaterialSkin.Controls.MaterialRaisedButton ModificarSolicitudCompraButton;
        private System.Windows.Forms.DataGridView DgvSolicitudesCompra;
        private System.Windows.Forms.Button NuevaSolicitudButton;
        private System.Windows.Forms.Button BorrarTodoButton;
        private System.Windows.Forms.Button BorrarLineaButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GrabarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BienDeUsoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DepartamentoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvSolicitudBienUso;
        private System.Windows.Forms.TextBox FiltrarSolicitudesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FiltrarBienesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListadoBienes;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private System.Windows.Forms.Label label6;
    }
}
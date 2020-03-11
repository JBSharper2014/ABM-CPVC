namespace CapaUsuario.Compras.Informe_recepcion
{
    partial class FrmInformeRecepcion
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CodInformeBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarInformeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DgvInformes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CrearInformeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.TabNuevo = new System.Windows.Forms.TabPage();
            this.ProveedorLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelarNuevoButton = new System.Windows.Forms.Button();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ProblemasTextBox = new System.Windows.Forms.TextBox();
            this.FallidoRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.ExitosoRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ImporteLabel = new System.Windows.Forms.Label();
            this.FechaRecepcionLabel = new System.Windows.Forms.Label();
            this.CodFacLabel = new System.Windows.Forms.Label();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodOrdenCompraLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaEmisionLabel = new System.Windows.Forms.Label();
            this.DgvProductosOrden = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesCompra)).BeginInit();
            this.TabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrden)).BeginInit();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1097, 41);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.TabNuevo);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 41);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1097, 708);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.CodInformeBusquedaTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BorrarInformeButton);
            this.tabPage1.Controls.Add(this.DgvInformes);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informes de recepcion";
            // 
            // CodInformeBusquedaTextBox
            // 
            this.CodInformeBusquedaTextBox.Location = new System.Drawing.Point(167, 33);
            this.CodInformeBusquedaTextBox.MaxLength = 5;
            this.CodInformeBusquedaTextBox.Name = "CodInformeBusquedaTextBox";
            this.CodInformeBusquedaTextBox.Size = new System.Drawing.Size(123, 27);
            this.CodInformeBusquedaTextBox.TabIndex = 3;
            this.CodInformeBusquedaTextBox.TextChanged += new System.EventHandler(this.CodInformeBusquedaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de Informe:";
            // 
            // BorrarInformeButton
            // 
            this.BorrarInformeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarInformeButton.AutoSize = true;
            this.BorrarInformeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorrarInformeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarInformeButton.Depth = 0;
            this.BorrarInformeButton.Location = new System.Drawing.Point(954, 28);
            this.BorrarInformeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BorrarInformeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BorrarInformeButton.Name = "BorrarInformeButton";
            this.BorrarInformeButton.Primary = false;
            this.BorrarInformeButton.Size = new System.Drawing.Size(65, 36);
            this.BorrarInformeButton.TabIndex = 1;
            this.BorrarInformeButton.Text = "Borrar";
            this.BorrarInformeButton.UseVisualStyleBackColor = true;
            this.BorrarInformeButton.Click += new System.EventHandler(this.BorrarInformeButton_Click);
            // 
            // DgvInformes
            // 
            this.DgvInformes.AllowUserToAddRows = false;
            this.DgvInformes.AllowUserToDeleteRows = false;
            this.DgvInformes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInformes.Location = new System.Drawing.Point(6, 73);
            this.DgvInformes.MultiSelect = false;
            this.DgvInformes.Name = "DgvInformes";
            this.DgvInformes.ReadOnly = true;
            this.DgvInformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInformes.Size = new System.Drawing.Size(1073, 545);
            this.DgvInformes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CrearInformeButton);
            this.tabPage2.Controls.Add(this.DgvOrdenesCompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ordenes de compra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CrearInformeButton
            // 
            this.CrearInformeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrearInformeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearInformeButton.Depth = 0;
            this.CrearInformeButton.Location = new System.Drawing.Point(803, 22);
            this.CrearInformeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearInformeButton.Name = "CrearInformeButton";
            this.CrearInformeButton.Primary = true;
            this.CrearInformeButton.Size = new System.Drawing.Size(231, 36);
            this.CrearInformeButton.TabIndex = 2;
            this.CrearInformeButton.Text = "Crear informe de recepcion";
            this.CrearInformeButton.UseVisualStyleBackColor = true;
            this.CrearInformeButton.Click += new System.EventHandler(this.CrearInformeButton_Click);
            // 
            // DgvOrdenesCompra
            // 
            this.DgvOrdenesCompra.AllowUserToAddRows = false;
            this.DgvOrdenesCompra.AllowUserToDeleteRows = false;
            this.DgvOrdenesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenesCompra.Location = new System.Drawing.Point(6, 73);
            this.DgvOrdenesCompra.MultiSelect = false;
            this.DgvOrdenesCompra.Name = "DgvOrdenesCompra";
            this.DgvOrdenesCompra.ReadOnly = true;
            this.DgvOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrdenesCompra.Size = new System.Drawing.Size(1073, 545);
            this.DgvOrdenesCompra.TabIndex = 1;
            // 
            // TabNuevo
            // 
            this.TabNuevo.AutoScroll = true;
            this.TabNuevo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabNuevo.Controls.Add(this.ProveedorLabel);
            this.TabNuevo.Controls.Add(this.label9);
            this.TabNuevo.Controls.Add(this.CancelarNuevoButton);
            this.TabNuevo.Controls.Add(this.GuardarDatosButton);
            this.TabNuevo.Controls.Add(this.label15);
            this.TabNuevo.Controls.Add(this.ProblemasTextBox);
            this.TabNuevo.Controls.Add(this.FallidoRadioButton);
            this.TabNuevo.Controls.Add(this.label14);
            this.TabNuevo.Controls.Add(this.ExitosoRadioButton);
            this.TabNuevo.Controls.Add(this.label13);
            this.TabNuevo.Controls.Add(this.label12);
            this.TabNuevo.Controls.Add(this.label11);
            this.TabNuevo.Controls.Add(this.ImporteLabel);
            this.TabNuevo.Controls.Add(this.FechaRecepcionLabel);
            this.TabNuevo.Controls.Add(this.CodFacLabel);
            this.TabNuevo.Controls.Add(this.ObservacionesTextBox);
            this.TabNuevo.Controls.Add(this.label7);
            this.TabNuevo.Controls.Add(this.label6);
            this.TabNuevo.Controls.Add(this.label5);
            this.TabNuevo.Controls.Add(this.label3);
            this.TabNuevo.Controls.Add(this.CodOrdenCompraLabel);
            this.TabNuevo.Controls.Add(this.label4);
            this.TabNuevo.Controls.Add(this.FechaEmisionLabel);
            this.TabNuevo.Controls.Add(this.DgvProductosOrden);
            this.TabNuevo.Controls.Add(this.label2);
            this.TabNuevo.Location = new System.Drawing.Point(4, 29);
            this.TabNuevo.Name = "TabNuevo";
            this.TabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.TabNuevo.Size = new System.Drawing.Size(1089, 675);
            this.TabNuevo.TabIndex = 2;
            this.TabNuevo.Text = "Nuevo Informe";
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.AutoSize = true;
            this.ProveedorLabel.Location = new System.Drawing.Point(506, 36);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(27, 20);
            this.ProveedorLabel.TabIndex = 29;
            this.ProveedorLabel.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Proveedor:";
            // 
            // CancelarNuevoButton
            // 
            this.CancelarNuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelarNuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarNuevoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarNuevoButton.Enabled = false;
            this.CancelarNuevoButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarNuevoButton.Image = global::CapaUsuario.Properties.Resources.cool_close32;
            this.CancelarNuevoButton.Location = new System.Drawing.Point(417, 611);
            this.CancelarNuevoButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 20);
            this.CancelarNuevoButton.Name = "CancelarNuevoButton";
            this.CancelarNuevoButton.Size = new System.Drawing.Size(157, 54);
            this.CancelarNuevoButton.TabIndex = 26;
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
            this.GuardarDatosButton.Location = new System.Drawing.Point(614, 611);
            this.GuardarDatosButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 20);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(157, 54);
            this.GuardarDatosButton.TabIndex = 27;
            this.GuardarDatosButton.Text = "Guardar datos";
            this.GuardarDatosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Problemas encontrados:";
            // 
            // ProblemasTextBox
            // 
            this.ProblemasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemasTextBox.Location = new System.Drawing.Point(51, 437);
            this.ProblemasTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ProblemasTextBox.Multiline = true;
            this.ProblemasTextBox.Name = "ProblemasTextBox";
            this.ProblemasTextBox.ReadOnly = true;
            this.ProblemasTextBox.Size = new System.Drawing.Size(1008, 159);
            this.ProblemasTextBox.TabIndex = 24;
            // 
            // FallidoRadioButton
            // 
            this.FallidoRadioButton.AutoSize = true;
            this.FallidoRadioButton.Depth = 0;
            this.FallidoRadioButton.Enabled = false;
            this.FallidoRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.FallidoRadioButton.Location = new System.Drawing.Point(300, 354);
            this.FallidoRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.FallidoRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FallidoRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FallidoRadioButton.Name = "FallidoRadioButton";
            this.FallidoRadioButton.Ripple = true;
            this.FallidoRadioButton.Size = new System.Drawing.Size(25, 30);
            this.FallidoRadioButton.TabIndex = 23;
            this.FallidoRadioButton.TabStop = true;
            this.FallidoRadioButton.UseVisualStyleBackColor = true;
            this.FallidoRadioButton.CheckedChanged += new System.EventHandler(this.FallidoRadioButton_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Fallido";
            // 
            // ExitosoRadioButton
            // 
            this.ExitosoRadioButton.AutoSize = true;
            this.ExitosoRadioButton.Depth = 0;
            this.ExitosoRadioButton.Enabled = false;
            this.ExitosoRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.ExitosoRadioButton.Location = new System.Drawing.Point(196, 354);
            this.ExitosoRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitosoRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ExitosoRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitosoRadioButton.Name = "ExitosoRadioButton";
            this.ExitosoRadioButton.Ripple = true;
            this.ExitosoRadioButton.Size = new System.Drawing.Size(25, 30);
            this.ExitosoRadioButton.TabIndex = 21;
            this.ExitosoRadioButton.TabStop = true;
            this.ExitosoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Exitoso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Control de calidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(759, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "$";
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.AutoSize = true;
            this.ImporteLabel.Location = new System.Drawing.Point(712, 124);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(27, 20);
            this.ImporteLabel.TabIndex = 17;
            this.ImporteLabel.Text = "---";
            // 
            // FechaRecepcionLabel
            // 
            this.FechaRecepcionLabel.AutoSize = true;
            this.FechaRecepcionLabel.Location = new System.Drawing.Point(786, 80);
            this.FechaRecepcionLabel.Name = "FechaRecepcionLabel";
            this.FechaRecepcionLabel.Size = new System.Drawing.Size(27, 20);
            this.FechaRecepcionLabel.TabIndex = 16;
            this.FechaRecepcionLabel.Text = "---";
            // 
            // CodFacLabel
            // 
            this.CodFacLabel.AutoSize = true;
            this.CodFacLabel.Location = new System.Drawing.Point(777, 36);
            this.CodFacLabel.Name = "CodFacLabel";
            this.CodFacLabel.Size = new System.Drawing.Size(27, 20);
            this.CodFacLabel.TabIndex = 15;
            this.CodFacLabel.Text = "---";
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObservacionesTextBox.Location = new System.Drawing.Point(645, 204);
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.ReadOnly = true;
            this.ObservacionesTextBox.Size = new System.Drawing.Size(414, 190);
            this.ObservacionesTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Importe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de recepción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código de factura:";
            // 
            // CodOrdenCompraLabel
            // 
            this.CodOrdenCompraLabel.AutoSize = true;
            this.CodOrdenCompraLabel.Location = new System.Drawing.Point(253, 36);
            this.CodOrdenCompraLabel.Name = "CodOrdenCompraLabel";
            this.CodOrdenCompraLabel.Size = new System.Drawing.Size(27, 20);
            this.CodOrdenCompraLabel.TabIndex = 9;
            this.CodOrdenCompraLabel.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de emisión:";
            // 
            // FechaEmisionLabel
            // 
            this.FechaEmisionLabel.AutoSize = true;
            this.FechaEmisionLabel.Location = new System.Drawing.Point(178, 302);
            this.FechaEmisionLabel.Name = "FechaEmisionLabel";
            this.FechaEmisionLabel.Size = new System.Drawing.Size(27, 20);
            this.FechaEmisionLabel.TabIndex = 7;
            this.FechaEmisionLabel.Text = "---";
            // 
            // DgvProductosOrden
            // 
            this.DgvProductosOrden.AllowUserToAddRows = false;
            this.DgvProductosOrden.AllowUserToDeleteRows = false;
            this.DgvProductosOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosOrden.Location = new System.Drawing.Point(51, 78);
            this.DgvProductosOrden.MultiSelect = false;
            this.DgvProductosOrden.Name = "DgvProductosOrden";
            this.DgvProductosOrden.ReadOnly = true;
            this.DgvProductosOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductosOrden.Size = new System.Drawing.Size(532, 201);
            this.DgvProductosOrden.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código de orden de compra:";
            // 
            // FrmInformeRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 749);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInformeRecepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes de Recepcion";
            this.Load += new System.EventHandler(this.FrmInformeRecepcion_Load);
            this.SizeChanged += new System.EventHandler(this.FrmInformeRecepcion_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInformes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenesCompra)).EndInit();
            this.TabNuevo.ResumeLayout(false);
            this.TabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvInformes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage TabNuevo;
        private MaterialSkin.Controls.MaterialFlatButton BorrarInformeButton;
        private System.Windows.Forms.DataGridView DgvOrdenesCompra;
        private MaterialSkin.Controls.MaterialRaisedButton CrearInformeButton;
        private System.Windows.Forms.TextBox CodInformeBusquedaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CodOrdenCompraLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FechaEmisionLabel;
        private System.Windows.Forms.DataGridView DgvProductosOrden;
        private System.Windows.Forms.Label ImporteLabel;
        private System.Windows.Forms.Label FechaRecepcionLabel;
        private System.Windows.Forms.Label CodFacLabel;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ProblemasTextBox;
        private MaterialSkin.Controls.MaterialRadioButton FallidoRadioButton;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialRadioButton ExitosoRadioButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CancelarNuevoButton;
        private System.Windows.Forms.Button GuardarDatosButton;
        private System.Windows.Forms.Label ProveedorLabel;
        private System.Windows.Forms.Label label9;
    }
}
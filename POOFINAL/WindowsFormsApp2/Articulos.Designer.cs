namespace WindowsFormsApp2
{
    partial class Articulos
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
            this.tbcCategoria = new System.Windows.Forms.TabPage();
            this.txtidC = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtCodigoC = new System.Windows.Forms.TextBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnSalirC = new System.Windows.Forms.Button();
            this.btnNuevoC = new System.Windows.Forms.Button();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbcProducto = new System.Windows.Forms.TabPage();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.btnSalirP = new System.Windows.Forms.Button();
            this.btnNuevoP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.tbcPrincipal.SuspendLayout();
            this.tbcProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCategoria
            // 
            this.tbcCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbcCategoria.Controls.Add(this.txtidC);
            this.tbcCategoria.Controls.Add(this.txtNombreC);
            this.tbcCategoria.Controls.Add(this.txtCodigoC);
            this.tbcCategoria.Controls.Add(this.dgvCategoria);
            this.tbcCategoria.Controls.Add(this.label24);
            this.tbcCategoria.Controls.Add(this.label25);
            this.tbcCategoria.Controls.Add(this.btnGuardarC);
            this.tbcCategoria.Controls.Add(this.btnEliminarC);
            this.tbcCategoria.Controls.Add(this.btnCancelarC);
            this.tbcCategoria.Controls.Add(this.btnSalirC);
            this.tbcCategoria.Controls.Add(this.btnNuevoC);
            this.tbcCategoria.Controls.Add(this.btnEditarC);
            this.tbcCategoria.Location = new System.Drawing.Point(4, 31);
            this.tbcCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcCategoria.Name = "tbcCategoria";
            this.tbcCategoria.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcCategoria.Size = new System.Drawing.Size(1439, 582);
            this.tbcCategoria.TabIndex = 3;
            this.tbcCategoria.Text = "Categorias";
            // 
            // txtidC
            // 
            this.txtidC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidC.Location = new System.Drawing.Point(452, 20);
            this.txtidC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidC.Name = "txtidC";
            this.txtidC.Size = new System.Drawing.Size(164, 25);
            this.txtidC.TabIndex = 91;
            this.txtidC.Visible = false;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreC.Location = new System.Drawing.Point(311, 55);
            this.txtNombreC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(305, 25);
            this.txtNombreC.TabIndex = 1;
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoC.Location = new System.Drawing.Point(311, 20);
            this.txtCodigoC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.ReadOnly = true;
            this.txtCodigoC.Size = new System.Drawing.Size(208, 25);
            this.txtCodigoC.TabIndex = 77;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(163, 90);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(739, 319);
            this.dgvCategoria.TabIndex = 82;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(159, 55);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 18);
            this.label24.TabIndex = 78;
            this.label24.Text = "Nombre:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(159, 20);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 18);
            this.label25.TabIndex = 76;
            this.label25.Text = "Codigo:";
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarC.Location = new System.Drawing.Point(1020, 228);
            this.btnGuardarC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(120, 55);
            this.btnGuardarC.TabIndex = 88;
            this.btnGuardarC.Text = "Grabar";
            this.btnGuardarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarC.UseVisualStyleBackColor = true;
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarC.Location = new System.Drawing.Point(1020, 290);
            this.btnEliminarC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(120, 55);
            this.btnEliminarC.TabIndex = 87;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarC.UseVisualStyleBackColor = true;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarC.Location = new System.Drawing.Point(1020, 353);
            this.btnCancelarC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(120, 55);
            this.btnCancelarC.TabIndex = 86;
            this.btnCancelarC.Text = "Cancelar";
            this.btnCancelarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarC.UseVisualStyleBackColor = true;
            // 
            // btnSalirC
            // 
            this.btnSalirC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirC.Location = new System.Drawing.Point(1020, 416);
            this.btnSalirC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalirC.Name = "btnSalirC";
            this.btnSalirC.Size = new System.Drawing.Size(120, 55);
            this.btnSalirC.TabIndex = 85;
            this.btnSalirC.Text = "Salir";
            this.btnSalirC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirC.UseVisualStyleBackColor = true;
            // 
            // btnNuevoC
            // 
            this.btnNuevoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoC.Location = new System.Drawing.Point(1020, 105);
            this.btnNuevoC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoC.Name = "btnNuevoC";
            this.btnNuevoC.Size = new System.Drawing.Size(120, 55);
            this.btnNuevoC.TabIndex = 84;
            this.btnNuevoC.Text = "Nuevo";
            this.btnNuevoC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoC.UseVisualStyleBackColor = true;
            // 
            // btnEditarC
            // 
            this.btnEditarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarC.Location = new System.Drawing.Point(1020, 166);
            this.btnEditarC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(120, 55);
            this.btnEditarC.TabIndex = 83;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarC.UseVisualStyleBackColor = true;
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcPrincipal.Controls.Add(this.tbcProducto);
            this.tbcPrincipal.Controls.Add(this.tbcCategoria);
            this.tbcPrincipal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(-4, 7);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.Padding = new System.Drawing.Point(12, 5);
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1447, 617);
            this.tbcPrincipal.TabIndex = 4;
            // 
            // tbcProducto
            // 
            this.tbcProducto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbcProducto.Controls.Add(this.btnGuardarP);
            this.tbcProducto.Controls.Add(this.btnEliminarP);
            this.tbcProducto.Controls.Add(this.btnCancelarP);
            this.tbcProducto.Controls.Add(this.btnSalirP);
            this.tbcProducto.Controls.Add(this.btnNuevoP);
            this.tbcProducto.Controls.Add(this.btnEditarP);
            this.tbcProducto.Controls.Add(this.txtIdP);
            this.tbcProducto.Controls.Add(this.btnBuscarP);
            this.tbcProducto.Controls.Add(this.dgvProductos);
            this.tbcProducto.Controls.Add(this.txtPrecioVenta);
            this.tbcProducto.Controls.Add(this.label16);
            this.tbcProducto.Controls.Add(this.label15);
            this.tbcProducto.Controls.Add(this.cboCategoria);
            this.tbcProducto.Controls.Add(this.txtStock);
            this.tbcProducto.Controls.Add(this.txtNombre);
            this.tbcProducto.Controls.Add(this.label5);
            this.tbcProducto.Controls.Add(this.label2);
            this.tbcProducto.Controls.Add(this.txtCodigoP);
            this.tbcProducto.Controls.Add(this.label3);
            this.tbcProducto.Location = new System.Drawing.Point(4, 31);
            this.tbcProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcProducto.Name = "tbcProducto";
            this.tbcProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcProducto.Size = new System.Drawing.Size(1439, 582);
            this.tbcProducto.TabIndex = 0;
            this.tbcProducto.Text = "Productos";
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarP.Location = new System.Drawing.Point(1016, 225);
            this.btnGuardarP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(120, 55);
            this.btnGuardarP.TabIndex = 73;
            this.btnGuardarP.Text = "Grabar";
            this.btnGuardarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarP.UseVisualStyleBackColor = true;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarP.Location = new System.Drawing.Point(1016, 288);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(120, 55);
            this.btnEliminarP.TabIndex = 72;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarP.UseVisualStyleBackColor = true;
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarP.Location = new System.Drawing.Point(1016, 351);
            this.btnCancelarP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(120, 55);
            this.btnCancelarP.TabIndex = 71;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarP.UseVisualStyleBackColor = true;
            // 
            // btnSalirP
            // 
            this.btnSalirP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirP.Location = new System.Drawing.Point(1016, 414);
            this.btnSalirP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(120, 55);
            this.btnSalirP.TabIndex = 70;
            this.btnSalirP.Text = "Salir";
            this.btnSalirP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirP.UseVisualStyleBackColor = true;
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoP.Location = new System.Drawing.Point(1016, 101);
            this.btnNuevoP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(120, 55);
            this.btnNuevoP.TabIndex = 69;
            this.btnNuevoP.Text = "Nuevo";
            this.btnNuevoP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoP.UseVisualStyleBackColor = true;
            // 
            // btnEditarP
            // 
            this.btnEditarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarP.Location = new System.Drawing.Point(1016, 164);
            this.btnEditarP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(120, 55);
            this.btnEditarP.TabIndex = 68;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarP.UseVisualStyleBackColor = true;
            // 
            // txtIdP
            // 
            this.txtIdP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdP.Location = new System.Drawing.Point(444, 107);
            this.txtIdP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(73, 25);
            this.txtIdP.TabIndex = 67;
            this.txtIdP.Visible = false;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarP.Location = new System.Drawing.Point(825, 233);
            this.btnBuscarP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(53, 37);
            this.btnBuscarP.TabIndex = 66;
            this.btnBuscarP.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(72, 233);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(745, 255);
            this.dgvProductos.TabIndex = 65;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPrecioVenta.Location = new System.Drawing.Point(220, 180);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(65, 25);
            this.txtPrecioVenta.TabIndex = 48;
            this.txtPrecioVenta.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 183);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 18);
            this.label16.TabIndex = 64;
            this.label16.Text = "Precio de Venta";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(447, 183);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 18);
            this.label15.TabIndex = 61;
            this.label15.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(599, 178);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(228, 26);
            this.cboCategoria.TabIndex = 54;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(372, 180);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(65, 25);
            this.txtStock.TabIndex = 50;
            this.txtStock.Text = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(220, 143);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(596, 25);
            this.txtNombre.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Producto:";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoP.Location = new System.Drawing.Point(220, 107);
            this.txtCodigoP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.ReadOnly = true;
            this.txtCodigoP.Size = new System.Drawing.Size(215, 25);
            this.txtCodigoP.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Codigo:";
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 633);
            this.Controls.Add(this.tbcPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Articulos";
            this.Text = "Articulos";
            this.tbcCategoria.ResumeLayout(false);
            this.tbcCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.tbcPrincipal.ResumeLayout(false);
            this.tbcProducto.ResumeLayout(false);
            this.tbcProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbcCategoria;
        private System.Windows.Forms.TextBox txtidC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtCodigoC;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnSalirC;
        private System.Windows.Forms.Button btnNuevoC;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbcProducto;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.Button btnSalirP;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label label3;
    }
}
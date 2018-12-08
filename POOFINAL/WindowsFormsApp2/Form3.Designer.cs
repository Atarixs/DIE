﻿namespace WindowsFormsApp2
{
    partial class ManagerControl
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox_TotalPagado = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_Restante = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxVentas = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.label_NumeroDeVenta = new System.Windows.Forms.Label();
            this.label_TotalAdeudado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label4 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(5, 726);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(175, 25);
            label4.TabIndex = 78;
            label4.Text = "Método de pago:";
            // 
            // label11
            // 
            label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(47, 575);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(106, 25);
            label11.TabIndex = 77;
            label11.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(13, 46);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(249, 25);
            label1.TabIndex = 60;
            label1.Text = "Numero de Transaccion:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(808, 395);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(368, 26);
            label5.TabIndex = 66;
            label5.Text = "Pagado:";
            label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(1056, 697);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 26);
            label7.TabIndex = 63;
            label7.Text = "Cancelar:";
            label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(865, 697);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 26);
            label6.TabIndex = 64;
            label6.Text = "Pagar:";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(808, 327);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(368, 26);
            label3.TabIndex = 62;
            label3.Text = "Total:";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 81;
            // 
            // cbPayment
            // 
            this.cbPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(205, 726);
            this.cbPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(160, 24);
            this.cbPayment.TabIndex = 80;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCantidad.Location = new System.Drawing.Point(211, 575);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(154, 22);
            this.nudCantidad.TabIndex = 79;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 763);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 42);
            this.label2.TabIndex = 76;
            this.label2.Text = "NULL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1083, 726);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 68);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox_TotalPagado
            // 
            this.textBox_TotalPagado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TotalPagado.Location = new System.Drawing.Point(808, 425);
            this.textBox_TotalPagado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_TotalPagado.Name = "textBox_TotalPagado";
            this.textBox_TotalPagado.Size = new System.Drawing.Size(367, 45);
            this.textBox_TotalPagado.TabIndex = 74;
            this.textBox_TotalPagado.Text = "NULL";
            this.textBox_TotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.BackgroundImage")));
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCheckout.Location = new System.Drawing.Point(835, 726);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(160, 68);
            this.btnCheckout.TabIndex = 68;
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(401, 46);
            this.dateTimePicker_Date.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(381, 30);
            this.dateTimePicker_Date.TabIndex = 75;
            this.dateTimePicker_Date.Visible = false;
            // 
            // label_Restante
            // 
            this.label_Restante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Restante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Restante.Location = new System.Drawing.Point(808, 505);
            this.label_Restante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Restante.Name = "label_Restante";
            this.label_Restante.Size = new System.Drawing.Size(368, 42);
            this.label_Restante.TabIndex = 71;
            this.label_Restante.Text = "NULL";
            this.label_Restante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.CausesValidation = false;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.Location = new System.Drawing.Point(193, 612);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 63);
            this.btnRemove.TabIndex = 72;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // listBoxVentas
            // 
            this.listBoxVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVentas.FormattingEnabled = true;
            this.listBoxVentas.ItemHeight = 25;
            this.listBoxVentas.Location = new System.Drawing.Point(401, 96);
            this.listBoxVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxVentas.Name = "listBoxVentas";
            this.listBoxVentas.Size = new System.Drawing.Size(381, 579);
            this.listBoxVentas.TabIndex = 73;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(111, 612);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 63);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 25;
            this.listBoxProductos.Location = new System.Drawing.Point(18, 173);
            this.listBoxProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(359, 379);
            this.listBoxProductos.TabIndex = 59;
            // 
            // label_Resultado
            // 
            this.label_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(808, 479);
            this.label_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(368, 26);
            this.label_Resultado.TabIndex = 67;
            this.label_Resultado.Text = "Restante:";
            this.label_Resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_NumeroDeVenta
            // 
            this.label_NumeroDeVenta.AutoSize = true;
            this.label_NumeroDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumeroDeVenta.Location = new System.Drawing.Point(270, 46);
            this.label_NumeroDeVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NumeroDeVenta.Name = "label_NumeroDeVenta";
            this.label_NumeroDeVenta.Size = new System.Drawing.Size(66, 25);
            this.label_NumeroDeVenta.TabIndex = 61;
            this.label_NumeroDeVenta.Text = "NULL";
            // 
            // label_TotalAdeudado
            // 
            this.label_TotalAdeudado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TotalAdeudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalAdeudado.Location = new System.Drawing.Point(808, 353);
            this.label_TotalAdeudado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TotalAdeudado.Name = "label_TotalAdeudado";
            this.label_TotalAdeudado.Size = new System.Drawing.Size(368, 42);
            this.label_TotalAdeudado.TabIndex = 65;
            this.label_TotalAdeudado.Text = "NULL";
            this.label_TotalAdeudado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1197, 28);
            this.menuStrip1.TabIndex = 83;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.toolStripSeparator1,
            this.cerrarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 814);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox_TotalPagado);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(label11);
            this.Controls.Add(this.label_Restante);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBoxVentas);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxProductos);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(label1);
            this.Controls.Add(label5);
            this.Controls.Add(this.label_NumeroDeVenta);
            this.Controls.Add(this.label_TotalAdeudado);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerControl";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox_TotalPagado;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label_Restante;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxVentas;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Label label_NumeroDeVenta;
        private System.Windows.Forms.Label label_TotalAdeudado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}
namespace SVPresentation.Formularios
{
    partial class FrmProducto
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
            label1 = new Label();
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            dgvProductos = new DataGridView();
            txbBuscar = new TextBox();
            BtnBuscar = new Button();
            BtnNuevoLista = new Button();
            tabNuevo = new TabPage();
            txbPrecioVentaNuevo = new TextBox();
            txbPrecioCompraNuevo = new TextBox();
            txbDescripcionNuevo = new TextBox();
            txbCodigoNuevo = new TextBox();
            label9 = new Label();
            txbCantidadNuevo = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            BtnGuardarNuevo = new Button();
            BtnVolverNuevo = new Button();
            cmbCategoriaNuevo = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            lblName = new Label();
            tabEditar = new TabPage();
            txbPrecioVentaEditar = new TextBox();
            txbPrecioCompraEditar = new TextBox();
            txbDescripcionEditar = new TextBox();
            txbCodigoEditar = new TextBox();
            label2 = new Label();
            label18 = new Label();
            cmbHabilitado = new ComboBox();
            button3 = new Button();
            label4 = new Label();
            label17 = new Label();
            txbCantidadEditar = new NumericUpDown();
            label16 = new Label();
            label13 = new Label();
            cmbCategoriaEditar = new ComboBox();
            label15 = new Label();
            button1 = new Button();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).BeginInit();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 3;
            label1.Text = "Inventario/Productos";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(13, 48);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvProductos);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(BtnBuscar);
            tabLista.Controls.Add(BtnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(18, 63);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(699, 235);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(424, 19);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(183, 27);
            txbBuscar.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.Location = new Point(623, 17);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(94, 29);
            BtnBuscar.TabIndex = 1;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click_1;
            // 
            // BtnNuevoLista
            // 
            BtnNuevoLista.Cursor = Cursors.Hand;
            BtnNuevoLista.Location = new Point(18, 17);
            BtnNuevoLista.Name = "BtnNuevoLista";
            BtnNuevoLista.Size = new Size(94, 29);
            BtnNuevoLista.TabIndex = 0;
            BtnNuevoLista.Text = "Nuevo";
            BtnNuevoLista.UseVisualStyleBackColor = true;
            BtnNuevoLista.Click += BtnNuevoLista_Click_1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbPrecioVentaNuevo);
            tabNuevo.Controls.Add(txbPrecioCompraNuevo);
            tabNuevo.Controls.Add(txbDescripcionNuevo);
            tabNuevo.Controls.Add(txbCodigoNuevo);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txbCantidadNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(BtnGuardarNuevo);
            tabNuevo.Controls.Add(BtnVolverNuevo);
            tabNuevo.Controls.Add(cmbCategoriaNuevo);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(lblName);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txbPrecioVentaNuevo
            // 
            txbPrecioVentaNuevo.Location = new Point(421, 169);
            txbPrecioVentaNuevo.Name = "txbPrecioVentaNuevo";
            txbPrecioVentaNuevo.Size = new Size(286, 27);
            txbPrecioVentaNuevo.TabIndex = 31;
            // 
            // txbPrecioCompraNuevo
            // 
            txbPrecioCompraNuevo.Location = new Point(421, 116);
            txbPrecioCompraNuevo.Name = "txbPrecioCompraNuevo";
            txbPrecioCompraNuevo.Size = new Size(286, 27);
            txbPrecioCompraNuevo.TabIndex = 30;
            // 
            // txbDescripcionNuevo
            // 
            txbDescripcionNuevo.Location = new Point(22, 169);
            txbDescripcionNuevo.Name = "txbDescripcionNuevo";
            txbDescripcionNuevo.Size = new Size(286, 27);
            txbDescripcionNuevo.TabIndex = 29;
            // 
            // txbCodigoNuevo
            // 
            txbCodigoNuevo.Location = new Point(22, 116);
            txbCodigoNuevo.Name = "txbCodigoNuevo";
            txbCodigoNuevo.Size = new Size(286, 27);
            txbCodigoNuevo.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(421, 31);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 27;
            label9.Text = "Cantidad:";
            // 
            // txbCantidadNuevo
            // 
            txbCantidadNuevo.Location = new Point(418, 58);
            txbCantidadNuevo.Name = "txbCantidadNuevo";
            txbCantidadNuevo.Size = new Size(289, 27);
            txbCantidadNuevo.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(421, 146);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 24;
            label8.Text = "Precio Venta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 92);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 22;
            label7.Text = "Precio Compra:";
            // 
            // BtnGuardarNuevo
            // 
            BtnGuardarNuevo.Cursor = Cursors.Hand;
            BtnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            BtnGuardarNuevo.Location = new Point(613, 256);
            BtnGuardarNuevo.Name = "BtnGuardarNuevo";
            BtnGuardarNuevo.Size = new Size(94, 29);
            BtnGuardarNuevo.TabIndex = 21;
            BtnGuardarNuevo.Text = "Guardar";
            BtnGuardarNuevo.UseVisualStyleBackColor = true;
            BtnGuardarNuevo.Click += BtnGuardarNuevo_Click;
            // 
            // BtnVolverNuevo
            // 
            BtnVolverNuevo.Cursor = Cursors.Hand;
            BtnVolverNuevo.Location = new Point(22, 256);
            BtnVolverNuevo.Name = "BtnVolverNuevo";
            BtnVolverNuevo.Size = new Size(94, 29);
            BtnVolverNuevo.TabIndex = 20;
            BtnVolverNuevo.Text = "Volver";
            BtnVolverNuevo.UseVisualStyleBackColor = true;
            BtnVolverNuevo.Click += BtnVolverNuevo_Click;
            // 
            // cmbCategoriaNuevo
            // 
            cmbCategoriaNuevo.Cursor = Cursors.Hand;
            cmbCategoriaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaNuevo.FormattingEnabled = true;
            cmbCategoriaNuevo.Location = new Point(19, 58);
            cmbCategoriaNuevo.Name = "cmbCategoriaNuevo";
            cmbCategoriaNuevo.Size = new Size(289, 28);
            cmbCategoriaNuevo.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 146);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 14;
            label6.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 92);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 16;
            label3.Text = "Codigo:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 20);
            lblName.TabIndex = 15;
            lblName.Text = "Categoria:";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(txbPrecioVentaEditar);
            tabEditar.Controls.Add(txbPrecioCompraEditar);
            tabEditar.Controls.Add(txbDescripcionEditar);
            tabEditar.Controls.Add(txbCodigoEditar);
            tabEditar.Controls.Add(label2);
            tabEditar.Controls.Add(label18);
            tabEditar.Controls.Add(cmbHabilitado);
            tabEditar.Controls.Add(button3);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(label17);
            tabEditar.Controls.Add(txbCantidadEditar);
            tabEditar.Controls.Add(label16);
            tabEditar.Controls.Add(label13);
            tabEditar.Controls.Add(cmbCategoriaEditar);
            tabEditar.Controls.Add(label15);
            tabEditar.Controls.Add(button1);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // txbPrecioVentaEditar
            // 
            txbPrecioVentaEditar.Location = new Point(411, 214);
            txbPrecioVentaEditar.Name = "txbPrecioVentaEditar";
            txbPrecioVentaEditar.Size = new Size(286, 27);
            txbPrecioVentaEditar.TabIndex = 51;
            // 
            // txbPrecioCompraEditar
            // 
            txbPrecioCompraEditar.Location = new Point(411, 160);
            txbPrecioCompraEditar.Name = "txbPrecioCompraEditar";
            txbPrecioCompraEditar.Size = new Size(286, 27);
            txbPrecioCompraEditar.TabIndex = 50;
            // 
            // txbDescripcionEditar
            // 
            txbDescripcionEditar.Location = new Point(28, 178);
            txbDescripcionEditar.Name = "txbDescripcionEditar";
            txbDescripcionEditar.Size = new Size(286, 27);
            txbDescripcionEditar.TabIndex = 49;
            // 
            // txbCodigoEditar
            // 
            txbCodigoEditar.Location = new Point(25, 121);
            txbCodigoEditar.Name = "txbCodigoEditar";
            txbCodigoEditar.Size = new Size(286, 27);
            txbCodigoEditar.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 79);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 47;
            label2.Text = "Habilitado:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 46);
            label18.Name = "label18";
            label18.Size = new Size(77, 20);
            label18.TabIndex = 34;
            label18.Text = "Categoria:";
            // 
            // cmbHabilitado
            // 
            cmbHabilitado.Cursor = Cursors.Hand;
            cmbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHabilitado.FormattingEnabled = true;
            cmbHabilitado.Location = new Point(408, 99);
            cmbHabilitado.Name = "cmbHabilitado";
            cmbHabilitado.Size = new Size(289, 28);
            cmbHabilitado.TabIndex = 46;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.FromArgb(30, 90, 195);
            button3.Location = new Point(606, 262);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 32;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 20);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 45;
            label4.Text = "Cantidad:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(28, 100);
            label17.Name = "label17";
            label17.Size = new Size(61, 20);
            label17.TabIndex = 35;
            label17.Text = "Codigo:";
            // 
            // txbCantidadEditar
            // 
            txbCantidadEditar.Location = new Point(411, 47);
            txbCantidadEditar.Name = "txbCantidadEditar";
            txbCantidadEditar.Size = new Size(289, 27);
            txbCantidadEditar.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(28, 154);
            label16.Name = "label16";
            label16.Size = new Size(90, 20);
            label16.TabIndex = 33;
            label16.Text = "Descripcion:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(411, 191);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 42;
            label13.Text = "Precio Venta:";
            // 
            // cmbCategoriaEditar
            // 
            cmbCategoriaEditar.FormattingEnabled = true;
            cmbCategoriaEditar.Location = new Point(28, 66);
            cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            cmbCategoriaEditar.Size = new Size(289, 28);
            cmbCategoriaEditar.TabIndex = 36;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(411, 137);
            label15.Name = "label15";
            label15.Size = new Size(110, 20);
            label15.TabIndex = 40;
            label15.Text = "Precio Compra:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(28, 262);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 39;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducto";
            Text = "FrmProducto";
            Load += FrmProducto_Load;
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).EndInit();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControlMain;
        private TabPage tabLista;
        private DataGridView dgvProductos;
        private TextBox txbBuscar;
        private Button BtnBuscar;
        private Button BtnNuevoLista;
        private TabPage tabEditar;
        private Label label2;
        private Label label18;
        private ComboBox cmbHabilitado;
        private Button button3;
        private Label label4;
        private Label label17;
        private NumericUpDown txbCantidadEditar;
        private Label label16;
        private Label label13;
        private ComboBox cmbCategoriaEditar;
        private Label label15;
        private Button button1;
        private TabPage tabNuevo;
        private TextBox txbPrecioVentaNuevo;
        private TextBox txbPrecioCompraNuevo;
        private TextBox txbDescripcionNuevo;
        private TextBox txbCodigoNuevo;
        private Label label9;
        private NumericUpDown txbCantidadNuevo;
        private Label label8;
        private Label label7;
        private Button BtnGuardarNuevo;
        private Button BtnVolverNuevo;
        private ComboBox cmbCategoriaNuevo;
        private Label label6;
        private Label label3;
        private Label lblName;
        private TextBox txbPrecioVentaEditar;
        private TextBox txbPrecioCompraEditar;
        private TextBox txbDescripcionEditar;
        private TextBox txbCodigoEditar;
    }
}
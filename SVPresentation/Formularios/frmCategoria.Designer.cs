﻿namespace SVPresentation.Formularios
{
    partial class frmCategoria
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
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            dgvCategorias = new DataGridView();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btn = new Button();
            tabNuevo = new TabPage();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cmbMedidaNuevo = new ComboBox();
            cmbNombreNuevo = new ComboBox();
            label3 = new Label();
            lblName = new Label();
            tabEditar = new TabPage();
            cmbHabilitado = new ComboBox();
            label5 = new Label();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            cmbMedidaEditar = new ComboBox();
            cmbNombreEditar = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(18, 51);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvCategorias);
            tabLista.Controls.Add(txtBuscar);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(btn);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(18, 63);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(699, 235);
            dgvCategorias.TabIndex = 3;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(424, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(623, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Cursor = Cursors.Hand;
            btn.Location = new Point(18, 17);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 0;
            btn.Text = "Nuevo";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cmbMedidaNuevo);
            tabNuevo.Controls.Add(cmbNombreNuevo);
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
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(612, 267);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(94, 29);
            btnGuardarNuevo.TabIndex = 7;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.Location = new Point(18, 267);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(94, 29);
            btnVolverNuevo.TabIndex = 6;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            // 
            // cmbMedidaNuevo
            // 
            cmbMedidaNuevo.Cursor = Cursors.Hand;
            cmbMedidaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedidaNuevo.FormattingEnabled = true;
            cmbMedidaNuevo.Location = new Point(19, 117);
            cmbMedidaNuevo.Name = "cmbMedidaNuevo";
            cmbMedidaNuevo.Size = new Size(687, 28);
            cmbMedidaNuevo.TabIndex = 5;
            // 
            // cmbNombreNuevo
            // 
            cmbNombreNuevo.FormattingEnabled = true;
            cmbNombreNuevo.Location = new Point(19, 50);
            cmbNombreNuevo.Name = "cmbNombreNuevo";
            cmbNombreNuevo.Size = new Size(687, 28);
            cmbNombreNuevo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 94);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Medida:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(18, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre:";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cmbHabilitado);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Controls.Add(cmbMedidaEditar);
            tabEditar.Controls.Add(cmbNombreEditar);
            tabEditar.Controls.Add(label2);
            tabEditar.Controls.Add(label4);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // cmbHabilitado
            // 
            cmbHabilitado.Cursor = Cursors.Hand;
            cmbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHabilitado.FormattingEnabled = true;
            cmbHabilitado.Location = new Point(16, 197);
            cmbHabilitado.Name = "cmbHabilitado";
            cmbHabilitado.Size = new Size(687, 28);
            cmbHabilitado.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 164);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 14;
            label5.Text = "Habilitado:";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(613, 268);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(94, 29);
            btnGuardarEditar.TabIndex = 13;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.Location = new Point(19, 268);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(94, 29);
            btnVolverEditar.TabIndex = 12;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            // 
            // cmbMedidaEditar
            // 
            cmbMedidaEditar.Cursor = Cursors.Hand;
            cmbMedidaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedidaEditar.FormattingEnabled = true;
            cmbMedidaEditar.Location = new Point(20, 118);
            cmbMedidaEditar.Name = "cmbMedidaEditar";
            cmbMedidaEditar.Size = new Size(687, 28);
            cmbMedidaEditar.TabIndex = 11;
            // 
            // cmbNombreEditar
            // 
            cmbNombreEditar.FormattingEnabled = true;
            cmbNombreEditar.Location = new Point(20, 51);
            cmbNombreEditar.Name = "cmbNombreEditar";
            cmbNombreEditar.Size = new Size(687, 28);
            cmbNombreEditar.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 9;
            label2.Text = "Medida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 23);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Inventario/categoria";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private Label label1;
        private TabPage tabEditar;
        private Button btn;
        private Button btnBuscar;
        private DataGridView dgvCategorias;
        private TextBox txtBuscar;
        private ComboBox cmbNombreNuevo;
        private Label label3;
        private Label lblName;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private ComboBox cmbMedidaNuevo;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private ComboBox cmbMedidaEditar;
        private ComboBox cmbNombreEditar;
        private Label label2;
        private Label label4;
        private ComboBox cmbHabilitado;
        private Label label5;
    }
}
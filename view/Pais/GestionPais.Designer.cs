﻿namespace view.Pais
{
    partial class GestionPais
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPais));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            agregarpais = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            editarpais = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            eliminarpais = new ToolStripButton();
            filtrarpais = new ToolStripTextBox();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            actualizarpaises = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            dgvpaises = new DataGridView();
            idPaisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paiseBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvpaises).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paiseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, agregarpais, toolStripSeparator2, editarpais, toolStripSeparator3, eliminarpais, filtrarpais, toolStripSeparator6, toolStripLabel1, actualizarpaises, toolStripSeparator5, toolStripSeparator4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(596, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // agregarpais
            // 
            agregarpais.Image = (Image)resources.GetObject("agregarpais.Image");
            agregarpais.ImageTransparentColor = Color.Magenta;
            agregarpais.Name = "agregarpais";
            agregarpais.Size = new Size(87, 24);
            agregarpais.Text = "Agregar";
            agregarpais.Click += agregarpais_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // editarpais
            // 
            editarpais.Image = (Image)resources.GetObject("editarpais.Image");
            editarpais.ImageTransparentColor = Color.Magenta;
            editarpais.Name = "editarpais";
            editarpais.Size = new Size(72, 24);
            editarpais.Text = "Editar";
            editarpais.Click += editarpais_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // eliminarpais
            // 
            eliminarpais.Image = (Image)resources.GetObject("eliminarpais.Image");
            eliminarpais.ImageTransparentColor = Color.Magenta;
            eliminarpais.Name = "eliminarpais";
            eliminarpais.Size = new Size(87, 24);
            eliminarpais.Text = "Eliminar";
            eliminarpais.Click += eliminarpais_Click;
            // 
            // filtrarpais
            // 
            filtrarpais.Alignment = ToolStripItemAlignment.Right;
            filtrarpais.BorderStyle = BorderStyle.FixedSingle;
            filtrarpais.Name = "filtrarpais";
            filtrarpais.Size = new Size(114, 27);
            filtrarpais.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(47, 24);
            toolStripLabel1.Text = "Filtrar";
            // 
            // actualizarpaises
            // 
            actualizarpaises.Image = (Image)resources.GetObject("actualizarpaises.Image");
            actualizarpaises.ImageTransparentColor = Color.Magenta;
            actualizarpaises.Name = "actualizarpaises";
            actualizarpaises.Size = new Size(99, 24);
            actualizarpaises.Text = "Actualizar";
            actualizarpaises.Click += actualizarpaises_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // dgvpaises
            // 
            dgvpaises.AutoGenerateColumns = false;
            dgvpaises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpaises.Columns.AddRange(new DataGridViewColumn[] { idPaisDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn });
            dgvpaises.DataSource = paiseBindingSource;
            dgvpaises.Dock = DockStyle.Fill;
            dgvpaises.Location = new Point(0, 27);
            dgvpaises.Margin = new Padding(3, 4, 3, 4);
            dgvpaises.Name = "dgvpaises";
            dgvpaises.RowHeadersWidth = 51;
            dgvpaises.Size = new Size(596, 518);
            dgvpaises.TabIndex = 1;
            // 
            // idPaisDataGridViewTextBoxColumn
            // 
            idPaisDataGridViewTextBoxColumn.DataPropertyName = "IdPais";
            idPaisDataGridViewTextBoxColumn.HeaderText = "IdPais";
            idPaisDataGridViewTextBoxColumn.MinimumWidth = 6;
            idPaisDataGridViewTextBoxColumn.Name = "idPaisDataGridViewTextBoxColumn";
            idPaisDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            paisDataGridViewTextBoxColumn.MinimumWidth = 6;
            paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            paisDataGridViewTextBoxColumn.Width = 125;
            // 
            // paiseBindingSource
            // 
            paiseBindingSource.DataSource = typeof(Models.Entities.Paise);
            // 
            // GestionPais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 545);
            Controls.Add(dgvpaises);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionPais";
            Text = "GestionPais";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvpaises).EndInit();
            ((System.ComponentModel.ISupportInitialize)paiseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton agregarpais;
        private ToolStripButton editarpais;
        private ToolStripButton eliminarpais;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox filtrarpais;
        private DataGridView dgvpaises;
        private BindingSource paiseBindingSource;
        private DataGridViewTextBoxColumn idPaisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private ToolStripButton actualizarpaises;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
    }
}
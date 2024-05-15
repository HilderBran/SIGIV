namespace view.Distritos
{
    partial class GestionDistritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDistritos));
            dgvDistritos = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAgregar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEditar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnEliminar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            txbFiltrar = new ToolStripTextBox();
            btnFiltrar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvDistritos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDistritos
            // 
            dgvDistritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistritos.Dock = DockStyle.Fill;
            dgvDistritos.Location = new Point(0, 27);
            dgvDistritos.Margin = new Padding(3, 2, 3, 2);
            dgvDistritos.Name = "dgvDistritos";
            dgvDistritos.RowHeadersWidth = 51;
            dgvDistritos.Size = new Size(800, 423);
            dgvDistritos.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnAgregar, toolStripSeparator2, btnEditar, toolStripSeparator3, btnEliminar, toolStripSeparator4, txbFiltrar, btnFiltrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageTransparentColor = Color.Magenta;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(73, 24);
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(61, 24);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageTransparentColor = Color.Magenta;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(74, 24);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // txbFiltrar
            // 
            txbFiltrar.Alignment = ToolStripItemAlignment.Right;
            txbFiltrar.Name = "txbFiltrar";
            txbFiltrar.Size = new Size(88, 27);
            txbFiltrar.TextChanged += txbFiltrar_TextChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Alignment = ToolStripItemAlignment.Right;
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(61, 24);
            btnFiltrar.Text = "Filtrar";
            // 
            // GestionDistritos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDistritos);
            Controls.Add(toolStrip1);
            Name = "GestionDistritos";
            Text = "DistritosGestion";
            ((System.ComponentModel.ISupportInitialize)dgvDistritos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDistritos;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAgregar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnEliminar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripTextBox txbFiltrar;
        private ToolStripButton btnFiltrar;
    }
}
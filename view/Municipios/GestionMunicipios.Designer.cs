namespace view.Municipios
{
    partial class GestionMunicipios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMunicipios));
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
            dgvMunicipios = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnAgregar, toolStripSeparator2, btnEditar, toolStripSeparator3, btnEliminar, toolStripSeparator4, txbFiltrar, btnFiltrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            // dgvMunicipios
            // 
            dgvMunicipios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMunicipios.Dock = DockStyle.Fill;
            dgvMunicipios.Location = new Point(0, 27);
            dgvMunicipios.Margin = new Padding(3, 2, 3, 2);
            dgvMunicipios.Name = "dgvMunicipios";
            dgvMunicipios.RowHeadersWidth = 51;
            dgvMunicipios.Size = new Size(700, 311);
            dgvMunicipios.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(58, 17);
            toolStripStatusLabel1.Text = "Cantidad ";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(88, 16);
            // 
            // GestionMunicipios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(statusStrip1);
            Controls.Add(dgvMunicipios);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionMunicipios";
            Text = "GestionMunicipios";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridView dgvMunicipios;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}
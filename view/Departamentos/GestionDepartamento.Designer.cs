namespace view.Departamentos
{
    partial class GestionDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDepartamento));
            toolStrip1 = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            stbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tstbFiltrar = new ToolStripTextBox();
            dgvDepartamentos = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAgregar, stbEditar, tsbEliminar, tstbFiltrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(69, 22);
            tsbAgregar.Text = "Agregar";
            tsbAgregar.Click += tsbAgregar_Click;
            // 
            // stbEditar
            // 
            stbEditar.Image = (Image)resources.GetObject("stbEditar.Image");
            stbEditar.ImageTransparentColor = Color.Magenta;
            stbEditar.Name = "stbEditar";
            stbEditar.Size = new Size(57, 22);
            stbEditar.Text = "Editar";
            stbEditar.Click += stbEditar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(70, 22);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tstbFiltrar
            // 
            tstbFiltrar.Alignment = ToolStripItemAlignment.Right;
            tstbFiltrar.BorderStyle = BorderStyle.FixedSingle;
            tstbFiltrar.Name = "tstbFiltrar";
            tstbFiltrar.Size = new Size(100, 25);
            tstbFiltrar.TextChanged += tstbFiltrar_TextChanged;
            // 
            // dgvDepartamentos
            // 
            dgvDepartamentos.AllowUserToAddRows = false;
            dgvDepartamentos.AllowUserToDeleteRows = false;
            dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamentos.Dock = DockStyle.Fill;
            dgvDepartamentos.Location = new Point(0, 25);
            dgvDepartamentos.Name = "dgvDepartamentos";
            dgvDepartamentos.ReadOnly = true;
            dgvDepartamentos.Size = new Size(800, 425);
            dgvDepartamentos.TabIndex = 1;
            // 
            // GestionDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDepartamentos);
            Controls.Add(toolStrip1);
            Name = "GestionDepartamento";
            Text = "GestionDepartamento";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbAgregar;
        private ToolStripButton stbEditar;
        private ToolStripButton tsbEliminar;
        private ToolStripTextBox tstbFiltrar;
        private DataGridView dgvDepartamentos;
    }
}
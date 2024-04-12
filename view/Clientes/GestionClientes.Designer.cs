namespace view.Clientes
{
    partial class GestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAgregar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnVer = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnModificar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnEliminar = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            txtFiltrar = new ToolStripTextBox();
            btnFiltrar = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtNumber = new ToolStripProgressBar();
            lstBox = new ListBox();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnAgregar, toolStripSeparator2, btnVer, toolStripSeparator3, btnModificar, toolStripSeparator4, btnEliminar, toolStripSeparator5, txtFiltrar, btnFiltrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 32);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 32);
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageTransparentColor = Color.Magenta;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 29);
            btnAgregar.Text = "Agregar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 32);
            // 
            // btnVer
            // 
            btnVer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVer.Image = (Image)resources.GetObject("btnVer.Image");
            btnVer.ImageTransparentColor = Color.Magenta;
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(61, 29);
            btnVer.Text = "Ver";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 32);
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageTransparentColor = Color.Magenta;
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 29);
            btnModificar.Text = "Modificar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 32);
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageTransparentColor = Color.Magenta;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 29);
            btnEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 32);
            // 
            // txtFiltrar
            // 
            txtFiltrar.Alignment = ToolStripItemAlignment.Right;
            txtFiltrar.BackColor = SystemColors.Window;
            txtFiltrar.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(150, 32);
            // 
            // btnFiltrar
            // 
            btnFiltrar.Alignment = ToolStripItemAlignment.Right;
            btnFiltrar.BackColor = SystemColors.ButtonHighlight;
            btnFiltrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageTransparentColor = SystemColors.Window;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 29);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Click += toolStripButton5_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtNumber });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(78, 20);
            toolStripStatusLabel1.Text = "Contador :";
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 18);
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.Location = new Point(0, 35);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(800, 384);
            lstBox.TabIndex = 2;
            lstBox.SelectedIndexChanged += lstBox_SelectedIndexChanged;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBox);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "GestionClientes";
            Text = "GestionClientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStripButton btnVer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnModificar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnEliminar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripTextBox txtFiltrar;
        private ToolStripButton btnFiltrar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar txtNumber;
        private ListBox lstBox;
    }
}
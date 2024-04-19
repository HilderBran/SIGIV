namespace view
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            toolStrip1 = new ToolStrip();
            btnAgregaruser = new ToolStripButton();
            btnModificaruser = new ToolStripButton();
            btnEliminaruser = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            stbFiltraruser = new ToolStripTextBox();
            btnFiltraruser = new ToolStripButton();
            listBox1 = new ListBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, btnAgregaruser, toolStripSeparator2, btnModificaruser, toolStripSeparator3, btnEliminaruser, stbFiltraruser, btnFiltraruser });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregaruser
            // 
            btnAgregaruser.Image = (Image)resources.GetObject("btnAgregaruser.Image");
            btnAgregaruser.ImageTransparentColor = Color.Magenta;
            btnAgregaruser.Name = "btnAgregaruser";
            btnAgregaruser.Size = new Size(69, 22);
            btnAgregaruser.Text = "Agregar";
            // 
            // btnModificaruser
            // 
            btnModificaruser.Image = (Image)resources.GetObject("btnModificaruser.Image");
            btnModificaruser.ImageTransparentColor = Color.Magenta;
            btnModificaruser.Name = "btnModificaruser";
            btnModificaruser.Size = new Size(78, 22);
            btnModificaruser.Text = "Modificar";
            // 
            // btnEliminaruser
            // 
            btnEliminaruser.Image = (Image)resources.GetObject("btnEliminaruser.Image");
            btnEliminaruser.ImageTransparentColor = Color.Magenta;
            btnEliminaruser.Name = "btnEliminaruser";
            btnEliminaruser.Size = new Size(70, 22);
            btnEliminaruser.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // stbFiltraruser
            // 
            stbFiltraruser.Alignment = ToolStripItemAlignment.Right;
            stbFiltraruser.BorderStyle = BorderStyle.FixedSingle;
            stbFiltraruser.Name = "stbFiltraruser";
            stbFiltraruser.Size = new Size(100, 25);
            // 
            // btnFiltraruser
            // 
            btnFiltraruser.Alignment = ToolStripItemAlignment.Right;
            btnFiltraruser.Image = (Image)resources.GetObject("btnFiltraruser.Image");
            btnFiltraruser.ImageTransparentColor = Color.Magenta;
            btnFiltraruser.Name = "btnFiltraruser";
            btnFiltraruser.Size = new Size(57, 22);
            btnFiltraruser.Text = "Filtrar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(788, 409);
            listBox1.TabIndex = 1;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(toolStrip1);
            Name = "GestionUsuarios";
            Text = "GestionUsuarios";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAgregaruser;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnModificaruser;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnEliminaruser;
        private ToolStripTextBox stbFiltraruser;
        private ToolStripButton btnFiltraruser;
        private ListBox listBox1;
    }
}
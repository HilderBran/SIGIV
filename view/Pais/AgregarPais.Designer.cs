namespace view
{
    partial class AgregarPais
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            IdPais = new TextBox();
            Pais = new TextBox();
            Guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            cancelarpais = new Button();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(371, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // IdPais
            // 
            IdPais.BorderStyle = BorderStyle.FixedSingle;
            IdPais.Location = new Point(126, 70);
            IdPais.Name = "IdPais";
            IdPais.Size = new Size(100, 23);
            IdPais.TabIndex = 1;
            // 
            // Pais
            // 
            Pais.BorderStyle = BorderStyle.FixedSingle;
            Pais.Location = new Point(126, 189);
            Pais.Name = "Pais";
            Pais.Size = new Size(100, 23);
            Pais.TabIndex = 2;
            // 
            // Guardar
            // 
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.Location = new Point(46, 291);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(75, 23);
            Guardar.TabIndex = 3;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(157, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 4;
            label1.Text = "IdPais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(157, 159);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 5;
            label2.Text = "Pais";
            // 
            // cancelarpais
            // 
            cancelarpais.FlatStyle = FlatStyle.Flat;
            cancelarpais.Location = new Point(222, 291);
            cancelarpais.Name = "cancelarpais";
            cancelarpais.Size = new Size(75, 23);
            cancelarpais.TabIndex = 6;
            cancelarpais.Text = "Cancelar";
            cancelarpais.UseVisualStyleBackColor = true;
            cancelarpais.Click += cancelarpais_Click;
            // 
            // AgregarPais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 348);
            Controls.Add(cancelarpais);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Guardar);
            Controls.Add(Pais);
            Controls.Add(IdPais);
            Controls.Add(toolStrip1);
            Name = "AgregarPais";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private TextBox IdPais;
        private TextBox Pais;
        private Button Guardar;
        private Label label1;
        private Label label2;
        private Button cancelarpais;
    }
}

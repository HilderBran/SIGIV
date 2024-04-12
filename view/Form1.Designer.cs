namespace view
{
    partial class Form1
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
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // IdPais
            // 
            IdPais.Location = new Point(201, 99);
            IdPais.Name = "IdPais";
            IdPais.Size = new Size(100, 23);
            IdPais.TabIndex = 1;
            // 
            // Pais
            // 
            Pais.Location = new Point(201, 203);
            Pais.Name = "Pais";
            Pais.Size = new Size(100, 23);
            Pais.TabIndex = 2;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(226, 272);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(75, 23);
            Guardar.TabIndex = 3;
            Guardar.Text = "button1";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "IdPais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 165);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "Pais";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Guardar);
            Controls.Add(Pais);
            Controls.Add(IdPais);
            Controls.Add(toolStrip1);
            Name = "Form1";
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
    }
}

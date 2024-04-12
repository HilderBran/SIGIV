namespace view
{
    partial class Login
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ButtonFace;
            txtUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(37, 129);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(320, 31);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "Example";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.ButtonFace;
            txtContraseña.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = SystemColors.WindowFrame;
            txtContraseña.Location = new Point(37, 236);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(320, 31);
            txtContraseña.TabIndex = 1;
            txtContraseña.Text = "Example";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 102);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 209);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(148, 307);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(148, 36);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}
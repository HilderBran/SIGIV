namespace view.Distritos
{
    partial class AgregarDistritos
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
            cbbIdMunicipio = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            txbDistrito = new TextBox();
            label2 = new Label();
            txbIdDistrito = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbbIdMunicipio
            // 
            cbbIdMunicipio.FormattingEnabled = true;
            cbbIdMunicipio.Location = new Point(210, 223);
            cbbIdMunicipio.Name = "cbbIdMunicipio";
            cbbIdMunicipio.Size = new Size(110, 23);
            cbbIdMunicipio.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(339, 282);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Location = new Point(117, 282);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 194);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 13;
            label3.Text = "Municipio";
            // 
            // txbDistrito
            // 
            txbDistrito.Location = new Point(210, 150);
            txbDistrito.Margin = new Padding(3, 2, 3, 2);
            txbDistrito.Name = "txbDistrito";
            txbDistrito.Size = new Size(110, 23);
            txbDistrito.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 133);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 11;
            label2.Text = "Distrito";
            // 
            // txbIdDistrito
            // 
            txbIdDistrito.Location = new Point(210, 83);
            txbIdDistrito.Margin = new Padding(3, 2, 3, 2);
            txbIdDistrito.Name = "txbIdDistrito";
            txbIdDistrito.Size = new Size(110, 23);
            txbIdDistrito.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 9;
            label1.Text = "IdDistrito";
            // 
            // AgregarDistritos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 450);
            Controls.Add(cbbIdMunicipio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(txbDistrito);
            Controls.Add(label2);
            Controls.Add(txbIdDistrito);
            Controls.Add(label1);
            Name = "AgregarDistritos";
            Text = "AgregarDistritos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbIdMunicipio;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label3;
        private TextBox txbDistrito;
        private Label label2;
        private TextBox txbIdDistrito;
        private Label label1;
    }
}
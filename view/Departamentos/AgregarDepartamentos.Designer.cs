namespace view.Departamentos
{
    partial class AgregarDepartamentos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbIdDepartamento = new TextBox();
            txbDepartamento = new TextBox();
            cbbIdPais = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(287, 63);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "IdDepertamento";
            // 
            // label2
            // 
            label2.Location = new Point(287, 253);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 1;
            label2.Text = "IdPais";
            // 
            // label3
            // 
            label3.Location = new Point(289, 145);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 2;
            label3.Text = "Departamento";
            // 
            // txbIdDepartamento
            // 
            txbIdDepartamento.Location = new Point(287, 89);
            txbIdDepartamento.Name = "txbIdDepartamento";
            txbIdDepartamento.Size = new Size(100, 23);
            txbIdDepartamento.TabIndex = 3;
            // 
            // txbDepartamento
            // 
            txbDepartamento.Location = new Point(287, 183);
            txbDepartamento.Name = "txbDepartamento";
            txbDepartamento.Size = new Size(100, 23);
            txbDepartamento.TabIndex = 4;
            // 
            // cbbIdPais
            // 
            cbbIdPais.FormattingEnabled = true;
            cbbIdPais.Location = new Point(287, 280);
            cbbIdPais.Name = "cbbIdPais";
            cbbIdPais.Size = new Size(100, 23);
            cbbIdPais.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Location = new Point(211, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(396, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cbbIdPais);
            Controls.Add(txbDepartamento);
            Controls.Add(txbIdDepartamento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarDepartamentos";
            Text = "AgregarDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbIdDepartamento;
        private TextBox txbDepartamento;
        private ComboBox cbbIdPais;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
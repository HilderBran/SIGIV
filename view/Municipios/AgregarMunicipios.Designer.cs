namespace view.Municipios
{
    partial class AgregarMunicipios
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
            txbIdMunicipio = new TextBox();
            txbMunicipio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cbbIdDepartamento = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "IdMunicipio";
            // 
            // txbIdMunicipio
            // 
            txbIdMunicipio.Location = new Point(159, 47);
            txbIdMunicipio.Margin = new Padding(3, 2, 3, 2);
            txbIdMunicipio.Name = "txbIdMunicipio";
            txbIdMunicipio.Size = new Size(110, 23);
            txbIdMunicipio.TabIndex = 1;
            // 
            // txbMunicipio
            // 
            txbMunicipio.Location = new Point(159, 114);
            txbMunicipio.Margin = new Padding(3, 2, 3, 2);
            txbMunicipio.Name = "txbMunicipio";
            txbMunicipio.Size = new Size(110, 23);
            txbMunicipio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 97);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Municipio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 158);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "IdDepartamento";
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Location = new Point(66, 246);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(288, 246);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbbIdDepartamento
            // 
            cbbIdDepartamento.FormattingEnabled = true;
            cbbIdDepartamento.Location = new Point(159, 187);
            cbbIdDepartamento.Name = "cbbIdDepartamento";
            cbbIdDepartamento.Size = new Size(110, 23);
            cbbIdDepartamento.TabIndex = 8;
            // 
            // AgregarMunicipios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 301);
            Controls.Add(cbbIdDepartamento);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(txbMunicipio);
            Controls.Add(label2);
            Controls.Add(txbIdMunicipio);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarMunicipios";
            Text = "Agregar Municipios";
            Load += AgregarMunicipios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbIdMunicipio;
        private TextBox txbMunicipio;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cbbIdDepartamento;
    }
}
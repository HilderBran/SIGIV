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
            txbIdPais = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 40);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "IdMunicipio";
            // 
            // txbIdMunicipio
            // 
            txbIdMunicipio.Location = new Point(182, 63);
            txbIdMunicipio.Name = "txbIdMunicipio";
            txbIdMunicipio.Size = new Size(125, 27);
            txbIdMunicipio.TabIndex = 1;
            // 
            // txbMunicipio
            // 
            txbMunicipio.Location = new Point(182, 152);
            txbMunicipio.Name = "txbMunicipio";
            txbMunicipio.Size = new Size(125, 27);
            txbMunicipio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Municipio";
            // 
            // txbIdPais
            // 
            txbIdPais.Location = new Point(182, 234);
            txbIdPais.Name = "txbIdPais";
            txbIdPais.Size = new Size(125, 27);
            txbIdPais.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 211);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "IdPais";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(76, 328);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(329, 328);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AgregarMunicipios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 401);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txbIdPais);
            Controls.Add(label3);
            Controls.Add(txbMunicipio);
            Controls.Add(label2);
            Controls.Add(txbIdMunicipio);
            Controls.Add(label1);
            Name = "AgregarMunicipios";
            Text = "AgregarMunicipios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbIdMunicipio;
        private TextBox txbMunicipio;
        private Label label2;
        private TextBox txbIdPais;
        private Label label3;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
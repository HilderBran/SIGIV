namespace view.Empleados
{
    partial class AgregarEmpleado
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
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txbDui = new TextBox();
            label4 = new Label();
            txbIsss = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            txbMail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cbCargo = new ComboBox();
            cbPais = new ComboBox();
            label9 = new Label();
            cbDepartamento = new ComboBox();
            label10 = new Label();
            cbMunicipio = new ComboBox();
            label11 = new Label();
            cbDistrito = new ComboBox();
            label12 = new Label();
            txbDireccion = new TextBox();
            label13 = new Label();
            txbReferencia = new TextBox();
            label14 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label15 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(32, 34);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(200, 23);
            txbNombre.TabIndex = 1;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(32, 88);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(200, 23);
            txbApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 13);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(255, 31);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txbDui
            // 
            txbDui.Location = new Point(32, 144);
            txbDui.Name = "txbDui";
            txbDui.Size = new Size(200, 23);
            txbDui.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 126);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 6;
            label4.Text = "DUI";
            // 
            // txbIsss
            // 
            txbIsss.Location = new Point(32, 198);
            txbIsss.Name = "txbIsss";
            txbIsss.Size = new Size(200, 23);
            txbIsss.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 180);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 8;
            label5.Text = "ISSS";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(255, 88);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 70);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefono";
            // 
            // txbMail
            // 
            txbMail.Location = new Point(255, 144);
            txbMail.Name = "txbMail";
            txbMail.Size = new Size(200, 23);
            txbMail.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 126);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 12;
            label7.Text = "Correro Electronico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 180);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 14;
            label8.Text = "Cargo";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(255, 198);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(200, 23);
            cbCargo.TabIndex = 17;
            // 
            // cbPais
            // 
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(30, 281);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(200, 23);
            cbPais.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 263);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 18;
            label9.Text = "Pais";
            // 
            // cbDepartamento
            // 
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(255, 281);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(200, 23);
            cbDepartamento.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(255, 263);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 20;
            label10.Text = "Departamento";
            // 
            // cbMunicipio
            // 
            cbMunicipio.FormattingEnabled = true;
            cbMunicipio.Location = new Point(30, 331);
            cbMunicipio.Name = "cbMunicipio";
            cbMunicipio.Size = new Size(200, 23);
            cbMunicipio.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 313);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 22;
            label11.Text = "Municipio";
            // 
            // cbDistrito
            // 
            cbDistrito.FormattingEnabled = true;
            cbDistrito.Location = new Point(255, 331);
            cbDistrito.Name = "cbDistrito";
            cbDistrito.Size = new Size(200, 23);
            cbDistrito.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(255, 313);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 24;
            label12.Text = "Distrito";
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(30, 386);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(200, 23);
            txbDireccion.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 368);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 26;
            label13.Text = "Dirección";
            // 
            // txbReferencia
            // 
            txbReferencia.Location = new Point(255, 386);
            txbReferencia.Name = "txbReferencia";
            txbReferencia.Size = new Size(200, 23);
            txbReferencia.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(255, 368);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 28;
            label14.Text = "Referencia";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(373, 440);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.DialogResult = DialogResult.OK;
            btnGuardar.Location = new Point(150, 440);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label15.Location = new Point(32, 238);
            label15.Name = "label15";
            label15.Size = new Size(73, 15);
            label15.TabIndex = 32;
            label15.Text = "Direccion      ";
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 511);
            Controls.Add(label15);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txbReferencia);
            Controls.Add(label14);
            Controls.Add(txbDireccion);
            Controls.Add(label13);
            Controls.Add(cbDistrito);
            Controls.Add(label12);
            Controls.Add(cbMunicipio);
            Controls.Add(label11);
            Controls.Add(cbDepartamento);
            Controls.Add(label10);
            Controls.Add(cbPais);
            Controls.Add(label9);
            Controls.Add(cbCargo);
            Controls.Add(label8);
            Controls.Add(txbMail);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(txbIsss);
            Controls.Add(label5);
            Controls.Add(txbDui);
            Controls.Add(label4);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label3);
            Controls.Add(txbApellido);
            Controls.Add(label2);
            Controls.Add(txbNombre);
            Controls.Add(label1);
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbNombre;
        private TextBox txbApellido;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txbDui;
        private Label label4;
        private TextBox txbIsss;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox txbMail;
        private Label label7;
        private Label label8;
        private ComboBox cbCargo;
        private ComboBox cbPais;
        private Label label9;
        private ComboBox cbDepartamento;
        private Label label10;
        private ComboBox cbMunicipio;
        private Label label11;
        private ComboBox cbDistrito;
        private Label label12;
        private TextBox txbDireccion;
        private Label label13;
        private TextBox txbReferencia;
        private Label label14;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label15;
    }
}
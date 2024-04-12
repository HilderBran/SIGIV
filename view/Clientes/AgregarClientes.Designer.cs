namespace view.Clientes
{
    partial class AgregarClientes
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
            txtNombreCliente = new TextBox();
            label2 = new Label();
            txtApellidoCliente = new TextBox();
            label3 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtDUI = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombres de Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(187, 73);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(348, 27);
            txtNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellidos de Cliente";
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(187, 123);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(348, 27);
            txtApellidoCliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 300);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 4;
            label3.Text = "DUI";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(187, 168);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(348, 27);
            txtDireccion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(187, 210);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(348, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 252);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 8;
            label5.Text = "Emial";
            label5.Click += label5_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(187, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(348, 27);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 170);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 10;
            label6.Text = "Direccion";
            // 
            // txtDUI
            // 
            txtDUI.Location = new Point(187, 298);
            txtDUI.Name = "txtDUI";
            txtDUI.Size = new Size(348, 27);
            txtDUI.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(380, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(144, 377);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // AgregarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 437);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDUI);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtApellidoCliente);
            Controls.Add(label2);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Name = "AgregarClientes";
            Text = "GestionClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCliente;
        private Label label2;
        private TextBox txtApellidoCliente;
        private Label label3;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtDUI;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
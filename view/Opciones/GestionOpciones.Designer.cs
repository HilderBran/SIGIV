namespace view.Opciones
{
    partial class GestionOpciones
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
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            lstbOpciones = new ListBox();
            groupBox2 = new GroupBox();
            rbBuscar = new RadioButton();
            rbEliminar = new RadioButton();
            rbModificar = new RadioButton();
            rbNuevo = new RadioButton();
            groupBox1 = new GroupBox();
            txbNombre = new TextBox();
            btnOperaciones = new Button();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(367, 450);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstbOpciones);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(15, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(337, 286);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de Opciones";
            // 
            // lstbOpciones
            // 
            lstbOpciones.Dock = DockStyle.Fill;
            lstbOpciones.FormattingEnabled = true;
            lstbOpciones.ItemHeight = 15;
            lstbOpciones.Location = new Point(10, 26);
            lstbOpciones.Name = "lstbOpciones";
            lstbOpciones.Size = new Size(317, 250);
            lstbOpciones.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbBuscar);
            groupBox2.Controls.Add(rbEliminar);
            groupBox2.Controls.Add(rbModificar);
            groupBox2.Controls.Add(rbNuevo);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(15, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 73);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones";
            // 
            // rbBuscar
            // 
            rbBuscar.AutoSize = true;
            rbBuscar.Checked = true;
            rbBuscar.Location = new Point(237, 33);
            rbBuscar.Name = "rbBuscar";
            rbBuscar.Size = new Size(60, 19);
            rbBuscar.TabIndex = 7;
            rbBuscar.TabStop = true;
            rbBuscar.Text = "Buscar";
            rbBuscar.UseVisualStyleBackColor = true;
            // 
            // rbEliminar
            // 
            rbEliminar.AutoSize = true;
            rbEliminar.Location = new Point(163, 33);
            rbEliminar.Name = "rbEliminar";
            rbEliminar.Size = new Size(68, 19);
            rbEliminar.TabIndex = 6;
            rbEliminar.Text = "Eliminar";
            rbEliminar.UseVisualStyleBackColor = true;
            // 
            // rbModificar
            // 
            rbModificar.AutoSize = true;
            rbModificar.Location = new Point(81, 33);
            rbModificar.Name = "rbModificar";
            rbModificar.Size = new Size(76, 19);
            rbModificar.TabIndex = 5;
            rbModificar.Text = "Modificar";
            rbModificar.UseVisualStyleBackColor = true;
            // 
            // rbNuevo
            // 
            rbNuevo.AutoSize = true;
            rbNuevo.Location = new Point(15, 33);
            rbNuevo.Name = "rbNuevo";
            rbNuevo.Size = new Size(60, 19);
            rbNuevo.TabIndex = 4;
            rbNuevo.Text = "Nuevo";
            rbNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOperaciones);
            groupBox1.Controls.Add(txbNombre);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(15, 22);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(219, 23);
            txbNombre.TabIndex = 0;
            // 
            // btnOperaciones
            // 
            btnOperaciones.Location = new Point(240, 22);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Size = new Size(87, 23);
            btnOperaciones.TabIndex = 1;
            btnOperaciones.Text = "Ejecutar";
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += button2_Click;
            // 
            // GestionOpciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 450);
            Controls.Add(panel1);
            Name = "GestionOpciones";
            Text = "GestionOpciones";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txbNombre;
        private GroupBox groupBox3;
        private ListBox lstbOpciones;
        private RadioButton rbBuscar;
        private RadioButton rbEliminar;
        private RadioButton rbModificar;
        private RadioButton rbNuevo;
        private Button btnOperaciones;
    }
}
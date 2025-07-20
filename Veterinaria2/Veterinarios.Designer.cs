namespace Veterinaria2
{
    partial class Veterinarios
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
            label6 = new Label();
            grdVeterinarios = new DataGridView();
            txtDireccion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmdAnular = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdVeterinarios).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 256);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 51;
            label6.Text = "Lista de Veterinarios:";
            // 
            // grdVeterinarios
            // 
            grdVeterinarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVeterinarios.Location = new Point(7, 274);
            grdVeterinarios.Name = "grdVeterinarios";
            grdVeterinarios.Size = new Size(495, 203);
            grdVeterinarios.TabIndex = 50;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(7, 210);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(495, 23);
            txtDireccion.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 192);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 48;
            label5.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 55);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 47;
            label4.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(281, 73);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(221, 23);
            dtpFechaNacimiento.TabIndex = 46;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(7, 142);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(221, 23);
            txtTelefono.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 124);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 44;
            label3.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(7, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 43;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(281, 142);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 23);
            txtCorreo.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 55);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 41;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 124);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 40;
            label1.Text = "Correo:";
            // 
            // cmdAnular
            // 
            cmdAnular.Location = new Point(346, 500);
            cmdAnular.Name = "cmdAnular";
            cmdAnular.Size = new Size(75, 23);
            cmdAnular.TabIndex = 55;
            cmdAnular.Text = "Anular";
            cmdAnular.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(265, 500);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(75, 23);
            cmdModificar.TabIndex = 54;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(427, 500);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(75, 23);
            cmdSalir.TabIndex = 53;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(184, 500);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(75, 23);
            cmdGuardar.TabIndex = 52;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // Veterinarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 530);
            ControlBox = false;
            Controls.Add(cmdAnular);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdGuardar);
            Controls.Add(label6);
            Controls.Add(grdVeterinarios);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Veterinarios";
            Text = "Veterinarios";
            ((System.ComponentModel.ISupportInitialize)grdVeterinarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView grdVeterinarios;
        private TextBox txtDireccion;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label2;
        private Label label1;
        private Button cmdAnular;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdGuardar;
    }
}
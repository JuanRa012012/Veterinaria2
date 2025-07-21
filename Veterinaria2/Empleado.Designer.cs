namespace Veterinaria2
{
    partial class Empleado
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
            btnServicios = new Button();
            btnMascotas = new Button();
            btnFacturas = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 23);
            label1.Name = "label1";
            label1.Size = new Size(139, 54);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            // 
            // btnServicios
            // 
            btnServicios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnServicios.Location = new Point(70, 111);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(114, 51);
            btnServicios.TabIndex = 1;
            btnServicios.Text = "SERVICIOS";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnMascotas
            // 
            btnMascotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMascotas.Location = new Point(70, 183);
            btnMascotas.Name = "btnMascotas";
            btnMascotas.Size = new Size(114, 51);
            btnMascotas.TabIndex = 1;
            btnMascotas.Text = "MASCOTAS";
            btnMascotas.UseVisualStyleBackColor = true;
            btnMascotas.Click += button2_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFacturas.Location = new Point(70, 261);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(114, 51);
            btnFacturas.TabIndex = 1;
            btnFacturas.Text = "FACTURAS";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(70, 398);
            button4.Name = "button4";
            button4.Size = new Size(114, 29);
            button4.TabIndex = 1;
            button4.Text = "SALIR";
            button4.UseVisualStyleBackColor = true;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 450);
            Controls.Add(button4);
            Controls.Add(btnFacturas);
            Controls.Add(btnMascotas);
            Controls.Add(btnServicios);
            Controls.Add(label1);
            Name = "Empleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnServicios;
        private Button btnMascotas;
        private Button btnFacturas;
        private Button button4;
    }
}
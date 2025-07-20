namespace Veterinaria2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmd_cancelar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmd_cancelar
            // 
            cmd_cancelar.Location = new Point(158, 381);
            cmd_cancelar.Name = "cmd_cancelar";
            cmd_cancelar.Size = new Size(75, 23);
            cmd_cancelar.TabIndex = 13;
            cmd_cancelar.Text = "Cancelar";
            cmd_cancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 381);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 322);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(221, 23);
            txtClave.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 253);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 23);
            txtUsuario.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 304);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Clave:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 413);
            Controls.Add(cmd_cancelar);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmd_cancelar;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}

namespace Veterinaria2
{
    partial class Razas
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
            cboEspecie = new ComboBox();
            label10 = new Label();
            cmdAnular = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdGuardar = new Button();
            label6 = new Label();
            grdRazas = new DataGridView();
            txtNombre = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdRazas).BeginInit();
            SuspendLayout();
            // 
            // cboEspecie
            // 
            cboEspecie.FormattingEnabled = true;
            cboEspecie.Location = new Point(12, 128);
            cboEspecie.Name = "cboEspecie";
            cboEspecie.Size = new Size(297, 23);
            cboEspecie.TabIndex = 65;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 110);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 64;
            label10.Text = "Especie:";
            // 
            // cmdAnular
            // 
            cmdAnular.Location = new Point(171, 429);
            cmdAnular.Name = "cmdAnular";
            cmdAnular.Size = new Size(66, 23);
            cmdAnular.TabIndex = 63;
            cmdAnular.Text = "Anular";
            cmdAnular.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(99, 429);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(66, 23);
            cmdModificar.TabIndex = 62;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(243, 429);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(66, 23);
            cmdSalir.TabIndex = 61;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(27, 429);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(66, 23);
            cmdGuardar.TabIndex = 60;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 168);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 59;
            label6.Text = "Lista:";
            // 
            // grdRazas
            // 
            grdRazas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRazas.Location = new Point(12, 186);
            grdRazas.Name = "grdRazas";
            grdRazas.Size = new Size(297, 237);
            grdRazas.TabIndex = 58;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 23);
            txtNombre.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 56;
            label2.Text = "Nombre:";
            // 
            // Razas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 461);
            ControlBox = false;
            Controls.Add(cboEspecie);
            Controls.Add(label10);
            Controls.Add(cmdAnular);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdGuardar);
            Controls.Add(label6);
            Controls.Add(grdRazas);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "Razas";
            Text = "Razas";
            ((System.ComponentModel.ISupportInitialize)grdRazas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEspecie;
        private Label label10;
        private Button cmdAnular;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdGuardar;
        private Label label6;
        private DataGridView grdRazas;
        private TextBox txtNombre;
        private Label label2;
    }
}
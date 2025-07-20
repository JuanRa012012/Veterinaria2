namespace Veterinaria2
{
    partial class Especies
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
            bttAnularEspecies = new Button();
            bttModificarEspecies = new Button();
            bttSalirEspecies = new Button();
            bttGuardarEspecies = new Button();
            lblListaEspecies = new Label();
            dgvListaEspecies = new DataGridView();
            txtNombreEspecies = new TextBox();
            lblNombreEspecies = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaEspecies).BeginInit();
            SuspendLayout();
            // 
            // bttAnularEspecies
            // 
            bttAnularEspecies.Location = new Point(171, 389);
            bttAnularEspecies.Name = "bttAnularEspecies";
            bttAnularEspecies.Size = new Size(66, 23);
            bttAnularEspecies.TabIndex = 61;
            bttAnularEspecies.Text = "Anular";
            bttAnularEspecies.UseVisualStyleBackColor = true;
            // 
            // bttModificarEspecies
            // 
            bttModificarEspecies.Location = new Point(99, 389);
            bttModificarEspecies.Name = "bttModificarEspecies";
            bttModificarEspecies.Size = new Size(66, 23);
            bttModificarEspecies.TabIndex = 60;
            bttModificarEspecies.Text = "Modificar";
            bttModificarEspecies.UseVisualStyleBackColor = true;
            // 
            // bttSalirEspecies
            // 
            bttSalirEspecies.Location = new Point(243, 389);
            bttSalirEspecies.Name = "bttSalirEspecies";
            bttSalirEspecies.Size = new Size(66, 23);
            bttSalirEspecies.TabIndex = 59;
            bttSalirEspecies.Text = "Salir";
            bttSalirEspecies.UseVisualStyleBackColor = true;
            // 
            // bttGuardarEspecies
            // 
            bttGuardarEspecies.Location = new Point(27, 389);
            bttGuardarEspecies.Name = "bttGuardarEspecies";
            bttGuardarEspecies.Size = new Size(66, 23);
            bttGuardarEspecies.TabIndex = 58;
            bttGuardarEspecies.Text = "Guardar";
            bttGuardarEspecies.UseVisualStyleBackColor = true;
            // 
            // lblListaEspecies
            // 
            lblListaEspecies.AutoSize = true;
            lblListaEspecies.Location = new Point(12, 75);
            lblListaEspecies.Name = "lblListaEspecies";
            lblListaEspecies.Size = new Size(34, 15);
            lblListaEspecies.TabIndex = 57;
            lblListaEspecies.Text = "Lista:";
            // 
            // dgvListaEspecies
            // 
            dgvListaEspecies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaEspecies.Location = new Point(12, 93);
            dgvListaEspecies.Name = "dgvListaEspecies";
            dgvListaEspecies.Size = new Size(297, 273);
            dgvListaEspecies.TabIndex = 56;
            // 
            // txtNombreEspecies
            // 
            txtNombreEspecies.Location = new Point(12, 34);
            txtNombreEspecies.Name = "txtNombreEspecies";
            txtNombreEspecies.Size = new Size(297, 23);
            txtNombreEspecies.TabIndex = 55;
            // 
            // lblNombreEspecies
            // 
            lblNombreEspecies.AutoSize = true;
            lblNombreEspecies.Location = new Point(12, 16);
            lblNombreEspecies.Name = "lblNombreEspecies";
            lblNombreEspecies.Size = new Size(54, 15);
            lblNombreEspecies.TabIndex = 54;
            lblNombreEspecies.Text = "Nombre:";
            // 
            // Especies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            ControlBox = false;
            Controls.Add(bttAnularEspecies);
            Controls.Add(bttModificarEspecies);
            Controls.Add(bttSalirEspecies);
            Controls.Add(bttGuardarEspecies);
            Controls.Add(lblListaEspecies);
            Controls.Add(dgvListaEspecies);
            Controls.Add(txtNombreEspecies);
            Controls.Add(lblNombreEspecies);
            Name = "Especies";
            Text = "Especies";
            ((System.ComponentModel.ISupportInitialize)dgvListaEspecies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttAnularEspecies;
        private Button bttModificarEspecies;
        private Button bttSalirEspecies;
        private Button bttGuardarEspecies;
        private Label lblListaEspecies;
        private DataGridView dgvListaEspecies;
        private TextBox txtNombreEspecies;
        private Label lblNombreEspecies;
    }
}
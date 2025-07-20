namespace Veterinaria2
{
    partial class Clientes
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
            txtNombreCLientes = new TextBox();
            lblNombreCliente = new Label();
            lblFechaNcimiento = new Label();
            dtpFechaNaciClientes = new DateTimePicker();
            txtCorreoCliente = new TextBox();
            lblCorreoCliente = new Label();
            txtTeleClientes = new TextBox();
            lblTelefonoClientes = new Label();
            bttAnularClientes = new Button();
            bttModificarClientes = new Button();
            bttSalirClientes = new Button();
            bttGuardarClientes = new Button();
            lblListaClientes = new Label();
            dgvListaClientes = new DataGridView();
            txtDirecClientes = new TextBox();
            lblDireccClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCLientes
            // 
            txtNombreCLientes.Location = new Point(24, 56);
            txtNombreCLientes.Name = "txtNombreCLientes";
            txtNombreCLientes.Size = new Size(221, 23);
            txtNombreCLientes.TabIndex = 17;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(24, 35);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(54, 15);
            lblNombreCliente.TabIndex = 16;
            lblNombreCliente.Text = "Nombre:";
            // 
            // lblFechaNcimiento
            // 
            lblFechaNcimiento.AutoSize = true;
            lblFechaNcimiento.Location = new Point(274, 38);
            lblFechaNcimiento.Name = "lblFechaNcimiento";
            lblFechaNcimiento.Size = new Size(104, 15);
            lblFechaNcimiento.TabIndex = 21;
            lblFechaNcimiento.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNaciClientes
            // 
            dtpFechaNaciClientes.Location = new Point(274, 56);
            dtpFechaNaciClientes.Name = "dtpFechaNaciClientes";
            dtpFechaNaciClientes.Size = new Size(221, 23);
            dtpFechaNaciClientes.TabIndex = 20;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(281, 133);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(221, 23);
            txtCorreoCliente.TabIndex = 27;
            // 
            // lblCorreoCliente
            // 
            lblCorreoCliente.AutoSize = true;
            lblCorreoCliente.Location = new Point(281, 115);
            lblCorreoCliente.Name = "lblCorreoCliente";
            lblCorreoCliente.Size = new Size(46, 15);
            lblCorreoCliente.TabIndex = 26;
            lblCorreoCliente.Text = "Correo:";
            // 
            // txtTeleClientes
            // 
            txtTeleClientes.Location = new Point(24, 133);
            txtTeleClientes.Name = "txtTeleClientes";
            txtTeleClientes.Size = new Size(221, 23);
            txtTeleClientes.TabIndex = 25;
            // 
            // lblTelefonoClientes
            // 
            lblTelefonoClientes.AutoSize = true;
            lblTelefonoClientes.Location = new Point(24, 115);
            lblTelefonoClientes.Name = "lblTelefonoClientes";
            lblTelefonoClientes.Size = new Size(56, 15);
            lblTelefonoClientes.TabIndex = 24;
            lblTelefonoClientes.Text = "Teléfono:";
            // 
            // bttAnularClientes
            // 
            bttAnularClientes.Location = new Point(286, 458);
            bttAnularClientes.Name = "bttAnularClientes";
            bttAnularClientes.Size = new Size(75, 23);
            bttAnularClientes.TabIndex = 39;
            bttAnularClientes.Text = "Anular";
            bttAnularClientes.UseVisualStyleBackColor = true;
            // 
            // bttModificarClientes
            // 
            bttModificarClientes.Location = new Point(205, 458);
            bttModificarClientes.Name = "bttModificarClientes";
            bttModificarClientes.Size = new Size(75, 23);
            bttModificarClientes.TabIndex = 38;
            bttModificarClientes.Text = "Modificar";
            bttModificarClientes.UseVisualStyleBackColor = true;
            // 
            // bttSalirClientes
            // 
            bttSalirClientes.Location = new Point(367, 458);
            bttSalirClientes.Name = "bttSalirClientes";
            bttSalirClientes.Size = new Size(75, 23);
            bttSalirClientes.TabIndex = 37;
            bttSalirClientes.Text = "Salir";
            bttSalirClientes.UseVisualStyleBackColor = true;
            // 
            // bttGuardarClientes
            // 
            bttGuardarClientes.Location = new Point(124, 458);
            bttGuardarClientes.Name = "bttGuardarClientes";
            bttGuardarClientes.Size = new Size(75, 23);
            bttGuardarClientes.TabIndex = 36;
            bttGuardarClientes.Text = "Guardar";
            bttGuardarClientes.UseVisualStyleBackColor = true;
            // 
            // lblListaClientes
            // 
            lblListaClientes.AutoSize = true;
            lblListaClientes.Location = new Point(24, 217);
            lblListaClientes.Name = "lblListaClientes";
            lblListaClientes.Size = new Size(93, 15);
            lblListaClientes.TabIndex = 35;
            lblListaClientes.Text = "Lista de clientes:";
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClientes.Location = new Point(24, 235);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.Size = new Size(495, 203);
            dgvListaClientes.TabIndex = 34;
            // 
            // txtDirecClientes
            // 
            txtDirecClientes.Location = new Point(24, 182);
            txtDirecClientes.Name = "txtDirecClientes";
            txtDirecClientes.Size = new Size(495, 23);
            txtDirecClientes.TabIndex = 33;
            // 
            // lblDireccClientes
            // 
            lblDireccClientes.AutoSize = true;
            lblDireccClientes.Location = new Point(24, 164);
            lblDireccClientes.Name = "lblDireccClientes";
            lblDireccClientes.Size = new Size(60, 15);
            lblDireccClientes.TabIndex = 32;
            lblDireccClientes.Text = "Dirección:";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 497);
            ControlBox = false;
            Controls.Add(bttAnularClientes);
            Controls.Add(bttModificarClientes);
            Controls.Add(bttSalirClientes);
            Controls.Add(bttGuardarClientes);
            Controls.Add(lblListaClientes);
            Controls.Add(dgvListaClientes);
            Controls.Add(txtDirecClientes);
            Controls.Add(lblDireccClientes);
            Controls.Add(txtCorreoCliente);
            Controls.Add(lblCorreoCliente);
            Controls.Add(txtTeleClientes);
            Controls.Add(lblTelefonoClientes);
            Controls.Add(lblFechaNcimiento);
            Controls.Add(dtpFechaNaciClientes);
            Controls.Add(txtNombreCLientes);
            Controls.Add(lblNombreCliente);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCLientes;
        private Label lblNombreCliente;
        private Label lblFechaNcimiento;
        private DateTimePicker dtpFechaNaciClientes;
        private TextBox txtCorreoCliente;
        private Label lblCorreoCliente;
        private TextBox txtTeleClientes;
        private Label lblTelefonoClientes;
        private Button bttAnularClientes;
        private Button bttModificarClientes;
        private Button bttSalirClientes;
        private Button bttGuardarClientes;
        private Label lblListaClientes;
        private DataGridView dgvListaClientes;
        private TextBox txtDirecClientes;
        private Label lblDireccClientes;
    }
}
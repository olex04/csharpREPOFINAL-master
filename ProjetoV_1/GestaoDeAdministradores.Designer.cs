namespace ProjetoV_1
{
    partial class GestaoDeAdministradores
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
            this.listBoxAdministradores = new System.Windows.Forms.ListBox();
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.buttonEditAdmin = new System.Windows.Forms.Button();
            this.buttonDelAdmin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSuperUser = new System.Windows.Forms.CheckBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAdministradores
            // 
            this.listBoxAdministradores.FormattingEnabled = true;
            this.listBoxAdministradores.Location = new System.Drawing.Point(40, 39);
            this.listBoxAdministradores.Name = "listBoxAdministradores";
            this.listBoxAdministradores.Size = new System.Drawing.Size(193, 264);
            this.listBoxAdministradores.TabIndex = 0;
            this.listBoxAdministradores.SelectedIndexChanged += new System.EventHandler(this.listBoxAdministradores_SelectedIndexChanged);
            // 
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.Location = new System.Drawing.Point(40, 309);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(193, 23);
            this.buttonAddAdmin.TabIndex = 1;
            this.buttonAddAdmin.Text = "Adicionar Administrador";
            this.buttonAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonAddAdmin_Click);
            // 
            // buttonEditAdmin
            // 
            this.buttonEditAdmin.Location = new System.Drawing.Point(40, 338);
            this.buttonEditAdmin.Name = "buttonEditAdmin";
            this.buttonEditAdmin.Size = new System.Drawing.Size(193, 23);
            this.buttonEditAdmin.TabIndex = 2;
            this.buttonEditAdmin.Text = "Editar Administrador";
            this.buttonEditAdmin.UseVisualStyleBackColor = true;
            this.buttonEditAdmin.Click += new System.EventHandler(this.buttonEditAdmin_Click);
            // 
            // buttonDelAdmin
            // 
            this.buttonDelAdmin.Location = new System.Drawing.Point(40, 367);
            this.buttonDelAdmin.Name = "buttonDelAdmin";
            this.buttonDelAdmin.Size = new System.Drawing.Size(193, 23);
            this.buttonDelAdmin.TabIndex = 3;
            this.buttonDelAdmin.Text = "Eliminar Adminstrador";
            this.buttonDelAdmin.UseVisualStyleBackColor = true;
            this.buttonDelAdmin.Click += new System.EventHandler(this.buttonDelAdmin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxAdministradores);
            this.groupBox1.Controls.Add(this.buttonDelAdmin);
            this.groupBox1.Controls.Add(this.buttonAddAdmin);
            this.groupBox1.Controls.Add(this.buttonEditAdmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 421);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administradores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSuperUser);
            this.groupBox2.Controls.Add(this.buttonGuardar);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(332, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 260);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // checkBoxSuperUser
            // 
            this.checkBoxSuperUser.AutoSize = true;
            this.checkBoxSuperUser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSuperUser.Location = new System.Drawing.Point(99, 165);
            this.checkBoxSuperUser.Name = "checkBoxSuperUser";
            this.checkBoxSuperUser.Size = new System.Drawing.Size(110, 17);
            this.checkBoxSuperUser.TabIndex = 5;
            this.checkBoxSuperUser.Text = "É Super Utilizador";
            this.checkBoxSuperUser.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(117, 208);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(69, 117);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(177, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(69, 53);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(177, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // GestaoDeAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestaoDeAdministradores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAdministradores;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.Button buttonEditAdmin;
        private System.Windows.Forms.Button buttonDelAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSuperUser;
    }
}
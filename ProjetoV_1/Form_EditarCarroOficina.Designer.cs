﻿namespace ProjetoV_1
{
    partial class Form_EditarCarroOficina
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
            this.comboBoxCombustvel = new System.Windows.Forms.ComboBox();
            this.textBoxKms = new System.Windows.Forms.TextBox();
            this.labelKms = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelChasis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCombustvel
            // 
            this.comboBoxCombustvel.FormattingEnabled = true;
            this.comboBoxCombustvel.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Elétrico"});
            this.comboBoxCombustvel.Location = new System.Drawing.Point(59, 231);
            this.comboBoxCombustvel.Name = "comboBoxCombustvel";
            this.comboBoxCombustvel.Size = new System.Drawing.Size(215, 21);
            this.comboBoxCombustvel.TabIndex = 73;
            // 
            // textBoxKms
            // 
            this.textBoxKms.Location = new System.Drawing.Point(59, 343);
            this.textBoxKms.Name = "textBoxKms";
            this.textBoxKms.Size = new System.Drawing.Size(215, 20);
            this.textBoxKms.TabIndex = 72;
            this.textBoxKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKms_KeyPress);
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(56, 326);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(27, 13);
            this.labelKms.TabIndex = 71;
            this.labelKms.Text = "Kms";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(59, 288);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(215, 20);
            this.textBoxMatricula.TabIndex = 70;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(59, 271);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(50, 13);
            this.labelMatricula.TabIndex = 69;
            this.labelMatricula.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(92, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Editar Carro da Oficina";
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAplicar.Location = new System.Drawing.Point(173, 404);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(125, 23);
            this.buttonAplicar.TabIndex = 67;
            this.buttonAplicar.Text = "Atualizar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(42, 404);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 23);
            this.buttonCancel.TabIndex = 66;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(59, 180);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(215, 20);
            this.textBoxModelo.TabIndex = 65;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(59, 134);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(215, 20);
            this.textBoxMarca.TabIndex = 64;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(59, 87);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(215, 20);
            this.textBoxNumeroChassis.TabIndex = 63;
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(56, 214);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(64, 13);
            this.labelCombustivel.TabIndex = 62;
            this.labelCombustivel.Text = "Combustivel";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(56, 165);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 61;
            this.labelModelo.Text = "Modelo";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(56, 117);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 60;
            this.labelMarca.Text = "Marca";
            // 
            // labelChasis
            // 
            this.labelChasis.AutoSize = true;
            this.labelChasis.Location = new System.Drawing.Point(56, 70);
            this.labelChasis.Name = "labelChasis";
            this.labelChasis.Size = new System.Drawing.Size(98, 13);
            this.labelChasis.TabIndex = 59;
            this.labelChasis.Text = "Número de Chassis";
            // 
            // EditarCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 441);
            this.Controls.Add(this.comboBoxCombustvel);
            this.Controls.Add(this.textBoxKms);
            this.Controls.Add(this.labelKms);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelChasis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarCarroOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCarroOficina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCombustvel;
        private System.Windows.Forms.TextBox textBoxKms;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelChasis;
    }
}
namespace ProjetoV_1
{
    partial class ExaminarVenda
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCarro = new System.Windows.Forms.GroupBox();
            this.labelNumChas = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxCarro.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(146, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Data";
            // 
            // groupBoxCarro
            // 
            this.groupBoxCarro.Controls.Add(this.groupBox5);
            this.groupBoxCarro.Controls.Add(this.labelNumChas);
            this.groupBoxCarro.Controls.Add(this.labelMarca);
            this.groupBoxCarro.Controls.Add(this.labelCombustivel);
            this.groupBoxCarro.Controls.Add(this.labelModelo);
            this.groupBoxCarro.Controls.Add(this.comboBoxCombustivel);
            this.groupBoxCarro.Controls.Add(this.textBoxNumeroChassis);
            this.groupBoxCarro.Controls.Add(this.textBoxMarca);
            this.groupBoxCarro.Controls.Add(this.textBoxModelo);
            this.groupBoxCarro.Location = new System.Drawing.Point(9, 55);
            this.groupBoxCarro.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCarro.Name = "groupBoxCarro";
            this.groupBoxCarro.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCarro.Size = new System.Drawing.Size(414, 238);
            this.groupBoxCarro.TabIndex = 77;
            this.groupBoxCarro.TabStop = false;
            this.groupBoxCarro.Text = "Carro";
            // 
            // labelNumChas
            // 
            this.labelNumChas.AutoSize = true;
            this.labelNumChas.Location = new System.Drawing.Point(5, 24);
            this.labelNumChas.Name = "labelNumChas";
            this.labelNumChas.Size = new System.Drawing.Size(98, 13);
            this.labelNumChas.TabIndex = 60;
            this.labelNumChas.Text = "Número de Chassis";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(4, 77);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 61;
            this.labelMarca.Text = "Marca";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(6, 181);
            this.labelCombustivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(64, 13);
            this.labelCombustivel.TabIndex = 67;
            this.labelCombustivel.Text = "Combustivel";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(4, 127);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 62;
            this.labelModelo.Text = "Modelo";
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.Enabled = false;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Gásoleo"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(8, 197);
            this.comboBoxCombustivel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(216, 21);
            this.comboBoxCombustivel.TabIndex = 59;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.Enabled = false;
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(8, 40);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(215, 20);
            this.textBoxNumeroChassis.TabIndex = 63;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Enabled = false;
            this.textBoxMarca.Location = new System.Drawing.Point(7, 93);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(215, 20);
            this.textBoxMarca.TabIndex = 64;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Enabled = false;
            this.textBoxModelo.Location = new System.Drawing.Point(8, 143);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(215, 20);
            this.textBoxModelo.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(154, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Examinar Venda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 429);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Enabled = false;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Novo",
            "Usado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(98, 371);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(215, 21);
            this.comboBoxEstado.TabIndex = 82;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Location = new System.Drawing.Point(98, 321);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(215, 20);
            this.textBoxValor.TabIndex = 81;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox9);
            this.groupBox5.Controls.Add(this.checkBox8);
            this.groupBox5.Controls.Add(this.checkBox7);
            this.groupBox5.Controls.Add(this.checkBox6);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(244, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(166, 209);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extras";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Enabled = false;
            this.checkBox9.Location = new System.Drawing.Point(4, 185);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(79, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Sem Extras";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Location = new System.Drawing.Point(4, 164);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(74, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Full Extras";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Location = new System.Drawing.Point(4, 143);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(108, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Estofos em couro";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(4, 122);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(108, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Chave inteligente";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(4, 101);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(135, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Sistema de navegação";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(4, 80);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(163, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Sensores de estacionamento";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(4, 59);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Caixa automática";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(4, 38);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Faróis Xénon";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(4, 17);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ar condicionado automático";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ExaminarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExaminarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExaminarVenda";
            this.groupBoxCarro.ResumeLayout(false);
            this.groupBoxCarro.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxCarro;
        private System.Windows.Forms.Label labelNumChas;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
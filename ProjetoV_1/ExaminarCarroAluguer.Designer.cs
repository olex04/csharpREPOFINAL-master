namespace ProjetoV_1
{
    partial class ExaminarCarroAluguer
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
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxCombustvel = new System.Windows.Forms.ComboBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelMarcaModeloCarro = new System.Windows.Forms.Label();
            this.textBoxAlugadoDeMomento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Enabled = false;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Excelente",
            "Como Novo",
            "Pouco Usado",
            "Usado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(68, 297);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(215, 21);
            this.comboBoxEstado.TabIndex = 42;
            // 
            // comboBoxCombustvel
            // 
            this.comboBoxCombustvel.Enabled = false;
            this.comboBoxCombustvel.FormattingEnabled = true;
            this.comboBoxCombustvel.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Elétrico"});
            this.comboBoxCombustvel.Location = new System.Drawing.Point(68, 249);
            this.comboBoxCombustvel.Name = "comboBoxCombustvel";
            this.comboBoxCombustvel.Size = new System.Drawing.Size(215, 21);
            this.comboBoxCombustvel.TabIndex = 41;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Enabled = false;
            this.textBoxMatricula.Location = new System.Drawing.Point(68, 348);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.ReadOnly = true;
            this.textBoxMatricula.Size = new System.Drawing.Size(215, 20);
            this.textBoxMatricula.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(74, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Examinar Carro de Aluguer";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(118, 442);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(125, 23);
            this.buttonOK.TabIndex = 35;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Enabled = false;
            this.textBoxModelo.Location = new System.Drawing.Point(68, 199);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.ReadOnly = true;
            this.textBoxModelo.Size = new System.Drawing.Size(215, 20);
            this.textBoxModelo.TabIndex = 34;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Enabled = false;
            this.textBoxMarca.Location = new System.Drawing.Point(68, 152);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ReadOnly = true;
            this.textBoxMarca.Size = new System.Drawing.Size(215, 20);
            this.textBoxMarca.TabIndex = 33;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.AccessibleDescription = "";
            this.textBoxNumeroChassis.Enabled = false;
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(68, 105);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.ReadOnly = true;
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(215, 20);
            this.textBoxNumeroChassis.TabIndex = 32;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(65, 233);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(64, 13);
            this.labelContacto.TabIndex = 31;
            this.labelContacto.Text = "Combustivel";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(65, 183);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(42, 13);
            this.labelMorada.TabIndex = 30;
            this.labelMorada.Text = "Modelo";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(65, 136);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(37, 13);
            this.labelNIF.TabIndex = 29;
            this.labelNIF.Text = "Marca";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(65, 89);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(98, 13);
            this.labelNome.TabIndex = 28;
            this.labelNome.Text = "Número de Chassis";
            // 
            // labelMarcaModeloCarro
            // 
            this.labelMarcaModeloCarro.AutoSize = true;
            this.labelMarcaModeloCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaModeloCarro.Location = new System.Drawing.Point(115, 52);
            this.labelMarcaModeloCarro.Name = "labelMarcaModeloCarro";
            this.labelMarcaModeloCarro.Size = new System.Drawing.Size(109, 16);
            this.labelMarcaModeloCarro.TabIndex = 43;
            this.labelMarcaModeloCarro.Text = "Marca ( Modelo )";
            // 
            // textBoxAlugadoDeMomento
            // 
            this.textBoxAlugadoDeMomento.Enabled = false;
            this.textBoxAlugadoDeMomento.Location = new System.Drawing.Point(68, 397);
            this.textBoxAlugadoDeMomento.Name = "textBoxAlugadoDeMomento";
            this.textBoxAlugadoDeMomento.ReadOnly = true;
            this.textBoxAlugadoDeMomento.Size = new System.Drawing.Size(215, 20);
            this.textBoxAlugadoDeMomento.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Situação de Aluguer";
            // 
            // ExaminarCarroAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 488);
            this.Controls.Add(this.textBoxAlugadoDeMomento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMarcaModeloCarro);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxCombustvel);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.Controls.Add(this.labelContacto);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelNIF);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExaminarCarroAluguer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExaminarCarroAluguer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxCombustvel;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelMarcaModeloCarro;
        private System.Windows.Forms.TextBox textBoxAlugadoDeMomento;
        private System.Windows.Forms.Label label3;
    }
}
namespace ProjetoV_1
{
    partial class AddCarroAluguer
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCombustvel = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(93, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adicionar Carro de Aluguer";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdicionar.Location = new System.Drawing.Point(233, 501);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(167, 28);
            this.buttonAdicionar.TabIndex = 20;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(59, 501);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(167, 28);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(85, 245);
            this.textBoxModelo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(285, 22);
            this.textBoxModelo.TabIndex = 17;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(85, 187);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(285, 22);
            this.textBoxMarca.TabIndex = 16;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.AccessibleDescription = "";
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(85, 129);
            this.textBoxNumeroChassis.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(285, 22);
            this.textBoxNumeroChassis.TabIndex = 15;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(81, 287);
            this.labelContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(84, 17);
            this.labelContacto.TabIndex = 14;
            this.labelContacto.Text = "Combustivel";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(81, 225);
            this.labelMorada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(54, 17);
            this.labelMorada.TabIndex = 13;
            this.labelMorada.Text = "Modelo";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(81, 167);
            this.labelNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(47, 17);
            this.labelNIF.TabIndex = 12;
            this.labelNIF.Text = "Marca";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(81, 110);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(131, 17);
            this.labelNome.TabIndex = 11;
            this.labelNome.Text = "Número de Chassis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Estado";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(85, 428);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(285, 22);
            this.textBoxMatricula.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Matricula";
            // 
            // comboBoxCombustvel
            // 
            this.comboBoxCombustvel.FormattingEnabled = true;
            this.comboBoxCombustvel.Items.AddRange(new object[] {
            "Gasóleo",
            "Gasolina",
            "Elétrico"});
            this.comboBoxCombustvel.Location = new System.Drawing.Point(85, 306);
            this.comboBoxCombustvel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCombustvel.Name = "comboBoxCombustvel";
            this.comboBoxCombustvel.Size = new System.Drawing.Size(285, 24);
            this.comboBoxCombustvel.TabIndex = 26;
            this.comboBoxCombustvel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombustvel_SelectedIndexChanged);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Excelente",
            "Como Novo",
            "Pouco Usado",
            "Usado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(85, 366);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(285, 24);
            this.comboBoxEstado.TabIndex = 27;
            // 
            // AddCarroAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 569);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxCombustvel);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxNumeroChassis);
            this.Controls.Add(this.labelContacto);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelNIF);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCarroAluguer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCombustvel;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}
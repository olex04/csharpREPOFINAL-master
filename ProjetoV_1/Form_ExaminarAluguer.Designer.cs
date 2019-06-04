namespace ProjetoV_1
{
    partial class Form_ExaminarAluguer
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxKMS = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDataInicio = new System.Windows.Forms.TextBox();
            this.labelDataFim = new System.Windows.Forms.Label();
            this.labelKMS = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.textBoxDataFim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(111, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Examinar Aluguer";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(115, 524);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(125, 23);
            this.buttonOK.TabIndex = 53;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxKMS
            // 
            this.textBoxKMS.Enabled = false;
            this.textBoxKMS.Location = new System.Drawing.Point(70, 184);
            this.textBoxKMS.Name = "textBoxKMS";
            this.textBoxKMS.ReadOnly = true;
            this.textBoxKMS.Size = new System.Drawing.Size(215, 20);
            this.textBoxKMS.TabIndex = 52;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Location = new System.Drawing.Point(70, 137);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(215, 20);
            this.textBoxValor.TabIndex = 51;
            // 
            // textBoxDataInicio
            // 
            this.textBoxDataInicio.AccessibleDescription = "";
            this.textBoxDataInicio.Enabled = false;
            this.textBoxDataInicio.Location = new System.Drawing.Point(70, 90);
            this.textBoxDataInicio.Name = "textBoxDataInicio";
            this.textBoxDataInicio.ReadOnly = true;
            this.textBoxDataInicio.Size = new System.Drawing.Size(215, 20);
            this.textBoxDataInicio.TabIndex = 50;
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Location = new System.Drawing.Point(67, 218);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(55, 13);
            this.labelDataFim.TabIndex = 49;
            this.labelDataFim.Text = "Data Final";
            // 
            // labelKMS
            // 
            this.labelKMS.AutoSize = true;
            this.labelKMS.Location = new System.Drawing.Point(67, 168);
            this.labelKMS.Name = "labelKMS";
            this.labelKMS.Size = new System.Drawing.Size(30, 13);
            this.labelKMS.TabIndex = 48;
            this.labelKMS.Text = "KMS";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(67, 121);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(31, 13);
            this.labelValor.TabIndex = 47;
            this.labelValor.Text = "Valor";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(67, 74);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(75, 13);
            this.labelDataInicio.TabIndex = 46;
            this.labelDataInicio.Text = "Data de Início";
            // 
            // textBoxDataFim
            // 
            this.textBoxDataFim.Enabled = false;
            this.textBoxDataFim.Location = new System.Drawing.Point(70, 235);
            this.textBoxDataFim.Name = "textBoxDataFim";
            this.textBoxDataFim.ReadOnly = true;
            this.textBoxDataFim.Size = new System.Drawing.Size(215, 20);
            this.textBoxDataFim.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 232);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Carro Utilizado";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.AccessibleDescription = "";
            this.textBoxMatricula.Enabled = false;
            this.textBoxMatricula.Location = new System.Drawing.Point(12, 193);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.ReadOnly = true;
            this.textBoxMatricula.Size = new System.Drawing.Size(215, 20);
            this.textBoxMatricula.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Matricula";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.AccessibleDescription = "";
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(12, 146);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(215, 20);
            this.textBoxEstado.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Estado";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.AccessibleDescription = "";
            this.textBoxModelo.Enabled = false;
            this.textBoxModelo.Location = new System.Drawing.Point(12, 95);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.ReadOnly = true;
            this.textBoxModelo.Size = new System.Drawing.Size(215, 20);
            this.textBoxModelo.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Modelo";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.AccessibleDescription = "";
            this.textBoxMarca.Enabled = false;
            this.textBoxMarca.Location = new System.Drawing.Point(12, 47);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ReadOnly = true;
            this.textBoxMarca.Size = new System.Drawing.Size(215, 20);
            this.textBoxMarca.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Marca";
            // 
            // ExaminarAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDataFim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxKMS);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxDataInicio);
            this.Controls.Add(this.labelDataFim);
            this.Controls.Add(this.labelKMS);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelDataInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExaminarAluguer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExaminarAluguer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxKMS;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxDataInicio;
        private System.Windows.Forms.Label labelDataFim;
        private System.Windows.Forms.Label labelKMS;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.TextBox textBoxDataFim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label4;
    }
}
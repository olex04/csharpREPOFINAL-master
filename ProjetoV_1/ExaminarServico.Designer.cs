namespace ProjetoV_1
{
    partial class ExaminarServico
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
            this.labelTipo = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataDeEntrada = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.labelDataEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(75, 168);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(40, 17);
            this.labelTipo.TabIndex = 58;
            this.labelTipo.Text = "Tipo:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Enabled = false;
            this.textBoxTipo.Location = new System.Drawing.Point(78, 188);
            this.textBoxTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTipo.Multiline = true;
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(271, 38);
            this.textBoxTipo.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(140, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Examinar Serviço";
            // 
            // dateTimePickerDataSaida
            // 
            this.dateTimePickerDataSaida.Enabled = false;
            this.dateTimePickerDataSaida.Location = new System.Drawing.Point(183, 124);
            this.dateTimePickerDataSaida.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataSaida.Name = "dateTimePickerDataSaida";
            this.dateTimePickerDataSaida.Size = new System.Drawing.Size(164, 22);
            this.dateTimePickerDataSaida.TabIndex = 53;
            // 
            // dateTimePickerDataDeEntrada
            // 
            this.dateTimePickerDataDeEntrada.Enabled = false;
            this.dateTimePickerDataDeEntrada.Location = new System.Drawing.Point(183, 87);
            this.dateTimePickerDataDeEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataDeEntrada.Name = "dateTimePickerDataDeEntrada";
            this.dateTimePickerDataDeEntrada.Size = new System.Drawing.Size(164, 22);
            this.dateTimePickerDataDeEntrada.TabIndex = 52;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(138, 241);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(167, 28);
            this.buttonOK.TabIndex = 55;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.AutoSize = true;
            this.labelDataSaida.Location = new System.Drawing.Point(75, 124);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(102, 17);
            this.labelDataSaida.TabIndex = 51;
            this.labelDataSaida.Text = "Data de Saida:";
            // 
            // labelDataEntrada
            // 
            this.labelDataEntrada.AutoSize = true;
            this.labelDataEntrada.Location = new System.Drawing.Point(60, 87);
            this.labelDataEntrada.Name = "labelDataEntrada";
            this.labelDataEntrada.Size = new System.Drawing.Size(116, 17);
            this.labelDataEntrada.TabIndex = 50;
            this.labelDataEntrada.Text = "Data de Entrada:";
            // 
            // ExaminarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 306);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataSaida);
            this.Controls.Add(this.dateTimePickerDataDeEntrada);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDataSaida);
            this.Controls.Add(this.labelDataEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExaminarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarServico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataSaida;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDeEntrada;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Label labelDataEntrada;
    }
}
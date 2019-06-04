namespace ProjetoV_1
{
    partial class Form_AdicionarServico
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDataEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(45, 140);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 58;
            this.labelTipo.Text = "Tipo:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(47, 156);
            this.textBoxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipo.Multiline = true;
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(204, 32);
            this.textBoxTipo.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(94, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Adicionar Serviço";
            // 
            // dateTimePickerDataSaida
            // 
            this.dateTimePickerDataSaida.Location = new System.Drawing.Point(126, 104);
            this.dateTimePickerDataSaida.Name = "dateTimePickerDataSaida";
            this.dateTimePickerDataSaida.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerDataSaida.TabIndex = 53;
            // 
            // dateTimePickerDataDeEntrada
            // 
            this.dateTimePickerDataDeEntrada.Location = new System.Drawing.Point(126, 74);
            this.dateTimePickerDataDeEntrada.Name = "dateTimePickerDataDeEntrada";
            this.dateTimePickerDataDeEntrada.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerDataDeEntrada.TabIndex = 52;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdicionar.Location = new System.Drawing.Point(168, 192);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(125, 23);
            this.buttonAdicionar.TabIndex = 55;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.AutoSize = true;
            this.labelDataSaida.Location = new System.Drawing.Point(45, 104);
            this.labelDataSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(78, 13);
            this.labelDataSaida.TabIndex = 51;
            this.labelDataSaida.Text = "Data de Saida:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(36, 192);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 23);
            this.buttonCancel.TabIndex = 54;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelDataEntrada
            // 
            this.labelDataEntrada.AutoSize = true;
            this.labelDataEntrada.Location = new System.Drawing.Point(34, 74);
            this.labelDataEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataEntrada.Name = "labelDataEntrada";
            this.labelDataEntrada.Size = new System.Drawing.Size(88, 13);
            this.labelDataEntrada.TabIndex = 50;
            this.labelDataEntrada.Text = "Data de Entrada:";
            // 
            // AdicionarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 249);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataSaida);
            this.Controls.Add(this.dateTimePickerDataDeEntrada);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelDataSaida);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelDataEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarServico";
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
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDataEntrada;
    }
}
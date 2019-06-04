namespace ProjetoV_1
{
    partial class EditarServico
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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDataEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(54, 133);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 67;
            this.labelTipo.Text = "Tipo:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(56, 149);
            this.textBoxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipo.Multiline = true;
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(204, 32);
            this.textBoxTipo.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(103, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Editar Serviço";
            // 
            // dateTimePickerDataSaida
            // 
            this.dateTimePickerDataSaida.Location = new System.Drawing.Point(135, 97);
            this.dateTimePickerDataSaida.Name = "dateTimePickerDataSaida";
            this.dateTimePickerDataSaida.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerDataSaida.TabIndex = 62;
            // 
            // dateTimePickerDataDeEntrada
            // 
            this.dateTimePickerDataDeEntrada.Location = new System.Drawing.Point(135, 67);
            this.dateTimePickerDataDeEntrada.Name = "dateTimePickerDataDeEntrada";
            this.dateTimePickerDataDeEntrada.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerDataDeEntrada.TabIndex = 61;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAtualizar.Location = new System.Drawing.Point(166, 199);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(125, 23);
            this.buttonAtualizar.TabIndex = 64;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.AutoSize = true;
            this.labelDataSaida.Location = new System.Drawing.Point(54, 97);
            this.labelDataSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(78, 13);
            this.labelDataSaida.TabIndex = 60;
            this.labelDataSaida.Text = "Data de Saida:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(35, 199);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 23);
            this.buttonCancel.TabIndex = 63;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelDataEntrada
            // 
            this.labelDataEntrada.AutoSize = true;
            this.labelDataEntrada.Location = new System.Drawing.Point(43, 67);
            this.labelDataEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataEntrada.Name = "labelDataEntrada";
            this.labelDataEntrada.Size = new System.Drawing.Size(88, 13);
            this.labelDataEntrada.TabIndex = 59;
            this.labelDataEntrada.Text = "Data de Entrada:";
            // 
            // EditarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 249);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataSaida);
            this.Controls.Add(this.dateTimePickerDataDeEntrada);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.labelDataSaida);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelDataEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarServico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataSaida;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDeEntrada;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDataEntrada;
    }
}
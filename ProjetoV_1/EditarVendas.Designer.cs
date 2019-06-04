namespace ProjetoV_1
{
    partial class EditarVendas
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
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(99, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Editar Venda";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(51, 171);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 69;
            this.labelData.Text = "Data";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(53, 196);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerData.TabIndex = 62;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdicionar.Location = new System.Drawing.Point(159, 238);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(125, 23);
            this.buttonAdicionar.TabIndex = 64;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(28, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Novo",
            "Usado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(52, 138);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(215, 21);
            this.comboBoxEstado.TabIndex = 68;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(52, 88);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(215, 20);
            this.textBoxValor.TabIndex = 67;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(50, 120);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 66;
            this.labelEstado.Text = "Estado";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(51, 71);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(31, 13);
            this.labelValor.TabIndex = 65;
            this.labelValor.Text = "Valor";
            // 
            // EditarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelValor;
    }
}
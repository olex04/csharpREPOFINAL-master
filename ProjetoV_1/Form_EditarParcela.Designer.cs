namespace ProjetoV_1
{
    partial class Form_EditarParcela
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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValorParcela = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoParcela = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAtualizar.Location = new System.Drawing.Point(155, 127);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(125, 23);
            this.buttonAtualizar.TabIndex = 66;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(23, 127);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 23);
            this.buttonCancel.TabIndex = 65;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(89, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Editar Parcela";
            // 
            // textBoxValorParcela
            // 
            this.textBoxValorParcela.Location = new System.Drawing.Point(75, 95);
            this.textBoxValorParcela.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValorParcela.Name = "textBoxValorParcela";
            this.textBoxValorParcela.Size = new System.Drawing.Size(156, 20);
            this.textBoxValorParcela.TabIndex = 63;
            this.textBoxValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorParcela_KeyPress);
            // 
            // textBoxDescricaoParcela
            // 
            this.textBoxDescricaoParcela.Location = new System.Drawing.Point(75, 42);
            this.textBoxDescricaoParcela.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescricaoParcela.Multiline = true;
            this.textBoxDescricaoParcela.Name = "textBoxDescricaoParcela";
            this.textBoxDescricaoParcela.Size = new System.Drawing.Size(156, 38);
            this.textBoxDescricaoParcela.TabIndex = 62;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.labelValor.Location = new System.Drawing.Point(39, 98);
            this.labelValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(34, 13);
            this.labelValor.TabIndex = 61;
            this.labelValor.Text = "Valor:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.labelDesc.Location = new System.Drawing.Point(21, 46);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(51, 13);
            this.labelDesc.TabIndex = 60;
            this.labelDesc.Text = "Descrição:";
            // 
            // EditarParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 162);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValorParcela);
            this.Controls.Add(this.textBoxDescricaoParcela);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarParcela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditarParcela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValorParcela;
        private System.Windows.Forms.TextBox textBoxDescricaoParcela;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelDesc;
    }
}
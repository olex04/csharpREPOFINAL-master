namespace ProjetoV_1
{
    partial class GestaoDeAluguer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listboxClienteAluguer = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarAluguer = new System.Windows.Forms.Button();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTotalAluguer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.groupbox_carros = new System.Windows.Forms.GroupBox();
            this.buttonEliminarCarro = new System.Windows.Forms.Button();
            this.buttonExaminarCarro = new System.Windows.Forms.Button();
            this.buttonEditarCarroAluguer = new System.Windows.Forms.Button();
            this.buttonAdicionarCarroAluguer = new System.Windows.Forms.Button();
            this.listBoxCarrosAluguer = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonApagarAluguer = new System.Windows.Forms.Button();
            this.buttonEnviarFatura = new System.Windows.Forms.Button();
            this.buttonVerAluguerAoPormenor = new System.Windows.Forms.Button();
            this.listBoxAlugueresDoCliente = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupbox_carros.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listboxClienteAluguer);
            this.groupBox1.Location = new System.Drawing.Point(166, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(151, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Cliente";
            // 
            // listboxClienteAluguer
            // 
            this.listboxClienteAluguer.FormattingEnabled = true;
            this.listboxClienteAluguer.Location = new System.Drawing.Point(4, 17);
            this.listboxClienteAluguer.Margin = new System.Windows.Forms.Padding(2);
            this.listboxClienteAluguer.Name = "listboxClienteAluguer";
            this.listboxClienteAluguer.Size = new System.Drawing.Size(143, 329);
            this.listboxClienteAluguer.TabIndex = 0;
            this.listboxClienteAluguer.SelectedIndexChanged += new System.EventHandler(this.listboxClienteAluguer_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerFim);
            this.groupBox2.Controls.Add(this.dateTimePickerInicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(161, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(61, 53);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerFim.TabIndex = 5;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(61, 18);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerInicio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAdicionarAluguer);
            this.groupBox3.Controls.Add(this.textBoxKm);
            this.groupBox3.Controls.Add(this.textBoxValor);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(476, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(169, 247);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aluguer";
            // 
            // buttonAdicionarAluguer
            // 
            this.buttonAdicionarAluguer.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAdicionarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarAluguer.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonAdicionarAluguer.Location = new System.Drawing.Point(4, 220);
            this.buttonAdicionarAluguer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarAluguer.Name = "buttonAdicionarAluguer";
            this.buttonAdicionarAluguer.Size = new System.Drawing.Size(161, 23);
            this.buttonAdicionarAluguer.TabIndex = 4;
            this.buttonAdicionarAluguer.Text = "Criar Aluguer";
            this.buttonAdicionarAluguer.UseVisualStyleBackColor = false;
            this.buttonAdicionarAluguer.Click += new System.EventHandler(this.buttonAdicionarAluguer_Click);
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(65, 149);
            this.textBoxKm.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(96, 20);
            this.textBoxKm.TabIndex = 12;
            this.textBoxKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKm_KeyPress);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(65, 185);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(96, 20);
            this.textBoxValor.TabIndex = 11;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Km:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelTotalAluguer);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.labelMorada);
            this.groupBox4.Controls.Add(this.labelContacto);
            this.groupBox4.Controls.Add(this.labelClienteSelecionado);
            this.groupBox4.Location = new System.Drawing.Point(166, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(479, 69);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // labelTotalAluguer
            // 
            this.labelTotalAluguer.AutoSize = true;
            this.labelTotalAluguer.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAluguer.Location = new System.Drawing.Point(393, 22);
            this.labelTotalAluguer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAluguer.Name = "labelTotalAluguer";
            this.labelTotalAluguer.Size = new System.Drawing.Size(23, 13);
            this.labelTotalAluguer.TabIndex = 13;
            this.labelTotalAluguer.Text = "0 €";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Total:";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(5, 50);
            this.labelMorada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(10, 13);
            this.labelMorada.TabIndex = 4;
            this.labelMorada.Text = "-";
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(5, 36);
            this.labelContacto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(10, 13);
            this.labelContacto.TabIndex = 3;
            this.labelContacto.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSelecionado.Location = new System.Drawing.Point(4, 17);
            this.labelClienteSelecionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(165, 18);
            this.labelClienteSelecionado.TabIndex = 2;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // groupbox_carros
            // 
            this.groupbox_carros.Controls.Add(this.buttonEliminarCarro);
            this.groupbox_carros.Controls.Add(this.buttonExaminarCarro);
            this.groupbox_carros.Controls.Add(this.buttonEditarCarroAluguer);
            this.groupbox_carros.Controls.Add(this.buttonAdicionarCarroAluguer);
            this.groupbox_carros.Controls.Add(this.listBoxCarrosAluguer);
            this.groupbox_carros.Location = new System.Drawing.Point(11, 3);
            this.groupbox_carros.Margin = new System.Windows.Forms.Padding(2);
            this.groupbox_carros.Name = "groupbox_carros";
            this.groupbox_carros.Padding = new System.Windows.Forms.Padding(2);
            this.groupbox_carros.Size = new System.Drawing.Size(151, 425);
            this.groupbox_carros.TabIndex = 5;
            this.groupbox_carros.TabStop = false;
            this.groupbox_carros.Text = "Carros Para Aluguer";
            // 
            // buttonEliminarCarro
            // 
            this.buttonEliminarCarro.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEliminarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarCarro.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonEliminarCarro.Location = new System.Drawing.Point(4, 398);
            this.buttonEliminarCarro.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarCarro.Name = "buttonEliminarCarro";
            this.buttonEliminarCarro.Size = new System.Drawing.Size(143, 23);
            this.buttonEliminarCarro.TabIndex = 3;
            this.buttonEliminarCarro.Text = "Eliminar Carro";
            this.buttonEliminarCarro.UseVisualStyleBackColor = false;
            this.buttonEliminarCarro.Click += new System.EventHandler(this.buttonEliminarCarro_Click);
            // 
            // buttonExaminarCarro
            // 
            this.buttonExaminarCarro.BackColor = System.Drawing.Color.LightBlue;
            this.buttonExaminarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExaminarCarro.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonExaminarCarro.Location = new System.Drawing.Point(4, 371);
            this.buttonExaminarCarro.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExaminarCarro.Name = "buttonExaminarCarro";
            this.buttonExaminarCarro.Size = new System.Drawing.Size(143, 23);
            this.buttonExaminarCarro.TabIndex = 2;
            this.buttonExaminarCarro.Text = "Examinar Carro";
            this.buttonExaminarCarro.UseVisualStyleBackColor = false;
            this.buttonExaminarCarro.Click += new System.EventHandler(this.buttonExaminarCarro_Click);
            // 
            // buttonEditarCarroAluguer
            // 
            this.buttonEditarCarroAluguer.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEditarCarroAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarCarroAluguer.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonEditarCarroAluguer.Location = new System.Drawing.Point(4, 344);
            this.buttonEditarCarroAluguer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarCarroAluguer.Name = "buttonEditarCarroAluguer";
            this.buttonEditarCarroAluguer.Size = new System.Drawing.Size(143, 23);
            this.buttonEditarCarroAluguer.TabIndex = 1;
            this.buttonEditarCarroAluguer.Text = "Editar Informações Carro";
            this.buttonEditarCarroAluguer.UseVisualStyleBackColor = false;
            this.buttonEditarCarroAluguer.Click += new System.EventHandler(this.buttonEditarCarroAluguer_Click);
            // 
            // buttonAdicionarCarroAluguer
            // 
            this.buttonAdicionarCarroAluguer.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAdicionarCarroAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarCarroAluguer.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonAdicionarCarroAluguer.Location = new System.Drawing.Point(4, 317);
            this.buttonAdicionarCarroAluguer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarCarroAluguer.Name = "buttonAdicionarCarroAluguer";
            this.buttonAdicionarCarroAluguer.Size = new System.Drawing.Size(143, 23);
            this.buttonAdicionarCarroAluguer.TabIndex = 0;
            this.buttonAdicionarCarroAluguer.Text = "Adicionar Carro";
            this.buttonAdicionarCarroAluguer.UseVisualStyleBackColor = false;
            this.buttonAdicionarCarroAluguer.Click += new System.EventHandler(this.buttonAdicionarCarroAluguer_Click);
            // 
            // listBoxCarrosAluguer
            // 
            this.listBoxCarrosAluguer.FormattingEnabled = true;
            this.listBoxCarrosAluguer.Location = new System.Drawing.Point(4, 17);
            this.listBoxCarrosAluguer.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCarrosAluguer.Name = "listBoxCarrosAluguer";
            this.listBoxCarrosAluguer.Size = new System.Drawing.Size(143, 290);
            this.listBoxCarrosAluguer.TabIndex = 0;
            this.listBoxCarrosAluguer.SelectedIndexChanged += new System.EventHandler(this.listBoxCarrosAluguer_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonApagarAluguer);
            this.groupBox5.Controls.Add(this.buttonEnviarFatura);
            this.groupBox5.Controls.Add(this.buttonVerAluguerAoPormenor);
            this.groupBox5.Controls.Add(this.listBoxAlugueresDoCliente);
            this.groupBox5.Location = new System.Drawing.Point(324, 76);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(148, 352);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alugueres do Cliente";
            // 
            // buttonApagarAluguer
            // 
            this.buttonApagarAluguer.BackColor = System.Drawing.Color.LightBlue;
            this.buttonApagarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagarAluguer.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonApagarAluguer.Location = new System.Drawing.Point(4, 326);
            this.buttonApagarAluguer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarAluguer.Name = "buttonApagarAluguer";
            this.buttonApagarAluguer.Size = new System.Drawing.Size(140, 23);
            this.buttonApagarAluguer.TabIndex = 2;
            this.buttonApagarAluguer.Text = "Apagar Aluguer";
            this.buttonApagarAluguer.UseVisualStyleBackColor = false;
            this.buttonApagarAluguer.Click += new System.EventHandler(this.buttonApagarAluguer_Click);
            // 
            // buttonEnviarFatura
            // 
            this.buttonEnviarFatura.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEnviarFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnviarFatura.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonEnviarFatura.Location = new System.Drawing.Point(4, 299);
            this.buttonEnviarFatura.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnviarFatura.Name = "buttonEnviarFatura";
            this.buttonEnviarFatura.Size = new System.Drawing.Size(140, 23);
            this.buttonEnviarFatura.TabIndex = 1;
            this.buttonEnviarFatura.Text = "Enviar Fatura";
            this.buttonEnviarFatura.UseVisualStyleBackColor = false;
            this.buttonEnviarFatura.Click += new System.EventHandler(this.buttonEnviarFatura_Click);
            // 
            // buttonVerAluguerAoPormenor
            // 
            this.buttonVerAluguerAoPormenor.BackColor = System.Drawing.Color.LightBlue;
            this.buttonVerAluguerAoPormenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerAluguerAoPormenor.Font = new System.Drawing.Font("Berlin Sans FB", 8F);
            this.buttonVerAluguerAoPormenor.Location = new System.Drawing.Point(4, 272);
            this.buttonVerAluguerAoPormenor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerAluguerAoPormenor.Name = "buttonVerAluguerAoPormenor";
            this.buttonVerAluguerAoPormenor.Size = new System.Drawing.Size(140, 23);
            this.buttonVerAluguerAoPormenor.TabIndex = 0;
            this.buttonVerAluguerAoPormenor.Text = "Examinar Aluguer";
            this.buttonVerAluguerAoPormenor.UseVisualStyleBackColor = false;
            this.buttonVerAluguerAoPormenor.Click += new System.EventHandler(this.buttonVerAluguerAoPormenor_Click);
            // 
            // listBoxAlugueresDoCliente
            // 
            this.listBoxAlugueresDoCliente.FormattingEnabled = true;
            this.listBoxAlugueresDoCliente.Location = new System.Drawing.Point(4, 17);
            this.listBoxAlugueresDoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlugueresDoCliente.Name = "listBoxAlugueresDoCliente";
            this.listBoxAlugueresDoCliente.Size = new System.Drawing.Size(140, 251);
            this.listBoxAlugueresDoCliente.TabIndex = 0;
            // 
            // GestaoDeAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 445);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupbox_carros);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestaoDeAluguer";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupbox_carros.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listboxClienteAluguer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.GroupBox groupbox_carros;
        private System.Windows.Forms.Button buttonAdicionarCarroAluguer;
        private System.Windows.Forms.ListBox listBoxCarrosAluguer;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAdicionarAluguer;
        private System.Windows.Forms.Label labelTotalAluguer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.Button buttonEditarCarroAluguer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonVerAluguerAoPormenor;
        private System.Windows.Forms.ListBox listBoxAlugueresDoCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Button buttonExaminarCarro;
        private System.Windows.Forms.Button buttonEnviarFatura;
        private System.Windows.Forms.Button buttonApagarAluguer;
        private System.Windows.Forms.Button buttonEliminarCarro;
    }
}
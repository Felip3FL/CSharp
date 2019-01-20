namespace Aula_47___Arquivo_IO_2
{
    partial class Form1
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtArquivoBackup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMoverCopiar = new System.Windows.Forms.Button();
            this.txtArquivoDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArquivoOrigem = new System.Windows.Forms.TextBox();
            this.btnCriarExibirArquivo = new System.Windows.Forms.Button();
            this.txtArqs = new System.Windows.Forms.TextBox();
            this.btnAtributos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnMoverArquivo = new System.Windows.Forms.Button();
            this.btnCopiarArquvo = new System.Windows.Forms.Button();
            this.btnDeletarArquivo = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Arquivo Backup";
            // 
            // txtArquivoBackup
            // 
            this.txtArquivoBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoBackup.Location = new System.Drawing.Point(12, 377);
            this.txtArquivoBackup.Name = "txtArquivoBackup";
            this.txtArquivoBackup.Size = new System.Drawing.Size(326, 22);
            this.txtArquivoBackup.TabIndex = 46;
            this.txtArquivoBackup.Text = "C:\\Users\\fl\\Desktop\\Macoratti.bak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(147, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = " Replace()";
            // 
            // btnMoverCopiar
            // 
            this.btnMoverCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverCopiar.Location = new System.Drawing.Point(12, 410);
            this.btnMoverCopiar.Name = "btnMoverCopiar";
            this.btnMoverCopiar.Size = new System.Drawing.Size(129, 30);
            this.btnMoverCopiar.TabIndex = 44;
            this.btnMoverCopiar.Text = "Mover e Copiar";
            this.btnMoverCopiar.UseVisualStyleBackColor = true;
            this.btnMoverCopiar.Click += new System.EventHandler(this.btnMoverCopiar_Click);
            // 
            // txtArquivoDestino
            // 
            this.txtArquivoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoDestino.Location = new System.Drawing.Point(12, 329);
            this.txtArquivoDestino.Name = "txtArquivoDestino";
            this.txtArquivoDestino.Size = new System.Drawing.Size(329, 22);
            this.txtArquivoDestino.TabIndex = 43;
            this.txtArquivoDestino.Text = "C:\\Users\\fl\\Desktop\\Arquivo_Destino.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Origem";
            // 
            // txtArquivoOrigem
            // 
            this.txtArquivoOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoOrigem.Location = new System.Drawing.Point(12, 283);
            this.txtArquivoOrigem.Name = "txtArquivoOrigem";
            this.txtArquivoOrigem.Size = new System.Drawing.Size(329, 22);
            this.txtArquivoOrigem.TabIndex = 40;
            this.txtArquivoOrigem.Text = "C:\\Users\\fl\\Desktop\\Arquivo_Origem.txt";
            // 
            // btnCriarExibirArquivo
            // 
            this.btnCriarExibirArquivo.Location = new System.Drawing.Point(12, 178);
            this.btnCriarExibirArquivo.Name = "btnCriarExibirArquivo";
            this.btnCriarExibirArquivo.Size = new System.Drawing.Size(328, 23);
            this.btnCriarExibirArquivo.TabIndex = 39;
            this.btnCriarExibirArquivo.Text = "Criar/Exibir Arquivo ";
            this.btnCriarExibirArquivo.UseVisualStyleBackColor = true;
            this.btnCriarExibirArquivo.Click += new System.EventHandler(this.btnCriarExibirArquivo_Click);
            // 
            // txtArqs
            // 
            this.txtArqs.Location = new System.Drawing.Point(12, 204);
            this.txtArqs.Multiline = true;
            this.txtArqs.Name = "txtArqs";
            this.txtArqs.Size = new System.Drawing.Size(328, 47);
            this.txtArqs.TabIndex = 38;
            // 
            // btnAtributos
            // 
            this.btnAtributos.Location = new System.Drawing.Point(257, 51);
            this.btnAtributos.Name = "btnAtributos";
            this.btnAtributos.Size = new System.Drawing.Size(110, 23);
            this.btnAtributos.TabIndex = 37;
            this.btnAtributos.Text = "Atributos do Arquivo";
            this.btnAtributos.UseVisualStyleBackColor = true;
            this.btnAtributos.Click += new System.EventHandler(this.btnAtributos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Destino ";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(111, 143);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(229, 20);
            this.txtDestino.TabIndex = 35;
            this.txtDestino.Text = "C:\\Users\\fl\\Desktop\\Arquivo_Copia.txt";
            // 
            // btnMoverArquivo
            // 
            this.btnMoverArquivo.Location = new System.Drawing.Point(15, 143);
            this.btnMoverArquivo.Name = "btnMoverArquivo";
            this.btnMoverArquivo.Size = new System.Drawing.Size(89, 29);
            this.btnMoverArquivo.TabIndex = 34;
            this.btnMoverArquivo.Text = "Mover Arquivo";
            this.btnMoverArquivo.UseVisualStyleBackColor = true;
            this.btnMoverArquivo.Click += new System.EventHandler(this.btnMoverArquivo_Click);
            // 
            // btnCopiarArquvo
            // 
            this.btnCopiarArquvo.Location = new System.Drawing.Point(15, 103);
            this.btnCopiarArquvo.Name = "btnCopiarArquvo";
            this.btnCopiarArquvo.Size = new System.Drawing.Size(89, 34);
            this.btnCopiarArquvo.TabIndex = 33;
            this.btnCopiarArquvo.Text = "Copiar Arquivo";
            this.btnCopiarArquvo.UseVisualStyleBackColor = true;
            this.btnCopiarArquvo.Click += new System.EventHandler(this.btnCopiarArquvo_Click);
            // 
            // btnDeletarArquivo
            // 
            this.btnDeletarArquivo.Location = new System.Drawing.Point(110, 51);
            this.btnDeletarArquivo.Name = "btnDeletarArquivo";
            this.btnDeletarArquivo.Size = new System.Drawing.Size(92, 28);
            this.btnDeletarArquivo.TabIndex = 32;
            this.btnDeletarArquivo.Text = "Deletar Arquivo";
            this.btnDeletarArquivo.UseVisualStyleBackColor = true;
            this.btnDeletarArquivo.Click += new System.EventHandler(this.btnDeletarArquivo_Click_1);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(12, 51);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(92, 28);
            this.btnCriarArquivo.TabIndex = 31;
            this.btnCriarArquivo.Text = "Criar Arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Caminho e Nome do Arquivo";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(12, 25);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(358, 20);
            this.txtNomeArquivo.TabIndex = 29;
            this.txtNomeArquivo.Text = "C:\\Users\\fl\\Desktop\\Arquivo_Teste.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 458);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtArquivoBackup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMoverCopiar);
            this.Controls.Add(this.txtArquivoDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArquivoOrigem);
            this.Controls.Add(this.btnCriarExibirArquivo);
            this.Controls.Add(this.txtArqs);
            this.Controls.Add(this.btnAtributos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnMoverArquivo);
            this.Controls.Add(this.btnCopiarArquvo);
            this.Controls.Add(this.btnDeletarArquivo);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeArquivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArquivoBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMoverCopiar;
        private System.Windows.Forms.TextBox txtArquivoDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArquivoOrigem;
        private System.Windows.Forms.Button btnCriarExibirArquivo;
        private System.Windows.Forms.TextBox txtArqs;
        private System.Windows.Forms.Button btnAtributos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnMoverArquivo;
        private System.Windows.Forms.Button btnCopiarArquvo;
        private System.Windows.Forms.Button btnDeletarArquivo;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeArquivo;
    }
}


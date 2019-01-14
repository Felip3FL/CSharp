namespace Aula_46___Arquivos_IO
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
            this.btnInfoDir = new System.Windows.Forms.Button();
            this.btnDeleteDir = new System.Windows.Forms.Button();
            this.btnCriaDir = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnDriversLogicos = new System.Windows.Forms.Button();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.txtArqs = new System.Windows.Forms.TextBox();
            this.btnArquivos = new System.Windows.Forms.Button();
            this.btnDiretorios = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInfoDir
            // 
            this.btnInfoDir.Location = new System.Drawing.Point(212, 425);
            this.btnInfoDir.Name = "btnInfoDir";
            this.btnInfoDir.Size = new System.Drawing.Size(377, 23);
            this.btnInfoDir.TabIndex = 19;
            this.btnInfoDir.Text = "Informações do diretorio";
            this.btnInfoDir.UseVisualStyleBackColor = true;
            this.btnInfoDir.Click += new System.EventHandler(this.btnInfoDir_Click);
            // 
            // btnDeleteDir
            // 
            this.btnDeleteDir.Location = new System.Drawing.Point(475, 396);
            this.btnDeleteDir.Name = "btnDeleteDir";
            this.btnDeleteDir.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteDir.TabIndex = 18;
            this.btnDeleteDir.Text = "Deletar Diretório";
            this.btnDeleteDir.UseVisualStyleBackColor = true;
            this.btnDeleteDir.Click += new System.EventHandler(this.btnDeleteDir_Click);
            // 
            // btnCriaDir
            // 
            this.btnCriaDir.Location = new System.Drawing.Point(212, 395);
            this.btnCriaDir.Name = "btnCriaDir";
            this.btnCriaDir.Size = new System.Drawing.Size(114, 23);
            this.btnCriaDir.TabIndex = 17;
            this.btnCriaDir.Text = "Criar Diretório";
            this.btnCriaDir.UseVisualStyleBackColor = true;
            this.btnCriaDir.Click += new System.EventHandler(this.btnCriaDir_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(212, 369);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(377, 20);
            this.txtDir.TabIndex = 16;
            this.txtDir.Text = "C:\\Users\\fl\\Desktop\\oi";
            // 
            // btnDriversLogicos
            // 
            this.btnDriversLogicos.Location = new System.Drawing.Point(211, 335);
            this.btnDriversLogicos.Name = "btnDriversLogicos";
            this.btnDriversLogicos.Size = new System.Drawing.Size(378, 27);
            this.btnDriversLogicos.TabIndex = 15;
            this.btnDriversLogicos.Text = "Exibir Dirves Lógicos";
            this.btnDriversLogicos.UseVisualStyleBackColor = true;
            this.btnDriversLogicos.Click += new System.EventHandler(this.btnDriversLogicos_Click);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(354, 41);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(100, 20);
            this.txtCriterio.TabIndex = 14;
            this.txtCriterio.Text = "*.txt";
            // 
            // txtArqs
            // 
            this.txtArqs.Location = new System.Drawing.Point(212, 78);
            this.txtArqs.Multiline = true;
            this.txtArqs.Name = "txtArqs";
            this.txtArqs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArqs.Size = new System.Drawing.Size(377, 250);
            this.txtArqs.TabIndex = 13;
            // 
            // btnArquivos
            // 
            this.btnArquivos.Location = new System.Drawing.Point(475, 29);
            this.btnArquivos.Name = "btnArquivos";
            this.btnArquivos.Size = new System.Drawing.Size(114, 42);
            this.btnArquivos.TabIndex = 12;
            this.btnArquivos.Text = "Arquivos";
            this.btnArquivos.UseVisualStyleBackColor = true;
            this.btnArquivos.Click += new System.EventHandler(this.btnArquivos_Click);
            // 
            // btnDiretorios
            // 
            this.btnDiretorios.Location = new System.Drawing.Point(212, 29);
            this.btnDiretorios.Name = "btnDiretorios";
            this.btnDiretorios.Size = new System.Drawing.Size(114, 42);
            this.btnDiretorios.TabIndex = 11;
            this.btnDiretorios.Text = "Diretórios";
            this.btnDiretorios.UseVisualStyleBackColor = true;
            this.btnDiretorios.Click += new System.EventHandler(this.btnDiretorios_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(211, 2);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(378, 20);
            this.txtOrigem.TabIndex = 10;
            this.txtOrigem.Text = "c:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 463);
            this.Controls.Add(this.btnInfoDir);
            this.Controls.Add(this.btnDeleteDir);
            this.Controls.Add(this.btnCriaDir);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnDriversLogicos);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.txtArqs);
            this.Controls.Add(this.btnArquivos);
            this.Controls.Add(this.btnDiretorios);
            this.Controls.Add(this.txtOrigem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfoDir;
        private System.Windows.Forms.Button btnDeleteDir;
        private System.Windows.Forms.Button btnCriaDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnDriversLogicos;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.TextBox txtArqs;
        private System.Windows.Forms.Button btnArquivos;
        private System.Windows.Forms.Button btnDiretorios;
        private System.Windows.Forms.TextBox txtOrigem;
    }
}


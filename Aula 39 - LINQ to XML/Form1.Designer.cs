namespace Aula_39___LINQ_to_XML
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnXDocument = new System.Windows.Forms.Button();
            this.btnXElement = new System.Windows.Forms.Button();
            this.txtXmlDoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(551, 461);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 48);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnXDocument
            // 
            this.btnXDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXDocument.Location = new System.Drawing.Point(15, 461);
            this.btnXDocument.Margin = new System.Windows.Forms.Padding(4);
            this.btnXDocument.Name = "btnXDocument";
            this.btnXDocument.Size = new System.Drawing.Size(199, 48);
            this.btnXDocument.TabIndex = 4;
            this.btnXDocument.Text = "Criar XML : XDocument";
            this.btnXDocument.UseVisualStyleBackColor = false;
            this.btnXDocument.Click += new System.EventHandler(this.btnXDocument_Click);
            // 
            // btnXElement
            // 
            this.btnXElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXElement.Location = new System.Drawing.Point(295, 461);
            this.btnXElement.Margin = new System.Windows.Forms.Padding(4);
            this.btnXElement.Name = "btnXElement";
            this.btnXElement.Size = new System.Drawing.Size(195, 48);
            this.btnXElement.TabIndex = 5;
            this.btnXElement.Text = "Criar XML : XElement";
            this.btnXElement.UseVisualStyleBackColor = false;
            this.btnXElement.Click += new System.EventHandler(this.btnXElement_Click);
            // 
            // txtXmlDoc
            // 
            this.txtXmlDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtXmlDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXmlDoc.Location = new System.Drawing.Point(13, 13);
            this.txtXmlDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtXmlDoc.Multiline = true;
            this.txtXmlDoc.Name = "txtXmlDoc";
            this.txtXmlDoc.Size = new System.Drawing.Size(666, 443);
            this.txtXmlDoc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 520);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnXDocument);
            this.Controls.Add(this.btnXElement);
            this.Controls.Add(this.txtXmlDoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnXDocument;
        private System.Windows.Forms.Button btnXElement;
        private System.Windows.Forms.TextBox txtXmlDoc;
    }
}


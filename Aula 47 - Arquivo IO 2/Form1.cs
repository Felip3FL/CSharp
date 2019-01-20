using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula_47___Arquivo_IO_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnCriarArquivo_Click_1(object sender, EventArgs e)
        {
            try
            {
                File.Create(txtNomeArquivo.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeletarArquivo_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(txtNomeArquivo.Text))
            {
                File.Delete(txtNomeArquivo.Text);
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
        }

        private void btnAtributos_Click(object sender, EventArgs e)
        {
            FileAttributes atributos = File.GetAttributes(txtNomeArquivo.Text);
            txtArqs.Text = atributos.ToString();
        }

        private void btnCopiarArquvo_Click(object sender, EventArgs e)
        {
            File.Copy(txtNomeArquivo.Text, txtDestino.Text);
        }

        private void btnMoverArquivo_Click(object sender, EventArgs e)
        {
            File.Move(txtNomeArquivo.Text, txtDestino.Text);
        }

        private void btnCriarExibirArquivo_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtNomeArquivo.Text))
            {
                using (StreamWriter stw = File.CreateText(txtNomeArquivo.Text))
                {
                    stw.WriteLine("Felip3FL\n\r");
                    stw.WriteLine("felip3.fl@gmail.com \n\r");
                }
            }
            else
            {
                MessageBox.Show("Arquivo já existe, ele será aberto.");
            }

            using (StreamReader sr = File.OpenText(txtNomeArquivo.Text))
            {
                txtArqs.Text = "";
                string texto = "";
                while ((texto = sr.ReadLine()) != null)
                {
                    txtArqs.Text += texto + "\n\r";
                }
            }
        }

        private void btnMoverCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArquivoBackup.Text == string.Empty)
                {
                    File.Replace(txtArquivoOrigem.Text, txtArquivoDestino.Text, null);
                }
                else
                {
                    File.Replace(txtArquivoOrigem.Text, txtArquivoDestino.Text, txtArquivoBackup.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

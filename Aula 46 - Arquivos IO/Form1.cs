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

namespace Aula_46___Arquivos_IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiretorios_Click(object sender, EventArgs e)
        {

            //OBTER DIRETORIOS

            txtArqs.Text = "";

            string[] dir;
            dir = Directory.GetDirectories(txtOrigem.Text);
            for (int i=0; i <= dir.Count() -1 ; i++)
            {
                txtArqs.Text += dir[i] + "\r\n";
                   
            }


        }


        private void btnArquivos_Click(object sender, EventArgs e)
        {

            //OBTER ARQUIVOS

            txtArqs.Text = "";

            string[] arqs;
            arqs = Directory.GetFiles(txtOrigem.Text,txtCriterio.Text);
            for(int i = 0; i <= arqs.Count()-1; i++)
            {
                txtArqs.Text += arqs[i] + "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDriversLogicos_Click(object sender, EventArgs e)
        {
            txtArqs.Text = "";
            string[] drvs;
            drvs = Directory.GetLogicalDrives();
            for (int i = 0; i <= drvs.Count() - 1; i++)
            {
                txtArqs.Text += drvs[i] + "\r\n";
            }
        }

        private void btnCriaDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(txtDir.Text))
                {
                    Directory.CreateDirectory(txtDir.Text);
                }
                else
                {
                    MessageBox.Show("Diretorio " + txtDir.Text + " já existe");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtDir.Text))
                {
                    Directory.Delete(txtDir.Text);
                }
                else
                {
                    MessageBox.Show("Diretorio " + txtDir.Text + " já deletado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInfoDir_Click(object sender, EventArgs e)
        {
            DateTime dataCriacao = Directory.GetCreationTime(txtDir.Text);
            DateTime dataHoraAcesso = Directory.GetLastAccessTime(txtDir.Text);
            string raiz = Directory.GetDirectoryRoot(txtDir.Text);
            string pai = Directory.GetParent(txtDir.Text).ToString();
            MessageBox.Show("Data Criação : " + dataCriacao.ToShortDateString() +
                          "\r\n" + "Hora de Acesso : " + dataHoraAcesso.ToShortTimeString() +
                          "\r\n" + "Raiz : " + raiz + "\r\n" + "Dir. Pai : " + pai);
        }
    }
}

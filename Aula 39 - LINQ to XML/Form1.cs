using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Aula_39___LINQ_to_XML
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

        private void btnXDocument_Click(object sender, EventArgs e)
        {
            txtXmlDoc.Text = CriarDocumentoXMLviaXDocument().ToString();
        }

        private XDocument CriarDocumentoXMLviaXDocument()
        {

            //Criar XML
            XDocument clientesXML = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                                new XComment("Criando XML via LINQ to XML - XDocument"),
                                new XElement("clientes",
                                    new XElement("cliente",
                                        new XAttribute("codigo", 1),
                                        new XElement("nome", "Felipe"),
                                        new XElement("email", "felip3.fl@gmail.com")),
                                    new XElement("cliente",
                                        new XAttribute("codigo", 2),
                                        new XElement("nome", "Pamella"),
                                        new XElement("email", "pamella@gmail.com"))));

            clientesXML.Save(@"C:\Users\fl\Desktop\MeuXML.xml");

            return clientesXML;
        }


        private XElement CriarDocumentoXMLViaXElement()
        {
            XElement xmlDoc =
             new XElement("clientes",
             new XElement("cliente",
                new XAttribute("codigo", "1"),
                    new XElement("nome", "Felipe"),
                    new XElement("email", "felip3.fl@gmail.com")),
             new XElement("cliente",
                 new XAttribute("codigo", "2"),
                    new XElement("nome", "Pamella"),
                    new XElement("email", "pamella@bol.com.br")));

            xmlDoc.Save(@"C:\Users\fl\Desktop\MeuXML.xml");

            return xmlDoc;
        }

        private void btnXElement_Click(object sender, EventArgs e)
        {
            txtXmlDoc.Text = CriarDocumentoXMLViaXElement().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22___Interface
{
    public interface IImposto
    {
        //Assinatura do método
        double calcularImposto();

    }

    public interface ITransacao : IImposto
    {
        void exibirTransacao();
        double getValor();
    }

    //Classe concreta
    public class Juros
    {
        public double calculaJuros(double valor, double taxa)
        {
            return valor * taxa;
        }
    }


    public class Transacao : Juros, ITransacao
    {
        private string codigo;
        public string data;
        public double valor;

        public virtual double calcularImposto()
        {
            return valor * 0.15;
        }

        public Transacao()
        {
            codigo = "";
            data = "";
            valor = 0.0;
        }

        public Transacao(string _codigo, string _data, double _valor)
        {
            codigo = _codigo;
            data = _data;
            valor = _valor;
        }

        public void exibirTransacao()
        {
            Console.WriteLine("Transação : {0}", codigo);
            Console.WriteLine("Data      : {0}", data);
            Console.WriteLine("Valor     : {0}", getValor());
            Console.WriteLine("Imposto   : {0}", calcularImposto());
            Console.WriteLine("Juros     : {0}", calculaJuros(valor, 0.25));
        }

        public double getValor()
        {
            return valor;
        }



    }

    public class Teste : Transacao
    {
        public override double calcularImposto()
        {
            return getValor() * .30;
        }
    }

}

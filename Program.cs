using System;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP mulan = new IngressoVIP();
            mulan.Nome= "Mulan";
            mulan.Pagamento= 35f;
            mulan.Acrescimo= 17f;
            mulan.MostarValor();
            mulan.MostarValorVIP();

            System.Console.WriteLine($"A diferença entre os valores dos ingressos, para o filme {mulan.Nome}, é de R$ {mulan.Acrescimo}.");


        }
    }
}

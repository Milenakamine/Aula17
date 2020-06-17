namespace Aula17
{
    public class IngressoVIP : Ingresso
    {
        public float Acrescimo { get; set; }

        public void MostarValorVIP(){
            float adicional = Pagamento+Acrescimo;
            System.Console.WriteLine($"O valor do ingresso VIP, para o filme {Nome}, é R${adicional}.");
        }
    }
}
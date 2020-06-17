namespace Aula17
{
    public class Ingresso
    {
        public string Nome { get; set; }

        public float Pagamento { get; set; }

        public void MostarValor(){
            System.Console.WriteLine($"O valor do ingresso comum, para o filme {Nome}, é R${Pagamento}.");
        }

        
    }
}
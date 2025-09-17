using VetorConta;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        //declarar vetor - cria-se vetor null
        Conta[] vetorContas = new Conta[3];

        //laço de repetição
        for (int i=0;i < vetorContas.Length; i++){
            //declaração de instanciação de CADA ÍNDICE
            vetorContas[i] = new Conta();
            Console.Write("Informe o número: ");
            vetorContas[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o titular: ");
            vetorContas[i].titular = Console.ReadLine();
            Console.Write("Informe o saldo: ");
            vetorContas[i].saldo = Convert.ToDouble(Console.ReadLine());
        }
        //apresentação das contas com for
        for (int i=0;i < vetorContas.Length; i++){
            vetorContas[i].MostrarAtributos();
        }

        //foreach APENAS para mostrar conteúdo dos vetores
        //apresentação das contas com foreach
        foreach (Conta c in vetorContas){
            c.MostrarAtributos();
        }
    }
}
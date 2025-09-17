using VetorFuncionario;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario[] vetorFuncionario = new Funcionario[3];
        double soma = 0;
        for (int i = 0; i < vetorFuncionario.Length; i++)
        {

            vetorFuncionario[i] = new Funcionario();
            Console.Write("Informe o código do funcionário: ");
            vetorFuncionario[i].codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome do funcionário: ");
            vetorFuncionario[i].nome = Console.ReadLine();
            Console.Write($"Informe o salário de {vetorFuncionario[i].nome}: ");
            vetorFuncionario[i].salario = Convert.ToDouble(Console.ReadLine());
            soma += vetorFuncionario[i].salario;

        }
        Console.WriteLine($"A soma dos salários é {soma:c}");

    }
}
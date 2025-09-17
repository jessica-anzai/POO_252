using ListFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Funcionario> vetorFuncionario = new List<Funcionario>();

        double soma = 0;
        for (int i = 0; i < 3; i++)
        {
            Funcionario f = new Funcionario();
            Console.Write("Informe o código do funcionário: ");
            f.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome do funcionário: ");
            f.nome = Console.ReadLine();
            Console.Write($"Informe o salário de {f.nome}: ");
            f.salario = Convert.ToDouble(Console.ReadLine());
            soma += f.salario;
            vetorFuncionario.Add(f);
        }
        Console.WriteLine($"A soma dos salários é {soma:c}");
    }
}
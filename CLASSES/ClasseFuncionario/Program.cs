using ClasseFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f = new Funcionario();
        Console.WriteLine("Informe o código: ");
        f.codigo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o nome: ");
        f.nome = Console.ReadLine();
        Console.WriteLine("Informe o salário: ");
        f.salario = Convert.ToDouble(Console.ReadLine());
        f.MostrarAtributos();
        Console.WriteLine();

        Console.WriteLine("Informe o percentual de acréscimo: ");
        int aum = Convert.ToInt32(Console.ReadLine());
        f.CalcularAumento(aum);
        Console.WriteLine();

        f.MostrarAtributos();
        Console.WriteLine();
    }
}
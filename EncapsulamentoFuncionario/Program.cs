using EncapsulamentoFuncionario;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        Console.Write("Informe o código: ");
        f1.Codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Informe o salário: ");
        f1.Salario = Convert.ToDouble(Console.ReadLine());

        f1.MostrarAtributos();

        Console.Write("Informe o percentual de aumento do salário: ");
        double acrescimo = Convert.ToDouble(Console.ReadLine());
        f1.CalcularAumento(acrescimo);

        f1.MostrarAtributos();

    }
}
using ConstrutorFuncionario;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {

        Funcionario f = new Funcionario();
        f.MostrarAtributos();

        Funcionario f1 = new Funcionario(1,"Ana",1500);
        f1.MostrarAtributos();

        Funcionario f2 = new Funcionario(2,2000);
        f2.MostrarAtributos();

        Console.WriteLine($"Quantidade de instâncias: {Funcionario.Contador}"); //exibir atributo static no program main utiliza nome da classe ao invés da instância.

    }
}
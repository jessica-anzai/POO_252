using HerancaFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f = new Funcionario(1000);
        Console.WriteLine($"Funcionario: {f.CalcularBonificacao():c}");

        Secretario s = new Secretario(1000);
        Console.WriteLine($"Secretário: {s.CalcularBonificacao():c}");

        Gerente g = new Gerente(1000);
        Console.WriteLine($"Gerente: {g.CalcularBonificacao():c}");

        Diretor d = new Diretor(1000);
        Console.WriteLine($"Diretor: {d.CalcularBonificacao():c}");

        GerenciadorBonificacao gB = new GerenciadorBonificacao();
        gB.TotalizadorBonificacao(f);
        gB.TotalizadorBonificacao(s);
        gB.TotalizadorBonificacao(g);
        gB.TotalizadorBonificacao(d);

        Console.WriteLine($"Total de bonificações: {gB.TotalBonificacao:c}");
    }
}
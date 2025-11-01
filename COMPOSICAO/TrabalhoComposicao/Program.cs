using TrabalhoComposicao;

internal class Program
{
    private static void Main(string[] args)
    {
        Banco b = new Banco();
        b.IniciarBanco();

        // Abrindo contas correntes
        b.AbrirConta(2000, 200);
        b.AbrirConta(3500, 200);

        // Abrindo conta poupança
        b.AbrirPoupanca(5000);

        // Acessando as instâncias criadas pelo banco
        ContaCorrente cc1 = b.Conta[0];
        ContaCorrente cc2 = b.Conta[1];
        ContaPoupanca cp1 = b.Poup[0];

        // Exemplo de operações
        cc1.GerarExtrato();
        cc2.GerarExtrato();
        cp1.GerarExtrato();
        cp1.GerarRendimento();
    }
}
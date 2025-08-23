using ClasseConta; //a pasta - usa os arquivos que estão lá

// declarção de variável
Conta c1;

//instaciação de objeto
c1 = new Conta();
c1.numero = 1;
c1.titular = "Ana";
c1.saldo = 100;
Console.WriteLine("Número: " + c1.numero);
Console.WriteLine("Titular: "+c1.titular);
Console.WriteLine("Saldo: "+c1.saldo);
c1.MostrarAtributos();
c1.Sacar(10);
c1.MostrarAtributos();

//outra instanciação
Conta c2 = new Conta(); // forma mais prática
Console.Write("Digite o número: ");
c2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular: ");
c2.titular = Console.ReadLine();
Console.Write("Digite o saldo: ");
c2.saldo = Convert.ToDouble(Console.ReadLine());
c2.MostrarAtributos();
c2.Depositar(100);
c2.MostrarAtributos();

Conta c3 = new Conta();
c3.MostrarAtributos();
double soma = 0;


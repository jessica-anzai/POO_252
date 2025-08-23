//HOJE É DIA DE REVISÃO BEBÊ


//-------------------------------------------------------------------------------------------------------------------------------
//Estruturas de repetição
int i = 1;
do
{
    System.Console.WriteLine("5 x " + i + " = " + 5*i);
    i ++;       
}while(i<=10);

/*int i = 1;
while (i <= 10)
{
    System.Console.WriteLine("5 x " + i + " = " + 5*i);
    i ++;    
}*/
/*for (int i = 1; i <= 10; i++)
    System.Console.WriteLine("5 x " + i + " = " + 5*i);
*/
//-------------------------------------------------------------------------------------------------------------------------------
//Estruturas de decisão de multipla escolha
/*System.Console.Write("Digite um numero de 1 a 3:");
int opcao = Convert.ToInt32(Console.ReadLine());
switch (opcao)
{
    case 1: System.Console.WriteLine("Parabéns, você escolheu a opção 1 - Pacote Plus");
    break;
    case 2: System.Console.WriteLine("Parabéns, você escolheu a opção 2 - Pacote Premium");
    break;
    case 3: System.Console.WriteLine("Parabéns, você escolheu a opção 3 - Pacote Premium Plus");
    break;
    default: //ESSE TEM A MESMA FUNÇÃO DO ELSE, PORÉM NO SWITCH
    System.Console.WriteLine("Escolheu errado meu parceiro.");
    break;
}*/
//-------------------------------------------------------------------------------------------------------------------------------
/* Estrutura de decisão comum

System.Console.WriteLine("Digite a sua idade e descubra sua classificação:");
int idade = Convert.ToInt32(Console.ReadLine());
if (idade >= 18)
    Console.WriteLine("Pode beber meu fi");           //Usa-se or ou || para ou
else if (idade == 0)                                  //para mais de uma condição usa-se and ou &&
    Console.WriteLine("É um embrião é ?");            //usa-se not ou ! para negação
else
    Console.WriteLine("Você é di menó");*/
//-------------------------------------------------------------------------------------------------------------------------------
//ENTRADA 
/*Console.Write("Digite o seu ano de nascimento:");
int ano = Convert.ToInt32(Console.ReadLine());
int idade = 2025 - ano;
Console.WriteLine("Sua idade é "+idade);*/
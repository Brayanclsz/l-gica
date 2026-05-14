// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----Questionário-----");

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Você tem CNH? ");
string cnhResposta = Console.ReadLine();

string responsividadeCNH;
if(cnhResposta.ToLower() != "sim")
{
    responsividadeCNH = "Você não possui CNH";
}
else
{
    responsividadeCNH = "Você possui CNH";
}

Console.WriteLine("-----Dados-----");

Console.WriteLine("Seu nome é: "+ nome);
Console.WriteLine("Sua idade é: "+ idade + " anos");
Console.WriteLine("Sua altura é: "+ altura + "cm");
Console.WriteLine(responsividadeCNH);
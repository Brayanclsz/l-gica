// See https://aka.ms/new-console-template for more information
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
    responsividadeCNH = "Não possui CNH";
}
else
{
    responsividadeCNH = "Possui CNH";
}

Console.WriteLine("Nome: "+ nome);
Console.WriteLine("Idade: "+ idade + " anos");
Console.WriteLine("Altura: "+ altura + "cm");
Console.WriteLine(responsividadeCNH);
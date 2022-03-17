System.Console.WriteLine("Escreva um numero de acordo com a empolgação");
var N = int.Parse(Console.ReadLine());
var natal = "";
System.Console.WriteLine(ImprimirMensagem(N, natal));


static string ImprimirMensagem(int n, string natal)
{
    for(int i = 1; i < n; i++)
    {
        natal += "a";
    }
    return $"Feliz nat{natal}l!\n";
}
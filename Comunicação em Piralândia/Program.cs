// See https://aka.ms/new-console-template for more information
long numerico = 213895417832108390;

string num = numerico.ToString();

var resultado = string.Empty;

for (int i = num.Length - 1; i > -1; i--)
{
    resultado += num[i];
}

System.Console.WriteLine(resultado);
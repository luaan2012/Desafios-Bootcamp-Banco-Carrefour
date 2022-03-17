using System; 

class TESTE 
{

    static void Main(string[] args)
    { 
        System.Console.WriteLine("Digite sua colocação");
        int n= int.Parse(Console.ReadLine());
        if (n == 1)
            Console.WriteLine("Top 1");
        else if (n > 1 && n  < 4)
            Console.WriteLine("Top 3");
        else if (n > 3 && n  < 6)
            Console.WriteLine("Top 5");
        else if (n > 5 && n < 11)
            Console.WriteLine("Top 10");
        else if (n > 11 && n  < 26)
            Console.WriteLine("Top 25");
        else if (n > 25 && n  < 51)
            Console.WriteLine("Top 50");
        else if (n > 50 && n  < 101)
            Console.WriteLine("Top 100"); 
        }

}
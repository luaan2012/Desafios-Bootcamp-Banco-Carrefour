
class Problem 
{

    static void Main(string[] args) 
    { 

        int num = 7;
        int fatorial = num;
        int c = 1;

        for (int i = c; i < num; i++)
        {
            fatorial = fatorial * (num - i);
        }
        System.Console.WriteLine(fatorial);

    }

}


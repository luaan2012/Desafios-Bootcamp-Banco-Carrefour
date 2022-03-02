using System; 

class Problem {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
        

        int val1 = int.Parse(v[0]);
        int val2 = int.Parse(v[1]);

            
        Console.WriteLine($"{val2 * val1} ");

    }

}
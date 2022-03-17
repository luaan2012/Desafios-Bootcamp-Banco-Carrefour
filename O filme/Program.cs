using System; 
 
class Problem {
     
    static void Main(string[] args) { 
        string[] input = Console.ReadLine().Split(' ');

        double A = double.Parse(input[0]);
        double B = double.Parse(input[1]);
        double aumento = ((B - A) / A) * 100;

        Console.WriteLine("{0:F2}%", aumento);

    }
    
}

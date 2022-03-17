using System.Globalization;

class Problem {
 
    static void Main(string[] args) { 
		string[] line = Console.ReadLine().Split(' ');
        double A = double.Parse(line[0]);
        double B = double.Parse(line[1]);
        double C = double.Parse(line[2]);

        var Triangulo = A * C / 2.0;
        var circulo = 3.14159 * C * C;
        var trapezio = (A + B) / 2.0 * C;
        var quadrado = B * B;
        var retangulo = A * B;

        Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }
    
}
using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 89, nota, valor, quociente, resto, n100 = 0, n50 = 0, n20 = 0, n10 = 0, n5 = 0, n2 = 0, n1 = 1;

        

      
            valor = N;
            
            n100 = valor / 100; //0.89
            
            valor = valor - (n100 * 100); 

            n50 = valor / 50;
            
            valor = valor - (n50 * 50);
  
            n20 = valor / 20;
            
            valor = valor - (n20 * 20);

            n10 = valor / 10;
            
            valor = valor - (n10 * 10);

            n5 = valor / 5;
            
            valor = valor - (n5 * 5);
            
            n2 = valor / 2;
            
            valor = valor - (n2 * 2) ;
            
                

            n1 = valor / 1;

            nota = 100;
            Console.WriteLine(valor);
            Console.WriteLine($"{n100} nota(s) de R$ 100,00");
            Console.WriteLine($"{n50} nota(s) de R$ 50,00");
            Console.WriteLine($"{n20} nota(s) de R$ 20,00");
            Console.WriteLine($"{n10} nota(s) de R$ 10,00");
            Console.WriteLine($"{n5} nota(s) de R$ 5,00");
            Console.WriteLine($"{n2} nota(s) de R$ 2,00");
            Console.WriteLine($"{n1} nota(s) de R$ 1,00");

            
            
    

           //Continue com a sua lógica aqui
                                                   
        }
    }
}
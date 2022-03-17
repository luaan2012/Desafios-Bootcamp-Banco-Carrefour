using System; 

class Teste 
{

    static void Main(string[] args) 
    { 
      
      int x = 3;
      for (int i = 0; i < x; i++)
      {   
          System.Console.WriteLine();
          var txt = Console.ReadLine();
          Console.WriteLine((txt.Length * 0.01).ToString("N2") );
      }
    }
}

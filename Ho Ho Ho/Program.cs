using System;

namespace DIO {
    class Program {
        static void Main(string[] args) {
           
            int N = int.Parse(Console.ReadLine());
            string con = "";
            string teste = "Ho ";
            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++) {
                con += teste;
                if (i+1 == N) {
                 con = con.Remove(0, 3);   
                 Console.WriteLine(con+"Ho!");
                 
  
              }
            }
            

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            //tipo booleano = 0 ou 1 - 0 (falso) e 1 (verdadeiro)
            //bool booleano = 10 > 5 || true; 
            //bool booleano2 = 10 > 15;

            int numero = 2;

            //E = &&
            if(numero < 5 && numero != 2) {
                //numero menor que 5
                Console.WriteLine("numero menor que 5");
            } else if(numero < 10) {
                //numero menor que 10
                Console.WriteLine("numero menor que 10");
            } else {
                //numero maior ou igual a 10
                Console.WriteLine("numero maior ou igual a 10" );
            }

            //OU = || - pipe
            if(10 > 5 || 10 > 10) {
                //executa
            }

            if(10 > 5 || 10 > 1) {
                //executa
            }

            //Console.WriteLine(" Booleano 1: " + booleano);
            //Console.WriteLine(" Booleano 2: " + booleano2);

            //if (booleano) {
            //    Console.WriteLine(" Will");
            //}
            
            Console.ReadKey();
        }
    }
}

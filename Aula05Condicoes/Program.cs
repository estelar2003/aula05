using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Condicoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;
            string resposta;
           






            Console.WriteLine("Bem-vindo ao DETRAN");
            Console.WriteLine("Digite a sua idade");
            idade = int.Parse(Console.ReadLine());
         

            Console.WriteLine($"Você tem {idade} anos!");

            if(idade >= 18)
            {
              Console.WriteLine("Você já pode tirar a CNH");
            }
            else
            {
                Console.WriteLine("Você ainda não tem idade...");
            }

            Console.WriteLine("Você já tem uma carteira CNH? Digite sim ou não");
            resposta = Console.ReadLine();
          

            if(resposta=="sim") 
            {
                Console.WriteLine("Então você deve renovar a sua CNH");
            }
            else
            {
                Console.WriteLine("Vpcê vai tirar sua primeira carteira de motorista");
            }


            Console.ReadKey();
            Main(null);







        }
    }
}

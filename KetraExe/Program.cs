using System;
using System.Collections.Generic;

namespace KetraExe
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o nome e idade de tres pessoas");

            Console.WriteLine("Digite nome: ");
            //armazendo valores do dados acima
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite idade: ");
            int idade1 = Convert.ToInt32(Console.ReadLine());
            Pessoas pessoa1 = new Pessoas(nome1, idade1);

            Console.WriteLine("Digite nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite idade: ");
            int idade2 = Convert.ToInt32(Console.ReadLine());
            Pessoas pessoa2 = new Pessoas(nome2, idade2);

            Console.WriteLine("Digite nome: ");
            string nome3 = Console.ReadLine();
            Console.WriteLine("Digite idade: ");
            int idade3 = Convert.ToInt32(Console.ReadLine());
            Pessoas pessoa3 = new Pessoas(nome3, idade3);
            Console.WriteLine("##############");

            //pegando as propriedades da class e fazendo a logica
            if (pessoa1.idade > pessoa2.idade && pessoa1.idade > pessoa3.idade)
            {
                Console.WriteLine(pessoa1.ExibirDados());
            }else if (pessoa2.idade > pessoa1.idade && pessoa2.idade > pessoa3.idade)
            {
                Console.WriteLine(pessoa2.ExibirDados());
            }
            else
            {
                Console.WriteLine(pessoa3.ExibirDados());

            }





            //criar metodo para Exibir os Dados - solução ? criar um metodo q vai listar do maior para o menor
            // função pra adicionar valores
            //for (int i = 0; i < 3; i++)
            //{

            //    Console.WriteLine("Digite nome: ");
            //    string nome =  Console.ReadLine();

            //    Console.WriteLine("Digite idade: ");
            //    int idade = Convert.ToInt32(Console.ReadLine());

            //    //instanciando 
            //    Pessoas pessoa = new Pessoas(nome, idade);

            //    //Setando na listas os atributos instanciado no objeto pessoa
            //    lista.Add(pessoa);
            //}




            Console.ReadKey();
        }
    }
}

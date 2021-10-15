using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int n1;
            Console.WriteLine(int.MinValue);


            double saldo = 10.357898732;

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            int idade = 34;
            double saldo2 = 10.35784;
            string nome = "Miriam";

            // placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo2);

            // interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // concatenação de strings
            Console.WriteLine(nome+ " tem " + idade + " anos e tem saldo igual a " + saldo2.ToString("F2") + " reais");


            //EXERCÍCIO

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade2 = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.2345678;


            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            //Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto2, preco2);

            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}", idade2, codigo, genero);

            Console.WriteLine("Medida com 8 casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (3 casas decimais): {0:F3}", medida);


            // Casting

            int a = 2;
            int b = 5;

            double resultado1 = b / a;
            Console.WriteLine(resultado1);

            // conversão explícita dos dados
            double resultado2 = (double) b / a;
            Console.WriteLine(resultado2);


            // Entrada de múltiplos dados na mesma linha (mesmo tipo de dado)
            // miriam sarah cecilia gustavo

            string[] vetor = Console.ReadLine().Split(' ');

            foreach (string v in vetor)
            {
                Console.WriteLine(v);
            }

            // Entrada de múltiplos dados na mesma linha (diferentes tipos de dados)
            // Miriam F 34 1.65

            string[] vetor2 = Console.ReadLine().Split(' ');

            string name = vetor2[0];
            char sex = char.Parse(vetor2[1]);
            int age = int.Parse(vetor2[2]);
            double height = double.Parse(vetor2[3]);

            foreach (object o in vetor2)
            {
                Console.WriteLine(o);
            }


            // Entrada de tipos de dados diferentes

            int numero = int.Parse(Console.ReadLine());
            char caractere = char.Parse(Console.ReadLine());
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine(numero);
            Console.WriteLine(caractere);
            Console.WriteLine(numero2);
            



        }
    }
}

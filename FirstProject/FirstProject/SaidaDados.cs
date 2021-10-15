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


        }
    }
}

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            
            Console.Clear();

            Console.WriteLine("Escolha uma opção ai ligeiro");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("Quero sair - 5");
            Console.WriteLine("-----------------------");

            short res = short.Parse(Console.ReadLine());

            switch(res){

                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Divisao(); break;

                case 4: Multiplicacao(); break;

                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;
            }


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Diga um valor para somar");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Diga o outro valor para somar");
            float valor2 = float.Parse(Console.ReadLine());
            float resultadoSoma = valor1 + valor2;

            // Console.WriteLine(valor1 + valor2);
            Console.WriteLine($"O valor da soma é:{resultadoSoma}");
            // Console.WriteLine($"O valor da soma é:{valor1 + valor2}");
            // Console.WriteLine($"O valor da soma é:" + (valor1 + valor2));
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Diga um valor para diminuir");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Diga o outro valor para diminuir");
            float valor2 = float.Parse(Console.ReadLine());
            float resultadoSubtracao = valor1 - valor2;


            Console.WriteLine($"O valor da soma é:{resultadoSubtracao}");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Diga um valor a ser divido");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Diga o valor divisor");
            float valor2 = float.Parse(Console.ReadLine());
            float resultadoDivisao = valor1 / valor2;


            Console.WriteLine($"O valor da soma é:{resultadoDivisao}");

            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor ai moral");
            float valor2 = float.Parse(Console.ReadLine());

            float resultadoMultiplicacao = valor1 * valor2;

            Console.WriteLine($"Valor da multiplicação: {resultadoMultiplicacao}");
            Console.ReadKey();

            Menu();
        }

    }
}

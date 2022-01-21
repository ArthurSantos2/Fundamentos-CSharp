using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();

            // decimal valor = 104544.25m;
            // Console.WriteLine(Math.Ceiling(valor));
            // Console.WriteLine(Math.Floor(valor));
            // Console.WriteLine(Math.Round(valor));

            // Console.WriteLine(valor.ToString(
            //     "C",
            //     CultureInfo.CreateSpecificCulture("pt-BR")));

            // ARRAY
            // var meuArray = new Teste[5];
            // meuArray[0] = new Teste();

            
            // var funcionarios = new Funcionario[5];
            // funcionarios[0] = new Funcionario() {Id = 2579, Nome="Chuchubeleza"};

            // foreach(var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Nome);
            //     Console.WriteLine(funcionario.Id);
            // }

            
            // tratamento de exceptions TRY CATCH

            var arr = new int[3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                //     //IndexOutOfRangeException
                //     Console.WriteLine(arr[index]);
                // }

                Cadastrar("fggfgf");

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice na lista");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("FALHA AO CADASTRAR O TEXTO!");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("falharapix!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Deu errado pcoQ!");
            }
            finally
            {
                Console.WriteLine("Finalizou!!!");
            }

          

        }
        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);

            
        }
        //herança
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu {get; set;}
        }




        // struct Funcionario
        // {
        //     public int Id {get; set;}

        //     public string Nome {get; set;}
        // }
    
    }

}

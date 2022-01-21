using System.Text;

namespace Strings
{
        class Program
        {
            static void Main(string[] args)
            {
            //boas praticas, uso do stringbuilder

            var text = new StringBuilder();
            text.Append("Este texto é um teste");
            text.Append("Este tete");
            text.Append("Em teste");
            text.Append("Este tem teste");

            text.ToString();
            // Console.WriteLine(text);



            //substituir texto ou dividir e substring e Trim para limpar
            //espaços

            var texto = " Esse texto é um teste ";
            // Console.WriteLine(text.Replace("Esse", "isto"));
            // Console.WriteLine(text.Replace("s", "m"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(5, 5);
            var resultadoo = texto.Substring(5, texto.LastIndexOf("o"));
            // Console.WriteLine(resultado);
            // Console.WriteLine(resultadoo);

            // Console.WriteLine(text.Trim());




            //ToLower e ToUpper e Insert e Lenght

            var textoLTIL = "Este texto é um teste";
            // Console.WriteLine(textoLTIL.ToLower());
            // Console.WriteLine(textoLTIL.ToUpper());
            // Console.WriteLine(textoLTIL.Insert(5, "AQUI "));
            // Console.WriteLine(textoLTIL.Remove(5, 5));
            // Console.WriteLine(textoLTIL.Length);


            // INDICES = INDEX feito para trabalhar com lista
            //não exclusivo para o string
            //um texto é uma lista de caracteres

            var textINDEX = "Este texto é um teste";
            // Console.WriteLine(textINDEX.IndexOf("é"));
            // Console.WriteLine(textINDEX.LastIndexOf("s"));



            // Uso do método EQUALS, esse funciona
            //quando o que está comparando é EXATAMENTE IGUAL
            //e funciona para outros tipos de objetos TODOS TIPOS
            //mas a comparação deve ser de objetos iguais

            var textEQUALS = "Esse teste é do equals";
            // Console.WriteLine(textEQUALS.Equals("Esse teste é do equals"));




            // Começa com e termina com. Para começa com: StartsWith
            // Para termina com: EndsWith

            var textSE = "Este texto é um teste";
            // Console.WriteLine(textSE.StartsWith("Este"));
            // Console.WriteLine(textSE.StartsWith("este"));
            // Console.WriteLine(textSE.StartsWith("texto"));

            // Console.WriteLine(textSE.EndsWith("teste"));
            // Console.WriteLine(textSE.EndsWith("Teste"));
            // Console.WriteLine(textSE.EndsWith("Este"));



            //Comparação de texto(STRINGS)

            var textSTRING = "Testando esse texto";
            // Console.WriteLine(textSTRING.CompareTo("Testando"));
            // Console.WriteLine(textSTRING.CompareTo("testando"));
            // Console.WriteLine(textSTRING.Contains("Testando"));
            // Console.WriteLine(textSTRING.Contains("testando"));
            // Console.WriteLine(textSTRING.Contains("testando", StringComparison.OrdinalIgnoreCase));
            // Console.WriteLine(textSTRING.Contains(null));



            //Interpolação de strings

            var price = 10.2;
            var textINTER = "O preço do produto é:" + price + ", apenas na promoção";
            var textFORMATADO = string.Format(
                 "O preço do produto é {1} apenas na promoção {0}",
                 price, true);

            // O arroba @ funciona para poder quebrar a linha 
            // e ter continuação
            // /n quebra linha
            // cifrão $ é para interpolação

            var textIN = @$"O preço
                do produto é {price} apenas na promoção";

            // Console.WriteLine(text);






            //USOS DO GUID

            var id = Guid.NewGuid(); //interessante para gerar chave temporária
            id.ToString();

            id = new Guid("93dcfea8-e3a7-44bf-b7f4-8df32e393b89");

            id = Guid.NewGuid();
            // Console.WriteLine(id.ToString().Substring(1, 8));
        }
    }    
    
}

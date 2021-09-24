using System;

namespace SovellusEsim1
{
    class Program
    {
        static string ohje = "0.Lopetus\n1.Lisää\n2.Listaa";

        static void Main(string[] args)
        {
            Sovellus app = new Sovellus();

            Console.WriteLine(ohje);
            string komento = Console.ReadLine();
            while (!komento.StartsWith("0"))   // ! tarkoittaa NOT
            {
                switch (komento)
                {
                    case "1":
                        Console.WriteLine("Anna työntekijän nimi");
                        var nimi = Console.ReadLine();

                        Console.WriteLine("Anna palkkatiedot");
                        var palkkatiedot = Console.ReadLine();
                        
                        var työntekijä = new Työntekijä(palkkatiedot,nimi);                        

                        app.LisääTyöntekijä(työntekijä);
                        break;

                    case "2":
                        Console.WriteLine(app.ListaaTyöntekijät());
                        break;

                    default:        // kaikissa muissa tapauksissa
                        break;
                }
                Console.WriteLine(ohje);
                komento = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum KRum = new KlasseRum();

            Studerende s1 = new Studerende("Hassan Raza Hussain", 4, 15);
            Studerende s2 = new Studerende("Ahmed Chad", 8, 29);
            Studerende s3  = new Studerende("Jeenes", 9, 26);

            KRum.SemesterStart = DateTime.Parse("2017,8, 28");
            KRum.KlasseNavn = "3F";

            KRum.KlasseListe.Add(s1);
            KRum.KlasseListe.Add(s2);
            KRum.KlasseListe.Add(s3);

            Console.WriteLine("Klassens navn er;");
            Console.WriteLine(KRum.KlasseNavn);
            Console.WriteLine("");
            Console.WriteLine("Semesteret starter følgende dato:");
            Console.WriteLine(KRum.SemesterStart);
            Console.WriteLine("");
            Console.WriteLine("De studerende er føglende:");

            foreach (var Studerende in KRum.KlasseListe )
            {
                Console.WriteLine(Studerende);
            }

            Console.WriteLine("");
            Console.WriteLine("Antal elever som har fødselsdag i hver årstid, er følgende:");

            KRum.Årstid();

            Console.ReadKey();
        }
    }
}

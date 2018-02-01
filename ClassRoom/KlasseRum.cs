using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    //INSTANCEFIELDS
    {
        private string _klasseNavn;
        private List<Studerende> _klasseListe;
        private DateTime _semesterStart;

        //DEFAULT CONSTRUCTOR
        public KlasseRum()
        {
            _klasseListe = new List<Studerende>();
        }
        //PROPERTIES
        public string KlasseNavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }

        }
        public List<Studerende> KlasseListe
        {
            get { return _klasseListe; }
            set { _klasseListe = value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }
        public void Årstid()
        {
            int Vinter = 0;
            int Forår = 0;
            int Sommer = 0;
            int Efterår = 0;

            foreach (var Studerende in KlasseListe)
            {
                if (Studerende.Årstid() == "Vinter")
                {
                    Vinter += 1;
                }

                if (Studerende.Årstid() == "Forår")
                {
                    Forår += 1;
                }

                if (Studerende.Årstid() == "Sommer")
                {
                    Sommer += 1;
                }

                if (Studerende.Årstid() == "Efterår")
                {
                    Efterår += 1;
                }

            }
            Console.WriteLine($"Vinter perioden: {Vinter}");
            Console.WriteLine($"Foråret: {Forår}");
            Console.WriteLine($"Sommer perioden: {Sommer}");
            Console.WriteLine($"Efteråret {Efterår}");

        }

            public override string ToString()
        {
            return $"{ KlasseNavn}  { KlasseListe} { SemesterStart}"; 
        }
    }
}







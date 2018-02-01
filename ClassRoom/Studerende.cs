using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {

        //INSTANCEFIELDS
        string _navn;
        int _fødselsmåned;
        int _fødselsdag;


        //CONSTRUCTOR
        public Studerende(String Navn, int Fødselsmåned, int Fødselsdag)
        {
            Navn = _navn;
            Fødselsmåned = _fødselsmåned;
            Fødselsdag = _fødselsdag;
        }

        //PROPERTIES
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned = value; }
        }

        public int Fødselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag = value; }
        }

        public string Årstid()
        { 
            if (Fødselsdag == 12 || Fødselsdag == 1 || Fødselsdag == 2)
            {
            return "Vinter";
            }

            else if (Fødselsdag == 3 || Fødselsdag == 4 || Fødselsdag == 5)
            {
            return "Forår";

            }
              else if (Fødselsdag == 6 || Fødselsdag == 7 || Fødselsdag == 8)
            {
            return "Sommer";

            }
              else if (Fødselsdag == 9 || Fødselsdag == 10 || Fødselsdag == 11)
            {
            return "Efterår";
            }
        return "";
        } 

        public override string ToString()
        {
            return $"{Navn} {Fødselsmåned} {Fødselsdag}";
        }
    }
}

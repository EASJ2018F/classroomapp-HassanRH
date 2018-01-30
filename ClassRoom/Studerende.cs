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
        public string Navn { get; set; }
        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned = value;}
        }
   
        public int Fødselsdag
        {
            get { return _fødselsdag;}
            set { _fødselsdag = value; }
        }
            
    }
}

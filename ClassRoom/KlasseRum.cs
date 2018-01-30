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
        private string _klassenavn;
        private List<Studerende> _klasseliste;
        private DateTime _semesterstart;

        //CONSTRUCTOR
        public KlasseRum(String KlasseNavn, List<Studerende> KlasseList, DateTime SemesterStart)

        {
            KlasseNavn = _klassenavn;
            KlasseList = _klasseliste;
            SemesterStart = _semesterstart;
        }
        //PROPERTIES
        public string Klassenavn
        {
            get { return _klassenavn; }
            set { _klassenavn = value; }

        }
        public List<Studerende> klasseliste
        {
            get { return _klasseliste; }
            set { _klasseliste = value; }
        }

        public DateTime semesterstart
        {
            get { return _semesterstart; }
            set { _semesterstart = value; }
        }

    }
}







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
            var studentList = new List<Studerende>
            {
                new Studerende("Sebastian", 01, 18),
                new Studerende("Kevin", 05, 20),
                new Studerende("Michael", 08, 17)
            };

            var klasseRum = new KlasseRum("3B", studentList, new DateTime(2018,04,09));

            var sf = 0;
            var ss = 0;
            var se = 0;
            var sv = 0;

            foreach (var studerende in klasseRum.ClassList)
            {
                if (Årstid(studerende) == "Forår")
                {
                    sf++;
                }
                if (Årstid(studerende) == "Sommer")
                {
                    ss++;
                }
                if (Årstid(studerende) == "Efterår")
                {
                    se++;
                }
                if (Årstid(studerende) == "Vinter")
                {
                    sv++;
                }
            }

            Console.WriteLine(klasseRum);
            Console.WriteLine($"I klassen er der {sf} der har fødselsdag om foråret");
            Console.WriteLine($"I klassen er der {ss} der har fødselsdag om sommeren");
            Console.WriteLine($"I klassen er der {se} der har fødselsdag om efteråret");
            Console.WriteLine($"I klassen er der {sv} der har fødselsdag om vinteren");
            Console.ReadKey();


        }
        public static string Årstid(Studerende s)
        {
            if (s.BirthdayMonth >= 3 && s.BirthdayMonth <= 5)
            {
                return "Forår";
            }

            if (s.BirthdayMonth >= 6 && s.BirthdayMonth <= 8)
            {
                return "Sommer";
            }

            if (s.BirthdayMonth >= 9 && s.BirthdayMonth <= 11)
            {
                return "Efterår";
            }

            if (s.BirthdayMonth >= 12 || s.BirthdayMonth == 1 || s.BirthdayMonth == 2)
            {
                return "Vinter";
            }

            return "ERROR! Date out of bounds";
        }
    }
}

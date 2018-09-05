using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Name { get; set; }
        public int BirthdayMonth { get; set; }
        public int Birthday { get; set; }

        public Studerende(string name, int birthdayMonth, int birthday)
        {
            Name = name;
            BirthdayMonth = birthdayMonth;
            Birthday = birthday;
        }



        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(BirthdayMonth)}: {BirthdayMonth}, {nameof(Birthday)}: {Birthday}";
        }
    }
}

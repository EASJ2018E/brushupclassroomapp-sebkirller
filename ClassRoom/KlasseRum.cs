using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string ClassName { get; set; }
        public List<Studerende> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }

        public KlasseRum(string className, List<Studerende> classList, DateTime semesterStart)
        {
            ClassName = className;
            ClassList = classList;
            SemesterStart = semesterStart;
        }

        public override string ToString()
        {
            return $"{nameof(ClassName)}: {ClassName}, {nameof(ClassList)}: {"Liste over studerende"}, {nameof(SemesterStart)}: {SemesterStart}";
        }
    }
}

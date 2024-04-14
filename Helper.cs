using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.classes
{
    static class Helper
    {
        public static bool IsName(string name)
        {
            if (name.Length < 3)
                return false;

            if (!char.IsUpper(name[0]))
                return false;

            return true;
        }

        public static bool IsSurname(string surname)
        {
            return IsName(surname);
        }

        public static bool IsClassroomName(string className)
        {
            return className.Length == 3 && char.IsUpper(className[0]) && char.IsUpper(className[1]) && char.IsUpper(className[2]);
        }

    }
}

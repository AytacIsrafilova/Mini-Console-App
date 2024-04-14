using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    internal class Helper
    {
        public static bool ValidateName(string name)
        {
            return !string.IsNullOrEmpty(name) && char.IsUpper(name[0]) && name.Length >= 3 && name.Split(' ').Length == 1;
        }

        public static bool ValidateSurname(string surname)
        {
            return !string.IsNullOrEmpty(surname) && char.IsUpper(surname[0]) && surname.Length >= 3 && surname.Split(' ').Length == 1;
        }

        public static bool ValidateClassroomName(string className)
        {
            return className.Length == 5 &&
                   char.IsUpper(className[0]) &&
                   char.IsUpper(className[1]) &&
                   char.IsDigit(className[2]) &&
                   char.IsDigit(className[3]) &&
                   char.IsDigit(className[4]);
        }
    }

}


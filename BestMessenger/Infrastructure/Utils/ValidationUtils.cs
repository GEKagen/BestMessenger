using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMessenger.Infrastructure.Utils
{
    public static class ValidationUtils
    {

        public static bool NameValidate(string value)
        {
            if (value.Length == 0)
            {
                return false;
            }
            foreach (var item in value)
            {
                if (Char.IsDigit(item) == true )
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EmailValidate(string value)
        {
            return true;
        }
        public static bool PasswordValidate(string value)
        {
            return true;
        }

    }
}

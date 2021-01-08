using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
    class MyValidation
    {
        public static bool IsValidLength(string txt, int min, int max)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txt))
                isValid = false;
            else if (txt.Length < min || txt.Length > max)
                isValid = false;

            return isValid;
        }

        public static bool IsValidLetterLength(string txt, int min, int max)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txt))
                isValid = false;
            else if (txt.Length < min || txt.Length > max)
                isValid = false;

            for (int i = 0; i < txt.Length; i++)
            {
                if (!(char.IsLetter(txt[i])))
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        public static bool IsValidNumber(string txt)
        {
            bool isValid = true;

            for (int i = 0; i < txt.Length; i++)
            {
                if (!(char.IsNumber(txt[i])))
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        public static bool IsValidLetter(string txt)      //allows alphabetic characters
        {
            bool isValid = true;

            if (txt.Trim().Length == 0)
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsLetter(txt[i])))
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        public static bool IsValidLetterNumberWhitespace(string txt)      //allows alphanumeric and whitespace
        {
            bool isValid = true;

            if (txt.Trim().Length == 0)
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsLetter(txt[i])) && !(char.IsWhiteSpace(txt[i])) && !(char.IsNumber(txt[i])))
                        isValid = false;
                }
            }

            return isValid;
        }

        public static bool IsValidPrice(double price)
        {
            bool isValid = true;

            if (price >= 0.00)
            {

            }

            return isValid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoldenSphinx
{
    class MyException : Exception
    {
        private string message;

        public MyException(String message)
        {
            this.message = message;
        }

        public override string ToString()
        {
            return String.Format("Error: {0} ", message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sopTest
{
    public class Read
    {
        public String Opinion(String whatToRead)
        {
            if (whatToRead.Length < 5)
            {
                return "SHORT";
            }
            else
            {
                return "GOOD";
            }
        }
    }
}

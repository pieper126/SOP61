using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sopTest
{
    public class Write
    {
        public String WriteVerse(String subject)
        {
            if (subject.Length > 5)
            {
                return "this is long";
            }
            else
            {
                return "this is short";
            }
        }
    }
}

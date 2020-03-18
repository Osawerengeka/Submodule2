using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submodule2
{
    class stringB
    {
        public string merge(string[] s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                res += " " + s[i];

            }
            return res;
        
        }

    }
}

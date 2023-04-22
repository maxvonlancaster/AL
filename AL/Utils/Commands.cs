using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL.Utils
{
    public static class Commands
    {
        public static Hashtable CommandHashTable = new Hashtable() 
        {
            {"features", () => { } }
        };
    }
}

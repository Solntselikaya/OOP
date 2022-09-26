using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Cell
    {
        private bool busy = false;

        public bool isFree()
        {
            if (busy == true)
            {
                return true;
            }
            return false;
        }
    }
}

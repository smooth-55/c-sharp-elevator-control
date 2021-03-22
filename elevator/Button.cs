using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    class Button
    {
        int fNumber;
        public Button(int floorNum)
        {
            fNumber = floorNum;
        }

        public int floorNumbers()
        {
            return fNumber;
        }
    }
}

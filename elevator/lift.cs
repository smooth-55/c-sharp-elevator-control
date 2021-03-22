using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevator
{
    class lift
    {

        public void lift_up(PictureBox lift)
        {
            if (lift.Top > 40)
            {
                lift.Top -= 1; //elevator goes up
            }
        }

        public void lift_down(PictureBox lift)
        {
            if (lift.Top < 288)
            {
                lift.Top += 1; // elevator goes down
            }
        }


    }
}

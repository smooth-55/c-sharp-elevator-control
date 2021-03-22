using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevator
{
    class door
    {

        public void door_close(PictureBox leftDoor, PictureBox rightDoor, int floorNum)
        {
            if (floorNum == 1 && leftDoor.Left <= 57 && rightDoor.Left >= 116)
            {
                leftDoor.Left += 1; //shifts door to right with 1 increment
                rightDoor.Left -= 1;// shifts door to left with 1 decrement

            }

            else if (floorNum == 0 && leftDoor.Left <= 57 && rightDoor.Left >= 116)
            {
                leftDoor.Left += 1; //shifts door to right with 1 increment
                rightDoor.Left -= 1;// shifts door to left with 1 decrement
            }

        }

        public void door_open(PictureBox leftDoor, PictureBox rightDoor, int floorNum )
        {
            if (floorNum == 1 && leftDoor.Left >= 1 && rightDoor.Left <= 171)
            {
                leftDoor.Left -= 1;
                rightDoor.Left += 1;
            }


            else if (floorNum == 0 && leftDoor.Left >= 1 && rightDoor.Left <= 171)
            {
                leftDoor.Left -= 1;
                rightDoor.Left += 1;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevator
{
    public partial class windowApp : Form
    {

        bool go_down = false;
        bool go_up = false;

        bool atGround = false;
        bool atFirst = true;
        int count = 0;

        door doo = new door();
        lift lft = new lift();
        Button b = new Button(1);
        Query dc = new Query();



        public windowApp()
        {
            InitializeComponent();
        }

        private void dwnArr_Click(object sender, EventArgs e)
        {

            doorOpen.Enabled = true;
            doorClose.Enabled = true;
            btn_ground_floor.Enabled = true;
            btn_first_floor.Enabled = true;
            upArr.BackColor = Color.White;
            dwnArr.BackColor = Color.Red;

            if (atGround == true)
            {
                go_up = true;
            }
            else if (atFirst == true)
            {
                timerOpenDoor1.Enabled = true;

            }

            timerCloseDoor2.Enabled = true;
            atGround = false;


        }

        private void upArr_Click(object sender, EventArgs e)
        {
            upArr.BackColor = Color.Red;
            go_down = true;

            timerCloseDoor1.Enabled = true;
            timerOpenDoor1.Enabled = false;
            atFirst = false;

            dwnArr.Enabled = true;

            btn_first_floor.Enabled = true;
            btn_ground_floor.Enabled = true;

        }

        private void timerOpenDoor1_Tick(object sender, EventArgs e)
        {
            if (doorLeft1.Left > 1 && doorRight1.Left < 171)
            {
                doo.door_open(doorLeft1, doorRight1, 1);
            }
            else
            {
                timerAutoCloseDoor.Enabled = true;
                dc.insertdata("First Floor Door Opened!");
                viewData();
                timerOpenDoor1.Enabled = false;
                upArr.Enabled = true;
            }

        }


        private void timerCloseDoor1_Tick(object sender, EventArgs e)
        {
            if (doorLeft1.Left < 57 && doorRight1.Left > 116)
            {
                doo.door_close(doorLeft1, doorRight1, 1); //sends the parameter to the Door class

            }
            else
            {
                dwnArr.BackColor = Color.White;
                timerAutoCloseDoor.Enabled = false;
                count = 0;
                dc.insertdata("First Floor Door Closed!");
                viewData();
                timerCloseDoor1.Enabled = false;

                if (go_down == true)

                {
                    dc.insertdata("Elevator moving down!");
                    viewData();
                    timerAutoCloseDoor.Enabled = false;

                    btn_first_floor.Enabled = false;
                    btn_ground_floor.Enabled = false;
                    doorClose.Enabled = false;
                    doorOpen.Enabled = false;
                    mainDisplay.BackgroundImage = Properties.Resources.downarrow;
                    display1.BackgroundImage = Properties.Resources.downarrow;
                    display2.BackgroundImage = Properties.Resources.downarrow;
                    timerLiftDown.Enabled = true;
                    go_down = false;


                }
            }
        }

        private void timerOpenDoor2_Tick(object sender, EventArgs e)
        {

            if (doorLeft2.Left > 1 && doorRight2.Left < 171)
            {
                doo.door_open(doorLeft2, doorRight2, 0);

            }
            else
            {
                timerAutoCloseDoor.Enabled = true;
                dc.insertdata("Ground Floor Door Opened!");
                viewData();
                timerOpenDoor2.Enabled = false;
                dwnArr.Enabled = true;

            }

        }

        private void timerCloseDoor2_Tick(object sender, EventArgs e)
        {
            if (doorLeft2.Left < 57 && doorRight2.Left > 116)
            {
                doo.door_close(doorLeft2, doorRight2, 0);

            }
            else
            {
                upArr.BackColor = Color.White;
                timerAutoCloseDoor.Enabled = false;
                count = 0;
                timerCloseDoor2.Enabled = false;
                dc.insertdata("Ground Floor Door closed!");
                viewData();

                if (go_up == true)
                {
                    dc.insertdata("Elevator moving up!");
                    viewData();
                    timerOpenDoor1.Enabled = false;

                    mainDisplay.BackgroundImage = global::elevator.Properties.Resources.uparrow;
                    display1.BackgroundImage = global::elevator.Properties.Resources.uparrow;
                    display2.BackgroundImage = global::elevator.Properties.Resources.uparrow;
                    doorClose.Enabled = false;
                    doorOpen.Enabled = false;
                    btn_ground_floor.Enabled = false;
                    btn_first_floor.Enabled = false;
                    timerLiftUP.Enabled = true;
                    go_up = false;

                }

            }
        }

        private void timerLiftDown_Tick(object sender, EventArgs e)
        {

            try
            {
                if (lift.Top < 288)
                {
                    lft.lift_down(lift);
                }
                else
                {
                    timerLiftDown.Enabled = false;
                    // b = new Button(0);
                    mainDisplay.BackgroundImage = global::elevator.Properties.Resources.G;
                    display1.BackgroundImage = global::elevator.Properties.Resources.G;
                    display2.BackgroundImage = global::elevator.Properties.Resources.G;
                    timerLiftUP.Enabled = false;
                    dwnArr.Enabled = true;
                    btn_first_floor.Enabled = true;
                    doorOpen.Enabled = true;
                    doorClose.Enabled = true;
                    timerOpenDoor2.Enabled = true;
                    timerCloseDoor2.Enabled = false;
                    atGround = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void timerLiftUP_Tick(object sender, EventArgs e)
        {

            try
            {
                if (lift.Top > 40)
                {
                    lft.lift_up(lift);
                }
                else
                {
                    timerLiftUP.Enabled = false;
                    b = new Button(1);
                    mainDisplay.BackgroundImage = global::elevator.Properties.Resources.one;
                    display1.BackgroundImage = global::elevator.Properties.Resources.one;
                    display2.BackgroundImage = global::elevator.Properties.Resources.one;
                    upArr.Enabled = true;
                    btn_ground_floor.Enabled = true;
                    doorOpen.Enabled = true;
                    doorClose.Enabled = true;
                    timerOpenDoor1.Enabled = true;
                    timerCloseDoor1.Enabled = false;
                    atFirst = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_first_floor_Click(object sender, EventArgs e)
        {
            atGround = false;
            go_up = true;
            timerCloseDoor2.Enabled = true;
            timerOpenDoor2.Enabled = false;
        }

        private void btn_ground_floor_Click(object sender, EventArgs e)
        {
            atGround = false;
            go_down = true;
            timerCloseDoor1.Enabled = true;
            timerOpenDoor1.Enabled = false;
            dwnArr.Enabled = false;


        }

        private void timerAutoCloseDoor_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= 150 && atFirst == true)
            {
                timerCloseDoor1.Enabled = true;

            }
            else if (count >= 150 && atGround == true)
            {
                timerCloseDoor2.Enabled = true;
            }
        }

        private void doorOpen_Click(object sender, EventArgs e)
        {

            if (atGround == true)
            {
                timerOpenDoor2.Enabled = true;
                timerCloseDoor2.Enabled = false;
            }
            else if (atFirst == true)
            {
                timerOpenDoor1.Enabled = true;
                timerCloseDoor1.Enabled = false;
            }
        }

        private void doorClose_Click(object sender, EventArgs e)
        {
            if (atGround == true)
            {
                timerCloseDoor2.Enabled = true;
                timerOpenDoor2.Enabled = false;
                timerAutoCloseDoor.Enabled = true;

            }
            else if (atFirst == true)
            {
                timerCloseDoor1.Enabled = true;
                timerOpenDoor1.Enabled = false;
            }
        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            timerOpenDoor1.Enabled = true;
            timerOpenDoor2.Enabled = true;
            timerLiftDown.Enabled = false;
            timerLiftUP.Enabled = false;

            dc.insertdata("Emergency !!");
            viewData();
        }

        private void windowApp_Load(object sender, EventArgs e)
        {
            database.DbConnection();
        }

        public void viewData()
        {
            try
            {
                Query dc = new Query();
                DataTable dt = dc.ViewLog();
                dataGridView1.DataSource = dt;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Log is not Available !!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.clear();
            viewData();
        }
    }
}

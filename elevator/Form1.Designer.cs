namespace elevator
{
    partial class windowApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowApp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.liftFrame1 = new System.Windows.Forms.PictureBox();
            this.lift = new System.Windows.Forms.PictureBox();
            this.doorLeft1 = new System.Windows.Forms.PictureBox();
            this.doorRight1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.liftFrame2 = new System.Windows.Forms.PictureBox();
            this.doorRight2 = new System.Windows.Forms.PictureBox();
            this.doorLeft2 = new System.Windows.Forms.PictureBox();
            this.btn_first_floor = new System.Windows.Forms.Button();
            this.mainDisplay = new System.Windows.Forms.PictureBox();
            this.display1 = new System.Windows.Forms.PictureBox();
            this.display2 = new System.Windows.Forms.PictureBox();
            this.btn_ground_floor = new System.Windows.Forms.Button();
            this.upArr = new System.Windows.Forms.Button();
            this.dwnArr = new System.Windows.Forms.Button();
            this.doorOpen = new System.Windows.Forms.Button();
            this.doorClose = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerOpenDoor1 = new System.Windows.Forms.Timer(this.components);
            this.timerCloseDoor1 = new System.Windows.Forms.Timer(this.components);
            this.timerOpenDoor2 = new System.Windows.Forms.Timer(this.components);
            this.timerCloseDoor2 = new System.Windows.Forms.Timer(this.components);
            this.timerLiftUP = new System.Windows.Forms.Timer(this.components);
            this.timerLiftDown = new System.Windows.Forms.Timer(this.components);
            this.timerAutoCloseDoor = new System.Windows.Forms.Timer(this.components);
            this.btn_alarm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftFrame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Location = new System.Drawing.Point(33, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // liftFrame1
            // 
            this.liftFrame1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liftFrame1.BackgroundImage")));
            this.liftFrame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liftFrame1.Location = new System.Drawing.Point(40, 17);
            this.liftFrame1.Margin = new System.Windows.Forms.Padding(2);
            this.liftFrame1.Name = "liftFrame1";
            this.liftFrame1.Size = new System.Drawing.Size(152, 221);
            this.liftFrame1.TabIndex = 1;
            this.liftFrame1.TabStop = false;
            // 
            // lift
            // 
            this.lift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lift.BackgroundImage")));
            this.lift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lift.Location = new System.Drawing.Point(57, 40);
            this.lift.Margin = new System.Windows.Forms.Padding(2);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(118, 198);
            this.lift.TabIndex = 2;
            this.lift.TabStop = false;
            // 
            // doorLeft1
            // 
            this.doorLeft1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorLeft1.BackgroundImage")));
            this.doorLeft1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft1.Location = new System.Drawing.Point(57, 40);
            this.doorLeft1.Margin = new System.Windows.Forms.Padding(2);
            this.doorLeft1.Name = "doorLeft1";
            this.doorLeft1.Size = new System.Drawing.Size(61, 198);
            this.doorLeft1.TabIndex = 3;
            this.doorLeft1.TabStop = false;
            // 
            // doorRight1
            // 
            this.doorRight1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorRight1.BackgroundImage")));
            this.doorRight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight1.Location = new System.Drawing.Point(116, 40);
            this.doorRight1.Margin = new System.Windows.Forms.Padding(2);
            this.doorRight1.Name = "doorRight1";
            this.doorRight1.Size = new System.Drawing.Size(58, 198);
            this.doorRight1.TabIndex = 3;
            this.doorRight1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox2.Location = new System.Drawing.Point(33, 254);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 240);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // liftFrame2
            // 
            this.liftFrame2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liftFrame2.BackgroundImage")));
            this.liftFrame2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liftFrame2.Location = new System.Drawing.Point(40, 265);
            this.liftFrame2.Margin = new System.Windows.Forms.Padding(2);
            this.liftFrame2.Name = "liftFrame2";
            this.liftFrame2.Size = new System.Drawing.Size(152, 221);
            this.liftFrame2.TabIndex = 1;
            this.liftFrame2.TabStop = false;
            // 
            // doorRight2
            // 
            this.doorRight2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorRight2.BackgroundImage")));
            this.doorRight2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight2.Location = new System.Drawing.Point(116, 288);
            this.doorRight2.Margin = new System.Windows.Forms.Padding(2);
            this.doorRight2.Name = "doorRight2";
            this.doorRight2.Size = new System.Drawing.Size(58, 198);
            this.doorRight2.TabIndex = 3;
            this.doorRight2.TabStop = false;
            // 
            // doorLeft2
            // 
            this.doorLeft2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorLeft2.BackgroundImage")));
            this.doorLeft2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft2.Location = new System.Drawing.Point(57, 288);
            this.doorLeft2.Margin = new System.Windows.Forms.Padding(2);
            this.doorLeft2.Name = "doorLeft2";
            this.doorLeft2.Size = new System.Drawing.Size(61, 198);
            this.doorLeft2.TabIndex = 3;
            this.doorLeft2.TabStop = false;
            // 
            // btn_first_floor
            // 
            this.btn_first_floor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_first_floor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_first_floor.BackgroundImage")));
            this.btn_first_floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_first_floor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_first_floor.Enabled = false;
            this.btn_first_floor.Location = new System.Drawing.Point(329, 226);
            this.btn_first_floor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_first_floor.Name = "btn_first_floor";
            this.btn_first_floor.Size = new System.Drawing.Size(40, 36);
            this.btn_first_floor.TabIndex = 4;
            this.btn_first_floor.UseVisualStyleBackColor = false;
            this.btn_first_floor.Click += new System.EventHandler(this.btn_first_floor_Click);
            // 
            // mainDisplay
            // 
            this.mainDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainDisplay.BackgroundImage")));
            this.mainDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainDisplay.Location = new System.Drawing.Point(297, 169);
            this.mainDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(44, 51);
            this.mainDisplay.TabIndex = 5;
            this.mainDisplay.TabStop = false;
            // 
            // display1
            // 
            this.display1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("display1.BackgroundImage")));
            this.display1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.display1.Location = new System.Drawing.Point(196, 56);
            this.display1.Margin = new System.Windows.Forms.Padding(2);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(37, 45);
            this.display1.TabIndex = 5;
            this.display1.TabStop = false;
            // 
            // display2
            // 
            this.display2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("display2.BackgroundImage")));
            this.display2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.display2.Location = new System.Drawing.Point(196, 306);
            this.display2.Margin = new System.Windows.Forms.Padding(2);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(37, 46);
            this.display2.TabIndex = 5;
            this.display2.TabStop = false;
            // 
            // btn_ground_floor
            // 
            this.btn_ground_floor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ground_floor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ground_floor.BackgroundImage")));
            this.btn_ground_floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ground_floor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ground_floor.Enabled = false;
            this.btn_ground_floor.Location = new System.Drawing.Point(276, 226);
            this.btn_ground_floor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ground_floor.Name = "btn_ground_floor";
            this.btn_ground_floor.Size = new System.Drawing.Size(40, 36);
            this.btn_ground_floor.TabIndex = 4;
            this.btn_ground_floor.UseVisualStyleBackColor = false;
            this.btn_ground_floor.Click += new System.EventHandler(this.btn_ground_floor_Click);
            // 
            // upArr
            // 
            this.upArr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upArr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upArr.BackgroundImage")));
            this.upArr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upArr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upArr.Location = new System.Drawing.Point(196, 377);
            this.upArr.Margin = new System.Windows.Forms.Padding(2);
            this.upArr.Name = "upArr";
            this.upArr.Size = new System.Drawing.Size(37, 32);
            this.upArr.TabIndex = 4;
            this.upArr.UseVisualStyleBackColor = false;
            this.upArr.Click += new System.EventHandler(this.upArr_Click);
            // 
            // dwnArr
            // 
            this.dwnArr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dwnArr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dwnArr.BackgroundImage")));
            this.dwnArr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dwnArr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dwnArr.Location = new System.Drawing.Point(196, 131);
            this.dwnArr.Margin = new System.Windows.Forms.Padding(2);
            this.dwnArr.Name = "dwnArr";
            this.dwnArr.Size = new System.Drawing.Size(33, 32);
            this.dwnArr.TabIndex = 4;
            this.dwnArr.UseVisualStyleBackColor = false;
            this.dwnArr.Click += new System.EventHandler(this.dwnArr_Click);
            // 
            // doorOpen
            // 
            this.doorOpen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doorOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorOpen.BackgroundImage")));
            this.doorOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doorOpen.Enabled = false;
            this.doorOpen.Location = new System.Drawing.Point(276, 277);
            this.doorOpen.Margin = new System.Windows.Forms.Padding(2);
            this.doorOpen.Name = "doorOpen";
            this.doorOpen.Size = new System.Drawing.Size(40, 36);
            this.doorOpen.TabIndex = 4;
            this.doorOpen.UseVisualStyleBackColor = false;
            this.doorOpen.Click += new System.EventHandler(this.doorOpen_Click);
            // 
            // doorClose
            // 
            this.doorClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doorClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doorClose.BackgroundImage")));
            this.doorClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doorClose.Enabled = false;
            this.doorClose.Location = new System.Drawing.Point(329, 277);
            this.doorClose.Margin = new System.Windows.Forms.Padding(2);
            this.doorClose.Name = "doorClose";
            this.doorClose.Size = new System.Drawing.Size(40, 36);
            this.doorClose.TabIndex = 4;
            this.doorClose.UseVisualStyleBackColor = false;
            this.doorClose.Click += new System.EventHandler(this.doorClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(263, 161);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 248);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // timerOpenDoor1
            // 
            this.timerOpenDoor1.Interval = 5;
            this.timerOpenDoor1.Tick += new System.EventHandler(this.timerOpenDoor1_Tick);
            // 
            // timerCloseDoor1
            // 
            this.timerCloseDoor1.Interval = 5;
            this.timerCloseDoor1.Tick += new System.EventHandler(this.timerCloseDoor1_Tick);
            // 
            // timerOpenDoor2
            // 
            this.timerOpenDoor2.Interval = 5;
            this.timerOpenDoor2.Tick += new System.EventHandler(this.timerOpenDoor2_Tick);
            // 
            // timerCloseDoor2
            // 
            this.timerCloseDoor2.Interval = 5;
            this.timerCloseDoor2.Tick += new System.EventHandler(this.timerCloseDoor2_Tick);
            // 
            // timerLiftUP
            // 
            this.timerLiftUP.Interval = 5;
            this.timerLiftUP.Tick += new System.EventHandler(this.timerLiftUP_Tick);
            // 
            // timerLiftDown
            // 
            this.timerLiftDown.Interval = 5;
            this.timerLiftDown.Tick += new System.EventHandler(this.timerLiftDown_Tick);
            // 
            // timerAutoCloseDoor
            // 
            this.timerAutoCloseDoor.Interval = 5;
            this.timerAutoCloseDoor.Tick += new System.EventHandler(this.timerAutoCloseDoor_Tick);
            // 
            // btn_alarm
            // 
            this.btn_alarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_alarm.BackgroundImage")));
            this.btn_alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alarm.Location = new System.Drawing.Point(294, 335);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(75, 62);
            this.btn_alarm.TabIndex = 6;
            this.btn_alarm.Text = "Alarm";
            this.btn_alarm.UseVisualStyleBackColor = true;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 357);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(594, 445);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 41);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Detail Log";
            // 
            // windowApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_alarm);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.upArr);
            this.Controls.Add(this.doorRight2);
            this.Controls.Add(this.doorLeft2);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.dwnArr);
            this.Controls.Add(this.doorLeft1);
            this.Controls.Add(this.doorRight1);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.liftFrame1);
            this.Controls.Add(this.mainDisplay);
            this.Controls.Add(this.btn_ground_floor);
            this.Controls.Add(this.doorClose);
            this.Controls.Add(this.doorOpen);
            this.Controls.Add(this.btn_first_floor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.liftFrame2);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "windowApp";
            this.Text = "elevator-App";
            this.Load += new System.EventHandler(this.windowApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftFrame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox liftFrame1;
        private System.Windows.Forms.PictureBox lift;
        private System.Windows.Forms.PictureBox doorLeft1;
        private System.Windows.Forms.PictureBox doorRight1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox liftFrame2;
        private System.Windows.Forms.PictureBox doorRight2;
        private System.Windows.Forms.PictureBox doorLeft2;
        private System.Windows.Forms.Button btn_first_floor;
        private System.Windows.Forms.PictureBox mainDisplay;
        private System.Windows.Forms.PictureBox display1;
        private System.Windows.Forms.PictureBox display2;
        private System.Windows.Forms.Button btn_ground_floor;
        private System.Windows.Forms.Button upArr;
        private System.Windows.Forms.Button dwnArr;
        private System.Windows.Forms.Button doorOpen;
        private System.Windows.Forms.Button doorClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerOpenDoor1;
        private System.Windows.Forms.Timer timerCloseDoor1;
        private System.Windows.Forms.Timer timerOpenDoor2;
        private System.Windows.Forms.Timer timerCloseDoor2;
        private System.Windows.Forms.Timer timerLiftUP;
        private System.Windows.Forms.Timer timerLiftDown;
        private System.Windows.Forms.Timer timerAutoCloseDoor;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}


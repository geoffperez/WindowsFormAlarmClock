using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ClassLibrary1;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();
        int interval = 1000;



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
            this.AlarmList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddAlarm = new System.Windows.Forms.Button();
            this.SetTime = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.Seconds = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SnoozePeriod = new System.Windows.Forms.NumericUpDown();
            this.SimulationControl = new System.Windows.Forms.NumericUpDown();
            this.ShowTime = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ALARMOFF = new System.Windows.Forms.Button();
            this.SnoozeAlarm = new System.Windows.Forms.Button();
            this.DisplayMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SnoozePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationControl)).BeginInit();
            this.SuspendLayout();
            // 
            // AlarmList
            // 
            this.AlarmList.FormattingEnabled = true;
            this.AlarmList.Location = new System.Drawing.Point(599, 52);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Size = new System.Drawing.Size(111, 212);
            this.AlarmList.TabIndex = 0;
            this.AlarmList.Tag = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alarms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SNOOZE PERIOD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter New Alarm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Text";
            // 
            // AddAlarm
            // 
            this.AddAlarm.Location = new System.Drawing.Point(128, 385);
            this.AddAlarm.Name = "AddAlarm";
            this.AddAlarm.Size = new System.Drawing.Size(98, 25);
            this.AddAlarm.TabIndex = 10;
            this.AddAlarm.Text = "ALARM";
            this.AddAlarm.UseVisualStyleBackColor = true;
            this.AddAlarm.Click += new System.EventHandler(this.AddAlarm_Click);
            this.AddAlarm.MouseHover += new System.EventHandler(this.ToolTip);
            // 
            // SetTime
            // 
            this.SetTime.Location = new System.Drawing.Point(297, 385);
            this.SetTime.Name = "SetTime";
            this.SetTime.Size = new System.Drawing.Size(98, 25);
            this.SetTime.TabIndex = 11;
            this.SetTime.Text = "SET TIME";
            this.SetTime.UseVisualStyleBackColor = true;
            this.SetTime.Click += new System.EventHandler(this.SetTime_Click);
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(128, 242);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(77, 20);
            this.Hours.TabIndex = 12;
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(128, 276);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(77, 20);
            this.Minutes.TabIndex = 13;
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(128, 308);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(77, 20);
            this.Seconds.TabIndex = 14;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(128, 343);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(168, 20);
            this.Output.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Current Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "  Hours:     Minutes :  Seconds";
            // 
            // SnoozePeriod
            // 
            this.SnoozePeriod.Location = new System.Drawing.Point(313, 240);
            this.SnoozePeriod.Name = "SnoozePeriod";
            this.SnoozePeriod.Size = new System.Drawing.Size(106, 20);
            this.SnoozePeriod.TabIndex = 21;
            this.SnoozePeriod.MouseHover += new System.EventHandler(this.ToolTip);
            // 
            // SimulationControl
            // 
            this.SimulationControl.Location = new System.Drawing.Point(684, 414);
            this.SimulationControl.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SimulationControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SimulationControl.Name = "SimulationControl";
            this.SimulationControl.Size = new System.Drawing.Size(94, 20);
            this.SimulationControl.TabIndex = 22;
            this.SimulationControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SimulationControl.ValueChanged += new System.EventHandler(this.simulationControl);
            this.SimulationControl.MouseHover += new System.EventHandler(this.ToolTip);
            // 
            // ShowTime
            // 
            this.ShowTime.AutoSize = true;
            this.ShowTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTime.ForeColor = System.Drawing.Color.Black;
            this.ShowTime.Location = new System.Drawing.Point(145, 80);
            this.ShowTime.Name = "ShowTime";
            this.ShowTime.Size = new System.Drawing.Size(0, 43);
            this.ShowTime.TabIndex = 23;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(659, 266);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(51, 23);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.AlarmDelete);
            this.DeleteButton.MouseHover += new System.EventHandler(this.ToolTip);
            // 
            // ALARMOFF
            // 
            this.ALARMOFF.Location = new System.Drawing.Point(131, 168);
            this.ALARMOFF.Name = "ALARMOFF";
            this.ALARMOFF.Size = new System.Drawing.Size(79, 28);
            this.ALARMOFF.TabIndex = 26;
            this.ALARMOFF.Text = "Alarm Off";
            this.ALARMOFF.UseVisualStyleBackColor = true;
            this.ALARMOFF.Click += new System.EventHandler(this.AlarmOff);
            // 
            // SnoozeAlarm
            // 
            this.SnoozeAlarm.Location = new System.Drawing.Point(297, 168);
            this.SnoozeAlarm.Name = "SnoozeAlarm";
            this.SnoozeAlarm.Size = new System.Drawing.Size(79, 28);
            this.SnoozeAlarm.TabIndex = 27;
            this.SnoozeAlarm.Text = "Snooze";
            this.SnoozeAlarm.UseVisualStyleBackColor = true;
            this.SnoozeAlarm.Click += new System.EventHandler(this.Snooze_Click);
            // 
            // DisplayMessage
            // 
            this.DisplayMessage.AutoSize = true;
            this.DisplayMessage.BackColor = System.Drawing.Color.DarkRed;
            this.DisplayMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMessage.ForeColor = System.Drawing.Color.Black;
            this.DisplayMessage.Location = new System.Drawing.Point(390, 23);
            this.DisplayMessage.Name = "DisplayMessage";
            this.DisplayMessage.Size = new System.Drawing.Size(0, 39);
            this.DisplayMessage.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayMessage);
            this.Controls.Add(this.SnoozeAlarm);
            this.Controls.Add(this.ALARMOFF);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ShowTime);
            this.Controls.Add(this.SimulationControl);
            this.Controls.Add(this.SnoozePeriod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.SetTime);
            this.Controls.Add(this.AddAlarm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlarmList);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "My Alarm Clock";
            ((System.ComponentModel.ISupportInitialize)(this.SnoozePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new FormClosingEventHandler(Form1_Closing);
            this.Load += new System.EventHandler(this.onOpen);



        }

        #endregion

        private System.Windows.Forms.ListBox AlarmList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SetTime;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.TextBox Seconds;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown SnoozePeriod;
        private System.Windows.Forms.NumericUpDown SimulationControl;


        Time2 currentTime = new Time2();

        private void SetTime_Click(object sender, System.EventArgs e)
        {
            int hour = Convert.ToInt16(Hours.Text);
            int minute = Convert.ToInt16(Minutes.Text);
            int second = Convert.ToInt16(Seconds.Text);
            Timer();
            currentTime.SetTime(hour, minute, second);
            Hours.Text = "";
            Minutes.Text = "";
            Seconds.Text = "";

        }
        private void OnTimedEvent(Object source, EventArgs e)
        {

            DisplayTime(currentTime);
            currentTime.Addtime(0, 0, 1);
            detectAlarm();


        }


        private void DisplayTime(object currentTime)
        {
            ShowTime.Text = currentTime.ToString();
        }
        private void Timer()
        {

            t.Interval = interval;
            t.Tick += OnTimedEvent;
            t.Start();
        }

        private void simulationControl(object sender, System.EventArgs e)
        {

            int simvalue = Convert.ToInt32(SimulationControl.Value);
            t.Interval = t.Interval / simvalue;


        }
        private void ToolTip(object sender, System.EventArgs e)
        {

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.AddAlarm, "Adds an alarm to the list of alarms");
            ToolTip1.SetToolTip(this.SetTime, "Sets the current time");
            ToolTip1.SetToolTip(this.DeleteButton, "Deletes selected alarm");
            ToolTip1.SetToolTip(this.SimulationControl, "Speeds up passage of time");
            ToolTip1.SetToolTip(this.SnoozePeriod, "Snooze amount in minutes");
            ToolTip1.SetToolTip(this.ALARMOFF, "Turns alarm off");
            ToolTip1.SetToolTip(this.SnoozeAlarm, "Snoozes Alarm");
        }


        AlarmTime NewAlarm = new AlarmTime();
        List<AlarmTime> Alarms = new List<AlarmTime>();
        List<AlarmTime> SnoozeAlarms = new List<AlarmTime>();

        private void AddAlarm_Click(object sender, System.EventArgs e)
        {
            int hour = Convert.ToInt16(Hours.Text);
            int minute = Convert.ToInt16(Minutes.Text);
            int second = Convert.ToInt16(Seconds.Text);
            string output = Output.Text;


            NewAlarm.setTime(output, hour, minute, second);
            Alarms.Add(NewAlarm);
            AlarmList.Items.Add(NewAlarm.Time());
            NewAlarm.clearstringbuilder();

            Hours.Text = "";
            Minutes.Text = "";
            Seconds.Text = "";
            Output.Text = "";
        }

        private void AlarmDelete(object sender, System.EventArgs e)
        {

            if (AlarmList.SelectedIndex != -1)
            {
                AlarmList.Items.RemoveAt(AlarmList.SelectedIndex);
            }

        }

        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                DisplayMessage.BackColor = DisplayMessage.BackColor == Color.Red ? Color.Green : Color.Red;
            }
        }
        public string getMsg;
        public int alarmsignal;
        private void detectAlarm()
        {
            int Alarmtriggered;
            int Snoozetriggered;


            foreach (var time in Alarms)
            {
                Alarmtriggered = currentTime.CompareTo(currentTime, time);
                if (Alarmtriggered == 1)
                {

                    alarmsignal = 1;
                    getMsg = time.GetMessage;
                    DisplayMessage.Text = getMsg.ToString();
                    Blink();
                }

            }

            foreach (var time in SnoozeAlarms)
            {
                Snoozetriggered = currentTime.CompareTo(currentTime, time);
                if (Snoozetriggered == 0)
                {

                    alarmsignal = 1;
                    getMsg = time.GetMessage;
                    DisplayMessage.Text = getMsg.ToString();
                    Blink();
                }

            }

        }

        private void AlarmOff(object sender, System.EventArgs e)
        {
            DisplayMessage.Hide();

        }

        private void Snooze_Click(object sender, System.EventArgs e)
        {
            int snoozePeriod = Convert.ToInt32(SnoozePeriod.Value);
            NewAlarm.Addtime(0, snoozePeriod, 0);
            SnoozeAlarms.Add(NewAlarm);
            DisplayMessage.Hide();


        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {


            if (MessageBox.Show("Do you want to save changes to the Alarm list?", "Alarm",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                const string sPath = "save.txt";

                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                foreach (var item in AlarmList.Items)
                {
                    SaveFile.WriteLine(item);
                }

                SaveFile.Close();

                MessageBox.Show("Alarms Saved!");
                e.Cancel = false;
            }

        }

        private void onOpen(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Do you want to load saved Alarms?", "Alarm",
   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    using (var Filestream = File.OpenRead("save.txt"))  // open file
                    using (var reader = new StreamReader(Filestream))   // read the stream with TextReader
                    {
                        string line;

                        // read until no more lines are present
                        while ((line = reader.ReadLine()) != null)
                        {
                            AlarmList.Items.Add(line);
                        }
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Could not find previously saved data");
                }
            }
            }
        

        protected Button AddAlarm;
        private Label ShowTime;
        private Button DeleteButton;
        private ToolTip toolTip1;
        private Button ALARMOFF;
        private Button SnoozeAlarm;
        private Label DisplayMessage;
    }
}


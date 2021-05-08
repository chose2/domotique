
namespace domotique
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.currentTime = new System.Windows.Forms.Label();
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.NumericUpDown();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.monday = new System.Windows.Forms.CheckBox();
            this.sunday = new System.Windows.Forms.CheckBox();
            this.tuesday = new System.Windows.Forms.CheckBox();
            this.wednesday = new System.Windows.Forms.CheckBox();
            this.saturday = new System.Windows.Forms.CheckBox();
            this.thursday = new System.Windows.Forms.CheckBox();
            this.friday = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCommandButton = new System.Windows.Forms.Button();
            this.commandSelection = new System.Windows.Forms.ComboBox();
            this.RaiseButton = new System.Windows.Forms.Button();
            this.timer1m = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(13, 188);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(90, 25);
            this.currentTime.TabIndex = 1;
            this.currentTime.Text = "12:34:56";
            // 
            // timer1s
            // 
            this.timer1s.Interval = 1000;
            this.timer1s.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(252, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 257);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command Queue";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 202);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AddCommandButton);
            this.groupBox2.Controls.Add(this.commandSelection);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 102);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command Box";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.minute);
            this.groupBox4.Controls.Add(this.hour);
            this.groupBox4.Location = new System.Drawing.Point(296, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 46);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(65, 19);
            this.minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(33, 20);
            this.minute.TabIndex = 1;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(10, 19);
            this.hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(33, 20);
            this.hour.TabIndex = 0;
            this.hour.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monday);
            this.groupBox3.Controls.Add(this.sunday);
            this.groupBox3.Controls.Add(this.tuesday);
            this.groupBox3.Controls.Add(this.wednesday);
            this.groupBox3.Controls.Add(this.saturday);
            this.groupBox3.Controls.Add(this.thursday);
            this.groupBox3.Controls.Add(this.friday);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 46);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Days";
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Location = new System.Drawing.Point(49, 19);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(35, 17);
            this.monday.TabIndex = 1;
            this.monday.Text = "M";
            this.monday.UseVisualStyleBackColor = true;
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.Location = new System.Drawing.Point(10, 19);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(33, 17);
            this.sunday.TabIndex = 0;
            this.sunday.Text = "S";
            this.sunday.UseVisualStyleBackColor = true;
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Location = new System.Drawing.Point(90, 19);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(33, 17);
            this.tuesday.TabIndex = 2;
            this.tuesday.Text = "T";
            this.tuesday.UseVisualStyleBackColor = true;
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Location = new System.Drawing.Point(129, 19);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(37, 17);
            this.wednesday.TabIndex = 3;
            this.wednesday.Text = "W";
            this.wednesday.UseVisualStyleBackColor = true;
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Location = new System.Drawing.Point(249, 19);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(33, 17);
            this.saturday.TabIndex = 6;
            this.saturday.Text = "S";
            this.saturday.UseVisualStyleBackColor = true;
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Location = new System.Drawing.Point(172, 19);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(33, 17);
            this.thursday.TabIndex = 4;
            this.thursday.Text = "T";
            this.thursday.UseVisualStyleBackColor = true;
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Location = new System.Drawing.Point(211, 19);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(32, 17);
            this.friday.TabIndex = 5;
            this.friday.Text = "F";
            this.friday.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Command :";
            // 
            // AddCommandButton
            // 
            this.AddCommandButton.Location = new System.Drawing.Point(296, 71);
            this.AddCommandButton.Name = "AddCommandButton";
            this.AddCommandButton.Size = new System.Drawing.Size(111, 23);
            this.AddCommandButton.TabIndex = 8;
            this.AddCommandButton.Text = "Add Command";
            this.AddCommandButton.UseVisualStyleBackColor = true;
            this.AddCommandButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // commandSelection
            // 
            this.commandSelection.FormattingEnabled = true;
            this.commandSelection.Location = new System.Drawing.Point(72, 73);
            this.commandSelection.Name = "commandSelection";
            this.commandSelection.Size = new System.Drawing.Size(218, 21);
            this.commandSelection.TabIndex = 7;
            this.commandSelection.Text = "None";
            // 
            // RaiseButton
            // 
            this.RaiseButton.Location = new System.Drawing.Point(457, 284);
            this.RaiseButton.Name = "RaiseButton";
            this.RaiseButton.Size = new System.Drawing.Size(75, 23);
            this.RaiseButton.TabIndex = 8;
            this.RaiseButton.Text = "Raise";
            this.RaiseButton.UseVisualStyleBackColor = true;
            this.RaiseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1m
            // 
            this.timer1m.Interval = 60000;
            this.timer1m.Tick += new System.EventHandler(this.timer1m_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 480);
            this.Controls.Add(this.RaiseButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox monday;
        private System.Windows.Forms.CheckBox sunday;
        private System.Windows.Forms.CheckBox tuesday;
        private System.Windows.Forms.CheckBox wednesday;
        private System.Windows.Forms.CheckBox saturday;
        private System.Windows.Forms.CheckBox thursday;
        private System.Windows.Forms.CheckBox friday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCommandButton;
        private System.Windows.Forms.ComboBox commandSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button RaiseButton;
        private System.Windows.Forms.Timer timer1m;
    }
}


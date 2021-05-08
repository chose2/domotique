using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace domotique
{
    public partial class Form1 : Form
    {
        SerialPortCommunicator serialPortCommunicator;
        List<CommandParameter> CommandLists;
        public Form1()
        {
            InitializeComponent();
            serialPortCommunicator = new SerialPortCommunicator();
        }

    private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            progressBar1.Value = DateTime.Now.Hour * 100 / 24;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String command in serialPortCommunicator.Commands)
            {
                commandSelection.Items.Add(command);

            }
            CommandLists = new List<CommandParameter>();
            timer1s.Start();
            timer1m.Start();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> days = new List<int>();

            if (sunday.Checked)
            {
                days.Add(0);
            }
            if (monday.Checked)
            {
                days.Add(1);
            }
            if (tuesday.Checked)
            {
                days.Add(2);
            }
            if (wednesday.Checked)
            {
                days.Add(3);
            }
            if (thursday.Checked)
            {
                days.Add(4);
            }
            if (friday.Checked)
            {
                days.Add(5);
            }
            if (saturday.Checked)
            {
                days.Add(6);
            }

            CommandLists.Add(new CommandParameter(days, Decimal.ToInt32(hour.Value), Decimal.ToInt32(minute.Value), commandSelection.SelectedIndex));
            RefreshCommandList();
        }

        private void RefreshCommandList()
        {
            listView1.Items.Clear();

            foreach(CommandParameter command in CommandLists)
            {
                listView1.Items.Add(command.Format());
            }

            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPortCommunicator.SendCommand(1);
        }

        private void timer1m_Tick(object sender, EventArgs e)
        {
            foreach (CommandParameter command in CommandLists)
            {
                if(DateTime.Now.Hour == command.Hour && DateTime.Now.Minute == command.Minute)
                {
                    serialPortCommunicator.SendCommand(command.Command);
                }
            }
        }
    }
}

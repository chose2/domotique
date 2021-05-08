using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotique
{
    public class CommandParameter
    {
        public List<int> Days;
        public int Hour;
        public int Minute;
        public int Command;

        public CommandParameter(List<int> days, int hour, int minute, int command)
        {
            Days = days;
            Hour = hour;
            Minute = minute;
            Command = command;
        }

        public string Format()
        {
            string text = "";
            
            foreach(int day in Days)
            {
                text += day.ToString() + ",";
            }            
            text += "; " + Hour.ToString() + ":" + Minute.ToString() + " " + Command.ToString();
            
            return text;
        }
    }
}


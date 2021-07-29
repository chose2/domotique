using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domotique
{
    public class SerialPortCommunicator
    {
        public String[] Commands = { "None", "Lower desk", "Raise desk" };
        SerialPort serialPort;

        public SerialPortCommunicator()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            //serialPort.Parity = SetPortParity(_serialPort.Parity);
            //serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            //serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            //serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);
            serialPort.Open();
        }

        ~SerialPortCommunicator()
        {
            serialPort.Close();
        }

        public void SendCommand(int commandCode)
        {
            if(serialPort.IsOpen)
            {
                serialPort.Write(commandCode.ToString());
            }
        }
    }
}

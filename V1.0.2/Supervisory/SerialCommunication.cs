/* ==== Class Supervisory v1.0.0 ====
 * 
 *Author: Fábio Santos
 *Creation: march 2025
 *Modification: march 14, 2025
 *IDE: Visual Studio 2022 version 17.13.3
 *
 *The current version of this class is responsible for: 
 *1 - setting and updating serial communication options in a graphical interface. 
 *The class provides methods for:  
 *2 - filling and updating drop-down lists (ComboBox) with serial port options, parity types and stop bits.
  ================================================================================================*/

using System;
using System.IO.Ports;
using System.Windows.Forms;


namespace Supervisory
{
    class SerialCommunication
    {

        //=======================================================================================
        //method UpdateCom   
        //updates the list of serial ports available on the system, adding them to the specified ComboBox.
        public void UpdateCom(ComboBox cbComPorts)
        {
            cbComPorts.Items.Clear();

            foreach (string comPortName in SerialPort.GetPortNames())
            {
                cbComPorts.Items.Add(comPortName);
            }

            cbComPorts.SelectedIndex = 0;
        }
        //=======================================================================================
        //method Parity
        //Populates the ComboBox with parity options (such as None, Odd, Even), setting "None" as the default.
        public void Parity(ComboBox cbParity)
        {
            int i = 0;
            cbParity.Items.Clear();

            foreach (string parity in Enum.GetNames(typeof(Parity)))
            {
                cbParity.Items.Add(parity);

                if (parity == "None")
                    cbParity.SelectedIndex = i;

                i++;
            }
        }
        //=======================================================================================
        //method StopBits
        //Populates the ComboBox with stop bit options (such as One, Two, OnePointFive), setting "One" as the default.
        public void StopBits(ComboBox cbStopBits)
        {
            int i = 0;
            cbStopBits.Items.Clear();

            foreach (string stopBits in Enum.GetNames(typeof(StopBits)))
            {
                cbStopBits.Items.Add(stopBits);

                if (stopBits == "One")
                    cbStopBits.SelectedIndex = i;

                i++;

            }
        }
        //=======================================================================================

    }
}




/* ==== STC Supervisory v1.0.3 ====
 * 
 *Author: Fábio Santos
 *Creation: march 2025
 *Modification: march 16, 2025
 *IDE: Visual Studio 2022 version 17.13.3
 *
 *In the current version of this software it is possible to:
 *1 - configure and execute serial communication with any hardware that has an available serial port.
 *2 - Transmit and receive data through the serial port.
 *3 - Monitor and control analog input readings
 *4 - Adding a synoptic for monitoring using resources from the AdvancedHMI library
  =======================================================================================================*/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using System.Collections.Generic;
using System.Threading;


namespace Supervisory
{
    public partial class formSTCSupervisory : Form
    {
        public formSTCSupervisory()
        {
            InitializeComponent();
        }

        SerialCommunication serial = new SerialCommunication();
        private CancellationTokenSource cts = new CancellationTokenSource();


        //Variable to receive and store data arriving via serial
        string rxSerial;
        string newReceive = string.Empty;
        
        

        //Everything that starts when the form is loaded
        private void formSTCSupervisory_Load(object sender, EventArgs e)
        {
            serial.UpdateCom(cbComPort);
            serial.Parity(cbParity);
            serial.StopBits(cbStoBits);
            cbBaudRate.SelectedIndex = 6;
            cbDataBits.SelectedIndex = 3;
            btnDisconnect.Enabled = false;
            btnConect.BackColor = Color.Green;
            btnDisconnect.BackColor = Color.Gray;
        
    
        }

    

        //Everything that happens when the conect button is clicked
        private void btnConect_Click_1(object sender, EventArgs e)
        {
            if (cSerial.IsOpen == true)

                cSerial.Close();

            //Converting CobomBox strings to their respective types
            cSerial.PortName = cbComPort.Text;
            cSerial.BaudRate = Int32.Parse(cbBaudRate.Text);
            cSerial.Parity = (Parity)cbParity.SelectedIndex;
            cSerial.DataBits = Int32.Parse(cbDataBits.Text);
            cSerial.StopBits = (StopBits)cbStoBits.SelectedIndex;

            try
            {
                cSerial.Open();

                btnConect.Enabled = false;
                cbComPort.Enabled = false;
                cbBaudRate.Enabled = false;
                cbParity.Enabled = false;
                cbDataBits.Enabled = false;
                cbStoBits.Enabled = false;
                btnConect.BackColor = Color.Gray;

                MessageBox.Show("Connected!",
                                    "SUCCESS",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

            }

            catch
            {
                MessageBox.Show("Could not open selected port!",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }

            btnDisconnect.Enabled = true;
            btnDisconnect.BackColor = Color.Red;
        }

        //Everything that happens when the disconnect button is clicked
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to disconnect?",
                                                    "ATTENTION",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cSerial.Close();

                MessageBox.Show("System disconnected",
                                    "SUCCESS",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                btnDisconnect.Enabled = false;
                btnConect.Enabled = true;
                btnConect.Enabled = true;
                cbComPort.Enabled = true;
                cbBaudRate.Enabled = true;
                cbParity.Enabled = true;
                cbDataBits.Enabled = true;
                cbStoBits.Enabled = true;

                btnConect.BackColor = Color.Green;
                btnDisconnect.BackColor = Color.Gray;

              

            }

        }


        //This method is needed to display the data stored in rxSerial in the textBox.
        private void TreatsReceivedData(object sender, EventArgs e)
        {
            {

                newReceive += rxSerial;

                if (newReceive.Length >= 10)
                {
                    if(newReceive.Substring(0,1) == "A")
                    {
                        lblReading.Text = newReceive.Substring(5, 5);
                        tank1.Value = Int32.Parse(lblReading.Text);
                                            
                    }
                }
            }
                newReceive = string.Empty;

            }
        

        

        /*This event is capable of reading the data contained in the serial and storing it in rxSerial, 
         * but it cannot write to the textBox, since a multitasking process is taking place, that is, 
         * the program is being executed and data is being read from the serial. 
         * This prevents direct writing to the textBox. So the method above was created and is being 
         * executed in the application. Invoke sends the current data to the TreatsReceivedData method.*/
        private void cSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            rxSerial = cSerial.ReadExisting();

            this.Invoke(new EventHandler(TreatsReceivedData));

        }
      
    }

}//end namespace Supervisory







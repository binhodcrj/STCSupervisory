/* ==== Analogal Reading ====
 * 
 *Author: Fábio Santos
 *Creation: march 2025
 *Modification: march 16, 2025
 *IDE: Arduino IDE version 2.3.4
 
This program aims to perform a test with the STC Supervisory software in its version 1.0.2. An analog 
signal is captured by the controller that will convert it to digital data and send it through the serial 
port to the monitoring software.

 In STC Supervisory: 
 --> Monitor changes in the STC supervisory display as analog values ​​change over time.
 ============================================================================================================================*/
//Global variables
char receiveSerial[4];           //receives data from the serial
char adBuffer[15];               //stores the string that will be sent via serial
int i = 0;                       //iteration variable to fill the receiveSerial array position
int storeValueAD = 0;            //stores the Ad conversion value
int analogPin = A0;              //Analog input pin selection
unsigned long lastDataTime = 0;  //Stores the last time value of the data sent by serial
const int dataInterval = 100;    //serial data sending interval in ms
bool adc = true;                 //AD conversion return control variable via serial. Used to start or turn off monitoring.
//=============================================================================================================================

void setup() {

  Serial.begin(9600);
}

void loop() {

  SerialEvent();     //receives data from the STC supervisory
  ConvertedValue();  //performs A/D conversion and sends the data to the STC supervisory
}
//================================== End Program ==============================
//Functions
void SerialEvent() {

  while (Serial.available()) {

    receiveSerial[i] = (char)Serial.read();

    if (receiveSerial[i] == '\r') {
      i = 0;

      if (receiveSerial[0] == 'O' && receiveSerial[1] == 'N')
        adc = true;

      if (receiveSerial[0] == 'O' && receiveSerial[1] == 'F' && receiveSerial[2] == 'F')
        adc = false;
    } else i++;
  }
}
//=============================================================================
void ConvertedValue() {

  if (adc) {
    unsigned long actualTime = millis();

    if (actualTime - lastDataTime >= dataInterval) {
      lastDataTime = actualTime;

      storeValueAD = analogRead(analogPin);
      storeValueAD = map(storeValueAD, 0, 1023, 0, 1000);

      //string formatting for AN0=0000
      snprintf(adBuffer, sizeof(adBuffer), "AN0 = %4d", storeValueAD);

      Serial.println(adBuffer);
    }
  }
}
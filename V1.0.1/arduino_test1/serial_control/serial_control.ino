/* ==== Serial Control ====
 * 
 *Author: Fábio Santos
 *Creation: march 2025
 *Modification: march 15, 2025
 *IDE: Arduino IDE version 2.3.4
 
 This program aims to perform a test with the STC Supervisory software in its version 1.0.1. A command 
 will be sent through the serial port where a LED connected to pin 13 of the Arduino should turn on or 
 off according to the command sent. In addition, a confirmation message must be sent by the Arduino to 
 the supervisory software.

 In STC Supervisory: 
 --> send the L command to turn on the LED 
 --> send the D command to turn off the LED.
 =======================================================================================================*/

//Global variables
char receiveSerial[2]; //receives data from the serial
int i = 0;             //iteration variable to fill the receiveSerial array position

void setup() {

  Serial.begin(9600);
  pinMode(13, OUTPUT);
  

}

void loop() {

  LedControl();
   
}
//================================== End Program ==============================
//Functions
void LedControl(){

  while(Serial.available()){

    receiveSerial[i] = (char)Serial.read(); //stores the current serial information at the starting position of i and converts it to char

    if(receiveSerial[i] == '\r'){           //when receiveSerial receives carriage return the iteration variable i is reset to zero

      i = 0;
    
    if(receiveSerial[0] == 'L'){
        
        digitalWrite(13, HIGH); 
        Serial.print("Data received: ");
        Serial.print(receiveSerial);
        Serial.println(" --> Led on");  

    }
          
    else if (receiveSerial[0] == 'D') {

        digitalWrite(13, LOW);
        Serial.print("Data received: ");
        Serial.print(receiveSerial);
        Serial.println(" --> Led off");

    }   

        if(receiveSerial[0] != '\r' && receiveSerial[0] != 'L' && receiveSerial[0] != 'D' )

          Serial.println("Invalid Command! Send L or D");
          
  }
  
   else
    i++;  
  }
}

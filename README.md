## STC Supervisory

STC Supervisory is a project that I am developing to be presented in a final evaluation panel of my technical course in industrial automation. 
The final software will be able to communicate with hardware via serial communication, receiving and sending data through this communication protocol.
It will receive data from the level of a reservoir and compare it with the level value at the set point and as the level of this reservoir undergoes variations 
it will apply a PID control to correct this disturbance and maintain the desired level or as close to this value as possible.

## 🚀 Getting started

## ⚙️ Running the tests

You can load the files present in the arduino_testX folder present in the folder of each software version on an Arduino and run the STC supervisory test on the desired version.

## 🛠️ Built with

Visual Studio 2022

* [Visual Studio Community](https://visualstudio.microsoft.com/pt-br/free-developer-offers/)
  
AdvancedHMI

* [AdvancedHMI](https://www.advancedhmi.com/)



## 📌 Version

# 1.0.1
* It is possible to configure and perform serial communication with any hardware that has an available serial port.
* It is now possible to send and receive hardware data via serial communication.
* A field for transmitting data via serial communication and another field for receiving data have been added.

# 1.0.2
* It is now possible to take readings from analog sensors and control their monitoring
  
# 1.0.3
* Adding a synoptic for monitoring using resources from the AdvancedHMI library
* Removal of start and stop buttons

## ✒️ Author

* **Fábio Santos** - [Fábio Santos](https://github.com/binhodcrj)

## visual-studio-hmi-arduino

Created an HMI using Visual Studio C# which sends one byte of data each time a button transferred. ( More bytes when gauge is used. Since I dont have the sensors, it shows fixed values for debug/test purposes.) 

Serial comminication is established over COM4 port by default. 
( In order to automate COM ports, to connect any COM ports automatically, add this line "serialPort1.PortName = ports[0];" just before the serial communication is opened. "serialPort1.Open();" Why am I writing down this here? Its because I am too lazy to go find and change actual code from the files which I uploaded.)

This HMI is a test for future HMIs that I am planning to design for a self-driving mobile robot.


![hmi](https://user-images.githubusercontent.com/49839246/166993681-780771ac-da2b-4eb7-bd57-c5f49f6d1454.PNG)

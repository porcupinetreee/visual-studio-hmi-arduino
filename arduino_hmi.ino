String datas = "";
void setup() {
  Serial.begin(9600); // opens serial port, sets data rate to 9600 bps
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
}

void loop() {
  // send/receive data only when you receive data:
  if (Serial.available() > 0) {
    // read the incoming byte ( char = 1 byte ) :
    datas = (char)Serial.read(); // only reads 1 byte of data

/*
 instructions: 0 1 1 0 0 0 1 0  activates "b" relay
               0 1 1 0 0 0 1 1  activates "c" relay
               0 1 1 0 0 1 0 0  activates "d" relay

               0 0 1 1 0 0 0 1  deactivates "b" relay
               0 0 1 1 0 0 1 0  deactivates "c" relay
               0 0 1 1 0 0 1 1  deactivates "d" relay
               
 */
    if(datas == "b"){

      digitalWrite(LED_BUILTIN, HIGH); 
      delay(100);
      
      }

    else if( datas == "1") // 
    {
      
      digitalWrite(LED_BUILTIN, LOW);
      delay(100);
      
      }

    if(datas == "c"){

      digitalWrite(5, HIGH);
      delay(100);
      
      }

    else if( datas == "2")
    {
      
      digitalWrite(5, LOW);
      delay(100);
      
      }

    if(datas == "d"){

      digitalWrite(6, HIGH);
      delay(100);
      
      }

    else if( datas == "3")
    {
      
      digitalWrite(6, LOW);
      delay(100);
      
      }




      
    }

  
}

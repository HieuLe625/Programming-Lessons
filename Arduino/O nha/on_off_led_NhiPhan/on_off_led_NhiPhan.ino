int pinArray[] = {2, 3, 4};
int count = 0;
//int timer = 5000;
void setup() {
  for (byte i=0;i<=5;i++){
    pinMode(pinArray[i], OUTPUT);
  }
}

void loop() {
  for(byte i=0;i<=5;i++){
    HieuUng();
  }
}
void HieuUng() {   
                   
  //0
  digitalWrite(4, 0);         // 0 = on
  digitalWrite(3, 0);        // 1 = off
  digitalWrite(2, 0);
  delay(1000);
  //1 
  digitalWrite(4, 1);
  digitalWrite(3, 0);
  digitalWrite(2, 0);
  delay(1000);
  //2
  digitalWrite(4, 0);
  digitalWrite(3, 1);
  digitalWrite(2, 0);
  delay(1000);
  //3
  digitalWrite(4, 1);
  digitalWrite(3, 1);
  digitalWrite(2, 0);
  delay(1000);
  //4
  digitalWrite(4, 0);
  digitalWrite(3, 0);
  digitalWrite(2, 1);
  delay(1000);
  //5
  digitalWrite(4, 1);
  digitalWrite(3, 0);
  digitalWrite(2, 1);
  delay(1000);
  //6
  digitalWrite(4, 0);
  digitalWrite(3, 1);
  digitalWrite(2, 1);
  delay(1000);
  //7
  digitalWrite(4, 1);
  digitalWrite(3, 1);
  digitalWrite(2, 1);
  delay(500);
}

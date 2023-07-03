
int pinArray[] = {2, 3, 4, 5, 6, 7};
int count = 0;
int timer = 200;
void setup() {
   for(count=0;count<=5;count++){
    pinMode(pinArray[count], OUTPUT);
   }
}

void loop() {
  for(byte i=0;i<=5;i++){
    HieuUng1();
  }
}
void HieuUng1(){
  for(count=0;count<=2;count++){
    digitalWrite(pinArray[count], HIGH);
  }
  delay(timer);
 
  for(count=0;count<=2;count++){
    digitalWrite(pinArray[count], LOW);
  }
  delay(timer);
}

//Khai bao
#define L1Red 8
#define L1Yellow 9
#define L1Green 10

#define L2Red 11
#define L2Yellow 12
#define L2Green 13

//Khai bao bien dem
//byte dem;

//cau hinh
void setup() {
   for(byte i=8; i<14; i++){
      pinMode(i,OUTPUT);
}
    for(byte i=8; i<14; i++){
      digitalWrite(i,OUTPUT);
}
}
void loop() {
  Mode2();
}

void Mode2(){
  //1
  digitalWrite(L1Yellow, LOW);
  digitalWrite(L2Yellow, LOW);
  delay(1000);
  //2
  digitalWrite(L1Yellow, HIGH);
  digitalWrite(L2Yellow, HIGH);
  delay(1000);
}

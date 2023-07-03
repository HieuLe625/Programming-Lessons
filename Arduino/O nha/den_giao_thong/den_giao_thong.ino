#define L1Red 2
#define L1Yellow 3
#define L1Green 4

#define L2Red 5
#define L2Yellow 6
#define L2Green 7

byte dem;

void setup() {
   for(byte i=0;i<8;i++){
    pinMode(i,OUTPUT);
   }
   for(byte i=0;i<8;i++){
    digitalWrite(i,HIGH);
   }
}

void ledoff(){
  for(byte i=0;i<8;i++){
    digitalWrite(i, HIGH);
  }
}

void loop() {
  Mode1();
}
void Mode1(){
  //1 
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Green, LOW);
  delay(5000);ledoff();
  //2 
  digitalWrite(L1Red,LOW);
  digitalWrite(L2Yellow, LOW);
  delay(1000);ledoff();
  //3
  digitalWrite(L1Green, LOW);
  digitalWrite(L2Red, LOW);
  delay(5000);ledoff();
  //4
  digitalWrite(L2Red, LOW);
  digitalWrite(L1Yellow, LOW);
  delay(1000);ledoff(); 
}

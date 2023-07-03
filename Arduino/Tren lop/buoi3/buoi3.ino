  //Khai bao
#define L1Red 2
#define L1Yellow 3
#define L1Green 4

#define L2Red 5
#define L2Yellow 6
#define L2Green 7

//Khai bao bien dem
byte dem;

//cau hinh
void setup() {
   for(byte i=0; i<8; i++){
      pinMode(i,OUTPUT);
}
    for(byte i=0; i<8; i++){
      digitalWrite(i,OUTPUT);
}
//  pinMode(2,INPUT_PULLUP); //khai bao chan cho nut nhan'
//attachInterrupt(0,quetNutNhan1,LOW);
//  attachInterrupt(1,quetNutNhan2,LOW);
}


//Ham tat LED
void Led_Off(){
  for (byte i=0; i<8; i++){
    digitalWrite(i,HIGH);
  }
}

void loop() {
  Mode1();
}

void Mode1(){
  //1
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Green, LOW);
  delay(5000);Led_Off();
  //2
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Yellow, LOW);
  delay(1000);Led_Off();
  //3
  digitalWrite(L1Green, LOW);
  digitalWrite(L2Red, LOW);
  delay(5000);Led_Off();
  //4
  digitalWrite(L1Yellow, LOW);
  digitalWrite(L2Red, LOW);
  delay(1000);Led_Off();
  
 }

//Khai bao
#define L1Red 8
#define L1Yellow 9
#define L1Green 10

#define L2Red 11
#define L2Yellow 12
#define L2Green 13
byte i,j, dem;
//cau hinh
void setup() {
   for(byte i=8; i<14; i++){
      pinMode(i,OUTPUT);
   }
    for(byte i=8; i<14; i++){
      digitalWrite(i,HIGH);
   }
}

//Ham tat LED
void Led_Off(){
  for (byte i=8; i<14; i++){
    digitalWrite(i,HIGH);
  }

}
void loop() {
  for(i=0; i<=1; i++){
     Mode1();
     dem++;
     if (dem==0){break;}
  }
  for(j=0; j<=5; j++){
    Mode2();
  }
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

  digitalWrite(L1Yellow, LOW);
  delay(1000);Led_Off();
  //5
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Green, LOW);
  delay(5000);Led_Off();
  //6
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Yellow, LOW);
  delay(1000);Led_Off();
  //7
  digitalWrite(L1Green, LOW);
  digitalWrite(L2Red, LOW);
  delay(5000);Led_Off();
  //8
  digitalWrite(L1Yellow, LOW);
  digitalWrite(L2Red, LOW);
  delay(1000);Led_Off();
}
void Mode2(){
  digitalWrite(L1Yellow, LOW);
  digitalWrite(L2Yellow, LOW);
  delay(1000);
  digitalWrite(L1Yellow, HIGH);
  digitalWrite(L2Yellow, HIGH);
  delay(1000);
}

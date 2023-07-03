  //Khai bao
#define L1Red 2
#define L1Yellow 3
#define L1Green 4
#define L2Red 5
#define L2Yellow 6
#define L2Green 7
void setup (){
  for (byte i=2;i<=8;i++){
  pinMode(i, OUTPUT);
  }
  for (byte i=2;i<=8;i++){
    digitalWrite(i,HIGH);
  }
}

void Led_Off(){
  for (byte i=2; i<8; i++){
    digitalWrite(i,HIGH);
  }
}
  
void loop (){
  for (byte i=0;i<=5;i++){
    Mode1();
  }
}

void Mode1(){
  //1
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Green, LOW);
  delay(3000);Led_Off();
  //2
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Yellow, LOW);
  delay(1000);Led_Off();
  //3
  digitalWrite(L1Green, LOW);
  digitalWrite(L2Red, LOW);
  delay(3000);Led_Off();
  //4
  digitalWrite(L1Yellow, LOW);
  digitalWrite(L2Red, LOW);
  delay(1000);Led_Off();
  //5
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Green, LOW);
  delay(3000);Led_Off();
  //6
  digitalWrite(L1Red, LOW);
  digitalWrite(L2Yellow, LOW);
  delay(1000);Led_Off();
  //7
  digitalWrite(L1Green, LOW);
  digitalWrite(L2Red, LOW);
  delay(3000);Led_Off();
  //8
  digitalWrite(L1Yellow, LOW);
  digitalWrite(L2Red, LOW);
  delay(1000);Led_Off();
}

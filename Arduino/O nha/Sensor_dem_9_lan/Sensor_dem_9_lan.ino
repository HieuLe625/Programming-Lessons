#define sensor 2
const int A = 3;
const int B = 4;
const int C = 5;
const int D = 6;
const int E = 7;
const int F = 8;
const int G = 9;
const int en1 = 10;
const int second = 1000;
const int digit = 10;
const int segment = 7;
byte dem=0;
//tao ma
// ma Anot chung
byte digseg[digit][segment]={
  {0,0,0,0,0,0,1},// 0
  {1,0,0,1,1,1,1},// 1
  {0,0,1,0,0,1,0},// 2
  {0,0,0,0,1,1,0},// 3
  {1,0,0,1,1,0,0},// 4
  {0,1,0,0,1,0,0},// 5
  {0,1,0,0,0,0,0},// 6
  {0,0,0,1,1,1,1},// 7
  {0,0,0,0,0,0,0},// 8
  {0,0,0,0,1,0,0}// 9
};
void setup() {
  pinMode(sensor,INPUT);
  pinMode(A, OUTPUT);
  pinMode(B, OUTPUT);
  pinMode(C, OUTPUT);
  pinMode(D, OUTPUT);
  pinMode(E, OUTPUT);
  pinMode(F, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(en1, OUTPUT);
  //chan cho phep
  digitalWrite(en1, LOW);
  for (byte i=3;i<12;i++){
    digitalWrite(i, HIGH);
  }
}

void loop() {
  if (digitalRead(sensor) == 0){
    delay(400);
    while(digitalRead(sensor) ==0){;}
      dem++;
    if (dem >=10){dem=0;}
  }digitalWrite(en1, LOW);
  writeDigit(dem);
}

// ham hiem thi so tren led 7 doan
void writeDigit(byte digit){
  byte pinA = A; // chan bat dau xuat tin hieu
  byte seg;
  for (seg = 0;seg<7;seg++){ //quet 7 thanh
    digitalWrite(pinA, digseg[digit][seg]);
    pinA++;
  }
}
 

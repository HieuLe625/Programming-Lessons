const int A = 3;
const int B = 4;
const int C = 5;
const int D = 6;
const int E = 7;
const int F = 8;
const int G = 9;
const int en1 = 10;
const int en2 = 11;
const int second = 1000;
const int digit = 10;
const int segment = 7;
byte chuc,dv;



void setup() {
  pinMode(A, OUTPUT);
  pinMode(B, OUTPUT);
  pinMode(C, OUTPUT);
  pinMode(D, OUTPUT);
  pinMode(E, OUTPUT);
  pinMode(F, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(en1, OUTPUT);
  pinMode(en2, OUTPUT);
  //ham cho phep'
  digitalWrite(en1, LOW);
  digitalWrite(en2, LOW);
}
void loop(){
  byte dem1= 0;   // khai bao chu~ muon' hien.
  writeDigit(dem1);
  delay(1000);
 
  byte dem2= 1;
  writeDigit(dem2);
  delay(1000);

}

//tao ma
// ma Anot chung
byte digseg[digit][segment]={
  {0,0,0,1,0,0,0},// A
  {0,1,1,0,0,0,1},// C
  {0,1,1,0,0,0,0},// E
  {0,1,1,1,0,0,0},// F
  {1,0,0,1,0,0,0},// H
  {1,1,1,0,0,0,1},// L
  {0,0,1,1,0,0,0},// P
  {0,1,0,0,1,0,0},// S
  {1,0,0,0,0,0,1},// U 
  {1,0,0,0,0,1,1}// J
};
// ham hiem thi so tren led 7 doan
void writeDigit(byte digit){
  byte pinA = A;
  byte seg;
  for (seg = 0;seg<7;seg++){
    digitalWrite(pinA, digseg[digit][seg]);
    pinA++;
  }
}

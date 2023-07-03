#define A 3
#define B 4
#define C 5
#define D 6
#define E 7
#define F 8
#define G 9
#define en1 10
#define en2 11

const int second = 1000;
const int digit = 10;
const int segment = 7;
byte chuc,dv;
byte dem;

void setup() {
  for(byte i=3;i<=11;i++){
    pinMode(i, OUTPUT);
  }
   
  for(byte i=3;i<=11;i++){
    digitalWrite(i, HIGH);
  }
}

void loop() {
  for(byte dem=0;dem<=99;dem++){
  //hiem thi so
  chuc = dem/10; //lay ham chuc
  dv= dem%10; // lay ham don vi
 //Ham chuc
 digitalWrite(en1, LOW);
 writeDigit(chuc);
 delay(15);
 digitalWrite(en1, HIGH);
 //ham do vi
 digitalWrite(en2, LOW);
 writeDigit(dv);
 delay(15);
 digitalWrite(en2, HIGH);
}
}
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
// ham hiem thi so tren led 7 doan
void writeDigit(byte digit){
  byte pinA = A;
  byte seg;
  for (seg = 0;seg<7;seg++){
    digitalWrite(pinA, digseg[digit][seg]);
    pinA++;
  }
}

#define MOTOR_PIN_1       A1  // Chân 1 của động cơ
#define MOTOR_PIN_2       A2  // Chân 2 của động cơ
#define MOTOR_PIN_3       A3  // Chân 3 của động cơ
#define MOTOR_PIN_4       A4  // Chân 4 của động cơ
#define ONOFF_PIN         A5  // Nút nhấn ON/OFF
#define ONOFF_LED_PIN     5   // LED báo động cơ chạy
#define DIR_PIN           A0  // Nút nhấn đảo chiều
#define DIR_LED_PIN       4   // Đèn báo THUẬN/ NGHỊCH
#define PULSES_PER_REV 2048   // Pulses per revolution
#define but_tocdo 13          // Nút nhấn tốc độ

const int A = 6; // A = Arduino chân 6
const int B = 7; // B = Arduino chân 7
const int C = 8; // C = Arduino chân 8
const int D = 9; // D = Arduino chân 9
const int E = 10; // E = Arduino chân 10
const int F = 11; // F= Arduino chân 11
const int G = 12; // G= Arduino chân 12
 
int run_thuan = 0; // Biến xác định chạy THUẬN/ NGHICH 
int on = 0;        // Biến xác định ON/ OFF

const int digit = 10;  // Số ký tự hiển thị 10 digits (0 - 9)
const int segment = 7; // Số thanh hiển thị trong LED (7)
int tt = 0;            // Biến trạng thái
int tocdo = 1024, dem = 1;

byte digseg[digit][segment] = {
{ 0,0,0,0,0,0,1 }, // = 0
{ 1,0,0,1,1,1,1 }, // = 1
{ 0,0,1,0,0,1,0 }, // = 2
{ 0,0,0,0,1,1,0 }, // = 3
{ 1,0,0,1,1,0,0 }, // = 4
{ 0,1,0,0,1,0,0 }, // = 5
{ 0,1,0,0,0,0,0 }, // = 6
{ 0,0,0,1,1,1,1 }, // = 7
{ 0,0,0,0,0,0,0 }, // = 8
{ 0,0,0,0,1,0,0 }  // = 9
};

//------ Hàm hiển thị số trên led 7 đoạn 
void writeDigit(byte digit)  
{
  byte pinA = A; // Chân bắt đầu xuất tín hiệu
  byte seg;
  for (seg = 0; seg < 7; seg++)           // Quét 7 thanh của led
  {
    digitalWrite(pinA, digseg[digit][seg]); // Chân bắt đầu, Vị trí số: vòng lặp quét 7 lần để hiển thị số đó
    pinA++;
  }
}

byte rpm, rpm_old, stepnr;
unsigned long timeoflaststep;

unsigned long stepinterval() { // calculates step timing based on potmeter input
  rpm = map(tocdo, 0, 1024, 1, 13); // max 12 rpm, else pulses get lost
  if(rpm != rpm_old) {
    rpm_old = rpm;
  }
  return 60000000UL / PULSES_PER_REV / rpm; // [us] stepinterval
}

void do_one_step() { 
  if(run_thuan == 1) {
        stepnr++;
     digitalWrite(DIR_LED_PIN, LOW);  
    }
  else {
    stepnr--;
    digitalWrite(DIR_LED_PIN, HIGH); 
    }
  stepnr = stepnr % 4; // remember in which of the 4 phases the motor is
  switch (stepnr) {
    case 0:
      digitalWrite(MOTOR_PIN_1, HIGH);
      digitalWrite(MOTOR_PIN_2, LOW);
      digitalWrite(MOTOR_PIN_3, LOW);
      digitalWrite(MOTOR_PIN_4, LOW);
    break;
    case 1:
      digitalWrite(MOTOR_PIN_1, LOW);
      digitalWrite(MOTOR_PIN_2, HIGH);
      digitalWrite(MOTOR_PIN_3, LOW);
      digitalWrite(MOTOR_PIN_4, LOW);
    break;
    case 2:
      digitalWrite(MOTOR_PIN_1, LOW);
      digitalWrite(MOTOR_PIN_2, LOW);
      digitalWrite(MOTOR_PIN_3, HIGH);
      digitalWrite(MOTOR_PIN_4, LOW);
    break;
    case 3:
      digitalWrite(MOTOR_PIN_1, LOW);
      digitalWrite(MOTOR_PIN_2, LOW);
      digitalWrite(MOTOR_PIN_3, LOW);
      digitalWrite(MOTOR_PIN_4, HIGH);
    break;
  }
}

void motor_idle() {
  digitalWrite(MOTOR_PIN_1,   LOW);
  digitalWrite(MOTOR_PIN_2,   LOW);
  digitalWrite(MOTOR_PIN_3,   LOW);
  digitalWrite(MOTOR_PIN_4,   LOW);
  digitalWrite(ONOFF_LED_PIN, HIGH);
}

void setup() {
  pinMode(ONOFF_PIN,     INPUT_PULLUP);
  pinMode(DIR_PIN,       INPUT_PULLUP);
  pinMode(MOTOR_PIN_1,   OUTPUT);
  pinMode(MOTOR_PIN_2,   OUTPUT);
  pinMode(MOTOR_PIN_3,   OUTPUT);
  pinMode(MOTOR_PIN_4,   OUTPUT);
  pinMode(ONOFF_LED_PIN, OUTPUT);
  pinMode(DIR_LED_PIN,   OUTPUT);
  pinMode(A, OUTPUT);
  pinMode(B, OUTPUT);
  pinMode(C, OUTPUT);
  pinMode(D, OUTPUT);
  pinMode(E, OUTPUT);
  pinMode(F, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(but_tocdo, INPUT);
  dem = 0;
  tocdo = 1024;
  digitalWrite(ONOFF_LED_PIN, HIGH);
  digitalWrite(DIR_LED_PIN, HIGH);
}

void loop() {
  if (digitalRead(ONOFF_PIN) == LOW) {
     delay(20);
     while(digitalRead(ONOFF_PIN) ==LOW);
     tt = tt + 1;
     if (tt>2) {tt = 0;}
     if (tt==1) {on =1;}
     if (tt==2) {on =0;}
  }

  if (on==1){
    digitalWrite(ONOFF_LED_PIN, LOW); // led sáng báo động cơ chạy
    if (digitalRead(DIR_PIN) ==0){
       delay(20);
       while(digitalRead(DIR_PIN) ==0);
       run_thuan =!run_thuan;
    }
    if (digitalRead(but_tocdo)==0){
      delay(20);
      while (digitalRead(but_tocdo)==0);
      tocdo = tocdo-300;
      dem = dem +1;
      if (tocdo<0) {tocdo = 1024;}
      if (dem>3) {dem = 1;}
    }
    if ((micros() - timeoflaststep) > stepinterval()) {
      timeoflaststep = micros();
      do_one_step();
    }
    writeDigit(dem);
  }
  else{
      motor_idle();
  }
}

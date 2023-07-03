//chay "thuan" kim dong ho CounterColockwise
//chay "Nguoc" kim dong ho Colockwise
#define MOTOR_PIN_1 A1
#define MOTOR_PIN_2 A2
#define MOTOR_PIN_3 A3
#define MOTOR_PIN_4 A4
#define ONOFF_PIN   2  
#define ONOFF_LED_PIN   5
#define DIR_PIN      3
#define DIR_LED_PIN  4
#define PULSES_PER_REV 2048 //xung: do phan giai

const int A = 6;
const int B = 7;
const int C = 8;
const int D = 9;
const int E = 10;
const int F = 11;
const int G = 12;

#define but_tocdo 13
const int digit = 10; // so hien thi so digit
const int segment = 7; // so thanh hiem thi trong ed 7 doan
int tocdo = 1024, dem = 1;

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
byte rpm, rpm_old, stepnr;
unsigned long timeoflaststep;

  #include <STEPPER.h>
  
  
  STEPPER motor(5,6,7,8); // Select the Arduino pins which is connected to the motor module
  
  
  void setup() 
  {
   motor.configureStep(Full); // Select the working mode of the motor. You can configure it in half step mode by simply replacing the keyword "Full" with "Half" 
  }
  
  
  void loop() 
  {
    
    motor.runStepper(Clockwise,High,1); //Parameter1 = Direction / Parameter2 = Speed / Parameter3 = No. of revolutions
    delay(2000);
                                               
    motor.turnStepper(CounterClockwise,Medium,180); //Parameter1 = Direction / Parameter2 = Speed / Parameter3 = Angle of rotation(0-360)
    delay(2000);
    
//   motor.turnStepper(Clockwise,Low,145); //Parameter1 = Direction / Parameter2 = Speed / Parameter3 = Angle of rotation(0-360)
//   delay(2000);
//    
//    motor.runStepper(CounterClockwise,Medium,1); //Parameter1 = Direction / Parameter2 = Speed /  Parameter3 = No. of revolutions
//   delay(2000);
//    motor.stopStepper();
//    delay(5000);
  }

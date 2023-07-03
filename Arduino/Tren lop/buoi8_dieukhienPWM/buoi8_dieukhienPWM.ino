#define enA 11
#define in1 12
#define in2 13
void setup() {
  pinMode(enA, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
}
void loop() {
  //dieu che' PWM
  int potValue = analogRead(A0); //doc gia tri  tu bien tro
  int pwmOutput = map(potValue, 0, 1023, 0, 255);
  analogWrite(enA, pwmOutput); // xuat xung PWM
  // dong co chay thuan
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  // dong co chay nguoc
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
}

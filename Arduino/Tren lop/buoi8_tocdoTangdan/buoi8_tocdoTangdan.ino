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
  for(byte dem =0; dem<255;dem++){
  analogWrite(enA, dem);
  // dong co chay thuan
   delay(100);
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  
}
}

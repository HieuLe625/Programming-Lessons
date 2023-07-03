#define enA 11
#define in1 12
#define in2 13
void setup() {
  pinMode(enA, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
  digitalWrite(enA, HIGH);

}

void loop() {
  //thuan
   digitalWrite(enA, HIGH);
   digitalWrite(in1, LOW);
   digitalWrite(in2, HIGH);
   delay(5000);
   // off
   digitalWrite(enA, LOW);
   digitalWrite(in1, LOW);
   digitalWrite(in2, LOW);
   delay(3000);
   
   //Nguoc
   digitalWrite(enA, HIGH);
   digitalWrite(in1, HIGH);
   digitalWrite(in2, LOW);
   delay(5000);
   // off
   digitalWrite(enA, LOW);
   digitalWrite(in1, LOW);
   digitalWrite(in2, LOW);
   delay(3000);
}

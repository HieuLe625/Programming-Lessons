#include<LiquidCrystal.h>
#include<stdio.h>
#include<math.h>

#define LedRed 8
#define Sensor A0 // khai bao chan cho cam bien
//khoi tao cac chan
// ket noi pin LCD (RS, E, D4, D5, D5, D7)
LiquidCrystal lcd(7,6,5,4,3,2);
byte dem;
byte degree_symbol[8] = { //tao cac ky tu so' 
  0b00111,
  0b00101,
  0b00111,
  0b00000,
  0b00000,
  0b00000,
  0b00000,
  0b00000
};
void setup() {
  pinMode(Sensor, INPUT);
  pinMode(8, OUTPUT);
  digitalWrite(8, HIGH); // tat' led

  lcd.begin(16,2); //khai bao LCD su dung
  lcd.createChar(1, degree_symbol);
  lcd.setCursor(0,0); //dua vi tri' con tro? ve` 0 0 "dong` 1"
  lcd.print("   Wellcome to   ");
  lcd.setCursor(0,1);
  lcd.print("   Arduino class  ");
  delay(1000);
  lcd.clear();

  

}

void loop() {
  int reading = analogRead(A0);
  float voltage = reading * 5.0 / 1024.0;
  float temp = voltage * 100.0;
  if( temp < 50){
   // digitalWrite(LedRed, HIGH);
  lcd.setCursor(0,0); //dua vi tri' con tro? ve` 0 0
  lcd.print("Day : 30/3/2021  ");
  lcd.setCursor(0,1);
  lcd.print("Temperature: ");
  lcd.print(temp);
  delay(500);
  lcd.clear();
  }
  else{
  lcd.setCursor(0,0); //dua vi tri' con tro? ve` 0 0
  lcd.print("System state:  ");
  lcd.setCursor(0,1);
  lcd.print("Warning!  ");
  lcd.print(temp);
  delay(500);
  digitalWrite(LedRed, LOW);
  delay(500);
  lcd.clear();
  digitalWrite(LedRed, HIGH);
  }
}

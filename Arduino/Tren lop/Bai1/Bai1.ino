#include<LiquidCrystal.h>
//Khoi tao cac chan
// LCD module connections (RS, E, D4, D5, D6, D7)
LiquidCrystal lcd(7,6,5,4,3,2); 
#define led 8
#define Sensor  A0
byte degree_symbol[8] = 
              {
                0b00111,
                0b00101,
                0b00111,
                0b00000,
                0b00000,
                0b00000,
                0b00000,
                0b00000
              };
              
void setup()
{
  pinMode(Sensor, INPUT);
  pinMode(led, OUTPUT);
  lcd.begin(16,2);                // Khai bao LCD su dung             
  lcd.createChar(1, degree_symbol);
  lcd.setCursor(0,0);
  lcd.print("  Wellcome to  ");   //In ra màn hình LCD
  lcd.setCursor(0,1);             //Dòng 0 là dòng thứ 1
  lcd.print(" Arduino Class   ");
  delay(1000);
  lcd.clear();
  digitalWrite(led, HIGH); // tắt led
  //--------------
  
}
void loop()
{
  int reading = analogRead(Sensor); // doc gia tri cua bien tro
  float voltage = reading * 5.0 / 1024.0;
  float temp = voltage * 100.0;
  if (temp<50){
      lcd.setCursor(0,0);
      lcd.print("Day: 30-03-2021 ");
      lcd.setCursor(0,1);          //Dòng 1 là dòng thứ 2
      lcd.print("Temperature: ");
      lcd.print(temp);
      delay(200);
      lcd.clear();
  }
  else {
      lcd.setCursor(0,0);
      lcd.print("System state: ");
      lcd.setCursor(0,1);          //Dòng 1 là dòng thứ 2
      lcd.print("Warning! ");
      lcd.print(temp);
      delay(500);
      digitalWrite(led, LOW); // sáng led
      delay(500);
      lcd.clear();
      digitalWrite(led, HIGH); // tắt led
  }

  

}

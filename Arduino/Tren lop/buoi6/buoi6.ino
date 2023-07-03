#include<LiquidCrystal.h>
//khoi tao cac chan
// LCD module connections (RS, E, D4, D5, D5, D7)
LiquidCrystal lcd(7,6,5,4,3,2);
const 
byte degree_symbol[8] = {
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
 //for(byte i=0;i<=5;i++){
  lcd.begin(16,2); //khai bao LCD su dung
  lcd.createChar(1, degree_symbol);
  lcd.setCursor(0,0); //dua vi tri' con tro? ve` 0 0
  lcd.print("   Wellcome to   ");
  lcd.setCursor(0,1);
  lcd.print("   Summer crip  ");
  delay(2000);
  lcd.clear();
//}
}

void loop() {
  lcd.clear();
  lcd.setCursor(0,0); //dua vi tri' con tro? ve` 0 0
  lcd.print("  Ichi-Ni-San  ");
  lcd.setCursor(0,1);
  lcd.print("  Nyan Arigato  ");
  delay(500);
  
  lcd.clear();
  lcd.setCursor(0,0); //dua vi tri' con tro? ve` 0 0
  lcd.print(" Le Trung Hieu  ");
  lcd.setCursor(0,1);
  lcd.print(" 6051030034  ");
  delay(500);
  lcd.clear();

}

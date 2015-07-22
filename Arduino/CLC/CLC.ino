void setup() {
  // initialize serial and turn lights ON:
  Serial.begin(9600);
  analogWrite(9,255);
}

void loop() {
  while(Serial.available()){
    analogWrite(9, Serial.read());
  }
}

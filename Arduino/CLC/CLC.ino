
void setup() {
  // initialize serial:
  Serial.begin(9600);
  analogWrite(9,255);
}

int level = 0;
void loop() {
  while(Serial.available()){
    level = Serial.read();
    analogWrite(9,level);
  }
}



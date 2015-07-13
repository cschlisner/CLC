
void setup() {
  // initialize serial:
  Serial.begin(9600);
  analogWrite(9,255);
}

float chainLength = 0.0, chainCount = 0.0, totalChainLength = 0.0;
float chainAvg = 0.0;
int level = 0;
void loop() {
  while(Serial.available()){
    level = Serial.read();
    analogWrite(9,level);
  }
}



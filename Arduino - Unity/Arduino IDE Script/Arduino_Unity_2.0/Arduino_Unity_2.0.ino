const int Btn_pin = 2;


void setup() {
  pinMode(Btn_pin, INPUT);

  Serial.begin(19200);
}

void loop() {
  
  int value = digitalRead(Btn_pin);
  String data_to_send = "";

  if (digitalRead(Btn_pin) > 0)
  {
    data_to_send = "1";
  }
  else if (digitalRead(Btn_pin) <= 0)
  {
    data_to_send = "0";
  }

  delay(10);
  Serial.println(data_to_send);
  Serial.flush();
}

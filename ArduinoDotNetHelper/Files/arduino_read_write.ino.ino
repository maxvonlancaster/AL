char commandValue; // данные, поступаемые с последовательного порта
int ledPin = 13; // встроенный светодиод

void setup() {
  pinMode(ledPin, OUTPUT); // режим на вывод данных
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    commandValue = Serial.read();
  }

  if (commandValue == '1') {
    digitalWrite(ledPin, HIGH); // включаем светодиод
  }
  else {
    digitalWrite(ledPin, LOW); // в противном случае выключаем
  }
  delay(10); // задержка перед следующим чтением данных
}
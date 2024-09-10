/*
 * comandos via serial
 * inverte o estado do led conctado a saída 13 do arduino quando recebe o caracter 'A' pela serial
 */
String mensagem;
void setup() {
  Serial.begin(9600);            //configura comunicação serial com 9600 bps
  pinMode(LED_BUILTIN, OUTPUT);  //configura pino do led como saída
  mensagem = "";
}
void loop() {
  if (Serial.available())  //se byte pronto para leitura
  {
    mensagem = Serial.readString();
    if (mensagem.equalsIgnoreCase("A")) {
      if (digitalRead(LED_BUILTIN) == HIGH) {
        digitalWrite(LED_BUILTIN, LOW);
        Serial.println("LED Desligado!");
      } else {
        digitalWrite(LED_BUILTIN, HIGH);
        Serial.println("LED Ligado!");
      }
    } else {
      Serial.println("Mensagem recebida: " + mensagem);
    }
  }
}

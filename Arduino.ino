/*
 * comandos via serial
 * inverte o estado do led conctado a saída 13 do arduino quando recebe o caracter 'A' pela serial
 */

void setup() {
  Serial.begin(9600);    //configura comunicação serial com 9600 bps
  pinMode(LED_BUILTIN,OUTPUT);   //configura pino do led como saída
}
void loop() {
   if (Serial.available()) //se byte pronto para leitura
   {
    switch(Serial.read())      //verifica qual caracter recebido
    {
      case 'A':                  //caso 'A'
        digitalWrite(LED_BUILTIN,!digitalRead(LED_BUILTIN)); //inverte estado do led
      break;
    }
  }
}

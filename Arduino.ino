#define ledAmarelo 4
#define ledVerde 5
#define ledVermelho 6
 
String mensagem;

void setup() {
  Serial.begin(9600);            // Configura comunicação serial com 9600 bps
  pinMode(ledAmarelo, OUTPUT);
  pinMode(ledVerde, OUTPUT);
  pinMode(ledVermelho, OUTPUT);
  
  mensagem = "";
}

void loop() {
  if (Serial.available()) {  // Se byte pronto para leitura
    mensagem = Serial.readString();

    // Comando para LED Amarelo
    if (mensagem.equalsIgnoreCase("ativaramarelo")) {
      digitalWrite(ledAmarelo, HIGH);
      Serial.println("LED Amarelo Ligado!");
    } else if (mensagem.equalsIgnoreCase("desativaramarelo")) {
      digitalWrite(ledAmarelo, LOW);
      Serial.println("LED Amarelo Desligado!");
    }

    // Comando para LED Verde
    if (mensagem.equalsIgnoreCase("ativarverde")) {
      digitalWrite(ledVerde, HIGH);
      Serial.println("LED Verde Ligado!");
    } else if (mensagem.equalsIgnoreCase("desativarverde")) {
      digitalWrite(ledVerde, LOW);
      Serial.println("LED Verde Desligado!");
    }

    // Comando para LED Vermelho
    if (mensagem.equalsIgnoreCase("ativarvermelho")) {
      digitalWrite(ledVermelho, HIGH);
      Serial.println("LED Vermelho Ligado!");
    } else if (mensagem.equalsIgnoreCase("desativarvermelho")) {
      digitalWrite(ledVermelho, LOW);
      Serial.println("LED Vermelho Desligado!");
    }

    Serial.println("Mensagem recebida: " + mensagem);
  }
}

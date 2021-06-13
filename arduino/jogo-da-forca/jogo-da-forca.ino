#define led1 2
#define led2 3
#define led3 4
#define led4 5
#define led5 6
#define led6 7
#define led7 8
#define led8 9

int leds[8] = {led1, led2, led3, led4, led5, led6, led7, led8}; // Vetor de leds
int contador = 0;
bool piscar = true;
char key; // Chave de identificação

//  Tabela de atribuição dos valores possíveis para "key"
//
//   Caracter   Significado
//  '---------+------------'
//      i         iniciar
//      p         parar
//      f         fechar
//      e         erro

void setup() {
  iniciar();
}

void loop() {
  principal();
}

void iniciar() { // Combina todos os procedimentos relacionados à inicialização em um único
  Serial.begin(9600);
  printarInicio();
  iniciarLeds();
  printarCompleto();
}

void principal() {
  if (Serial.available() > 0) {
    key = Serial.read();

    if (key == 'i') { // Se o caractere lido pelo monitor serial for 'i' (iniciar), o Arduino é preparado para o jogo
      apagar(); // Os leds são apagados
      piscar = false; // Os leds param de piscar
    }

    else if (key == 'p') { // Se o caractere lido pelo monitor serial for 'p' (parar), o Arduino "para"
      apagar(); // Os leds são apagados
      piscar = true; // Os leds voltam a piscar
      contador = 0; // O contador é reiniciado
    }

    else if (key == 'f') { // Se o caractere lido pelo monitor serial for 'f' (fechar), o Arduino "fecha"
      apagar(); // Os leds são apagados
      piscar = false; // Os leds param de piscar
    }

    else if (key == 'e') { // Se o caractere lido pelo monitor serial for 'e' (erro), o Arduino computa um erro
      if (contador < 8) {
        digitalWrite(leds[contador], HIGH); // Acende o led correspondente indexando leds de contador
        if (contador == 7) { // Se os 8 leds foram acesos
          piscar = true; // Os leds voltam a piscar
          contador = 0; // O contador é reiniciado
        }
        else // Se os 8 leds ainda não foram acesos
          contador++; // O contador avança
      }
    }
  }

  else if (piscar)
    repetirLeds();
}

void iniciarLeds() {
  pinMode(13, OUTPUT);
  for (int i = 0; i < 8; i++) { // Inicia, led a led, dando o feedback no monitor serial
    pinMode(leds[i], OUTPUT);
    digitalWrite(leds[i], HIGH);
    Serial.print("O led ");
    Serial.print(leds[i] - 1);
    Serial.println(" foi inicializado.");
    delay(250);
  }
  delay(750);
}

void repetirLeds() { // Apaga e acende os leds repetidamente
  apagar();
  delay(750);
  acender();
  delay(750);
}

void apagar() { // Apaga todos os leds
  for (int i = 0; i < 8; i++) {
    digitalWrite(leds[i], LOW);
  }
}

void acender() { // Acende todos os leds
  for (int i = 0; i < 8; i++) {
    digitalWrite(leds[i], HIGH);
  }
}

void printarInicio() { // Informa, printando no monitor serial, que a inicialização começou
  Serial.println("+-----------+");
  Serial.println("| INICIANDO |");
  Serial.println("+-----------+\r\n");
}

void printarCompleto() { // Informa, printando no monitor serial, que a inicialização terminou
  Serial.println("\r\n+------------------------+");
  Serial.println("| INICIALIZAÇÃO COMPLETA |");
  Serial.println("+------------------------+");
}

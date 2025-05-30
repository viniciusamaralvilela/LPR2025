#include <iostream>

using namespace std;

int main() {
    int numero, quadrado = 0, soma = 0;
    cout << "Digite um número: ";
    cin >> numero;
    quadrado = numero * numero; 
    cout << "O quadrado do número é: " << quadrado << endl;
    while(quadrado > 0){
        soma += quadrado % 10; //pega o ultimo digito do numero
        quadrado = int(quadrado /10); //remove o ultimo digito do numero
    }
    cout << "A soma dos numeros do numero ao quadrado é: " << soma << endl;
}

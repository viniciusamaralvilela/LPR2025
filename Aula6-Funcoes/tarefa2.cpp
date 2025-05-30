#include <iostream>
#include <locale>
using namespace std;

void primeiro(){ //tem que ser void pois eu quero vir para o codigo. Se eu quisesse apenas receber uma info, seria int/double/etc.
    cout << "Bem vindo a situação 1" << endl;
    int quant = 0;
    int numeros = 0;
    int m = 0;
    int par = 0;
    int cont = 0;
    cout << "Digite a quantidade de números: ";
    cin >> quant;
    int contudo = numeros;
    while (contudo < quant){
        cout << "Digite os números: ";
        cin >> numeros;
        if (numeros % 2 == 0){
            par += numeros;
            cont++; //contador de numeros pares
        }
        contudo++; //limitar a quantidade de números
    }
    m = par / cont;
    cout << "A média dos números pares é: " << m << endl;
}

void terceiro (){
        cout << "Bem vindo a situação 2" << endl;
        int soma = 0;
        for (int i = 51; i <= 498; i += 3)
        {
            soma += i;
        }
        cout << "A soma dos numeros é'" << soma << endl;
}

void quarto (){
    cout << "Bem vindo a situação 3" << endl;
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

int main(){
    locale::global(locale("pt_BR.UTF-8"));
    cout.imbue(locale());
    int opcao;
    cout << "Escolha uma opção: " << endl;
    cout << "1. Calcular a média dos números pares" << endl;
    cout << "2. Calcular a soma dos números de 50 a 500 que são múltiplos de 3" << endl;
    cout << "3. Calcular o quadrado de um número e a soma dos dígitos do quadrado" << endl;
    cin >> opcao;

    switch(opcao){
        case 1:
            primeiro();
            break;
        case 2:
            terceiro();
            break;
        case 3:
            quarto();
            break;
        default:
            cout << "Opção inválida!" << endl;
            break;
    }
    return 0;
}

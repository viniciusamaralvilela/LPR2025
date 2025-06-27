#include <iostream>
using namespace std;

int main(){
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
    return 0;
}
#include <iostream>

using namespace std;


int main(){
//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o códigode uma peça 2, o número de peças 2 e ovalor unitário de cada peça 2. Calcule emostre o valor a ser pago.
int u1;
int v1;
int u2;
int v2;
int vt;
cout << "Digite o valor da primeira peça e quantas unidades voce comprou" << endl;
cin >> v1 >> u1;
cout << "Digite o valor da segunda peça e quantas unidades voce comprou" << endl;
cin >> v2 >> u2;
vt = (v1 * u1) + (v2 * u2);
cout << "O valor a ser pago e: " << vt << endl;
return 0;

}
#include <iostream>

using namespace std;


int main(){
//esta tarefa se trata do exercicio quatro da segunda aula de LPR
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
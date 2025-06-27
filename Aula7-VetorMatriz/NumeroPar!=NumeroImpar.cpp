#include <iostream>
#include <vector>

using namespace std;

int main(){
int im = 0, p = 0;
vector<int> numeros(10); 
vector<int> par(p);
vector<int> impar(im);
cout << "Voce deve digitar 10 numeros inteiros" << endl;
for (int i = 0; i < 10; i++) {
    cout << "Digite o numero " << i + 1 << ": ";
    cin >> numeros[i];

if(numeros[i] % 2 == 0){
    numeros[i] = par[p];
    p++;
} else {
    numeros[i] = impar[im];
    im++;
}
}
cout << "Numeros pares: ";
for (int i = 0; i < p; i++) {
    cout << par[i] << " ";
}
cout << endl;
cout << "Numeros impares: ";
for (int i = 0; i < im; i++) {
    cout << impar[i] << " ";
}
return 0;
}
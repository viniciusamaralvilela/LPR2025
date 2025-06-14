using namespace std;
#include <iostream>
#include <string>

int main(){
    const int tamanho = 4;
    string nome [tamanho] = {"Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};
    int estou = 0;
    int chegar = 0;

    int distancia [tamanho][tamanho] = {
        {0, 524, 521, 882},
        {500, 0, 600, 1200},
        {1000, 600, 0, 800},
        {1500, 1200, 800, 0}
    };
    
    for (int i = 0; i < tamanho; i++){
        cout << i << " - " << nome[i] << endl;
    }
    
    cout << "Digite o número da cidade onde você está: ";
    cin >> estou;
    cout << "Digite o número da cidade onde você quer chegar: ";
    cin >> chegar;

    do{
    if (estou < 0 || estou >= tamanho || chegar < 0 || chegar >= tamanho) {
        cout << "Cidade inválida!" << endl;
    } else {
        cout << "A distância entre " << nome[estou] << " e " << nome[chegar] << " é de " 
             << distancia[estou][chegar] << " km." << endl;
    }
}while(estou =! chegar);

    return 0;
}
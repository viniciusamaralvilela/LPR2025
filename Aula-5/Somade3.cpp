#include <iostream>
using namespace std;

    int main () {
        int soma = 0;
        for (int i = 51; i <= 498; i += 3)
        {
            soma += i;
        }
        cout << "A soma dos numeros é'" << soma << endl;
    }
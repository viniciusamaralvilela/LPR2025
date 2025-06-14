#include <iostream>
using namespace std;

int funçao1 (int num, int &inverted_num){
    while (num != 0){
        int digit = num % 10;
        inverted_num = inverted_num * 10 + digit;
        num /= 10;
    }
    return inverted_num;
}
int main() {
    int num, inverted_num = 0;
    cout << "Digite um numero: ";
    cin >> num;
    funçao1 (num, inverted_num);
    cout << "numero invertido: " << inverted_num << endl;
    return 0;
}
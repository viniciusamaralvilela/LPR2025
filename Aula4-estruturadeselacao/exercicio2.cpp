#include <iostream>
using namespace std;

int main()
{
    int x;
    int y;
    cout << "Digite dois numeros";
    cin >> x >> y;
    if (x % y == 0 || y % x ==0)
    {
    cout << "Sao multiplos";
    }
    else
    {
    cout << "Nao sao multiplos";
    }
    return 0;
}

#include<iostream>
#include <list>
#include <cstdlib>
#include <ctime>
using namespace std;

int main(){
    srand(time(0));
    list<int> n;

    for(int i = 0; i < 100; i++){
        int aleatorio = rand();
        n.push_back(aleatorio);
    }
    n.sort();
    for (int x : n){
        cout << x << "" << endl;
    }
    for (auto it = n.begin(); it != n.end(); ) {
        if (*it % 2 == 0) {
            it = n.erase(it); 
        } else {
            ++it;
        }
    }
    for (int y : n){
        cout << y << "" << endl;
    }
    
}
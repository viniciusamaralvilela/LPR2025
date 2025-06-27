#include <iostream>
#include <vector>
#include <string>
using namespace std;

struct Livro
{
    string Titulo;
    string Autor;
    int ano;
    int pag;
    double preco;
};

int main()
{
    vector<Livro> inserir(3);
    double soma = 0;
    int somap = 0;

    for (int i = 0; i < inserir.size(); i++){
        cout << "Digite o nome do livro" << endl;
        cin >> inserir[i].Titulo;
        cout << "Digite o nome do autor" << endl;
        cin >> inserir[i].Autor;
        cout << "Digite o ano que o livro foi publicado" << endl;
        cin >> inserir[i].ano;
        cout << "Digite a quantidade de paginas que tem o livro" << endl;
        cin >> inserir[i].pag;
        cout << "Digite o preco do livro" << endl;
        cin >> inserir[i].preco;
        
        soma += inserir[i].preco;
        somap += inserir[i].pag;
    }

    cout << "O preco total dos livros eh: " << soma << endl;
    cout << "A media de paginas eh: " << somap/3 << endl;
}
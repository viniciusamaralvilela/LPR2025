
Console.WriteLine ("Escolha o seu personagem clicando nas teclas");
Console.WriteLine ("1 - Guerreira");
Console.WriteLine ("2 - Mago");
Console.WriteLine ("3 - Arqueira");
int x = Convert.ToInt32 (Console.ReadLine());
switch (x){
    case 1:
    Console.Write ("Seu personagem tem: Ataque Pesado, Defesa Total");
    break;
    case 2:
    Console.Write ("Seu personagem tem: Bola de Fogo, Escudo de Gelo");
    break;
    case 3:
    Console.Write ("Seu personagem tem: Flecha Precisa, Disparo Triplo");
    break;
    default:
    Console.Write ("Escolha um personagem");
    break;
}
// See https://aka.ms/new-console-template for more information
/* estrutura de repetição While.
 * Nessa estrutura a expresssão é validada no inicio e em seguinda é executado o restante da expressão.
 * serve para executar repetida vezes um bloco de código.
 * dentro de um array
 * exetuta determinado bloco de codigo enquanto for verdadeira
 * */

var contador = 1;
while(contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}
// usando while para percorrer um array
// primeiro foi criado um array.
// criado uma variavel para indice.
var indice1 = 0;
string[] nomesDiversos = new string[] { "Agnos", "Suelen", "Nivone", "Vilela", "Jean"};

while(indice1 < nomesDiversos.Length)
{
    Console.WriteLine(nomesDiversos[indice1]);
    indice1++;
}


var indice = 0 ;
string[] versoes =  new string[] { "2", "3", "4" };

    while(indice < versoes.Length)
{
    Console.WriteLine(versoes[indice]);
    indice++;
}



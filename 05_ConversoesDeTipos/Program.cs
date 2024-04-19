// See https://aka.ms/new-console-template for more information
// conversoes de tipos de dados usando c#
// conversoes implicitas
// de int para decimal acontece sem perda de dados.

int ano = 2020;
double ano2 = ano;

// conversões explicitas há perda de dados. 
decimal taxa = 12.98m;
int taxa2 = (int)taxa;

// conversões com classe auxiliares
decimal taxa3 = 19.55m;
string taxa4 = taxa3.ToString();

// converter texto em numero
string resposta = "12";
int idade = int.Parse(resposta);
int idade2 = Convert.ToInt32(resposta);
Console.WriteLine(idade2);

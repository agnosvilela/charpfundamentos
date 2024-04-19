// See https://aka.ms/new-console-template for more information

using System.Globalization;
// concatenação de string 
String nome = "Agnos";
string sobrenome = "Vilela";
string nomeCompleto = nome + " " + sobrenome;

// opção mais moderna - string interpolation
string nomeCompleto2 = $"{nome} {sobrenome}";

Console.WriteLine(nomeCompleto2.ToUpper());
Console.WriteLine(nomeCompleto2.ToLower());
Console.WriteLine(nomeCompleto2.Substring(4));
// nos tras a informação a partir desse indice inserido.
Console.WriteLine(nomeCompleto2.Substring(4,5));
// tras a informação a partir do indice e a quantidade de caractere.
Console.WriteLine(nomeCompleto2.Contains('A'));
Console.WriteLine(nomeCompleto2.Contains("Fa"));
// como saber se uma string existe dentro de outra. 

// verifica se uma palavra começa ou termina com tal letra ou texto

Console.WriteLine(nomeCompleto2.StartsWith("Fa"));
Console.WriteLine(nomeCompleto2.EndsWith("la"));

// tras o indece do caractere
Console.WriteLine(nomeCompleto2.IndexOf("A"));
Console.WriteLine(nomeCompleto2.LastIndexOf("A"));
// See https://aka.ms/new-console-template for more information
var notas = new int[] { 6, 8, 5, 7, 9 };
var soma = 0.0;

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] < 6)
    {
        Console.WriteLine("Nenhuma nota pode ser inferior a 6.");
        soma = 0;
        continue;
    }

    soma += notas[i];
}

var media = soma / notas.Length;

Console.WriteLine("Média: " + media);
Console.WriteLine("Hello, World!");

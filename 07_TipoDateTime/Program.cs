// See https://aka.ms/new-console-template for more information
var hoje = DateTime.Today;
var agora = DateTime.Now;

// criando um novo date time
var data1 = new DateTime(2023, 04, 18);
var data2 = new DateTime(2023, 04, 18, 11, 23, 30);
// converte o texto em string em data
var data3 = DateTime.Parse("18/04/2023");

// metodos de manipulação de datas.
Console.WriteLine(data2.Day);
Console.WriteLine(data2.Month);
Console.WriteLine(data2.Hour);
Console.WriteLine(data2.Minute);
Console.WriteLine(data2.Second);
Console.WriteLine(data2.AddDays(5));
Console.WriteLine(data2.ToLongDateString());
Console.WriteLine(data2.ToLongTimeString());

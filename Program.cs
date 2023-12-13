using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("4561321", "Iphone 12 Pro Max", "564SDS65AS", 256);
Smartphone nokia = new Nokia("4561321", "Nokia 12", "765SD545AS", 64);

Console.WriteLine("Iphone----------");
Console.WriteLine(iphone);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine();
Console.WriteLine("Nokia----------");
Console.WriteLine(nokia);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
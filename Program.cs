using DesafioPOO.Models;

Console.Clear();

// Nokia:
Nokia nokia = new Nokia("9123-5776", "Nokia 5.3 Dual Chip", "2222222", 32);
Console.WriteLine("Aparelho Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

//Iphone
Iphone iphone = new Iphone("1234-8775", "Iphone 13 Pro Max", "1111111", 128);
Console.WriteLine("Aparelho Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone");
Smartphone iphone1 = new Iphone("00 1234-5678", "15 Pro Máx", "001970-01-010000-0", 16);
iphone1.Ligar();
iphone1.InstalarAplicativo("Telegram");

Console.WriteLine("----------------------------------\n");


Console.WriteLine("Smartphone Nokia");
Smartphone nokia1 = new Nokia("11 8765-4321", "G11 Plus", "001970-01-010000-0", 32);
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Whatsapp");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("::::::::Inicio dos Testes com o modelo Nokia::::::");
Nokia nokia = new("12345", "Modelo X", "ifweokcdsan9909ldasdl", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhastApp");
Console.WriteLine("::::::::Fim dos Testes com o modelo Nokia::::::");

Console.WriteLine(" ");

Console.WriteLine("::::::::Inicio dos Testes com o modelo Iphone::::::");
Iphone iphone = new("67890", "Modelo Pro 10", "89pdolap0890kasd0da0", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhastApp");
Console.WriteLine("::::::::Fim dos Testes com o modelo Iphone::::::");
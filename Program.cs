using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("0101", "Iphone 14", "imei:0101-0101", 256);
Nokia nokia = new Nokia("0202", "Nokia Tijolao", "imei:0202-0202", 4);

//teste iphone
Console.WriteLine("Teste do Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsapp");


//teste nokia
Console.WriteLine("\nTeste do Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("facebook");



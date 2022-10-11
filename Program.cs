using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero:"12345",modelo:"xyz",imei:"3333",memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("waze");

Console.WriteLine();

Iphone iphone = new Iphone(numero:"6789",modelo:"abc",imei:"4444",memoria:256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("maps");
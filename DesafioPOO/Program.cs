// TODO: Realizar os testes com as classes Nokia e Iphone
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "10293848567", modelo: "Modelo X", Imei: "1212121", memoria: 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "999999", modelo: "15 PRO MAX", Imei: "31231231", memoria: 1024);
iphone.Ligar();
nokia.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.ReadKey();
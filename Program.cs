// See https://aka.ms/new-console-template for more information
using Abstraindo_celular.Models;

Console.WriteLine("Hello, World!");
Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NOKIA C20", imei: "1212121212", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Iphone 14", imei: "2323232323", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
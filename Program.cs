// See https://aka.ms/new-console-template for more information
using Abstraindo_celular.Models;

Console.WriteLine("Hello, World!");
Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NOKIA 2310", imei: "1234567890", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Iphone XR", imei: "7898765432", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
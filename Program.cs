using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "988063205", modelo: "Nokia G11 Plus", imei: "12345", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "988063205", modelo: "Iphone 11 Pro", imei: "54321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


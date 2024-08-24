using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12344", modelo: "C210", imei: "001970-01-010000-0", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12315", modelo: "A2848", imei: "001970-01-010000-1", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
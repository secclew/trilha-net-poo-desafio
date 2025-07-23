using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "123456789", modelo: "Nokia 6.1", imei: "123456789012345", memoria: 64, versaoAndroid: "9.0");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "987654321098765", memoria: 128, versaoIOS: "14.4");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

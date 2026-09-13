using Microsoft.Extensions.Configuration; // Konfiguration

//ConfigurationBuilder ile dosyayı tanıyoruz
IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();
    
// Veriyi okuma
string appName = config["AppSettings:AppName"]; //appsettings.json dosyasındaki AppSettings altındaki AppName değerini okuyoruz
int maxRetry = int.Parse(config["AppSettings:MaxRetryCount"] ?? "3"); //appsettings.json dosyasındaki AppSettings altındaki MaxRetryCount değerini okuyoruz

// Veriyi yazdırma
Console.WriteLine($"App Name: {appName}");
Console.WriteLine($"Max Retry Count: {maxRetry}");
HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddNorthWindServices();

builder.Services.AddFileWriter();
builder.Services.AddConsoleWriter();
builder.Services.AddDebugWriter();

builder.Services.AddSingleton<AppLogger>();
builder.Services.AddSingleton<ProductService>();
using var AppHost = builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application started.");


ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azúcar refinada");


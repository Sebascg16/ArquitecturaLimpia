HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddSingleton<IUserActionWriter,DebugWriter>();
builder.Services.AddSingleton<IUserActionWriter,ConsoleWriter>();
builder.Services.AddSingleton<AppLogger>();
builder.Services.AddSingleton<ProductService>();
using var AppHost = builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application started.");


ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azúcar refinada");


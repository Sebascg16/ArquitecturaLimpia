HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddNorthWindServices();

using IHost AppHost = builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");


IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azúcar refinada");


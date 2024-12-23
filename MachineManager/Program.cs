using MachineManager.Components;
using MachineManager.Contracts.Data;
using MachineManager.Contracts.Repositories;
using MachineManager.Contracts.Services;
using MachineManager.Data;
using MachineManager.Entities;
using MachineManager.Repositories;
using MachineManager.Services;

namespace MachineManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddSingleton<IDataStore<GuidList<Machine>>, VolatileMachineDataStore>();
            builder.Services.AddScoped<IDataRepository<Machine>, VolatileMachineDataRepository>();
            builder.Services.AddScoped<IDataService<Machine>, VolatileMachineDataService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}

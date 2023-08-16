using FIFA.WEB;
using FIFA.WEB.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7199/swagger/index.html") });
// Esta inyecci�n de servicios es para poder consumir APIs
// en new uri borramos y agregamos nuestro local host para que me muestre en web y no en Postman
// o swagger

builder.Services.AddScoped<IRepository, Repository>();
// Se le dice que haga un Scoped y mande la interface con su implementaci�n
// el entonces tomar� las clases y las utilizar� dentro del proyecto

await builder.Build().RunAsync();

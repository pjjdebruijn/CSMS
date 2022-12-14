using CSMS.Plugins.InMemory;
using CSMS.UseCases.PluginInterfaces;
using CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces;
using CSMS.UseCases.UseCases.CodeSnippetUseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


// map abstractions to concrete implementations (enables dependency injection)
builder.Services.AddSingleton<ICodeSnippetRepository, CodeSnippetRepository>();

builder.Services.AddTransient<IViewCodeSnippetsByNameUseCase, ViewCodeSnippetsByNameUseCase>();
builder.Services.AddTransient<IViewCodeSnippetsByIdUseCase, ViewCodeSnippetsByIdUseCase>();
builder.Services.AddTransient<IAddCodeSnippetUseCase, AddCodeSnippetUseCase>();
builder.Services.AddTransient<IUpdateCodeSnippetUseCase, UpdateCodeSnippetUseCase>();

// build app
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

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// run app , lets go!
app.Run();

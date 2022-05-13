using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.OpenApi.Models;
using portfolio.Data;
using portfolio.Dtos;
using portfolio.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
string myAllowSpecificOrigins = "MyPolicy";


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc(setupAction: options =>
{
    options.EnableEndpointRouting = false;
})/*.SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest)*/;
builder.Services.AddServerSideBlazor();
builder.Services.AddCors(options =>
{
    options.AddPolicy(myAllowSpecificOrigins,
                          policy =>
                          {
                              policy.WithOrigins("*")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

builder.Services.AddControllers().AddJsonOptions(x =>  x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); ;
builder.Services.AddDbContext<PortfolioDbContext>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Portfolio Api", Version = "v1", });
});
builder.Services.AddHttpClient();
builder.Services.AddSingleton<WeatherForecastService>();

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
app.UseCors("MyPolicy");

app.UseMvcWithDefaultRoute();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseDeveloperExceptionPage();
app.UseSwagger();


app.UseSwaggerUI(options =>
{


    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "api";
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();

});
app.Run();

using APIWeb.Middlewares;
using Business.Interfaces;
using Business.Services;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Database.DataSeed;
using Database.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Database Context
builder.Services.AddDbContext<MasterContext>(options => { options.UseInMemoryDatabase("MemoryDB"); });

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );

// DataAccess Repositories
builder.Services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));

// Services
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IReviewService, ReviewService>();

// Mapper
builder.Services.AddSingleton<IMapperProvider, MapperProvider>();
builder.Services.AddSingleton(serviceProvider =>
{
    var provider = serviceProvider.GetRequiredService<IMapperProvider>();
    return provider.GetMapper();
});

const string policyName = "AllowAll";
builder.Services.AddCors(options =>
{
    options.AddPolicy(policyName,
        policyBuilder => { policyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
// Configure the HTTP request pipeline.
var scopeeee = ((IApplicationBuilder) app).ApplicationServices.CreateScope();
var context = scopeeee.ServiceProvider.GetRequiredService<MasterContext>();
await TestData.SeedAsync(context);

//Custom Middlewares
app.UseMiddleware<RequestHandlerMiddleware>();
app.UseMiddleware<ResponseHandlerMiddleware>();
app.UseMiddleware<ErrorHandlerMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policyName);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
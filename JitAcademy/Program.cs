using Microsoft.EntityFrameworkCore;
using WebApplication4;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", () =>
    {

    })
    .WithName("GetProducts")
    .WithOpenApi();

app.MapPost("/products", (CreateProductCommand command) =>
    {


    })
    .WithName("PostProducts")
    .WithOpenApi();

app.Run();
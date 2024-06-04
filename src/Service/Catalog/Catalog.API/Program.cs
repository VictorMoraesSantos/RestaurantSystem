using Catalog.Application.DTOs.Mapping;
using Catalog.Infrasctructure.Data;
using Catalog.Infrasctructure.Repository;
using Catalog.Infrasctructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddAutoMapper(typeof(ProductDTOMappingProfile));
builder.Services.AddAutoMapper(typeof(CategoryDTOMappingProfile));


var app = builder.Build();

app.Run();

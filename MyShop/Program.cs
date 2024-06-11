using Microsoft.EntityFrameworkCore;
using MyShop.Repositories.Implements;
using MyShop.Repositories.Interfaces;
using MyShop.Repository.DBContext;
using MyShop.Repository.Interfaces;
using MyShop.Repository.Service;
using MyShop.Services;
using MyShop.Services.Interfaces;
using MyShop.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// inject contexr
builder.Services.AddDbContext<ShopDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection"))
);

// implement AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// add generic service
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// set api urls to lowercase
builder.Services.AddRouting(routing => routing.LowercaseUrls = true);

// inject services
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserTypeService, UserTypeService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

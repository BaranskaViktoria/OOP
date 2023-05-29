using BeautySalon_EF.DAL.Data;
using BeautySalon_EF.DAL.Data.Repositories;
using BeautySalon_EF.DAL.Interfaces.Repositories;
using TeamworkSystem.DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection for EF database + DbContext
builder.Services.AddDbContext<ProductsContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("MSSQLConnection");
    //options.UseSqlServer(connectionString);
});


builder.Services.AddScoped<IReplyProductsRepository, ProductsRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

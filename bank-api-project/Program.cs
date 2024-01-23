using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data;
using Solid.Data.Repositories;
using Solid.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddControllers().AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//    options.JsonSerializerOptions.WriteIndented = true;
//});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





builder.Services.AddScoped<IBankAcountService, BankAcountService>();
builder.Services.AddScoped<IBankAcountRepository, BankAcountRepository>();
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataBankAcount>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataCustomer>();

builder.Services.AddScoped<IOfficalBankService, OfficialBankService>();
builder.Services.AddScoped<IOfficalBankRepository, OfficialBankRepository>();
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataOfficalBank>();





builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.UseCors("MyPolicy");

app.MapControllers();

app.Run();

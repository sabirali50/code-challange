using AutoMapper;
using Cass_Information_Systems.Mapper;
using CSI.Core.IRepositories;
using CSI.Core.IServices;
using CSI.Infrastructure;
using CSI.Infrastructure.Repositories;
using CSI.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var conn = builder.Configuration.GetConnectionString("DefaultConnection");
// Adding DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
        conn));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfiles));
builder.Services.AddScoped<IShipmentRepository, ShipmentRepository>();
builder.Services.AddScoped<IShipperRepository, ShipperRepository>();
builder.Services.AddScoped<IShipmentService, ShipmentService>();
builder.Services.AddScoped<IShipperService, ShipperService>();
builder.Services.AddScoped<IQuoteService, QuoteService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCors(policy => policy.AllowAnyHeader()
                            .AllowAnyMethod()
                            .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());
app.UseAuthorization();

app.MapControllers();

app.Run();

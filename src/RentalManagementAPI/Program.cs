using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pitstop.RentalCarManagementAPI.MappingProfiles;
using Pitstop.RentalManagementAPI;
using Pitstop.RentalManagementAPI.Filters;
using Pitstop.RentalManagementAPI.Responses;
using Pitstop.RentalManagementAPI.Services;
using Pitstop.RentalManagementAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ExceptionFilter>();
});

builder.Services.AddAutoMapper(typeof(RentalCarProfile), typeof(BrandProfile), typeof(ModelProfile), typeof(CustomerProfile), typeof(RentalReservationResponse));
builder.Services.AddScoped<IRentalPlanningService, RentalPlanningService>();

var sqlConnectionString = builder.Configuration.GetConnectionString("RentalManagementCN");
builder.Services.AddDbContext<RentalManagementDbContext>(options => options.UseSqlServer(sqlConnectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<RentalManagementDbContext>();
    dbContext.Database.Migrate();
}

app.MapControllers();
app.Run();
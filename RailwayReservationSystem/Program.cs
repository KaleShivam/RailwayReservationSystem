using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Repo.RailwayReservationRepository;
using RailwayReservationSystem.Data;
using RailwayReservationSystem.Models;
using RailwayReservationSystem.Repo.RailwayReservationRepository;
using RailwayReservationSystem.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RailwayContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("RailwayCS")));
builder.Services.AddScoped<ITrain, TrainRepository>();
builder.Services.AddScoped<IPassenger, PassengerRepository>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

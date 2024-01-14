using DataAccessCore;
using DataAccessCore.DataAccess.Implementation;
using DataAccessCore.DataAccess.Interfaces;
using DataAccessCore.Mapping;
using MediatR;
using System.Reflection;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<IDataAccessDemo, DataAccessDemo>();
builder.Services.AddMediatR(cfg => {
	cfg.RegisterServicesFromAssembly(typeof(DemoLibraryMediatREntrypoint).Assembly);
});

builder.Services.AddAutoMapper(typeof(MappingProfile));

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

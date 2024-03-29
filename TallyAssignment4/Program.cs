using Microsoft.EntityFrameworkCore;
using TallyAssignment5.Data;
using TallyAssignment5.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddDbContext<ApplicationDBContext>(options => 
        options.UseSqlServer(builder.Configuration.GetConnectionString("TrainDB3Connect")));
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

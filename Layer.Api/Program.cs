using Layer.BLL.Services;
using Layer.DAL;

var builder = WebApplication.CreateBuilder(args);


var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var DbPath = System.IO.Path.Join(path, "db\\schools.sqlite3");

// Add services to the container.
builder.Services.AddDALModule(DbPath);

builder.Services.AddScoped<SchoolService>();

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

using _420BytesProyect.DM.DataBase;
using _420BytesProyect.DM;
using _420BytesProyect.BM.General.Interfaces;
using _420BytesProyect.BM.General;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IConexionBD, ConexionInsightDB>();
builder.Services.AddTransient<IBMUsuarios, BMUsuarios>();
builder.Services.AddTransient<IBMPlantas, BMPlanta>();
builder.Services.AddTransient<IBMDispositivos, BMDispositivo>();
builder.Services.AddTransient<IBMEstados, BMEstados>();
builder.Services.AddHttpClient();




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

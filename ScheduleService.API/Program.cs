using MassTransit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMassTransit(m =>
{
    // If the API us going to use local host rabbitmq leave it like the below
    // otherwise, use configration of your cloud services or etc. inside UsingRabbitMq()
    m.UsingRabbitMq();
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

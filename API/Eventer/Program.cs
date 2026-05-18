using Eventer.Contexts.EventContext.DTOs.Requests;
using Eventer.Contexts.EventContext.Interfaces;
using Eventer.Contexts.EventContext.Repositories;

void AddToContainer(WebApplicationBuilder b)
{
    b.Services.AddOpenApi();
    b.Services.AddControllers();
    b.Services.AddScoped<UpdateEventRequest>();
    b.Services.AddScoped<IEventRepository, EventRepository>();
}

void ConfigureRequestPipeline(WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
        app.UseSwaggerUI(opt => opt.SwaggerEndpoint("/openapi/v1.json", "API v1"));
    }

    app.UseHttpsRedirection();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
AddToContainer(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
ConfigureRequestPipeline(app);

app.Run();
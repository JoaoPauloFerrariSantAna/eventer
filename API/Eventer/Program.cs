void AddToContainer(WebApplicationBuilder b)
{
    b.Services.AddOpenApi();
    b.Services.AddControllers();
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
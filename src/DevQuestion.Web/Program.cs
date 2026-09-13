WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();//controller
builder.Services.AddOpenApi();//openApi

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();//OpenApi
    app.UseSwaggerUI(option => option.SwaggerEndpoint("/openapi/v1.json", "DevQuestions"));//swagger
}

app.MapControllers();//controller

app.Run();

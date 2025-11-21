using api.brainz.group.Core;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//set swagger configuration
builder.Services.AddSwaggerConfig();
//set auth configuration
builder.Services.AddJWTAuth(builder.Configuration);
//set exceptions
builder.Services.AddExceptionConfig();
//set trust
builder.Services.AddTrust();
//TODO: database 

//TODO: injections

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

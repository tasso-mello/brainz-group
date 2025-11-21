using api.brainz.group.Core;
using Swashbuckle.AspNetCore.SwaggerUI;

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
//set database 
builder.Services.AddDatabaseConfig(builder.Configuration);
//TODO: injections

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DocExpansion(DocExpansion.None);
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

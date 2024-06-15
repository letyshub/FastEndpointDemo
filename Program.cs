
using FastEndpoints;
using FastEndpoints.Swagger;
using FastEndpointsDemo;


var builder = WebApplication.CreateBuilder();
builder.Services
   .AddFastEndpoints(o =>
   {
      o.SourceGeneratorDiscoveredTypes.AddRange(DiscoveredTypes.All);
   })
   .SwaggerDocument(o =>
{
   o.DocumentSettings = s =>
   {
      s.Title = "FastEncpoints Demo API";
      s.Version = "v1";
   };
});
builder.Services.AddSingleton<DemoDatabase>();

var app = builder.Build();
app.UseFastEndpoints()
   .UseSwaggerGen();
app.Run();
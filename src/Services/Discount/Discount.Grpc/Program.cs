using Discount.Grpc.Services;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddGrpc();

var app = builder.Build();

// Pipeline
app.MapGrpcService<GreeterService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. " +
    "To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();

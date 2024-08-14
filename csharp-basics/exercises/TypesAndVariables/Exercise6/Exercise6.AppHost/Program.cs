var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Exercise6_ApiService>("apiservice");

builder.AddProject<Projects.Exercise6_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();

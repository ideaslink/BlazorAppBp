var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorAppDemo>("blazorappdemo");

builder.Build().Run();

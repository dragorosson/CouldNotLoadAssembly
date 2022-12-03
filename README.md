docker run -it -v $(pwd):/app mcr.microsoft.com/dotnet/sdk:6.0-focal

dotnet publish -c release -o /app/publish -r linux-x64 --self-contained true CouldNotLoadAssembly.sln

/app/publish/CouldNotLoadAssembly

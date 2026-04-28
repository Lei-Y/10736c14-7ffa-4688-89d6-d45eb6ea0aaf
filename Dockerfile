# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj
COPY LongestIncreasingSubsequence/*.csproj LongestIncreasingSubsequence/
COPY LongestIncreasingSubsequence.Cli/*.csproj LongestIncreasingSubsequence.Cli/
COPY LongestIncreasingSubsequence.Tests/*.csproj LongestIncreasingSubsequence.Tests/
COPY *.sln ./
RUN dotnet restore LongestIncreasingSubsequence.Cli/LongestIncreasingSubsequence.Cli.csproj

# Copy source and publish
COPY LongestIncreasingSubsequence/ LongestIncreasingSubsequence/
COPY LongestIncreasingSubsequence.Cli/ LongestIncreasingSubsequence.Cli/
RUN dotnet publish LongestIncreasingSubsequence.Cli/LongestIncreasingSubsequence.Cli.csproj -c Release -o /app --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "LongestIncreasingSubsequence.Cli.dll"]

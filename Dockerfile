# ── Stage 1: Build ───────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

# Copy csproj and restore dependencies first (layer cache)
COPY AMDD_Exam/AMDD_Exam.csproj AMDD_Exam/
RUN dotnet restore AMDD_Exam/AMDD_Exam.csproj

# Copy everything else and publish
COPY AMDD_Exam/ AMDD_Exam/
WORKDIR /src/AMDD_Exam
RUN dotnet publish AMDD_Exam.csproj -c Release -o /app/publish

# ── Stage 2: Runtime ──────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

# Render injects PORT env var — listen on it
ENV ASPNETCORE_URLS=http://+:${PORT:-8080}
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 8080

ENTRYPOINT ["dotnet", "AMDD_Exam.dll"]

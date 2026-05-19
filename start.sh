#!/bin/bash
docker compose up -d sqlserver
echo "Aguardando SQL Server..."
sleep 5
cd PlantCare.Api && dotnet run
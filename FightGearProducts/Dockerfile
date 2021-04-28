FROM mcr.microsoft.com/dotnet/sdk


COPY /bin/Release/netcoreapp3.1/publish/ FightGearProducts/

ENV ASPNETCORE_ENVIRONMENT Production

EXPOSE 5000
WORKDIR /FightGearProducts
ENTRYPOINT ["dotnet", "FightGearProducts.dll", "--urls=http://0.0.0.0:5000"]
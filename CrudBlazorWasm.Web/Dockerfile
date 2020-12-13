FROM nginx:alpine AS base
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY [".", "CrudBlazorWasm.Web/"]
WORKDIR "/src/CrudBlazorWasm.Web"
RUN dotnet build "CrudBlazorWasm.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CrudBlazorWasm.Web.csproj" -c Release -o /app

FROM base AS final
ENV ASPNETCORE_ENVIRONMENT=Production
COPY --from=publish /app/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf
# Copy the start script  
COPY start.sh ./  
# This command is optional,   
# it is just used to make sure all the EOL unix compliant  
RUN sed -i -e "s/\r$//" start.sh  
# The command that will be executed when the container starts  
CMD /bin/sh ./start.sh 
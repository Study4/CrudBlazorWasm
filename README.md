# CrudBlazorWasm
CRUD - ASP.NET Core Blazor Web Assamble 

Ver : .NET 5

## Feature

Update : 2020-12-12

- Upgrade to .NET 5
- ASP.NET Core Blazor Web Assambly CRUD Sample ( UI )
  - Add Logging
  - Add appsettings.json
  - Docker Support ( Dockerfile )
    - Use Nginx image
    - DockerFile support dotnet build and build docker image
- [Tye](https://github.com/dotnet/tye) support

## 更新履歷

* 2020-12-13
  * Upgrade .NET 5
  * 更新 Tye 的描述
  * 增加環境切換功能
* 2020-06-22
  * 新增 ASP.NET Core Blazor 3.2 Sample
  * ASP.NET Core Blazor Web Assambly CRUD Sample ( UI Only )
    * Docker Support ( Dockerfile )
      * Use Nginx image
      * DockerFile support dotnet build and build docker image
      * [Tye](https://github.com/dotnet/tye) support
* 前略

## 環境參數

* Development : API 連線到 http://localhost:5000
* Tye : API 連線到 http://localhost:5000
* Production : API 連線到 ???? ( 暫時設定 )

## How use - Full Stack

包含前端 ( Blazor ) 和後端 ( API ) 還有 Database。

### Use Tye ( for Mac / Windows / Linux )

Required 
- Need install docker 
- Need install Tye
- Use SQL Server for Linux Container ( Auto Download )

Environment : Tye

```shell
tye run
```

go to https://localhost:4000

## How use - UI Only

僅包含前端 ( UI )。

Note : Not support https://localhost:5001/employee

### Windows - Visual Studio 2019

Environment : N/A

直接使用 Visual Studio 啟動

### Windows / Mac / Linux - CMD / PowerShell / Shell

Environment : N/A

```shell
dotnet build
dotnet run
```

go to https://localhost:5001

### Container only

目前不支援直接使用 Container 來 API ( 但還是可以顯示頁面 )，若要使用 Container 請使用 Tye。原因是因為目前沒有設計將 API 的位置，透過 Docker 參數帶入。


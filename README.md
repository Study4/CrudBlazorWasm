# CrudBlazorWasm
CRUD - ASP.NET Core Blazor - 3.2

## 目標

Update : 2020-06-22

- ASP.NET Core Blazor Web Assambly CRUD Sample ( UI Only )
    - Docker Support ( Dockerfile )
      - Use Nginx image
- DockerFile support dotnet build and build docker image
- [Tye](https://github.com/dotnet/tye) support

## 更新履歷

* 2020-06-22
  * 新增 ASP.NET Core Blazor 3.2 Sample
* 前略

## Issue

* 目前尚無實做環境變數

## How use - Full Stack

暫無

## How use - API Only

僅包含後端 ( API ) 和資料庫。

### Tye ( for Mac / Windows / Linux )
 
- Need install Tye

```shell
tye run
```

go to https://localhost:4000 ( It is Blazor UI)

### Windows - Visual Studio 2019

- 使用 Visual Studio 2019 載入執行

### Windows - CMD or PowerShell

```shell
dotnet build
dotnet run
```

go to https://localhost:4001


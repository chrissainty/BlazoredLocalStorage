# BlazoredLocalStorage
A library to provide access to local storage in Blazor applications

[![NuGet](https://img.shields.io/nuget/v/BlazoredLocalStorage.svg?style=flat-square)](https://www.nuget.org/packages/BlazoredLocalStorage/)

### Installing

You can install from Nuget using the following command:

`Install-Package BlazoredLocalStorage`

Or via the Visual Studio package manger.

### Setup

First, you will need to register local storage with the service provider in your program.cs file

```c#
var serviceProvider = new BrowserServiceProvider(services =>
{
    services.AddLocalStorage();
});
``` 

### Usage
This is an example of using local storage in a .cshtml file 

```c#
@inject ILocalStorage localStorage

@functions {

    protected override void OnInit()
    {
        localStorage.SetItem("name", "John Smith");
        var name = localStorage.GetItem<string>("name");
    }

}
```

The APIs available are
 - SetItem()
 - GetItem()
 - RemoveItem()
 - Clear()
 - Length()
 - Key()

Blazored.LocalStorage methods will handle the serialisation and de-serialisation of the data for you.
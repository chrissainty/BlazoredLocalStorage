# BlazoredLocalStorage
A library to provide access to local storage in Blazor applications

![NuGet](https://img.shields.io/nuget/v/BlazoredLocalStorage.svg?style=flat-square)

### Usage

You can install from Nuget using the following command:

`Install-Package BlazoredLocalStorage`

Or via the Visual Studio package manger.

You will need to add the following using statement

`using Blazored.Js;`

You can then use the following static methods on the `LocalStorage` class.

**Save To Local Storage**
```c#
var stringToSave = "Save me to Local Storage";

LocalStorage.Save("myIdentifier", stringToSave);
```

**Get From Local Storage**
```c#
var stringSavedEarlier = LocalStorage.Get<string>("myIdentifier");
```

**Remove From Local Storage**
```c#
LocalStorage.Remove("myIdentifier");
```

The BlazoredLocalStorage methods will handle the serialisation and deserialisation of the data for you. 

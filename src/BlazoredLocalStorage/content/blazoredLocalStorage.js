Blazor.registerFunction('Blazored.Js.LocalStorage.Save', function (identifier, data) {
    localStorage.setItem(identifier, data);
    return true;
});

Blazor.registerFunction('Blazored.Js.LocalStorage.Get', function (identifier) {
    return localStorage.getItem(identifier);
});

Blazor.registerFunction('Blazored.Js.LocalStorage.Remove', function (identifier) {
    localStorage.removeItem(identifier); return true;
});

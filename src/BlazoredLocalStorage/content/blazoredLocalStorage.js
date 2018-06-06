Blazor.registerFunction('Blazored.Storage.LocalStorage.SetItem', function (identifier, data) {
    localStorage.setItem(identifier, data);
    return true;
});

Blazor.registerFunction('Blazored.Storage.LocalStorage.GetItem', function (identifier) {
    return localStorage.getItem(identifier);
});

Blazor.registerFunction('Blazored.Storage.LocalStorage.RemoveItem', function (identifier) {
    localStorage.removeItem(identifier);
    return true;
});

Blazor.registerFunction('Blazored.Storage.LocalStorage.Clear', function () {
    localStorage.clear();
    return true;
});

Blazor.registerFunction('Blazored.Storage.LocalStorage.Length', function () {
    return localStorage.length;
});

Blazor.registerFunction('Blazored.Storage.LocalStorage.Key', function (index) {
    return localStorage.key(index);
});
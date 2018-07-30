const blazored = {
    localStorage: {
        setItem: (key, data) => {
            window.localStorage.setItem(key, data);
        },
        getItem: (key) => {
            return window.localStorage.getItem(key);
        },
        removeItem: (key) => {
            window.localStorage.removeItem(key);
        },
        clear: () => {
            window.localStorage.clear();
        },
        length: () => {
            return window.localStorage.length;
        },
        key: (index) => {
            return window.localStorage.key(index);
        }
    }
}

window['blazored'] = blazored;

var str = "QXdlc29tZSBCYXNlNjRDb252ZXJ0";
var decodedData = window.atob(str); // decode the string
console.log(decodedData);

var str = "Awesome Base64Convert";
var encodedData = window.btoa(str); // encode a string
console.log(encodedData);

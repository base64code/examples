var str = "QXdlc29tZSBCYXNlNjRDb2Rl";
var decodedData = window.atob(str); // decode the string
console.log(decodedData);

var str = "Awesome Base64Code";
var encodedData = window.btoa(str); // encode a string
console.log(encodedData);



var add = (value1) => (value2) => {
    return value1 + value2;
}

var add10 = add(10);
var add200 = add(200);

console.log(add10(100));
console.log(add10(200));

console.log(add200(10));


var v1 = 100;
var v2 = 200;
console.log(add(100)(200));
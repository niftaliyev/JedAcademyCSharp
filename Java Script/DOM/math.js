// let num = 123.456789;
// console.log(num);
// console.log(Math.floor(num));
// console.log(Math.ceil(num));


let rand = Math.random();

function randNumber(min = 0, max = 10){
    return Math.floor((Math.random() * 1000) % (max - min+1) + min);
}

console.log(randNumber(-5,10));

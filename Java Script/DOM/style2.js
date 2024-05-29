// let box = document.querySelector('.box');
// let style = getComputedStyle(box);
// console.log(style);

// setInterval(() => {
//   let box = document.querySelector(".box");
//   box.style.setProperty("top", "200px");
//   box.style.setProperty("left", "200px");
// }, 1000);

// let boxObj = {
//     elem: document.querySelector(".box"),
//     top: 0,
//     left: 0
// }
// setInterval(() => {
//     boxObj.top += 100;
//     boxObj.left += 100;
//     boxObj.elem.style.setProperty('top',`${boxObj.top}px`);
//     boxObj.elem.style.setProperty('left',`${boxObj.left}px`);
// }, 1000);

let box = document.querySelector(".box");
setInterval(() => {
    let style = getComputedStyle(box);
    let top =parseInt(style.top)+100;
    let left = parseInt(style.left)+100;
    if (window.innerHeight > 500) {
        left = parseInt(style.top)-100;
    }else{
        left = parseInt(style.top)+100;

    }
    box.style.setProperty('top',`${top}px`);
    box.style.setProperty('left',`${left}px`);
}, 1000);

// setTimeout(() => {
//   let boxObj = {
//     elem: document.querySelector(".box"),
//     top: 0,
//     left: 0,
//   };
//   setInterval(() => {
//     boxObj.top += 100;
//     boxObj.left += 100;
//     boxObj.elem.style.setProperty("top", `${boxObj.top}px`);
//     boxObj.elem.style.setProperty("left", `${boxObj.left}px`);
//   }, 1000);
// }, 5000);



// box.style.left = `${window.innerWidth/2}px`;
// box.style.top = `${window.innerHeight/2}px`;

// console.log(window.innerWidth);
// console.log(window.innerHeight);





let menu = document.querySelector('#contextMenu');

document.addEventListener('contextmenu',function(){

    let overlay = document.querySelector('#overlay');
    menu.style.display = 'block';
    overlay.style.display = 'block';

    if (event.y > $(document).height() - 100 && $(window).height() > $(document).height()-100) {
        menu.style.top = (50 + 'px');
        menu.style.left = (50 + 'px');
    }else{
        menu.style.top = event.y + 'px';
        menu.style.left = event.x + 'px';
    }


    event.preventDefault();
});



document.querySelector('#overlay').addEventListener('click',function(){
    event.target.style.display = 'none';
    menu.style.display = 'none';
});


let one = document.querySelector('#one');
let two = document.querySelector('#two');
let three = document.querySelector('#three');
let list = document.querySelector('#list');
let turn = true;

one.addEventListener('click',function(){
    let item = document.createElement('li');
    item.innerHTML += '<i>❌</i>' + event.x;
    list.append(item);

});

two.addEventListener('click',function(){
    let item = document.createElement('li');
    item.innerHTML += '<i>❌</i>' + ' two';
    list.append(item);

});
three.addEventListener('click',function(){
    let item = document.createElement('li');
    item.innerHTML += '<i>❌</i>' + ' three';
    list.append(item);

});
list.addEventListener('click',function(){
    if (turn && event.target.tagName == 'LI') {
        console.log('LI');
        event.target.classList.add('done');
        turn = false;
    }
    else if (turn == false && event.target.tagName == 'LI') {
        console.log('LI');
        event.target.classList.remove('done');
        turn = true;
    }
    else if (event.target.tagName == 'I') {
        console.log('I');
        event.target.parentElement.remove();
        // event.target.classList.add('done');
    }
});







// let boxes = document.querySelectorAll(`[data-counter]`);
// for (const box of boxes) {
//     console.log(box.getAttribute("data-counter"));
//     box.addEventListener('click',function(){
        
//         let number = parseInt(event.target.innerText);
//         number++;
//         event.target.innerText = number;
//     });
// }





// let container = document.querySelector('#boxContainer');

// container.addEventListener('click',function(){
//     if (event.target.className == 'box') {
//         let number = parseInt(event.target.innerText);
//         number++;
//         event.target.innerText = number;
//     }
// });










// let boxes = document.querySelectorAll(".box");
// for (const box of boxes) {
//     box.addEventListener("click",function(){
//         let number = parseInt(event.target.innerText);
//         number++;
//         event.target.innerText = number;
//     });
// }


// document.addEventListener("DOMContentLoaded",function(){
//     let link = document.getElementById("link");
//     link.addEventListener("click",function(){
//         console.log("Clicked...");
//         console.dir(event);
//         event.preventDefault();
//     });
// });


// function logEvent() {
//     console.log("Target");
//     console.log(event.target);
//     console.log("Current target");
//     console.log(event.currentTarget);
// }

// let div = document.getElementById("div");
// let p = document.getElementById("p");
// let span = document.getElementById("span");



// div.addEventListener("click",logEvent);
// p.addEventListener("click",logEvent);
// span.addEventListener("click",logEvent);








// function onDivAction() {
//     console.log('Action!!');
// }

// let redBox = document.getElementById("redBox");
// // redBox.onclick = onDivAction;
// redBox.onclick = undefined;

// document.addEventListener("click",function(){
//     console.log('Action!!');
// });


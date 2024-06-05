



// document.forms.myForm.text.addEventListener('blur',function(){
//     let regex = /^[a-z]{1,}@[a-z]{1,}.[a-z]{2,}$/i;
//     if (!event.target.value.match(regex)) {
//         event.target.classList.add('invalid');
//     }else{
//         event.target.classList.remove('invalid');
//     }
// });



// document.forms.myForm.text.addEventListener('change',function(){
//     if (event.target.value.indexOf('@') > 0) {
//         event.target.classList.remove('invalid');
//     }else{
//         event.target.classList.add('invalid');
//     }
// });


// document.addEventListener('input',function(){
//     console.log(event.target.value);
// });


// document.addEventListener('keyup',function(){
//     console.log(event.key);
// });


// document.addEventListener('keydown',function(){
//     console.log(event.key);
//     if (event.key == 'a') {
//         event.preventDefault();
//     }
// });


// document.addEventListener('keypress',function(){
//     console.log(event.key);
// });


// let textForm = document.getElementById('textForm');
// textForm.addEventListener('submit',function(){
//     console.log(document.forms.myForm.text.value);
//     event.preventDefault();
// });



// let text = document.getElementById('btn');
// text.addEventListener('click',function(){
//     console.log('btn clicked!!');
// });



// let cardBtns = document.querySelectorAll('.card button');
// for (const btn of cardBtns) {
//     btn.addEventListener('click',function(){
//         console.log(event.target);
//         console.log(event.target.parentElement);
//         console.log(event.target.parentElement.previousElementSibling);
//         event.target.parentElement.previousElementSibling.src = './images/img4.jpg'
//     });
// }


/*
    parentElement
    children
    firstElementChildren
    lastElementChildreen
    previousElementSibling
    nextElementSibling

*/
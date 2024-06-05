import { newFunctionOneAsync,newFunctionTwoAsync,newFunctionThreeAsync } from './loadScript.js'

function main(){

    // //// Promise
    try {
        newFunctionOneAsync('one.js');
        console.log('anything');
        newFunctionTwoAsync('two.js');
        newFunctionThreeAsync('three.js');
    } catch (error) {
        console.error(error); 
    }
}



main();




// ////// callback
// function loadScript(src, callback) {


//     setTimeout(() => {

//         //    <script src=""></script>
//         let script = document.createElement('script');

//         //    <script src="two.js"></script>
//         script.src = src;

//         script.onload = function () {
//             console.log('Script loaded...');
//             callback();
//         };

//         script.onerror = function () {
//             // console.log('Not found!'); 
//             // callback(new Error('Not found!'));
//         };

//         document.body.append(script);

//     }, 1000);
// }
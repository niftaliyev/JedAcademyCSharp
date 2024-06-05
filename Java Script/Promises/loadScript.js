

export async function newFunctionThreeAsync(src) {
    let result = await loadScriptThreeAsync(src);
    console.log(result);
    three();
}
export async function newFunctionOneAsync(src) {
    let result = await loadScriptAsyncForOne(src);
    console.log(result);
    one();
}
export async function newFunctionTwoAsync(src) {
    let result = await loadScriptTwoAsync(src);
    console.log(result);
    two();
}
// export function newFunctionOneAsync(src) {
//     loadScriptAsyncForOne(src).then(result =>{
//         console.log(result);
//         one();
//     });

// }



// export async function newFunctionTwoAsync(src) {
//     loadScriptTwoAsync(src).then(result =>{
//     console.log(result);
//     two();
// });
// }
// export async function newFunctionThreeAsync(src) {
//     loadScriptThreeAsync(src).then(result =>{
//     console.log(result);
//     three();
// });

//}


export function loadScriptAsyncForOne(src) {
    return new Promise(function(resolve, reject) {

        setTimeout(() => {
            let script = document.createElement('script');
            script.src = src;
            
            script.onload = function() {
                console.log('Script loaded...'); 
                resolve(src);

            };
        
            script.onerror = function() {
                reject(new Error('Not found!'));
            };
        
            document.body.append(script);
        }, 3000);
        
    });
}

export function loadScriptTwoAsync(src) {
    return new Promise(function(resolve, reject) {

        setTimeout(() => {
            let script = document.createElement('script');
            script.src = src;
            
            script.onload = function() {
                console.log('Script loaded...'); 
                resolve(src);
            };
        
            script.onerror = function() {
                reject(new Error('Not found!'));
            };
        
            document.body.append(script);
        }, 1000);
        
    });
}

export function loadScriptThreeAsync(src) {
    return new Promise(function(resolve, reject) {

        setTimeout(() => {
            let script = document.createElement('script');
            script.src = src;
            
            script.onload = function() {
                console.log('Script loaded...'); 
                resolve(src);

            };
        
            script.onerror = function() {
                reject(new Error('Not found!'));
            };
        
            document.body.append(script);
        }, 15000);
        
                //https://openweathermap.org/api
       // get to weatherapi and take weather info for today
       // get weather apiden bu gunku gune olan hava melumatin getir
       // response return after 15 second
    });
}




// let searchForm = document.forms.userSearch;
// searchForm.addEventListener("submit", onSearch);

// // main();
// // async function main() {
// //   onSearch();
// // }

// async function onSearch() {
//   event.preventDefault();
//   let userName = searchForm.username.value;
//   let response = await getUser(userName);
//   let data = await response.json();
//   document.getElementById("userPhoto").setAttribute("src", data.Poster);
//   document.getElementById("Runtime").innerText =  `Runtime: ${data.Runtime}`;
// }

// async function getUser(userName) {
//   const url = `http://www.omdbapi.com/?apikey=2c9d65d5&t=${userName}`;
//   let response = await fetch(url);
//   return response;
// }

main();
async function main() {
  try {
    const url = "http://www.omdbapi.com/?apikey=2c9d65d5&t=Princ";
    let response = await fetch(url);
    let data = await response.json();
    console.log(data.Poster);
    let imageResponse = await fetch(data.Poster);
    let imgBlob = await imageResponse.blob();


    // var reader = new FileReader();
    // reader.readAsDataURL(imgBlob);
    // reader.onloadend = function () {
    //   var base64data = reader.result;
    //   console.log(base64data);
    // };
    let urlObject = URL.createObjectURL(imgBlob);
    console.log(urlObject);
    document.getElementById("userPhoto").setAttribute("src", urlObject);
  } catch (error) {
    console.log(error);
  }
}

// main();
// async function  main(){
//     try {
//         let response = await fetch(url);
//         let data = await response.json();
//         console.log(data);
//     } catch (error) {
//         console.log(error);
//     }

// }

// main();
// async function  main(){

//     let response = await GetResponseAsync(url);
//     console.log(response);
// }

// function GetResponseAsync(url){

//     return new Promise((resolve,reject) => {
//         let xhr = new XMLHttpRequest();
//         xhr.open('GET',url);
//         xhr.onload = function(){
//             resolve(xhr.response);
//         }
//         xhr.onerror = function(){
//             reject(xhr.statusText);
//         }
//         xhr.send();

//     });

// }

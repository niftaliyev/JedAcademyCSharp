document.addEventListener('DOMContentLoaded',function(){
    changeTheme();
});

document.querySelector('#lightBtn').addEventListener('click',function(){
    document.cookie = 'theme=Light';
    changeTheme();
});
document.querySelector('#darkBtn').addEventListener('click',function(){
    document.cookie = 'theme=Dark';
    changeTheme();
});

function changeTheme(){
    let themeValue = document.cookie.split('=')[1];
    if (themeValue == 'Light') {
        document.body.classList.remove('dark-theme');
        document.body.classList.add('light-theme');
    }
    else if(themeValue == 'Dark'){
        document.body.classList.remove('light-theme');
        document.body.classList.add('dark-theme');
    }
}
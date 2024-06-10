let tasks=[];

document.addEventListener('DOMContentLoaded',function(){

    
    changeTheme();

    let userJson = localStorage.getItem('user');
    if (userJson) {
        const user = JSON.parse(userJson);
        // console.log(user);
        document.forms.enterForm.hidden =true;
        document.getElementById('wellcome').hidden = false;
        document.querySelector('#wellcome h1').innerText = 'Wellcome: ' +  user.name;
        document.querySelector('#wellcome h3').innerText = 'Age: ' + user.age;
    }

    let taskJson = localStorage.getItem('tasks');
    if (taskJson) {
        tasks = JSON.parse(taskJson);
        for (const task of tasks) {
            drawTask(task);
        }
    }
});

document.querySelector('#lightBtn').addEventListener('click',function(){
    localStorage.setItem('theme','Light');
    changeTheme();
    location.reload();

});
document.querySelector('#darkBtn').addEventListener('click',function(){
    localStorage.setItem('theme','Dark');
    changeTheme();
    location.reload();
});


function changeTheme(){
    let themeColor = localStorage.getItem('theme');
    if (themeColor == 'Dark') {
        document.body.classList.remove('light-theme');
        document.body.classList.add('dark-theme');
    }
    else if(themeColor == 'Light'){
        document.body.classList.remove('dark-theme');
        document.body.classList.add('light-theme');
    }
}

document.forms.enterForm.addEventListener('submit',function(){
    let user ={
        name: document.forms.enterForm.name.value,
        age: document.forms.enterForm.age.value
    }
    console.log(user);

    const json = JSON.stringify(user);
    localStorage.setItem('user',json);
    event.preventDefault();
    location.reload();

});

document.forms.todoForm.addEventListener('submit',function(){
    let todo = {
        tittle: document.forms.todoForm.tittle.value,
        id: Date.now()

    }
    tasks.push(todo);
    console.log(tasks);
    localStorage.setItem('tasks',JSON.stringify(tasks));
    document.forms.todoForm.reset();
    location.reload();

    event.preventDefault();
});


function drawTask(task){
    let item = document.createElement('li');
    item.innerHTML = '<i>❌</i>' + task.tittle;
    item.dataset.id = task.id;
    document.getElementById('tasks').append(item);
}

document.querySelector('#tasks').addEventListener('click',function(){
    if (event.target.tagName == 'I') {
        let taskId = event.target.parentElement.dataset.id;
        tasks = tasks.filter(x => x.id != taskId);
        localStorage.setItem('tasks',JSON.stringify(tasks));
        event.target.parentElement.remove();
    }
});
let images = document.querySelectorAll('img');
for (const img of images) {
    img.src = 'https://www.cats.org.uk/media/13136/220325case013.jpg?width=500&height=333.49609375';
}


document.forms.todoForm.addEventListener('submit',function(){
    let item = document.createElement('li');
    item.innerHTML = '<i>❌</i>' + document.forms.todoForm.title.value;
    document.forms.todoForm.reset();
    document.getElementById('tasks').append(item);
    event.preventDefault();
});

document.querySelector('#tasks').addEventListener('click',function(){
    if (event.target.tagName == 'LI') {
        event.target.classList.add('done');
    }else if(event.target.tagName == 'I'){
        event.target.parentElement.remove();
    }
});
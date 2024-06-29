let currentUser = JSON.parse(localStorage.getItem("currentUser"));
if (currentUser) {
    const login = document.getElementById('login');
    login.style.display = 'none';
    const displaynone = document.getElementById('logout');
    displaynone.style.display = 'block';
}
console.log(currentUser);
const isAdmin = document.getElementById('isAdmin');

if (currentUser && currentUser.name == 'admin') {
    isAdmin.style.display = 'block';
}else{
    isAdmin.style.display = 'none';

}


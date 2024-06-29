document.forms.RegisterUser.addEventListener("submit", function () {
    event.preventDefault();
    let user = {
        id: Date.now(),
        name: document.forms.RegisterUser.name.value,
        password: document.forms.RegisterUser.password.value,
        isAdmin: document.forms.RegisterUser.name.value == "admin" ? true : false
      };

    
      let userLocalStorage = JSON.parse(localStorage.getItem('users'));
      console.log(userLocalStorage);

      let users = [];
      if (userLocalStorage) {
        users = userLocalStorage;
        users.push(user);
        localStorage.setItem("users", JSON.stringify(users));
      }else{
        users.push(user);
        localStorage.setItem("users", JSON.stringify(users));
      }
      document.forms.RegisterUser.reset();

});
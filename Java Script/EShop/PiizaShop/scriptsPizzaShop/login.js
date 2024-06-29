let users = JSON.parse(localStorage.getItem("users"));

document.forms.LoginUser.addEventListener("submit", function () {
  event.preventDefault();
  let name = document.forms.LoginUser.name.value;
  let password = document.forms.LoginUser.password.value;
  let currentUser = users.find((x) => x.name == name && x.password === password);

  if (currentUser) {
    localStorage.setItem("currentUser", JSON.stringify(currentUser));
    window.location.href = "./index.html";
  }
});

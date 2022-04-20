const menu = document.querySelector(".menu-mobile");

function showMenu() {
  const navList = document.querySelector(".nav-list");
  navList.classList.toggle("active");
}

menu.addEventListener("click", showMenu);

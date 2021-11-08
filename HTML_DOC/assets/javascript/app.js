var advisorForm =  document.querySelector(".advisorRegister");
var companyForm =  document.querySelector(".companyRegister");
var mobileMenu = document.querySelector(".mobileMenu");
function advisorRegister() {
    companyForm.style.display = "none";
    advisorForm.style.display = "block";
}


function companyRegister() {
    advisorForm.style.display = "none";
    companyForm.style.display = "block";
}

function showMobileMenu() {
    if (mobileMenu.style.display === "none")  return mobileMenu.style.display = "block";
    else (mobileMenu.style.display === "block")
    mobileMenu.style.display = "none";
}
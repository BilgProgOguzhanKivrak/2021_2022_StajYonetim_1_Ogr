function setFormVisibility(companyFormStyle, advisorFormStyle, studentFormStyle) {
    let advisorForm =  document.querySelector(".advisorRegister");
    let companyForm =  document.querySelector(".companyRegister");
    let studentForm = document.querySelector(".studentRegister");
    companyForm.style.display = companyFormStyle;
    advisorForm.style.display = advisorFormStyle;
    studentForm.style.display = studentFormStyle;
}


function advisorRegister() {
    setFormVisibility("none", "block", "none");
}


function companyRegister() {
    setFormVisibility("block", "none", "none");
}

function studentRegister() {
    setFormVisibility("none", "none", "block");
}

function showMobileMenu() {
    let mobileMenu = document.querySelector(".mobileMenu");

    if (mobileMenu.style.display === "none")  return mobileMenu.style.display = "block";
    else (mobileMenu.style.display === "block")
    mobileMenu.style.display = "none";
}


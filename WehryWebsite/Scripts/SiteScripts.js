//  Mobile Menu Button

function MobileNav() {
    var mobilenav = document.getElementById("mobile-nav");
    if (mobilenav.style.display === 'block')
        mobilenav.style.display = "none";
    else
        mobilenav.style.display = "block";
}
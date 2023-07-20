window.addEventListener('resize', changeNav);

let navDropBtn = document.getElementById('nav-drop-btn');
navDropBtn.addEventListener('click', showNav);

let navDropMaxWidth = 670;
let screenWidth; //document.documentElement.clientWidth;
let navBar = document.getElementById('nav-bar');
let iconBars = Array.from(document.getElementsByClassName('icon-bar'));
let navDropCount = 0;

changeNav();

function reportWindowSize() {
    screenWidth = window.innerWidth;
}

function changeNav() {
    reportWindowSize();
    if (screenWidth <= navDropMaxWidth) {
        navDropBtn.style.display = 'inline-block';
        if (navDropCount % 2 == 0) {
            navBar.style.display = 'none';
            logo.classList.remove('drop-logo-settings');
        } else {
            navBar.style.display = 'block';
            logo.classList.add('drop-logo-settings');
        }
    } else {
        navDropBtn.style.display = 'none';
        navBar.style.display = 'flex';
    }
}

function showNav() {
    if (navDropCount % 2 == 0) {
        navBar.style.display = 'block';
        logo.classList.add('drop-logo-settings');
        iconBars.map(ib => ib.style['background-color'] = '#D1B464');
        navDropCount++;
    } else {
        navBar.style.display = 'none';
        logo.classList.remove('drop-logo-settings');
        iconBars.map(ib => ib.style['background-color'] = '#000000');
        navDropCount--;
    }
}
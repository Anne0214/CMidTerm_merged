// tab用
let tabLink = document.getElementById("tab-btns").querySelectorAll("a");
let tabContents = document.getElementById("tab-inner").querySelectorAll('.form-content');

for (let i = 0; i < tabLink.length; i++) {
    tabLink[i].addEventListener('click', function(e) {
        e.preventDefault();
        panelDisplay(this);

    });

};

function panelDisplay(activePanel) {

    for (let i = 0; i < tabLink.length; i++) {

        if (tabLink[i] == activePanel) {
            tabLink[i].classList.add("tab_btn_active");
            tabContents[i].style.display = "block";

        } else {
            tabLink[i].classList.remove("tab_btn_active");
            tabContents[i].style.display = "none";
        }
    }
};


//數量器用
const counter = document.getElementById("num");
const add_btn = document.getElementById("add_btn");
const minus_btn = document.getElementById("minus_btn");
add_btn.addEventListener('click', function() {
    const num = +(counter.value);
    if(num<5)
        counter.value = num+1;
});
minus_btn.addEventListener('click', function() {
    const num1 = +(counter.value);
    if(num1>1)
        counter.value = num1-1;
});
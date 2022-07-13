let counterMinusElem = document.getElementById("leftArrow");
let counterPlusElem = document.getElementById("rightArrow");
let numberOfPage = document.getElementById("numberOfPage");
let count = 1;
let numberOfPages = 5;

updateDisplay();

function leftArrowClick() {
    if (count > 1) {
        count--;
    }
    numberOfPage.innerHTML = count;
}
function rightArrowClick() {
    if (count < numberOfPages) {
        count++;
    }
    numberOfPage.innerHTML = count;
}

function updateDisplay() {
    numberOfPage.innerHTML = count;
};

updateDisplay();

function pickPageFromInputLabel(pickedPage) {
    if (pickedPage >= 1 && pickedPage <= numberOfPages) {
        count = pickedPage;
        numberOfPage.innerHTML = count;
    }
};
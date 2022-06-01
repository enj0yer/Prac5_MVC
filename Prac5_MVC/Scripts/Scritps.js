
document.querySelectorAll(".act_button").forEach(el =>
    el.addEventListener("click", ev => {
        if (document.getElementById("result").value === "Ошибка в вычислениях") {
            document.getElementById("result").value = "";
        }
        document.getElementById("result").value += ev.target.value;
        ev.preventDefault();
    }));

document.querySelectorAll(".clear_field").forEach(el =>
    el.addEventListener("click", ev => {
        document.getElementById("result").value = "";
        ev.preventDefault();
    }));

document.querySelectorAll(".delete_last").forEach(el =>
    el.addEventListener("click", ev => {
        document.getElementById("result").value = document.getElementById("result").value.slice(0, -1);
        ev.preventDefault();
    }));

document.onkeydown = (ev) => {
    let keys = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "+", "Enter", "/", "*", "Delete", "Backspace"];

    if (keys.indexOf(ev.key) !== -1) {
        document.getElementById(ev.key).click();
    }
    ev.preventDefault();
};

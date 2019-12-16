// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function toggle() {
    var target_group = this.id.slice(0, -1);
    var btn1 = document.getElementById(target_group + '1');
    var btn2 = document.getElementById(target_group + '2');

    if (this.id === btn1.id) {
        this.style.display = 'none';
        btn2.innerText = 'Edit';
    } else if (this.id === btn2.id) {
        if (this.innerText === 'Edit') {
            btn1.style.display = 'inline';
            btn2.innerText = 'Cancel';
        } else {
            btn1.style.display = 'none';
            btn2.innerText = 'Edit';
        }
    }
}

document.getElementById('first_btn1').onclick = toggle;
document.getElementById('first_btn2').onclick = toggle;

document.getElementById('second_btn1').onclick = toggle;
document.getElementById('second_btn2').onclick = toggle;

document.getElementById('third_btn1').onclick = toggle;
document.getElementById('third_btn2').onclick = toggle;
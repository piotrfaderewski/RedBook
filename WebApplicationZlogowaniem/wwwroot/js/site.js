// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function toggle(e) {
    var target_group = e.target.id.slice(0, -1);
    var btn1 = document.getElementById(target_group + '1');
    var btn2 = document.getElementById(target_group + '2');

    var parent = e.target.parentNode.parentNode;
    var inputs = parent.getElementsByTagName('input');
    var selects = parent.getElementsByTagName('select');

    if (e.target.id === btn1.id) {
        e.target.style.display = 'none';
        btn2.innerText = 'Edit';
    } else if (e.target.id === btn2.id) {
        if (e.target.innerText === 'Edit') {
            btn1.style.display = 'inline';
            btn2.innerText = 'Cancel';
        } else {
            btn1.style.display = 'none';
            btn2.innerText = 'Edit';
        }
    }
    changeAccess(inputs);
    changeAccess(selects);
}

function changeAccess(inputs) {
    for (let item of inputs) {
        var parent = item.parentNode;
        if (parent.getAttribute('disabled') == null) {
            if (item.disabled === true) {
                item.disabled = false;
            } else {
                item.disabled = true;
            }
        }
    }
}

document.getElementById('first_btn1').onclick = toggle;
document.getElementById('first_btn2').onclick = toggle;

document.getElementById('second_btn1').onclick = toggle;
document.getElementById('second_btn2').onclick = toggle;

document.getElementById('third_btn1').onclick = toggle;
document.getElementById('third_btn2').onclick = toggle;

/* globals $ */

/* 
Create a function that takes an id or DOM element and:
  
*/

function solve() {
  return function (selector) {
    var el;
    if (typeof selector === 'string') {
      el = document.getElementById(selector);
    } else if (selector instanceof HTMLElement) {
      el = document.getElementsByTagName(selector)[0];
    } else {
      throw Error();
    }

    var buttonClasses = document.getElementsByClassName('button');

    [].slice.call(buttonClasses).forEach(function (x) {
      x.innerHTML = 'hide';
    });

    el.addEventListener('click', function (x) {
      if (x.target.className === 'button') {
        var clickedBtn = x.target;
        var nextSibling = clickedBtn.nextElementSibling;
        while (nextSibling) {
          if (nextSibling.className === 'content' && nextSibling.nextElementSibling.className === 'button') {
            if (nextSibling.style.display === 'none') {
              nextSibling.style.display = '';
              x.target.innerHTML = 'hide';
            } else {
              nextSibling.style.display = 'none';
              x.target.innerHTML = 'show';
            }
            break;
          } else {
            nextSibling = nextSibling.nextElementSibling;
          }
        }
      }
    });
  };
}
module.exports = solve;
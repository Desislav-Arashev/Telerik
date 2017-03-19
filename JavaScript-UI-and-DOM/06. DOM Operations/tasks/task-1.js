/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
    if(typeof element === 'string'){
      element = document.getElementById(element);
    }
    
    let div = '';
    for(let item of contents) {
      if (typeof(item) !== 'string' && typeof(item) !== 'number') {
        throw new Error();
      }
      div += '<div>' + item + '</div>';
    }
      element.innerHTML = div;
  };
};
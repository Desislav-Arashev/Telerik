/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {

    if (typeof selector !== 'string' || $(selector).length === 0) {
      throw new Error;
    }

    $('.button').html('hide')
    $('.button').click(function () {
      var nextSibling = $(this).next();
      var hasNextButton = false;
      while (nextSibling.length === 1) {
        if (nextSibling.hasClass('content')) {
          var firstSibling = nextSibling;
          while (firstSibling.length === 1) {
            if(firstSibling.hasClass('button')){
              hasNextButton = true;
              break;
            }
            firstSibling = firstSibling.next();
          }
          if(hasNextButton === false){
            break;
          }
          if (nextSibling.css('display') === 'none') {
            nextSibling.css('display', '');
            $(this).html('hide');
          }else{
          nextSibling.css('display', 'none');
          $(this).html('show');
          }
          break;
        }
        nextSibling = nextSibling.next();
      }
    })
  };
};

module.exports = solve;
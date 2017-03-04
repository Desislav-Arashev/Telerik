function solve(args) {
    var n = +args[0];
    if (n <= 1 ) {
      console.log('false');
    }
    else {
      for (var i = 2; i < n/2 + 1; i++) {
        if (n % i ==0) {
         console.log('false');
         return;
        }
      }
      console.log('true');
    }
}

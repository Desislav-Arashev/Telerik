function solve(args) {
    var number = +args[0];

    if (number < 700) {
      console.log('false 0');
    }
    else {
      number = number / 100;
      var thirdigit = number % 10;
      thirdigit = thirdigit | 0;
      if (thirdigit == 7) {
        console.log('true');
      } else {
        console.log('false ' + thirdigit);
      }
    }
}
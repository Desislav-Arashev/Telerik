function solve(args) {
    var number = +args[0];
    var position = 3;
    var mask = 1 << position;
    var bit = number & mask;
    var result = bit >> position;
    console.log(result);
    }
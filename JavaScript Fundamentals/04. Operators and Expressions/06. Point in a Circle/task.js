function solve(args) {
    var x = +args[0],
        y = +args[1];
    var radius = 2;
    var distance = Math.sqrt((x * x) + (y * y));
    distance = distance.toFixed(2)
    if (distance <= 2) {
        console.log('yes ' + distance);
    } else {
        console.log('no ' + distance);
    }
}
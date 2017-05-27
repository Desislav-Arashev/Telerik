function checkBroserIsMozillaFirefox(event, arguments) {
    var currentWindow = window,
        browser = currentWindow.navigator.appCodeName,
        isMozilaFirefox = (browser === "Mozilla");
    if (isMozilaFirefox) {
        alert("Yes");
    } else {
        alert("No");
    }
}
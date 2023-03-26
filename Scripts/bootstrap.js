var backImg = -1,
    dbStyle = document.body.style,
    backnd = [
        "url('')",
        "url('')"

    ];

function swapBG() {
    dbStyle.backgroundImage = backgnd[backImg++]
        ? backgnd[backImg]
        : backgnd[backImg = 0];
}

// Call swapBG() immediately
swapBG();

// Create an interval that runs every 23 seconds
setInterval(function () {
    swapBG();
    // Create a timeout to run after 2 seconds
    setTimeout(function () {
        swapBG()
    }, 2000);
}, 2000);
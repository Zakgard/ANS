var backImg = -1,
dbStyle = document.body.style,
backnd = [
    "url('https://overclockers.ru/st/legacy/blog/281867/294108_O.png')",
    "url('https://gamesqa.ru/wp-content/uploads/2017/08/wanneer-je-de-helft-van-iemands-leeftijd-bent-ben-je-exact-even-oud-als-zij-waren-toen-jij-geboren-werd.jpg')"
    
];

function swapBG() {
    dbStyle.backgroundImage = backgnd[ backImg++ ]
        ? backgnd[ backImg ]
        : backgnd[ backImg = 0 ];
}

// Call swapBG() immediately
swapBG();

// Create an interval that runs every 23 seconds
setInterval(function(){
   swapBG();
   // Create a timeout to run after 2 seconds
   setTimeout(function(){ 
       swapBG()
   }, 2000 );
}, 23000);
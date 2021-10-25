function display_val() {
    //alert("hello");
    var cMessage = "";
    var color = document.getElementById("colorchoice").value;
    document.getElementById("colorpage").style.background = color;
    if (color === "red") {
        cMessage = "This color has the longest wavelength.";
    }
    if (color === "blue") {
        cMessage = "This color is often associated with water.";
    }
    if (color === "yellow") {
        cMessage = "This color symbolizes optimism, energy, joy, happiness and friendship.";
    }
    if (color === "purple") {
        cMessage = "This color is created from mixing red and blue. (It is also my favorite)";
    }
    if (color === "green") {
        cMessage = "This color is created from mixing yellow and blue.";
    }
    if (color === "orange") {
        cMessage = "This color is created from mixing red and yellow.";
    }
    document.getElementById("colordesc").innerHTML = cMessage;
}
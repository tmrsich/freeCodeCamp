function play(str) {
  var audio = document.getElementById(str);
  audio.play();
  document.getElementById("display").innerText = str
}

window.document.onkeydown = function(event) {
  let key = event.key
  if (key === "q" || key === "Q") {
    play("Q");
  } else if (key === "w" || key === "W") {
    play("W");
  } else if (key === "e" || key === "E") {
    play("E");
  } else if (key === "a" || key === "A") {
    play("A");
  } else if (key === "s" || key === "S") {
    play("S");
  } else if (key === "d" || key === "D") {
    play("D");
  } else if (key === "z" || key === "Z") {
    play("Z");
  } else if (key === "x" || key === "X") {
    play("X");
  } else if (key === "c" || key === "C") {
    play("C");
  }
}
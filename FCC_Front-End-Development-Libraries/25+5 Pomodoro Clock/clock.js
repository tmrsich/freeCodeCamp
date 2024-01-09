// Help provided by the usefulprogrammer youtube channel

// Event listener that displays the default break and session length when the window is loaded
let defaultBreak = document.getElementById("break-length");
let defaultSession = document.getElementById("session-length");
let defaultTime = document.getElementById("time-left");

let breakIncrement = document.getElementById("break-increment");
let breakDecrement = document.getElementById("break-decrement");
let sessionIncrement = document.getElementById("session-increment");
let sessionDecrement = document.getElementById("session-decrement");
let startStop = document.getElementById("start_stop");
let reset = document.getElementById("reset");

let isBreak = false; // Variable to track whether it's break time or session time
let audio = new Audio('your-audio-file.mp3');

window.addEventListener("load", () => {
    defaultBreak.innerText = "5";
    defaultSession.innerText = "25";
    defaultTime.innerText = "25:00";
});

let timer;
let timerState = "stopped";

startStop.addEventListener("click", () => {
    // If the timer has been started
    if (timerState === "stopped") {
        console.log("Timer has been started");
        timerState = "counting";
        timer = setInterval(() => {
            defaultTime.innerText = decrementSecond(defaultTime.innerText);
        }, 1000);
    } else if (timerState === "counting") {
        console.log("Timer has been stopped");
        timerState = "stopped";
        clearInterval(timer);
    }
});

reset.addEventListener("click", () => {
    console.log("Reset button clicked");
    timerState = "stopped";
    clearInterval(timer);
    defaultBreak.innerText = "5";
    defaultSession.innerText = "25";
    defaultTime.innerText = "25:00";
});

breakIncrement.addEventListener("click", () => {
    incrementDecrement(defaultBreak, "increment");
});

breakDecrement.addEventListener("click", () => {
    incrementDecrement(defaultBreak, "decrement");
});

sessionIncrement.addEventListener("click", () => {
    incrementDecrement(defaultSession, "increment");
});

sessionDecrement.addEventListener("click", () => {
    incrementDecrement(defaultSession, "decrement");
});

function incrementDecrement(element, action) {
    let value = parseInt(element.innerText);

    if (action === "increment" && value < 60) {
        value += 1;
    } else if (action === "decrement" && value > 1) {
        value -= 1;
    }

    element.innerText = value.toString();

    // If the timer is stopped, update the time-left display
    if (timerState === "stopped") {
        defaultTime.innerText = value + ":00";
    }
}

function decrementSecond(str) {
    let timeSplit = str.split(":");
    let displayMinute = parseInt(timeSplit[0]);
    let displaySecond = parseInt(timeSplit[1]);

    displaySecond -= 1;

    if (displaySecond === -1) {
        // When the session or break countdown reaches zero
        if (displayMinute === 0) {
            // Switch between session and break
            isBreak = !isBreak;

            if (isBreak) {
                // If it's break time, update the label and set the time to break length
                document.getElementById("timer-label").innerText = "Break";
                displayMinute = parseInt(defaultBreak.innerText);
            } else {
                // If it's session time, update the label and set the time to session length
                document.getElementById("timer-label").innerText = "Session";
                displayMinute = parseInt(defaultSession.innerText);
            }

            displaySecond = 0; // Reset seconds to zero

            // Play the audio when the countdown reaches zero
            audio.play();
        } else {
            // Decrement minute and set seconds to 59
            displaySecond = 59;
            displayMinute -= 1;
        }
    }

    if (displaySecond <= 9) {
        displaySecond = "0" + displaySecond;
    }

    return displayMinute + ":" + displaySecond;
}

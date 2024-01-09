function sentensify(str) {
    // Only change code below this line
    const splitArray = str.split(/\W/);
    const newString = splitArray.join(" ");
    return newString;
  
    // Only change code above this line
  }
  
console.log(sentensify("May-the-force-be-with-you"));
console.log(sentensify("Hello.World"));
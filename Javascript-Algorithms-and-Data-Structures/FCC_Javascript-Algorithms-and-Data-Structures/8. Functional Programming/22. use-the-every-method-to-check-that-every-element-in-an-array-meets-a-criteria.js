function checkPositive(arr) {
  // Only change code below this line
  return arr.every((currentValue) => { return currentValue > 0; });

  // Only change code above this line
}

console.log(checkPositive([1, 2, 3, -4, 5]));
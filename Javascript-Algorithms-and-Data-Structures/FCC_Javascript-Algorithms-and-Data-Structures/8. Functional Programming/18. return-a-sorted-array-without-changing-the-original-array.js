const globalArray = [5, 6, 3, 2, 9];

function nonMutatingSort(arr) {
  // Only change code below this line
  const emptyArray = [];
  const newArray = arr.concat(emptyArray);
  newArray.sort((a, b) => { return a-b; });
  return newArray;
  // Only change code above this line
}

nonMutatingSort(globalArray);

// Used to test output to the console
// console.log(nonMutatingSort(globalArray));
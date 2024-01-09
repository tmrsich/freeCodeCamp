function sumAll(arr) {
  let minimum = Math.min(arr[0], arr[1]);
  let maximum = Math.max(arr[0], arr[1]);
  let betweenSum = 0;
  for (let i = minimum; i <= maximum; i++) {
    betweenSum += i;
  }

  return betweenSum;
}

console.log(sumAll([1, 4]));
let arr = [1, 88, 2, 3, 12, 13,  99, 98, 22, 15, 83];


quickSort(arr);
let findIndex = BinarySearch(arr, 2);
console.log(arr,findIndex);
function quickSort(arr, left = 0, right = arr.length - 1) {
  if (left > right) 
    return ;

    let pivot = partition(arr, left, right);
    quickSort(arr,left, pivot - 1);
    quickSort(arr,pivot + 1, right);
}

function partition(arr, left, right) {
  let pivot = arr[right];
  let i = left;

  for(let j = left; j < right; j++) {
    if (pivot > arr[j]) {
      let temp = arr[j];
      arr[j] = arr[i];
      arr[i] = temp;
      i++;
    }
  }
  let temp = arr[right];
  arr[right] = arr[i];
  arr[i] = temp;
  return i;
}


function BinarySearch(arr, find) {
  let left = 0;
  let right = arr.length - 1;

  while (left <= right) {
    let mid = left + (Math.floor((right - left) / 2));

    if (arr[mid] == find) {
      return mid;
    }
    else if (arr[mid] < find) {
      left  = mid + 1;

    }
    else {
      right =  mid - 1;
    }
  }
}
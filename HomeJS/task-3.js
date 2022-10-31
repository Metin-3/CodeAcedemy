let number = 4568;
let temp = number;
let count = 1;
let sum1 = 0;
let sum2 = 0;

while(temp > 0){
    let num = temp % 10;

    if(count %2 !== 0){
        sum1 = sum1 + num;
    }

    if(count %2 == 0){
        sum2 = sum2 + num;
    }

    temp = parseInt(temp / 10);

    count++;
}

console.log("sum of odd numbers: ", sum1);
console.log("sum of even numbers: ", sum2);
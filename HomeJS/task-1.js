let number = 53478;
let max = 0;
while(number > 0){
    if((number % 10) > max){
        max = number % 10;
    }
    number = parseInt(number / 10);
}

console.log("Max: ", max);
// Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

// Examples
// pigIt('Pig latin is cool'); // igPay atinlay siay oolcay
// pigIt('Hello world !');     // elloHay orldway !

function pigIt(str){
    let returnArr = [];
    let specialChars = ['.','!','?'];
    
    for (let word of str.split(" ")){
      let ayword = '';
      if (!specialChars.includes(word)){
        ayword = word.slice(1) + word.slice(0,1)+"ay";
        }
      
      else{
        ayword = word;
      }
      
      returnArr.push(ayword);
    }
  
    return returnArr.join(' ');
  
  
  }
// Your job is to write a function which increments a string, to create a new string.

// If the string already ends with a number, the number should be incremented by 1.
// If the string does not end with a number. the number 1 should be appended to the new string.
// Examples:

// foo -> foo1

// foobar23 -> foobar24

// foo0042 -> foo0043

// foo9 -> foo10

// foo099 -> foo100

// Attention: If the number has leading zeros the amount of digits should be considered.

function incrementString(str) {
    const numberPattern = /\d+$/;
    const match = str.match(numberPattern);
    
    if (match === null) {
      return str + '1';
    } else {
      const numberStr = match[0];
      const numberLength = numberStr.length;
      const incrementedNumber = (parseInt(numberStr, 10) + 1).toString();
      
      const paddedNumber = incrementedNumber.padStart(numberLength, '0');
      
      return str.slice(0, -numberLength) + paddedNumber;
    }
  }
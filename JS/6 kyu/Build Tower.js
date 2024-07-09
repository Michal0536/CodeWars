// Build Tower
// Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

// For example, a tower with 3 floors looks like this:

// [
//   "  *  ",
//   " *** ", 
//   "*****"
// ]
// And a tower with 6 floors looks like this:

// [
//   "     *     ", 
//   "    ***    ", 
//   "   *****   ", 
//   "  *******  ", 
//   " ********* ", 
//   "***********"
// ]

function towerBuilder(nFloors) 
  {
    let tower = [];
    let maxWidth = 2 * nFloors - 1;

    for (let i = 0; i<nFloors;i++)
      {
          let stars = '*'.repeat(2 * i + 1);
          let spaces = ' '.repeat((maxWidth - stars.length) / 2);
          tower.push(spaces + stars + spaces);
      }

    return tower;
  }
// Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.

//  Three 1's => 1000 points
//  Three 6's =>  600 points
//  Three 5's =>  500 points
//  Three 4's =>  400 points
//  Three 3's =>  300 points
//  Three 2's =>  200 points
//  One   1   =>  100 points
//  One   5   =>   50 point
// A single die can only be counted once in each roll. For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

// Example scoring

//  Throw       Score
//  ---------   ------------------
//  5 1 3 4 1   250:  50 (for the 5) + 2 * 100 (for the 1s)
//  1 1 1 3 1   1100: 1000 (for three 1s) + 100 (for the other 1)
//  2 4 4 5 4   450:  400 (for three 4s) + 50 (for the 5)
// Note: your solution must not modify the input array.

function score(dice) {
    let count = [0, 0, 0, 0, 0, 0];
  
    dice.forEach(die => {
      count[die - 1]++;
    });
  
    let totalScore = 0;
  
    for (let i = 0; i < 6; i++) {
      if (count[i] >= 3) {
        switch (i + 1) {
          case 1:
            totalScore += 1000;
            break;
          case 2:
            totalScore += 200;
            break;
          case 3:
            totalScore += 300;
            break;
          case 4:
            totalScore += 400;
            break;
          case 5:
            totalScore += 500;
            break;
          case 6:
            totalScore += 600;
            break;
        }
        count[i] -= 3;
      }
  
      if (i === 0) {
        totalScore += count[i] * 100;
      } else if (i === 4) {
        totalScore += count[i] * 50;
      }
    }
  
    return totalScore;
  }
  
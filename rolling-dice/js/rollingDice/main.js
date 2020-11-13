function main() {
  // Put your code here
  console.log("Let's roll some dice, baby!");
  console.log("---------------------------");

  for (let i = 0; i < 10; i++) {
    let die1 = Math.floor((Math.random() * 6) + 1);
    let die2 = Math.floor((Math.random() * 6) + 1);

    let message = `${diePic(die1)} + ${diePic(die2)} === ${die1 + die2}`;
    if (die1 === die2) {
      message += " DOUBLES!";
    }

    console.log(message);
  }
}

function diePic(die) {
  switch (die) {
    case 1:
      dieString = "\u2680";
      break;
    case 2:
      dieString = "\u2681";
      break;
    case 3:
      dieString = "\u2682";
      break;
    case 4:
      dieString = "\u2683";
      break;
    case 5:
      dieString = "\u2684";
      break;
    case 6:
      dieString = "\u2685";
      break;
  }
  return dieString;
}

main();
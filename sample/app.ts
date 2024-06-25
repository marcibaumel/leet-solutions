var readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
  });

  function SumValue(): void {
    rl.question('Enter something: ', (input) => {
        const limit = parseInt(input);
        if (!isNaN(limit)) {
            console.log(`You entered: ${limit}`);
            if (limit === Number.MAX_SAFE_INTEGER || limit < 1) {
                console.error('Given value is not good');
            } else {
                let result = 0;
                for (let i = 0; i <= limit; i++) {
                    result += i;
                }
                console.log('Sum:', result);
            }
        } else {
            console.error('Given value is not good');
        }
        rl.close();
    });
}

SumValue()
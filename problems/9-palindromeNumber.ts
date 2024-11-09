export function isPalindromeNumber(num: number): boolean {
    if (num < 0) {
        return false;
    }

    let reversed = 0;
    let original = num;

    while (original > 0) {
        reversed = reversed * 10 + (original % 10);
        original = Math.floor(original / 10);
    }

    return num == reversed;
}

export function isPalindromeString(num: number): boolean {
    return num.toString().split('').reverse().join('') == num.toString();
}
import { isPalindromeNumber, isPalindromeString } from '../app';

describe('Add function test', () => {
    it('Should return the parameter number', () => {
        expect(isPalindromeNumber(121)).toEqual(true);
        expect(isPalindromeNumber(-121)).toEqual(false);
        expect(isPalindromeNumber(10)).toEqual(false);
        expect(isPalindromeString(121)).toEqual(true);
        expect(isPalindromeString(-121)).toEqual(false);
        expect(isPalindromeString(10)).toEqual(false);
    });
});

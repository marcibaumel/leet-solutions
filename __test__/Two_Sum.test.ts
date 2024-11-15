import { twoSum } from '../common/Two_Sum';

describe('Two sum', () => {
    it('Should return indices of the two numbers ', () => {
        expect(twoSum([2, 7, 11, 15], 9)).toEqual([0, 1]);
        expect(twoSum([3, 10, 11, 15], 13)).toEqual([0, 1]);
        expect(twoSum([2, 7, 11, 15], 26)).toEqual([2, 3]);
    });
});
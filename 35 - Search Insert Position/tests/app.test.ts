import { searchInsert } from "../app";

describe('Search Insert Position tests', () => {
    it('Should return the parameter number', () => {
        expect(searchInsert([1,3,5,6], 5)).toEqual(2);
    })
})
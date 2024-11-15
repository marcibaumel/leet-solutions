import { searchInsert } from "../common/Search_Insert_Position";

describe('Search Insert Position tests', () => {
    it('Should return the parameter number', () => {
        expect(searchInsert([1, 3, 5, 6], 5)).toEqual(2);
        expect(searchInsert([1, 3, 5, 6], 2)).toEqual(1);
        expect(searchInsert([1, 3, 5, 6], 0)).toEqual(0);
        expect(searchInsert([1, 3, 5, 6], 57)).toEqual(4);
        expect(searchInsert([1, 3, 5, 6], 7)).toEqual(4);
    })
})
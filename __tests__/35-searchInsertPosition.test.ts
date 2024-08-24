import { searchInsertPosition } from "../problems/35-searchInsertPosition";


describe('Search Insert Position tests', () => {
    it('Should return the parameter number', () => {
        expect(searchInsertPosition([1,3,5,6], 5)).toEqual(2);
        expect(searchInsertPosition([1,3,5,6], 2)).toEqual(1);
        expect(searchInsertPosition([1,3,5,6], 0)).toEqual(0);
        expect(searchInsertPosition([1,3,5,6], 57)).toEqual(4);
        expect(searchInsertPosition([1,3,5,6], 7)).toEqual(4);
    })
})
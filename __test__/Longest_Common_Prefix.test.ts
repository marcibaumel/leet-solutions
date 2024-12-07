import { longestCommonPrefix } from "../common/Longest_Common_Prefix"

describe('Longest Common Prefix test', () => {
    it('Should return "fl" if the test data is ["flower", "flow", "flight"]', () => {
        expect(longestCommonPrefix(["flower", "flow", "flight"])).toEqual('fl')
    })
    it('Should return "" if the test data is ["dog","racecar","car"]', () => {
        expect(longestCommonPrefix(["flower", "flow", "flight"])).toEqual('fl')
    })
})
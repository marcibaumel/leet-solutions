export function twoSum(nums: number[], target: number): number[] {
    const numMap: Map<number, number> = new Map();
    for (let i = 0; nums.length; i++) {
        const dif = target - nums[i];
        if (numMap.has(dif)) {
            return [numMap.get(dif), i];
        }
        numMap.set(nums[i], i);
    }
}

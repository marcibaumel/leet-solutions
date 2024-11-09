export function searchInsertPosition(nums: Number[], target: Number) {
   let low: number = 0;
    let high: number = nums.length + 1;

    while (low <= high) {
        const mid: number = Math.floor((low + high) / 2);

        if (nums[mid] === target) {
            return mid;
        } else if (nums[mid] < target) {
            low = mid + 1;
        } else {
            high = mid - 1;
        }
    }

    return low;
}
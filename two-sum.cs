/*
给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

示例:

给定 nums = [2, 7, 11, 15], target = 9

因为 nums[0] + nums[1] = 2 + 7 = 9
所以返回 [0, 1]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/two-sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
*/

/* 
暴力遍历版本    
时间复杂度：O(n^2）
空间复杂度：O(1)
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0; i<nums.Length; i++){
            for(int j=i+1; j<nums.Length; j++){
                if(nums[i] == target - nums[j]){
                    int[] rtn = new int[2];
                    rtn[0] = i;
                    rtn[1] = j;
                    return rtn;
                }
            }
        }
        return null;
    }
}

/*
一遍哈希版本
时间复杂度 O(n)
空间复杂度 O(1)
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            Dictionary<int,int> numDic = new Dictionary<int,int>();
            for(int i=0; i<nums.Length; i++){
                int rightNum = target - nums[i];
                int rightNumIndex;
                if(numDic.TryGetValue(rightNum, out rightNumIndex)){
                    return new int[] {rightNumIndex, i };
                }
                numDic[nums[i]] = i;
            }
        return null;
    }
}
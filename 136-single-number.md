## 题目
给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

说明：

你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

示例 1:

输入: [2,2,1]
输出: 1
示例 2:

输入: [4,1,2,1,2]
输出: 4

## 解法一

使用HashSet，C#中 HashSet 可以保证不重复，循环一遍添加，如果遇到重复则将元素删除即可

时间复杂度 O（n）
空间复杂度 O（n）

``` c#
public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        for(int i=0; i<nums.Count(); i++){
            if(!numSet.Add(nums[i])){
                numSet.Remove(nums[i]);
            }
        }
        return numSet.First();
    }
}
```

## 解法二

通过异或，题目中含有一个重要条件，列表中 只有一个 不重复元素， 异或具有交换律，可以不考虑操作顺序。相同两数异或之后为0，就只会剩下不相同的元素，

``` c#
public class Solution {
    public int SingleNumber(int[] nums) {
        int num=0;
        for(int i=0; i<nums.Count(); i++){
           num ^= nums[i];
        }
        return num;
    }
}
```
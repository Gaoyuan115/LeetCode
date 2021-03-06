# 题目
给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。

最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。

你可以假设除了整数 0 之外，这个整数不会以零开头。

示例 1:

输入: [1,2,3]
输出: [1,2,4]
解释: 输入数组表示数字 123。
示例 2:

输入: [4,3,2,1]
输出: [4,3,2,2]
解释: 输入数组表示数字 4321。

# 思路
首先能想到一定是倒序遍历，需要处理的特殊情况就是从末尾位进位的问题，自己一开始想的复杂了，使用了一个carry变量在遍历中处理进位的情况。
题解中给出的方案： 因为加的值明确为1，那么只有当前位进位的情况下才会影响到后续的位的值，所有只有在当前位产生进位时才需要继续处理后续位，否则直接停止循环就好了。
另一个需要处理的边界情况是考虑每一位都是9，例如是9999这样的数字，这种情况下的结果长度需要填充一位，后面的数字全部为0。

``` C#
public class Solution {
    public int[] PlusOne(int[] digits) {
        int len = digits.Count();
        for(int i=len-1; i>=0; i--){
            digits[i]++;
            digits[i] = digits[i] % 10;
            if(digits[i] != 0){
                return digits;
            }
        }
        digits = new int[len + 1];
        digits[0] = 1;
        return digits;
    }
}
```
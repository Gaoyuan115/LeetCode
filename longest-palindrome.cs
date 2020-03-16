
/*
给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。

示例 1：

输入: "babad"
输出: "bab"
注意: "aba" 也是一个有效答案。
示例 2：

输入: "cbbd"
输出: "bb"


来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/longest-palindromic-substring
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
*/

/*
暴力搜索法，依次找出所有子串并查询是否为回文字符串。 只是一个最暴力的方案，先放着，回头回来改。。。
时间复杂度：两次循环 O（n^3）外层循环 n^2 内部判断 n
空间复杂度：常量变量 O (1)
*/
public class Solution {
    bool isPalindrome(string s){
        for(int i=0; i<s.Length/2; i++){
            if(s[i] != s[s.Length - i - 1]){
                return false;
            }
        }
        return true;
    }
    public string LongestPalindrome(string s) {
        string longestStr = s;
        int max = 0;
        for(int i=0; i< s.Length; i++){
            for(int j=i+1; j<s.Length; j++){
                string subStr = s.Substring(i, j );
                if(isPalindrome(subStr) && subStr.Length > max){
                    longestStr =subStr;
                    max = subStr.Length;
                }
            }
        }
        return longestStr;
    }

}
/*
给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

示例 1:

输入: "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
示例 2:

输入: "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
示例 3:

输入: "pwwkew"
输出: 3
解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
     请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/longest-substring-without-repeating-characters
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
*/

/*
时间复杂度：O(n)
空间复杂度：O(min(m,n))
滑动窗口法需要 O(k)O(k) 的空间，其中 kk 表示 Set 的大小。而 Set 的大小取决于字符串 nn 的大小以及字符集 / 字母 mm 的大小。
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> charDic = new Dictionary<char, int>();
        int start=0;
        int end = 0;
        int longestLenth = 0;
        while(end < s.Length){
            char curChar = s[end];
            if(charDic.ContainsKey(curChar) && charDic[curChar] >= start){
                start = charDic[curChar] + 1;
            }
            charDic[curChar] = end;     
            end++;
            int length = end - start;
            longestLenth = longestLenth > length ? longestLenth : length;  
        }
        return longestLenth;
    }
}
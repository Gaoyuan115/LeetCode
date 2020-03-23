## 题目
给定两个数组，编写一个函数来计算它们的交集。

示例 1:

输入: nums1 = [1,2,2,1], nums2 = [2,2]
输出: [2,2]
示例 2:

输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
输出: [4,9]
说明：

输出结果中每个元素出现的次数，应与元素在两个数组中出现的次数一致。
我们可以不考虑输出结果的顺序。
进阶:

如果给定的数组已经排好序呢？你将如何优化你的算法？
如果 nums1 的大小比 nums2 小很多，哪种方法更优？
如果 nums2 的元素存储在磁盘上，磁盘内存是有限的，并且你不能一次加载所有的元素到内存中，你该怎么办？

## 题解一

因为题目中不要求考虑输出结果的顺序，我们只需要求出两个数组中有哪些重复元素即可，使用HashMap来求各个元素出现的数量。
第一遍便利数组1，统计各个元素的数量。
遍历数组2，查询hashmap中对应的数量，如果数量大于1则说明该元素是重复元素，加入返回列表，并将hashmap中的数量-1。

时间复杂度 O(n+m)
空间复杂度 O(min(n,m))

``` C#
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int,int> dic1 = new Dictionary<int,int>();
        List<int> rtn = new List<int>(); 
        for(int i=0;i<nums1.Count(); i++){
            int count = 0;
            int num1 = nums1[i];
            if(dic1.TryGetValue(nums1[i],out count)){
                dic1[num1] = count +1;
            } else{
                dic1[num1] = 1;
            }
        }
        for (int i=0; i<nums2.Count(); i++){
            int num2 = nums2[i];
            int count = 0;
            if(dic1.TryGetValue(num2, out count)){
                if(count > 0){
                    dic1[num2] = count-1;
                    rtn.Add(num2);
                }
            }
        }
        return rtn.ToArray();
    }
}
```

## 题解二

双指针排序,先将两个数组排序，再使用两个指针分别指向数组元素。
如有相同元素，则添加至结果列表，并移动指针。
如果结果不同，因为数组已经排序，则移动数字较小的指针，因为再遇到下一个相等数字前两个数组不会再有重复

``` c#
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> list1 = new List<int>(nums1);
        list1.Sort();

        List<int> list2 = new List<int>(nums2);
        list2.Sort();
        
        int i=0; 
        int j=0;

        List<int> rtn = new List<int>();
        while(i<list1.Count() && j<list2.Count()){
            int num1 = list1[i];
            int num2 = list2[j];
            if(num1 > num2){
                j++;
            } else if (num2 > num1) {
                i++;
            } else {
                rtn.Add(num1);
                j++;
                i++;
            }
        }
        return rtn.ToArray();
    }
}
```
# 双指针
## 介绍

双指针，顾名思义，就是利用两个指针去遍历数组，一般来说，遍历数组采用的是单指针（index)去遍历，两个指针一般是在有序数组中使用，一个放首，一个放尾，同时向中间遍历，直到两个指针相交，完成遍历，时间复杂度也是O(n)。

## 用法
一般会有两个指针front,tail。分别指向开始和结束位置。
```
  front = 0;
  tail = A.length()-1

```

一般循环结束条件采用的是判断两指针是否相遇
```
  while(fron < tail)
  {
  ……
  }
```
对于in place交换的问题，循环结束条件一般就是其中一个指针遍历完成。

## 使用范围

多数适用为有序数组当中。用于解决如下问题

+ 数组求和


+ 数组就地交换
26 删除重复元素 一个指针遍历，一个指针寻找操作的元素
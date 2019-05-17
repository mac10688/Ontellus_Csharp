using System;
using System.Collections.Generic;

namespace Library
{
  //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php
  //Modified to use Icomparable T instead of just int
 public static class MergeSort
 {
  
  public static List<T> Sort<T>(List<T> unsorted) where T: IComparable
  {
      if (unsorted.Count <= 1)
        return unsorted;

      List<T> left = new List<T>();
      List<T> right = new List<T>();

      int middle = unsorted.Count / 2;
      for (int i = 0; i < middle;i++)  //Dividing the unsorted list
      {
          left.Add(unsorted[i]);
      }
      for (int i = middle; i < unsorted.Count; i++)
      {
          right.Add(unsorted[i]);
      }

      left = Sort(left);
      right = Sort(right);
      return Merge(left, right);
  }

  private static List<T> Merge<T>(List<T> left, List<T> right) where T: IComparable
  {
      List<T> result = new List<T>();

      while(left.Count > 0 || right.Count>0)
      {
          if (left.Count > 0 && right.Count > 0)
          {
              if (left[0].CompareTo(right[0]) < 0)  //Comparing First two elements to see which is smaller
              {
                  result.Add(left[0]);
                  left.Remove(left[0]);      //Rest of the list minus the first element
              }
              else if(left[0].CompareTo(right[0]) > 0)
              {
                  result.Add(right[0]);
                  right.Remove(right[0]);
              }
              else
              {
                // Removing duplicates
                  left.Remove(left[0]);
              }
          }
          else if(left.Count>0)
          {
              result.Add(left[0]);
              left.Remove(left[0]);
          }
          else if (right.Count > 0)
          {
              result.Add(right[0]);

              right.Remove(right[0]);    
          }    
      }
      return result;
  }

 }
}

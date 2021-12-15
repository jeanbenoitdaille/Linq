    using System;
    using System.Linq;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
             public int CountLessThan(int[] arr, int val){
                return arr.Count(x => x < val);
            }
        }
    }
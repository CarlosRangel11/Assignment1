using System;
using System.Linq;

namespace Assignment1 {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : TempAndSorting {
        //basic temp conversions (returning integers, which truncate the floating point values)
        public int c2f(int c) {
            return (int)((c * (9.0 / 5.0)) + 32.0);
        }

        public int f2c(int f) {
            return (int)((f - 32.0) * (5.0 / 9.0));
        }

        // sorts a given string of numbers by transforming it into an integer array, 
        // sorting that, and transforming that sorted array back into a string. 
        public string sort(string s) {
            string[] numsInString = s.Split(',');
            int[] nums = Array.ConvertAll(numsInString, int.Parse);
            int[] sortedArr = nums.OrderBy(x => x).ToArray();
            string sortedString = string.Join(",", sortedArr);
            return sortedString;
        }
    }
}

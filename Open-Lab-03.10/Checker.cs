using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int nums = 0;
            foreach (var item in str)
	        {
                if(item==letter){
                    nums++;
                }
	        }
            return nums;
        }
    }
}

using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float celkom = 0;
            float counter = 0;
            foreach (float i in nums)
            {
                celkom = celkom + i;
                counter++;
            }
            
            return celkom/counter;
        }
    }
}

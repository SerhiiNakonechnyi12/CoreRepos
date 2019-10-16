using System;
namespace ProjectsCSharp
{
    public class NumberManipulator
    {
        
        public int FindMax(int first, int second)
        {
            int result;

            if (first >second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
        
    }
}

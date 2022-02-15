using System;

namespace Quality
{
    public static class QualityChecker
    {
        public static bool IsQuality(int value)

        {
            if (value < 0)
            {
                throw new ArgumentException("The value must be additive or 0!");
            }
            
            if (value == 0 || value == 1)
            {
                return false;
            }

            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }  
            
            return true;
        }
    }
}

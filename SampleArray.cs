using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingPractice
{
    class SampleArray
    {
        #region "Integer Array"
        /// <Problem-No: 1. Maximum Area of a contianer>
        /// ------------------------------------------------
        /// <ProblemGiven>
        /// 1. Given an array of positive integer where each integer represents the height of vertical line on a chart.
        /// 2. Find two lines which together with x axis forms a container that would hold the greatest amount of water. 
        /// 3. Return the area of water it would hold
        /// </ProblemGiven>
        /// 
        ///     Y Axis
        ///     |
        ///     |
        ///     |
        ///     |
        ///     |
        ///     |        |
        ///     |        |         |
        ///     |        |    |    |
        ///     |   |    |    |    |
        ///     |---|----|----|----|----------------------> X Axis
        /// 
        /// <Analysis>
        /// 1. Area = length * width
        /// 2. Among the 2 lines shorter line will decide the amount of water.
        /// 3. To get the shorter line take min(i,j). that will be the lenght in area calculation formuala.
        /// 4. To get the width, arr[j] - arr[i] will give the distance or the width between 2 points.
        /// </Analysis>
        /// <returns></returns>
        public void SolutionForProblemOne()
        {
            int MaxArea = 0;

            int[] arr = GetArrayofNumbers();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int length = Math.Min(arr[i], arr[j]);
                    int width = j - i; // Math.Abs(i - j);
                    if (MaxArea < length * width)
                    {
                        MaxArea = length * width;
                    }

                }
            }
            Console.WriteLine("Maximmum area = {0} ", MaxArea);
        }

        /// <Problem-No: 2. Return the indices of the 2 integers which makes the sum of a given Target>
        /// <ProblemGiven>
        /// 1. Given array of integers, return the array of two numbers that add up to a given target.
        /// </ProblemGiven>
        /// 
        /// <Analysis>
        /// 1. We to ensure that -ve numbers will be given, one or more solution can form the solution, etc.,?
        /// </Analysis>
        /// </summary>
        public void SolutionForProblemTwo(int target)
        {
            int[] arr = GetArrayofNumbers();
            int[] result = new int[2] { 0, 0 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (target == arr[i] + arr[j])
                    {
                        Console.WriteLine("Target {0} can be retrieved by adding values({1},{2}) at {3} and {4}", target, arr[i], arr[j], i, j);
                    }
                }
            }
        }

        /// <Problem-No: 3. Trapping Rainwater>
        /// <ProblemGiven>
        /// 
        /// </ProblemGiven>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        private int[] GetArrayofNumbers()
        {
            return new int[5] { 9, 1, 3, 6, 7 };
        }
        #endregion

    }
    #region "Armstrong Number"
    public class ArmStrongNumber
    {
        public void CheckForArmStrongNumber(int givenNumber)
        {
            int quotient = givenNumber;
            int remainder;
            int result = 0;

            do
            {
                remainder = quotient % 10; //3 - 5
                result = result + (remainder * remainder * remainder);
                quotient = quotient / 10; //15 -  1

            } while (quotient > 0);
            if (result == givenNumber)
                Console.Write($"Given number {givenNumber} is an ARMSTRONG number");
        }

        public void CheckArmStrongNumberWithString(int givenNumber)
        {
            string numberInString = Convert.ToString(givenNumber);
            int[] givenIntArry = new int[numberInString.Length];
            char[] givenCharArry = numberInString.ToCharArray();

            int result = 0;

            for (int i = 0; i < givenCharArry.Length; i++)
            {
                result = result + (givenCharArry[i] * givenCharArry[i] * givenCharArry[i]);
            }

            if (result == givenNumber)
                Console.WriteLine("ARMSTRONG");
            else
                Console.WriteLine("NO ArmStrong");
        }
    }
    #endregion
}

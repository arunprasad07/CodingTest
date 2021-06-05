using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Arrays"
            SampleArray sampleArray = new SampleArray();

            // Problem One 
            //sampleArray.SolutionForProblemOne();

            //Problem two
            //sampleArray.SolutionForProblemTwo(4);

            //Problem three
            ArmStrongNumber obj = new ArmStrongNumber();
            int number = Convert.ToInt32(Console.ReadLine());
            obj.CheckArmStrongNumberWithString(number);

            #endregion

            Console.ReadKey();
        }

    }

    
}

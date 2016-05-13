using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Author: Pamela Apillanes 
 * Date Created: May 13th, 2016
 * Date Modified: May 13th, 2016
 * Student ID: 300867201  
 * 
 * Description: This program demonstrates GitHub and version control 
 * best practices.  We also explore Unit Testing 
 * 
 * Version: 0.2 - Added GetUserName Method 
 * Check Youtube Chanel: Part 3 
 */

namespace COMP123_S2016_Lesson1B
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName();
        }

        /* For method comments go to YUIDoc for samples 
         * wants us to have comments on our programs and test
         */

        /**
         * This method reads the UserName from teh Console
         * 
         * @method GetUserName 
         * @return {string} UserName
         */
        public static string GetUserName() 
        {
            //Initialize Variables
            string UserName = "";

            Console.Write("Enter UserName: ");
             UserName = Console.ReadLine();

             Console.WriteLine("/n=====================");
             Console.Write("You Entered: " + UserName);

             return UserName;
        }
    }
}

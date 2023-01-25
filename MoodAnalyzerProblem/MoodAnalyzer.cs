using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                //This method is used to check whether the substring occurs within a given string or not
                if (this.message.Contains("Sad")) 
                    return "SAD";
                else
                    return "HAPPY";  //default return value 

            }
            catch (NullReferenceException)
            {

                return "HAPPY?!!";
            }
        }
    }
}

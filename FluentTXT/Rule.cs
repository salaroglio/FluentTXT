using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentTXT
{
    public class MappingRule<T>
    {
        public string _workingText = string.Empty;
        public int baseCount = 0;        
        public Func<string, T, T> testFunc;
        public int Start;
        public int Length;        

        public void SetPropertyRule(Func<string, T, T> function)
        {
            testFunc = function;
        }

        public T GetObjectWithDataMapped(T context, string workingText, int baseCount)
        {
            return testFunc(GetStr(baseCount + Start, Length, workingText), context);
        }

        public string GetStr(int start, int length, string workingText)
        {
            var toReturn = workingText.Substring(start, length);
            return toReturn;
        }



    }
}

using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ai_Can_Calculate_Extension
{
    public class StringToCsharpCode : CodeActivity
    {

        [Category("Input")]
        public InArgument<string> Str { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string str = Str.Get(context);
            //add
            str = str.Replace("add", "+");
            str = str.Replace("plus", "+");

            //minus
            str = str.Replace("minus", "-");
            str = str.Replace("subtract", "-");

            //multiply
            str = str.Replace("times", "*");
            str = str.Replace("multiply by", "*");

            //divide
            str = str.Replace("divde", "/");
            str = str.Replace("divide by", "/");
            str = str.Replace("over", "/");

            //Executable code here
            
        }
    }
}

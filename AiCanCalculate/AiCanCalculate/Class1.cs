using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace AiCanCalculate
{

    public class Speak : CodeActivity
    {
        [Category("Input")]
        public InArgument<string> Message { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Volume = 100;
            synth.Rate = 0;
            synth.Speak(Message.Get(context));
        }
    }

    public class WordSort : CodeActivity
    {
        [Category("Input")]
        public InArgument<string> Message { get; set; }

        [Category("Output")]
        public OutArgument<string> Response { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string message = Message.Get(context);
            if (message.Contains("computer what is "))
            {
                try
                {
                    int messagesize = ("computer what is ").Length;
                    int index = message.IndexOf("computer what is ") + messagesize;
                    int length = message.Length - messagesize;
                    string real = message.Substring(index, length);
                    Response.Set(context, real);
                    return;
                }
                catch (Exception ex)
                {
                    Response.Set(context, "");
                    return;
                }
            }
            Response.Set(context, "");

        }
    }
}

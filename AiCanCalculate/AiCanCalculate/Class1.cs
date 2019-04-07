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
}

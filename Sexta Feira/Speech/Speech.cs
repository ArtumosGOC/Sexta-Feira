using System.Speech.Synthesis;

namespace Sexta_Feira
{


    internal class Speech
    {
        private static SpeechSynthesizer Speech_ = new SpeechSynthesizer();

        public static void VoiceR(string text)
        {
            if (Speech_.State == SynthesizerState.Speaking)
                Speech_.SpeakAsyncCancelAll();
                Speech_.SpeakAsync(text);
        }


    }
}

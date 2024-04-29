using System.Speech.Synthesis;

namespace Sexta_Feira.Speech
{
    internal class Speech
    {

        private static SpeechSynthesizer Speech_ = new SpeechSynthesizer(); // variavel com caracteristicas herdadas da classe.

        public static void VoiceR(string text)// funcao estatica resposavel pela fala.
        {
            if (Speech_.State == /*SynthesizerState.Ready*/SynthesizerState.Speaking)//checa se o status de fala
                Speech_.SpeakAsyncCancelAll();// cancela a fala no momento, caso "SynthesizerState.Ready" a fução só e valida quando "text = String.Empty".
            Speech_.SpeakAsync(text);//fala novo "text"
        }


    }
}

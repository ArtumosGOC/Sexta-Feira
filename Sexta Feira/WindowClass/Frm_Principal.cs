using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace Sexta_Feira
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }
        private SpeechRecognitionEngine Matriz;

        F_in f_In = new F_in();
        F_out f_Out = new F_out();

        private void Form1_Load(object sender, EventArgs e)
        {
            f_Out.CalcList();
            Init();
        }

        private void Init()
        {
            try
            {
                Matriz = new SpeechRecognitionEngine();
                Matriz.SetInputToDefaultAudioDevice();
                Matriz.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(isReal);
                Matriz.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(Volume);

                Choices alternateChoices = new Choices();
                alternateChoices.Add(f_In._InOi.ToArray<string>());




                GrammarBuilder builder = new GrammarBuilder();
                builder.Append(alternateChoices);

                Matriz.LoadGrammar(new Grammar(builder){ Name = "sys" });

                Matriz.RecognizeAsync(RecognizeMode.Multiple);
                Speech.VoiceR("O reconhecimento de voz foi iniciado");




            }
            catch (Exception ERROR)
            {
                MessageBox.Show(ERROR.Message);
            }


        }
        private void isReal(object s, SpeechRecognizedEventArgs e)
        {
           
            string Result_ = e.Result.Text;
            if ((double)e.Result.Confidence <= 0.7)
                return;
            switch (e.Result.Grammar.Name)
            {
                case "sys":
                    try
                    {
                        if (f_In._InOi.Any<string>(x => x == Result_))
                        {
                            for (int i = 0;i< f_In._InOi.Count;i++)
                            {
                                if (i == f_In._InOi.IndexOf(Result_)) Speech.VoiceR(f_Out._OutOI[i]);
                            }

                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
        private void Volume(object s, AudioLevelUpdatedEventArgs e)
        {
            PGB_Volume.Maximum = 100;
            PGB_Volume.Value = e.AudioLevel;
        }
        private void BT_LIST(object sender, EventArgs e)
        {
            Frm_Lista F2 = new Frm_Lista();
            F2.Show();

        }
    }
}
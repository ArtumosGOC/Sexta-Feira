using System;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace Sexta_Feira
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();//metodo de suporte de desingner, recomendado não mexer nisso.
        }
        private SpeechRecognitionEngine Matriz;

        protected F_in f_In = new F_in();// variavel com caracteristicas herdadas da classe.
        protected F_out f_Out = new F_out();// variavel com caracteristicas herdadas da classe.
        

        private void Form1_Load(object sender, EventArgs e)//carrega quando abre "Frm_Principal.*"
        {
            //chama a função para calcular e adcionar falas a lista.
            f_Out.CalcList();
            //chama a função Head do código.
            Init();
        }

        private void Init()
        {
            try//tenta executar o código
            {
                Matriz = new SpeechRecognitionEngine();// variavel com caracteristicas herdadas da classe.
                Matriz.SetInputToDefaultAudioDevice();// Set padrao de input de audio
                Matriz.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(isReal);// Gera reconhecimento de fala.
                Matriz.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(Volume);// faz leitura Nivel de audio.

                Choices ChoicesList = new Choices();// variavel com caracteristicas herdadas da classe.
                ChoicesList.Add(f_In._InOi.ToArray<string>());// ChoicesList adiciona a sua lista de input de fala "f_In._InOi.ToArray<string>()".

                GrammarBuilder builder = new GrammarBuilder();// variavel com caracteristicas herdadas da classe.
                builder.Append(ChoicesList);// Acrecenta a lista "ChoicesList" no construtor de gramática.

                //starta load na gramatica, já com a lista herdada e passado pelo construtor de gramatica,também da nome a "Grammar.Name". 
                Matriz.LoadGrammar(new Grammar(builder) { Name = "sys" }); 

                Matriz.RecognizeAsync(RecognizeMode.Multiple);//como vai tratar input de falas.
                Speech.Speech.VoiceR("O reconhecimento de voz foi iniciado");//chama "Speech.VoiceR(string text)".
            }
            catch (Exception ex)//caso de algum problema na excução do código.
            {
                MessageBox.Show(ex.Message);//mostra uma caixa de dialogo mostrando o erro.
            }


        }
        private void isReal(object s, SpeechRecognizedEventArgs e)//metodo de recomencimento de fala.
        {
           
            string Result_ = e.Result.Text;//"e" recebe input de audio e passa para "Result_".

            //faz uma verificação de voz OBS:quanto maior o número pior fica para identificar fala.
            if ((double)e.Result.Confidence <= 0.7)
                return;
            //usa Grammar.Name como parametro do switch.
            /*switch (e.Result.Grammar.Name)
            {
                case "sys"://caso o parametro "Grammar.Name=\"sys\"" execute:
                    try//tenta executar o código
                    {
                        /*
                        usa um operador bool para comparar string onde se "x lambda == Result_" executa
                        a função.
                        *//*
                        if (f_In._InOi.Any<string>(x => x == Result_))
                        {
                            //laço de repetoção que pega a posição de "f_In._InOi".
                            for (int i = 0;i< f_In._InOi.Count;i++)
                            {
                                /*
                                se i for igual a posição de "f_In._InOi.IndexOf(Result_)" então fale
                                "f_In._InOi[i]".
                                *//*
                                if (i == f_In._InOi.IndexOf(Result_))
                                    Speech.Speech.VoiceR(f_Out._OutOI[i]);
                            }
                            break;
                        }
                    }
                    catch (Exception ex)//caso de algum problema na excução do código.
                    {
                        MessageBox.Show(ex.Message);//mostra uma caixa de dialogo mostrando o erro.
                    }
                    break;
                //default não é usado.
                default:
                    break;
            }*/
            Speech.SpeechSwitch.SpeechReturnSwitch(e.Result.Grammar.Name, Result_); ;
        }
        private void Volume(object s, AudioLevelUpdatedEventArgs e)
        {
            PGB_Volume.Maximum = 100;//usa um progressabar na aplicação.
            PGB_Volume.Value = e.AudioLevel;// passa o valor do progressbar a partir de "AudioLevelUpdatedEventArgs".
        }
        private void BT_LIST(object sender, EventArgs e)
        {
            Frm_Lista F2 = new Frm_Lista();//f2 herda a classe "Frm_Lista".
            F2.Show();//f2 chama "new Frm_Lista".

        }
    }
}
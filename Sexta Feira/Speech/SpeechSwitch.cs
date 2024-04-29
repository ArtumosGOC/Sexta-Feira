using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sexta_Feira.Speech
{
    public class SpeechSwitch
    {

        public static void SpeechReturnSwitch(string Grammarname,string Result) 
        {

            F_in f_In = new F_in();
            F_out f_Out = new F_out();

            f_Out.CalcList();

            switch (Grammarname)
            {
                case "sys"://caso o parametro "Grammar.Name=\"sys\"" execute:
                    try//tenta executar o código
                    {
                        /*
                        usa um operador bool para comparar string onde se "x lambda == Result_" executa
                        a função.
                        */
                        if (f_In._InOi.Any<string>(x => x == Result))
                        {
                            //laço de repetoção que pega a posição de "f_In._InOi".
                            for (int i = 0; i < f_In._InOi.Count; i++)
                            {
                                /*
                                se i for igual a posição de "f_In._InOi.IndexOf(Result_)" então fale
                                "f_In._InOi[i]".
                                */
                                if (i == f_In._InOi.IndexOf(Result))
                                    Speech.VoiceR(f_Out._OutOI[i]);
                            }
                            break;
                        }
                    }
                    catch (Exception ex)//caso de algum problema na excução do código.
                    {
                        MessageBox.Show(ex.Message);//mostra uma caixa de dialogo mostrando o erro.
                    }
                    break;
            }
        }
            
    }
}

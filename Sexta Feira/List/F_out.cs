using System.Collections.Generic;

namespace Sexta_Feira
{
    public class F_out
    {
        protected F_in f_In = new F_in();// variavel com caracteristicas herdadas da classe.

        public List<string> _OutOI = new List<string>();// lista de publica strings.

        public void CalcList() //funcao sem retorno.
        {
            for (int i = 0; i < f_In._InOi.Count; i++)// obtem posições presentes em "f_In._InOi" para criar um laço de repetição.
            {
                _OutOI.Add(f_In._InOi[i].ToString());//adciona as words na lista com forme o valor de "i". 
            }
        }
    }
}

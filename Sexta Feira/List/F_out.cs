using System.Collections.Generic;

namespace Sexta_Feira
{
    public class F_out
    {
        F_in f_In = new F_in();
        public List<string> _OutOI = new List<string>();

        public void CalcList() 
        {
            for (int i = 0; i < f_In._InOi.Count; i++)
            {
                _OutOI.Add(f_In._InOi[i].ToString());
            }
        }
    }
}

using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Sexta_Feira
{
    public partial class Frm_Lista : Form
    {
        protected F_in f_In = new F_in();// variavel com caracteristicas herdadas da classe.
        protected F_out f_Out = new F_out();// variavel com caracteristicas herdadas da classe.

        public Frm_Lista()
        {
            InitializeComponent();//metodo de suporte de desingner, recomendado não mexer nisso.
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void ListForm_Load(object sender, EventArgs e)//carrega quando abre "Frm_Lista.*"
        {
            //"GB001.Text" recebe informações do windows.
            GB001.Text = "\"" + Environment.UserName + " --- " + Dns.GetHostEntry(Environment.MachineName).HostName + " --- " + Environment.OSVersion + "\"";

            //procura string's dentro de "f_In._InOi"
            foreach (String i in f_In._InOi.ToArray<string>()) 
            {
                RTBD_F.Text += i + "\n";//"RTBD_F.Text" recebe texto contido em "i" depois da uma quebra de linha.
            }

            //chama a função para calcular e adcionar falas a lista.
            f_Out.CalcList();

            //procura string's dentro de "f_Out._OutOI"
            foreach (String i in f_Out._OutOI.ToArray<string>())
            {
                RTBD_R.Text += i + "\n";//"RTBD_R.Text" recebe texto contido em "i" depois da uma quebra de linha.
            }

        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)//executada quando está fechando "Frm_Lista.*".
        {
            Frm_Lista F2 = new Frm_Lista();// variavel com caracteristicas herdadas da classe.
            F2.Close();// fecha windows form.
            /* não lembro por que criei isso, acredito que não interfira o código caso deletada */
        }
    }
}

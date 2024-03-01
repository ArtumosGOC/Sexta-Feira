using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Sexta_Feira
{
    public partial class Frm_Lista : Form
    {
        F_in f_In = new F_in();
        F_out f_Out = new F_out();
        public Frm_Lista()
        {
            InitializeComponent();
 
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            
            GB001.Text = "\"" + Environment.UserName + " --- " + Dns.GetHostEntry(Environment.MachineName).HostName + " --- " + Environment.OSVersion + "\"";

            foreach (String i in f_In._InOi.ToArray<string>()) 
            {
                RTBD_F.Text += i + "\n";
            }
            f_Out.CalcList();
            foreach (String i in f_Out._OutOI.ToArray<string>())
            {
                RTBD_R.Text += i + "\n";
            }

        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Lista F2 = new Frm_Lista();
            F2.Close();
        }
    }
}

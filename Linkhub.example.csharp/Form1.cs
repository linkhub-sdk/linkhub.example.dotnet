using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Linkhub;
namespace Linkhub.example.csharp
{
  

    public partial class Form1 : Form
    {

        private const String ServiceID = "POPBILL_TEST";
        private const String LinkID = "TESTER";
        private const String SecretKey = "lPyb3alKnKOPEzbigVix/W/1JLiF2Hs71ey15bYCewI=";


        private Authority auth = new Authority(LinkID, SecretKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Token t = auth.getToken("POPBILL_TEST", "1231212312", new List<String>(new String[] { "110" }));
                MessageBox.Show(t.session_token);
            }
            catch (LinkhubException le)
            {
                MessageBox.Show(le.code + "|" + le.Message);
            }
        }
    }
}

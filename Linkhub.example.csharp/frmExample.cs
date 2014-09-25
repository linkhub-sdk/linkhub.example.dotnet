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
  

    public partial class frmExample : Form
    {

        private const String ServiceID = "POPBILL_TEST";
        private const String LinkID = "TESTER";
        private const String SecretKey = "++SqIwwhxoY+EiBzgGLk3Li0IYUOKWR29yUtxrOOgnY=";


        private Authority auth = new Authority(LinkID, SecretKey);

        public frmExample()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Token t = auth.getToken("POPBILL_TEST", "1231212312", new List<String>(new String[] { "110" }));
                MessageBox.Show(t.session_token);
                TextBox1.Text = t.session_token;
            }
            catch (LinkhubException le)
            {
                MessageBox.Show(le.code + "|" + le.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Double remainPoint = auth.getBalance(TextBox1.Text, ServiceID);

                MessageBox.Show(remainPoint.ToString());
            }
            catch (LinkhubException le)
            {
                MessageBox.Show(le.code + "|" + le.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Double remainPoint = auth.getPartnerBalance(TextBox1.Text, ServiceID);

                MessageBox.Show(remainPoint.ToString());
            }
            catch (LinkhubException le)
            {
                MessageBox.Show(le.code + "|" + le.Message);
            }
        }
    }
}

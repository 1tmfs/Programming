using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_RadioButton
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string s = "";

            if(rbKorea.Checked)
                s += "국적 : 대한민국\n";
            else if (rbChina.Checked)
                s += "국적 : 중국\n";
            else if (rbJapan.Checked)
                s += "국적 : 일본\n";
            else if (rbOthers.Checked)
                s += "국적 : 그 외의 국가\n";

            if (rbMale.Checked)
                s += "성별 : 남성";
            else if (rbFemale.Checked)
                s += "성별 : 여성";

            MessageBox.Show(s, "결과");
        }
    }
}

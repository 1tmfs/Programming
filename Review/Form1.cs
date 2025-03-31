using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkStates = "";
            CheckBox[] cBox
                = { checkBox1, checkBox2, checkBox3 };

            foreach (var item in cBox)
            {
                checkStates += string.Format("{0} : {1}\n",
                    item.Text, item.Checked);
            }
            MessageBox.Show(checkStates, "checkStates");

            string summary = string.Format("단일 메뉴 팬이시군요!");

            string summary2 = string.Format("두 가지 맛을 즐기시네요!");

            string summary3 = string.Format("모든 음식을 좋아하시군요!");

            foreach(var item in cBox)
            {
                if (item.Checked == true)
                    summary += item.Text + " "
;            }
            MessageBox.Show(summary, "summary");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GradeCalculate: Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;
        public GradeCalculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = "인체의구조와기능";
            txt2.Text = "일반수학I";
            txt3.Text = "디지털공학및실험";
            txt4.Text = "비주얼프로그래밍";
            txt5.Text = "설계및프로젝트기본I";
            txt6.Text = "데이터사이언스";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_PictureBox_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);
            h /= 100;
            double bmi = w / (h * h);

            lblBMI.Text = string.Format("당신의 BMI = {0:F1}", bmi);

            if (bmi < 20)
            {
                lblResult.Text = "저체중입니다.";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (bmi >= 20 && bmi < 25)
            {
                lblResult.Text = "정상체중입니다.";
                pictureBox1.BackColor = Color.Green;
            }
            else if (bmi >= 25 && bmi < 30)
            {
                lblResult.Text = "경도비만입니다.";
                pictureBox1.BackColor = Color.Yellow;
            }
            else if (bmi >= 30 && bmi < 40)
            {
                lblResult.Text = "비만입니다.";
                pictureBox1.BackColor = Color.Orange;
            }
            else
            {
                lblResult.Text = "고도비만입니다.";
                pictureBox1.BackColor = Color.Red;
            }
        }
    }
}

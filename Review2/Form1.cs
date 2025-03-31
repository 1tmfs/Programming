using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKRW.Text == "" && txtUSD.Text != "") // 조건문 수정
            {
                double usd = double.Parse(txtUSD.Text); // 세미콜론 제거
                double Krw = 1449 * usd; // 변수 선언 분리
                txtKRW.Text = Krw.ToString() + "\\"; // 콤마(,) 제거
            }

            if (txtUSD.Text == "" && txtKRW.Text != "") // 조건문 수정
            {
                double krw = double.Parse(txtKRW.Text);
                double usd = krw / 1449; // txtUSD에 직접 숫자 할당하는 오류 수정
                txtUSD.Text = usd.ToString() + "$"; // txtUSD.Text에 값을 할당
            }
        }

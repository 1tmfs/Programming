﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_ScoreCalculate
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(txtKorean.Text)
                + Convert.ToDouble(txtMath.Text)
                + Convert.ToDouble(txtEnglish.Text);

            double avg = sum / 3;

            txtSum.Text = sum.ToString();
            txtAvg.Text = avg.ToString("0.0");
        }
    }
}

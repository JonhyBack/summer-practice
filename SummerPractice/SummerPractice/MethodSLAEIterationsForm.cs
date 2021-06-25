using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumericalMethods;

namespace SummerPractice
{
    public partial class MethodSLAEIterationsForm : Form
    {
        public MethodSLAEIterationsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodSLAEIterations methodSLAE = new MethodSLAEIterations();
            methodSLAE.f();

            label1.Text = "x1: " + methodSLAE.X1;
            label2.Text = "x2: " + methodSLAE.X2;
            label3.Text = "x3: " + methodSLAE.X3;
            label4.Text = "x4: " + methodSLAE.X4;
        }
    }
}

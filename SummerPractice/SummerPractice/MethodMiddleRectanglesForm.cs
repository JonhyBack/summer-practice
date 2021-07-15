using System;
using System.Windows.Forms;
using NumericalMethods;

namespace SummerPractice
{
    public partial class MethodMiddleRectanglesForm : Form
    {
        public MethodMiddleRectanglesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var methodRect = new MethodMiddleRectangles();
            var result = methodRect.CalcIntegral(100);

            label1.Text = "Result:" + result;
        }
    }
}

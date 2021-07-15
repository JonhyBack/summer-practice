using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using NumericalMethods;

namespace SummerPractice
{
    public partial class MethodSplineInterPolinomForm : Form
    {
        public MethodSplineInterPolinomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();

            var spline = new MethodSplineInterPolinom();
            var ArrayY = spline.Calculate();

            formsPlot1.Plot.AddScatter(spline.ArrayX.Skip(1).ToArray(), ArrayY, Color.Red, markerSize: 3, label: "Spline");
            formsPlot1.Plot.Legend();
        }

    }
}

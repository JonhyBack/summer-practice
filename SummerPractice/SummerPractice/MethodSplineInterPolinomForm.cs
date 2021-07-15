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
    public partial class MethodSplineInterPolinomForm : Form
    {
        public MethodSplineInterPolinomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            double[] xs = new double[6] { -6.5, -4.5, -2.5, -0.5, 1.5, 3.5 };
            double[] ys = new double[6] { 130, 94, 66, 46, 38, 38 };

            //var sip = new MethodSplineInterPolinom();
            //double[] y = new double[6];

            //for (int i = 1; i < y.Length; i++)
            //{
            //    y[i-1] = sip.f(xs[i-1], i);
            //}

            var nsi = new ScottPlot.Statistics.Interpolation.NaturalSpline(xs, ys, resolution: 20);

            //formsPlot1.Plot.AddScatter(xs, y, Color.Blue, markerSize: 3, label: "My Spline");
            formsPlot1.Plot.AddScatter(nsi.interpolatedXs, nsi.interpolatedYs, Color.Red, markerSize: 3, label: "Natural Spline");
            formsPlot1.Plot.Legend();
        }

    }
}

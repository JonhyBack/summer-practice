using System;
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
            dataGridView1.Rows.Clear();

            MethodSLAEIterations methodSLAE = new MethodSLAEIterations();
            var points = methodSLAE.Calculate();

            for (int i = 0; i < points.Count; i++)
            {
                dataGridView1.Rows.Add(i, points[i].X1, points[i].X2, points[i].X3, points[i].X4);
            }
        }
    }
}

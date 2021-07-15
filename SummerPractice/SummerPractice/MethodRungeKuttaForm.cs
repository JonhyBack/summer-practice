using System;
using System.Windows.Forms;
using NumericalMethods;

namespace SummerPractice
{
    public partial class MethodRungeKuttaForm : Form
    {
        public MethodRungeKuttaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var methodRK = new MethodRungeKutta();
            var result = methodRK.Calculate();

            for (int i = 0; i < result.Count; i++)
            {
                dataGridView1.Rows.Add(i, result[i].X, result[i].Y, result[i].A1, result[i].A2, result[i].A3, result[i].A4, result[i].A);
            }
        }
    }
}

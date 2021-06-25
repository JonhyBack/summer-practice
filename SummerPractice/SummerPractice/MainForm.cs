using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummerPractice
{
    public partial class MainForm : Form
    {
        private Form _activeForm = null;
        private IconButton _currentBtn;
        private Panel _leftBorderBtn;

        public MainForm()
        {
            InitializeComponent();

            _leftBorderBtn = new Panel();
            _leftBorderBtn.Size = new Size(7, 55);
            _leftBorderBtn.BackColor = Color.BlueViolet;
            panelMenu.Controls.Add(_leftBorderBtn);
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                _currentBtn = (IconButton)senderBtn;
                _currentBtn.BackColor = Color.LightGray;
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            
                _leftBorderBtn.Location = new Point(0, _currentBtn.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = Color.Gainsboro;
                _currentBtn.ForeColor = Color.Black;
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _leftBorderBtn.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MethodSLAEIterations_button_Click(object sender, EventArgs e)
        {
            openChildForm(new MethodSLAEIterationsForm());
            ActivateButton(sender);
        }

        private void MethodSplineInterPolinom_button_Click(object sender, EventArgs e)
        {
            openChildForm(new MethodSplineInterPolinomForm());
            ActivateButton(sender);
        }

        private void MethodMiddleTriangles_button_Click(object sender, EventArgs e)
        {
            openChildForm(new MethodMiddleRectanglesForm());
            ActivateButton(sender);
        }

        private void MethodRungeKutta_button_Click(object sender, EventArgs e)
        {
            openChildForm(new MethodRungeKuttaForm());
            ActivateButton(sender);
        }

        private void pictureBox_icon_Click(object sender, EventArgs e)
        {
            DisableButton();

            if (_activeForm != null)
            {
                _activeForm.Close();
            }
        }
    }
}

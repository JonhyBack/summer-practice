
namespace SummerPractice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MethodRungeKutta_button = new FontAwesome.Sharp.IconButton();
            this.MethodMiddleTriangles_button = new FontAwesome.Sharp.IconButton();
            this.MethodSplineInterPolinom_button = new FontAwesome.Sharp.IconButton();
            this.MethodSLAEIterations_button = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_icon = new FontAwesome.Sharp.IconPictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Controls.Add(this.MethodRungeKutta_button);
            this.panelMenu.Controls.Add(this.MethodMiddleTriangles_button);
            this.panelMenu.Controls.Add(this.MethodSplineInterPolinom_button);
            this.panelMenu.Controls.Add(this.MethodSLAEIterations_button);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(175, 361);
            this.panelMenu.TabIndex = 0;
            // 
            // MethodRungeKutta_button
            // 
            this.MethodRungeKutta_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MethodRungeKutta_button.FlatAppearance.BorderSize = 0;
            this.MethodRungeKutta_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodRungeKutta_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MethodRungeKutta_button.IconColor = System.Drawing.Color.Black;
            this.MethodRungeKutta_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MethodRungeKutta_button.Location = new System.Drawing.Point(0, 265);
            this.MethodRungeKutta_button.Name = "MethodRungeKutta_button";
            this.MethodRungeKutta_button.Size = new System.Drawing.Size(175, 55);
            this.MethodRungeKutta_button.TabIndex = 11;
            this.MethodRungeKutta_button.Text = "4. Розв’язання диференціального рівняння методом Рунге-Кутта. ";
            this.MethodRungeKutta_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MethodRungeKutta_button.UseVisualStyleBackColor = false;
            this.MethodRungeKutta_button.Click += new System.EventHandler(this.MethodRungeKutta_button_Click);
            // 
            // MethodMiddleTriangles_button
            // 
            this.MethodMiddleTriangles_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MethodMiddleTriangles_button.FlatAppearance.BorderSize = 0;
            this.MethodMiddleTriangles_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodMiddleTriangles_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MethodMiddleTriangles_button.IconColor = System.Drawing.Color.Black;
            this.MethodMiddleTriangles_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MethodMiddleTriangles_button.Location = new System.Drawing.Point(0, 210);
            this.MethodMiddleTriangles_button.Name = "MethodMiddleTriangles_button";
            this.MethodMiddleTriangles_button.Size = new System.Drawing.Size(175, 55);
            this.MethodMiddleTriangles_button.TabIndex = 10;
            this.MethodMiddleTriangles_button.Text = "3. Обчислення за допомогою методу середніх прямокутників";
            this.MethodMiddleTriangles_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MethodMiddleTriangles_button.UseVisualStyleBackColor = false;
            this.MethodMiddleTriangles_button.Click += new System.EventHandler(this.MethodMiddleTriangles_button_Click);
            // 
            // MethodSplineInterPolinom_button
            // 
            this.MethodSplineInterPolinom_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MethodSplineInterPolinom_button.FlatAppearance.BorderSize = 0;
            this.MethodSplineInterPolinom_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodSplineInterPolinom_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MethodSplineInterPolinom_button.IconColor = System.Drawing.Color.Black;
            this.MethodSplineInterPolinom_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MethodSplineInterPolinom_button.Location = new System.Drawing.Point(0, 155);
            this.MethodSplineInterPolinom_button.Name = "MethodSplineInterPolinom_button";
            this.MethodSplineInterPolinom_button.Size = new System.Drawing.Size(175, 55);
            this.MethodSplineInterPolinom_button.TabIndex = 9;
            this.MethodSplineInterPolinom_button.Text = "2. За табличними даними побудувати сплайн - інтерполяційний поліном  ";
            this.MethodSplineInterPolinom_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MethodSplineInterPolinom_button.UseVisualStyleBackColor = false;
            this.MethodSplineInterPolinom_button.Click += new System.EventHandler(this.MethodSplineInterPolinom_button_Click);
            // 
            // MethodSLAEIterations_button
            // 
            this.MethodSLAEIterations_button.BackColor = System.Drawing.Color.Gainsboro;
            this.MethodSLAEIterations_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MethodSLAEIterations_button.FlatAppearance.BorderSize = 0;
            this.MethodSLAEIterations_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodSLAEIterations_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.MethodSLAEIterations_button.IconColor = System.Drawing.Color.Black;
            this.MethodSLAEIterations_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MethodSLAEIterations_button.Location = new System.Drawing.Point(0, 100);
            this.MethodSLAEIterations_button.Name = "MethodSLAEIterations_button";
            this.MethodSLAEIterations_button.Size = new System.Drawing.Size(175, 55);
            this.MethodSLAEIterations_button.TabIndex = 8;
            this.MethodSLAEIterations_button.Text = "1. Розв’язання системи лінійних рівнянь методом ітерацій ";
            this.MethodSLAEIterations_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MethodSLAEIterations_button.UseVisualStyleBackColor = false;
            this.MethodSLAEIterations_button.Click += new System.EventHandler(this.MethodSLAEIterations_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_icon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 100);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_icon.ForeColor = System.Drawing.Color.BlueViolet;
            this.pictureBox_icon.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.pictureBox_icon.IconColor = System.Drawing.Color.BlueViolet;
            this.pictureBox_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBox_icon.IconSize = 100;
            this.pictureBox_icon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(175, 100);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            this.pictureBox_icon.Click += new System.EventHandler(this.pictureBox_icon_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(175, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(609, 361);
            this.panelChildForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click any button on the left panel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "Summer Practice";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton MethodSLAEIterations_button;
        private FontAwesome.Sharp.IconButton MethodSplineInterPolinom_button;
        private FontAwesome.Sharp.IconButton MethodMiddleTriangles_button;
        private FontAwesome.Sharp.IconButton MethodRungeKutta_button;
        private FontAwesome.Sharp.IconPictureBox pictureBox_icon;
        private System.Windows.Forms.Label label1;
    }
}


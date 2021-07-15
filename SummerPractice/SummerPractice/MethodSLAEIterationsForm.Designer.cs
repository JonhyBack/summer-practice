
namespace SummerPractice
{
    partial class MethodSLAEIterationsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_X4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_n,
            this.Column_X1,
            this.Column_X2,
            this.Column_X3,
            this.Column_X4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(468, 337);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_n
            // 
            this.Column_n.HeaderText = "n";
            this.Column_n.Name = "Column_n";
            this.Column_n.ReadOnly = true;
            // 
            // Column_X1
            // 
            this.Column_X1.HeaderText = "X1";
            this.Column_X1.Name = "Column_X1";
            this.Column_X1.ReadOnly = true;
            // 
            // Column_X2
            // 
            this.Column_X2.HeaderText = "X2";
            this.Column_X2.Name = "Column_X2";
            this.Column_X2.ReadOnly = true;
            // 
            // Column_X3
            // 
            this.Column_X3.HeaderText = "X3";
            this.Column_X3.Name = "Column_X3";
            this.Column_X3.ReadOnly = true;
            // 
            // Column_X4
            // 
            this.Column_X4.HeaderText = "X4";
            this.Column_X4.Name = "Column_X4";
            this.Column_X4.ReadOnly = true;
            // 
            // MethodSLAEIterationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MethodSLAEIterationsForm";
            this.Text = "Method Iteration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X4;
    }
}
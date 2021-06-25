
namespace SummerPractice
{
    partial class MethodRungeKuttaForm
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
            this.column_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_A2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_A3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_A4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_I,
            this.column_X,
            this.column_Y,
            this.column_A1,
            this.column_A2,
            this.column_A3,
            this.column_A4,
            this.column_A});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 337);
            this.dataGridView1.TabIndex = 1;
            // 
            // column_I
            // 
            this.column_I.HeaderText = "I";
            this.column_I.Name = "column_I";
            this.column_I.ReadOnly = true;
            // 
            // column_X
            // 
            this.column_X.HeaderText = "X";
            this.column_X.Name = "column_X";
            this.column_X.ReadOnly = true;
            // 
            // column_Y
            // 
            this.column_Y.HeaderText = "Y";
            this.column_Y.Name = "column_Y";
            this.column_Y.ReadOnly = true;
            // 
            // column_A1
            // 
            this.column_A1.HeaderText = "A1";
            this.column_A1.Name = "column_A1";
            this.column_A1.ReadOnly = true;
            // 
            // column_A2
            // 
            this.column_A2.HeaderText = "A2";
            this.column_A2.Name = "column_A2";
            this.column_A2.ReadOnly = true;
            // 
            // column_A3
            // 
            this.column_A3.HeaderText = "A3";
            this.column_A3.Name = "column_A3";
            this.column_A3.ReadOnly = true;
            // 
            // column_A4
            // 
            this.column_A4.HeaderText = "A4";
            this.column_A4.Name = "column_A4";
            this.column_A4.ReadOnly = true;
            // 
            // column_A
            // 
            this.column_A.HeaderText = "A";
            this.column_A.Name = "column_A";
            this.column_A.ReadOnly = true;
            // 
            // MethodRungeKuttaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "MethodRungeKuttaForm";
            this.Text = "MethodRungeKuttaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_I;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_A1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_A2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_A3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_A4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_A;
    }
}
namespace Array
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgDay = new System.Windows.Forms.DataGridView();
            this.colDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "매장 방문 수";
            // 
            // dgDay
            // 
            this.dgDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay1,
            this.colDay2,
            this.colDay3,
            this.colDay4,
            this.colDay5,
            this.colDay6,
            this.colDay7});
            this.dgDay.Location = new System.Drawing.Point(12, 32);
            this.dgDay.Name = "dgDay";
            this.dgDay.RowTemplate.Height = 25;
            this.dgDay.Size = new System.Drawing.Size(756, 96);
            this.dgDay.TabIndex = 1;
            // 
            // colDay1
            // 
            this.colDay1.HeaderText = "월";
            this.colDay1.Name = "colDay1";
            // 
            // colDay2
            // 
            this.colDay2.HeaderText = "화";
            this.colDay2.Name = "colDay2";
            // 
            // colDay3
            // 
            this.colDay3.HeaderText = "수";
            this.colDay3.Name = "colDay3";
            // 
            // colDay4
            // 
            this.colDay4.HeaderText = "목";
            this.colDay4.Name = "colDay4";
            // 
            // colDay5
            // 
            this.colDay5.HeaderText = "금";
            this.colDay5.Name = "colDay5";
            // 
            // colDay6
            // 
            this.colDay6.HeaderText = "토";
            this.colDay6.Name = "colDay6";
            // 
            // colDay7
            // 
            this.colDay7.HeaderText = "일";
            this.colDay7.Name = "colDay7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "일주일간";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "전체 자료 수 : 0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "이주일간";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 194);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgDay;
        private DataGridViewTextBoxColumn colDay1;
        private DataGridViewTextBoxColumn colDay2;
        private DataGridViewTextBoxColumn colDay3;
        private DataGridViewTextBoxColumn colDay4;
        private DataGridViewTextBoxColumn colDay5;
        private DataGridViewTextBoxColumn colDay6;
        private DataGridViewTextBoxColumn colDay7;
        private Button button1;
        private Label label2;
        private Button button3;
    }
}
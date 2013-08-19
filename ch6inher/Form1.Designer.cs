namespace ch6inher
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCost = new System.Windows.Forms.Label();
            this.cbDinnerFancy = new System.Windows.Forms.CheckBox();
            this.cbDinnerHealthy = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUnDdinner = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCostBirthday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCakeWrit = new System.Windows.Forms.TextBox();
            this.cbBirthdayFancy = new System.Windows.Forms.CheckBox();
            this.numUnDBirthday = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnDdinner)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnDBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(229, 205);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelCost);
            this.tabPage1.Controls.Add(this.cbDinnerFancy);
            this.tabPage1.Controls.Add(this.cbDinnerHealthy);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numericUnDdinner);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(221, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinnerparty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCost
            // 
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCost.Location = new System.Drawing.Point(37, 140);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(84, 13);
            this.labelCost.TabIndex = 13;
            // 
            // cbDinnerFancy
            // 
            this.cbDinnerFancy.AutoSize = true;
            this.cbDinnerFancy.Checked = true;
            this.cbDinnerFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDinnerFancy.Location = new System.Drawing.Point(6, 85);
            this.cbDinnerFancy.Name = "cbDinnerFancy";
            this.cbDinnerFancy.Size = new System.Drawing.Size(89, 17);
            this.cbDinnerFancy.TabIndex = 12;
            this.cbDinnerFancy.Text = "Fancy Option";
            this.cbDinnerFancy.UseVisualStyleBackColor = true;
            this.cbDinnerFancy.CheckedChanged += new System.EventHandler(this.cbDinnerFancy_CheckedChanged);
            // 
            // cbDinnerHealthy
            // 
            this.cbDinnerHealthy.AutoSize = true;
            this.cbDinnerHealthy.Location = new System.Drawing.Point(6, 111);
            this.cbDinnerHealthy.Name = "cbDinnerHealthy";
            this.cbDinnerHealthy.Size = new System.Drawing.Size(96, 17);
            this.cbDinnerHealthy.TabIndex = 11;
            this.cbDinnerHealthy.Text = "Healthy Option";
            this.cbDinnerHealthy.UseVisualStyleBackColor = true;
            this.cbDinnerHealthy.CheckedChanged += new System.EventHandler(this.cbDinnerHealthy_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // numericUnDdinner
            // 
            this.numericUnDdinner.Location = new System.Drawing.Point(6, 24);
            this.numericUnDdinner.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUnDdinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUnDdinner.Name = "numericUnDdinner";
            this.numericUnDdinner.Size = new System.Drawing.Size(120, 20);
            this.numericUnDdinner.TabIndex = 9;
            this.numericUnDdinner.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUnDdinner.ValueChanged += new System.EventHandler(this.numericUnDdinner_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dinner plan";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lblCostBirthday);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbCakeWrit);
            this.tabPage2.Controls.Add(this.cbBirthdayFancy);
            this.tabPage2.Controls.Add(this.numUnDBirthday);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(221, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cost";
            // 
            // lblCostBirthday
            // 
            this.lblCostBirthday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCostBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostBirthday.Location = new System.Drawing.Point(45, 136);
            this.lblCostBirthday.Name = "lblCostBirthday";
            this.lblCostBirthday.Size = new System.Drawing.Size(100, 27);
            this.lblCostBirthday.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cake writing";
            // 
            // tbCakeWrit
            // 
            this.tbCakeWrit.Location = new System.Drawing.Point(10, 103);
            this.tbCakeWrit.Name = "tbCakeWrit";
            this.tbCakeWrit.Size = new System.Drawing.Size(100, 20);
            this.tbCakeWrit.TabIndex = 3;
            this.tbCakeWrit.Text = "Enter value";
            this.tbCakeWrit.TextChanged += new System.EventHandler(this.tbCakeWrit_TextChanged);
            // 
            // cbBirthdayFancy
            // 
            this.cbBirthdayFancy.AutoSize = true;
            this.cbBirthdayFancy.Location = new System.Drawing.Point(10, 60);
            this.cbBirthdayFancy.Name = "cbBirthdayFancy";
            this.cbBirthdayFancy.Size = new System.Drawing.Size(89, 17);
            this.cbBirthdayFancy.TabIndex = 2;
            this.cbBirthdayFancy.Text = "Fancy Option";
            this.cbBirthdayFancy.UseVisualStyleBackColor = true;
            this.cbBirthdayFancy.CheckedChanged += new System.EventHandler(this.cbBirthdayFancy_CheckedChanged);
            // 
            // numUnDBirthday
            // 
            this.numUnDBirthday.Location = new System.Drawing.Point(10, 34);
            this.numUnDBirthday.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUnDBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUnDBirthday.Name = "numUnDBirthday";
            this.numUnDBirthday.Size = new System.Drawing.Size(120, 20);
            this.numUnDBirthday.TabIndex = 1;
            this.numUnDBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUnDBirthday.ValueChanged += new System.EventHandler(this.numUnDBirthday_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birthday plan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 223);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnDdinner)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnDBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.CheckBox cbDinnerFancy;
        private System.Windows.Forms.CheckBox cbDinnerHealthy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUnDdinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbBirthdayFancy;
        private System.Windows.Forms.NumericUpDown numUnDBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCakeWrit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCostBirthday;
    }
}



namespace TipCalculator
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
            this.BillAmount = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.TipPercent = new System.Windows.Forms.Label();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.NumberOfPerson = new System.Windows.Forms.Label();
            this.txtNumberOfPerson = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.TipPerPerson = new System.Windows.Forms.Label();
            this.txtTipPerPerson = new System.Windows.Forms.TextBox();
            this.TotalPerPerson = new System.Windows.Forms.Label();
            this.txtTotalPerPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BillAmount
            // 
            this.BillAmount.AutoSize = true;
            this.BillAmount.Location = new System.Drawing.Point(23, 14);
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.Size = new System.Drawing.Size(69, 15);
            this.BillAmount.TabIndex = 0;
            this.BillAmount.Text = "BillAmount";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(23, 32);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(100, 23);
            this.txtBillAmount.TabIndex = 1;
            this.txtBillAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillAmount_KeyPress);
            // 
            // TipPercent
            // 
            this.TipPercent.AutoSize = true;
            this.TipPercent.Location = new System.Drawing.Point(23, 74);
            this.TipPercent.Name = "TipPercent";
            this.TipPercent.Size = new System.Drawing.Size(37, 15);
            this.TipPercent.TabIndex = 2;
            this.TipPercent.Text = "Tip %";
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(23, 92);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.Size = new System.Drawing.Size(100, 23);
            this.txtTipPercent.TabIndex = 3;
            this.txtTipPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipPercent_KeyPress);
            // 
            // NumberOfPerson
            // 
            this.NumberOfPerson.AutoSize = true;
            this.NumberOfPerson.Location = new System.Drawing.Point(23, 138);
            this.NumberOfPerson.Name = "NumberOfPerson";
            this.NumberOfPerson.Size = new System.Drawing.Size(105, 15);
            this.NumberOfPerson.TabIndex = 4;
            this.NumberOfPerson.Text = "NumberOfPerson";
            // 
            // txtNumberOfPerson
            // 
            this.txtNumberOfPerson.Location = new System.Drawing.Point(23, 156);
            this.txtNumberOfPerson.Name = "txtNumberOfPerson";
            this.txtNumberOfPerson.Size = new System.Drawing.Size(100, 23);
            this.txtNumberOfPerson.TabIndex = 5;
            this.txtNumberOfPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfPerson_KeyPress);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.DarkRed;
            this.Calculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calculate.Location = new System.Drawing.Point(23, 208);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 34);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate!";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // TipPerPerson
            // 
            this.TipPerPerson.AutoSize = true;
            this.TipPerPerson.Location = new System.Drawing.Point(212, 73);
            this.TipPerPerson.Name = "TipPerPerson";
            this.TipPerPerson.Size = new System.Drawing.Size(81, 15);
            this.TipPerPerson.TabIndex = 7;
            this.TipPerPerson.Text = "TipPerPerson";
            // 
            // txtTipPerPerson
            // 
            this.txtTipPerPerson.BackColor = System.Drawing.SystemColors.Control;
            this.txtTipPerPerson.Location = new System.Drawing.Point(313, 70);
            this.txtTipPerPerson.Name = "txtTipPerPerson";
            this.txtTipPerPerson.ReadOnly = true;
            this.txtTipPerPerson.Size = new System.Drawing.Size(100, 23);
            this.txtTipPerPerson.TabIndex = 8;
            this.txtTipPerPerson.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TotalPerPerson
            // 
            this.TotalPerPerson.AutoSize = true;
            this.TotalPerPerson.Location = new System.Drawing.Point(207, 137);
            this.TotalPerPerson.Name = "TotalPerPerson";
            this.TotalPerPerson.Size = new System.Drawing.Size(91, 15);
            this.TotalPerPerson.TabIndex = 9;
            this.TotalPerPerson.Text = "TotalPerPerson";
            // 
            // txtTotalPerPerson
            // 
            this.txtTotalPerPerson.Location = new System.Drawing.Point(313, 135);
            this.txtTotalPerPerson.Name = "txtTotalPerPerson";
            this.txtTotalPerPerson.ReadOnly = true;
            this.txtTotalPerPerson.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPerPerson.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPerPerson);
            this.Controls.Add(this.TotalPerPerson);
            this.Controls.Add(this.txtTipPerPerson);
            this.Controls.Add(this.TipPerPerson);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.txtNumberOfPerson);
            this.Controls.Add(this.NumberOfPerson);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.TipPercent);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.BillAmount);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "TipCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BillAmount;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label TipPercent;
        private System.Windows.Forms.TextBox txtTipPercent;
        private System.Windows.Forms.Label NumberOfPerson;
        private System.Windows.Forms.TextBox txtNumberOfPerson;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label TipPerPerson;
        private System.Windows.Forms.TextBox txtTipPerPerson;
        private System.Windows.Forms.Label TotalPerPerson;
        private System.Windows.Forms.TextBox txtTotalPerPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


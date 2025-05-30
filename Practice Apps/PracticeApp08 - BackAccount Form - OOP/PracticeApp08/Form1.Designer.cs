﻿namespace PracticeApp08
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
            label1 = new Label();
            label2 = new Label();
            tbOwner = new TextBox();
            gridAccount = new DataGridView();
            tbAmount = new NumericUpDown();
            btnCreateAccount = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            label3 = new Label();
            tbInterest = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gridAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbInterest).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 100);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 283);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // tbOwner
            // 
            tbOwner.Location = new Point(126, 97);
            tbOwner.Name = "tbOwner";
            tbOwner.Size = new Size(176, 27);
            tbOwner.TabIndex = 2;
            // 
            // gridAccount
            // 
            gridAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAccount.Location = new Point(308, 97);
            gridAccount.Name = "gridAccount";
            gridAccount.RowHeadersWidth = 51;
            gridAccount.Size = new Size(429, 171);
            gridAccount.TabIndex = 4;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(126, 281);
            tbAmount.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            tbAmount.Minimum = new decimal(new int[] { -727379968, 232, 0, int.MinValue });
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(176, 27);
            tbAmount.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(126, 181);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(176, 29);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(326, 279);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(172, 29);
            btnDeposit.TabIndex = 7;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(539, 279);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(172, 29);
            btnWithdraw.TabIndex = 8;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 140);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 9;
            label3.Text = "Interest rate (%):";
            // 
            // tbInterest
            // 
            tbInterest.Location = new Point(178, 138);
            tbInterest.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            tbInterest.Minimum = new decimal(new int[] { -727379968, 232, 0, int.MinValue });
            tbInterest.Name = "tbInterest";
            tbInterest.Size = new Size(124, 27);
            tbInterest.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbInterest);
            Controls.Add(label3);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnCreateAccount);
            Controls.Add(tbAmount);
            Controls.Add(gridAccount);
            Controls.Add(tbOwner);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbInterest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbOwner;
        private DataGridView gridAccount;
        private NumericUpDown tbAmount;
        private Button btnCreateAccount;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Label label3;
        private NumericUpDown tbInterest;
    }
}

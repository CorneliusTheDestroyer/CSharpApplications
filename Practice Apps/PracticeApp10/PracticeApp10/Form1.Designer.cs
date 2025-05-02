namespace PracticeApp10
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
            btnAdd = new Button();
            cbbMarvelDC = new ComboBox();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            label2 = new Label();
            btnRemove = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 51);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Comic:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbbMarvelDC
            // 
            cbbMarvelDC.FormattingEnabled = true;
            cbbMarvelDC.Location = new Point(50, 278);
            cbbMarvelDC.Name = "cbbMarvelDC";
            cbbMarvelDC.Size = new Size(151, 28);
            cbbMarvelDC.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 353);
            dataGridView1.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(50, 129);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 255);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "Marvel / DC";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(50, 174);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(50, 375);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 454);
            Controls.Add(btnClose);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(cbbMarvelDC);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Comic Form App";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private ComboBox cbbMarvelDC;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Label label2;
        private Button btnRemove;
        private Button btnClose;
    }
}

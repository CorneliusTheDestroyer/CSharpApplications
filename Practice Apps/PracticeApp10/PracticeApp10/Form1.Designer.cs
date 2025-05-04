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
            cbbPublisher = new ComboBox();
            gridComics = new DataGridView();
            btnUpdate = new Button();
            lblPublisher = new Label();
            btnRemove = new Button();
            btnClose = new Button();
            txtName = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            txtYear = new TextBox();
            lblName = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridComics).BeginInit();
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
            btnAdd.Location = new Point(37, 285);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // cbbPublisher
            // 
            cbbPublisher.FormattingEnabled = true;
            cbbPublisher.Location = new Point(137, 212);
            cbbPublisher.Name = "cbbPublisher";
            cbbPublisher.Size = new Size(125, 28);
            cbbPublisher.TabIndex = 3;
            // 
            // gridComics
            // 
            gridComics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridComics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridComics.Location = new Point(374, 51);
            gridComics.Name = "gridComics";
            gridComics.RowHeadersWidth = 51;
            gridComics.Size = new Size(813, 353);
            gridComics.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(137, 285);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(50, 215);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(72, 20);
            lblPublisher.TabIndex = 5;
            lblPublisher.Text = "Publisher:";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(237, 285);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(37, 375);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 10;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(137, 113);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 11;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(137, 146);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 27);
            txtGenre.TabIndex = 12;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(137, 179);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 14;
            lblName.Text = "Name:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(50, 116);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 20);
            lblAuthor.TabIndex = 15;
            lblAuthor.Text = "Author:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(50, 149);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(51, 20);
            lblGenre.TabIndex = 16;
            lblGenre.Text = "Genre:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(50, 182);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 20);
            lblYear.TabIndex = 17;
            lblYear.Text = "Year:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(50, 249);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 19;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(137, 246);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 446);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblYear);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblName);
            Controls.Add(txtYear);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtName);
            Controls.Add(btnClose);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(lblPublisher);
            Controls.Add(gridComics);
            Controls.Add(cbbPublisher);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Comic Form App";
            ((System.ComponentModel.ISupportInitialize)gridComics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private ComboBox cbbPublisher;
        private DataGridView gridComics;
        private Button btnUpdate;
        private Label lblPublisher;
        private Button btnRemove;
        private Button btnClose;
        private TextBox txtName;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private TextBox txtYear;
        private Label lblName;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblYear;
        private Label lblPrice;
        private TextBox txtPrice;
    }
}

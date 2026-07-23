namespace InsertingInformation
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
            InsertButton = new Button();
            label1 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            txtAge = new TextBox();
            txtBloodGroup = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonExit = new Button();
            buttonSearch = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // InsertButton
            // 
            InsertButton.Location = new Point(480, 349);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(75, 23);
            InsertButton.TabIndex = 0;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 90);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(421, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(421, 145);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(421, 203);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 4;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.Location = new Point(421, 261);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(100, 23);
            txtBloodGroup.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 146);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 6;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 204);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 264);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "Blood Group ";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(306, 349);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(735, 228);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(723, 174);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CornflowerBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Chartreuse;
            dataGridView1.Location = new Point(627, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(310, 97);
            dataGridView1.TabIndex = 12;
            dataGridView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 463);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(buttonSearch);
            Controls.Add(buttonExit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtAge);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(InsertButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InsertButton;
        private Label label1;
        private TextBox txtName;
        private TextBox txtId;
        private TextBox txtAge;
        private TextBox txtBloodGroup;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonExit;
        private Button buttonSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
    }
}

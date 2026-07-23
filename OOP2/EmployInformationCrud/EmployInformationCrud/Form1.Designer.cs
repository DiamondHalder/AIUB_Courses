namespace EmployInformationCrud
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
            buttonInsert = new Button();
            label1 = new Label();
            DataGridView = new DataGridView();
            txtEmployId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmployeContact = new TextBox();
            txtEmployeName = new TextBox();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClean = new Button();
            buttonSearch = new Button();
            label6 = new Label();
            txtGender = new ComboBox();
            txtDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(552, 108);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(75, 23);
            buttonInsert.TabIndex = 0;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 112);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Employe Id";
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(27, 241);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.Size = new Size(621, 199);
            DataGridView.TabIndex = 2;
            DataGridView.CellEnter += DataGridView_CellEnter;
            // 
            // txtEmployId
            // 
            txtEmployId.Location = new Point(129, 109);
            txtEmployId.Name = "txtEmployId";
            txtEmployId.Size = new Size(100, 23);
            txtEmployId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 112);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Employe Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 156);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "Employe Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 169);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 202);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 7;
            label5.Text = "Birth Date";
            // 
            // txtEmployeContact
            // 
            txtEmployeContact.Location = new Point(129, 149);
            txtEmployeContact.Name = "txtEmployeContact";
            txtEmployeContact.Size = new Size(100, 23);
            txtEmployeContact.TabIndex = 8;
            // 
            // txtEmployeName
            // 
            txtEmployeName.Location = new Point(404, 109);
            txtEmployeName.Name = "txtEmployeName";
            txtEmployeName.Size = new Size(100, 23);
            txtEmployeName.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(666, 108);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(552, 170);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(666, 170);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(75, 23);
            buttonClean.TabIndex = 14;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(666, 226);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RosyBrown;
            label6.Location = new Point(343, 29);
            label6.Name = "label6";
            label6.Size = new Size(184, 32);
            label6.TabIndex = 16;
            label6.Text = "INFORMATION";
            // 
            // txtGender
            // 
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(404, 166);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(100, 23);
            txtGender.TabIndex = 17;
            // 
            // txtDateTimePicker
            // 
            txtDateTimePicker.Location = new Point(129, 196);
            txtDateTimePicker.Name = "txtDateTimePicker";
            txtDateTimePicker.Size = new Size(200, 23);
            txtDateTimePicker.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 440);
            Controls.Add(txtDateTimePicker);
            Controls.Add(txtGender);
            Controls.Add(label6);
            Controls.Add(buttonSearch);
            Controls.Add(buttonClean);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(txtEmployeName);
            Controls.Add(txtEmployeContact);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmployId);
            Controls.Add(DataGridView);
            Controls.Add(label1);
            Controls.Add(buttonInsert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInsert;
        private Label label1;
        private DataGridView DataGridView;
        private TextBox txtEmployId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmployeContact;
        private TextBox txtEmployeName;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClean;
        private Button buttonSearch;
        private Label label6;
        private ComboBox txtGender;
        private DateTimePicker txtDateTimePicker;
    }
}

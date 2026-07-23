namespace StudentInfoCrudOperation
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
            ButtonInsert = new Button();
            label1 = new Label();
            txtStudentName = new TextBox();
            GridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStudentId = new TextBox();
            txtFatherName = new TextBox();
            txtAddress = new TextBox();
            txtMobileNumber = new TextBox();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            ButtonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)GridView).BeginInit();
            SuspendLayout();
            // 
            // ButtonInsert
            // 
            ButtonInsert.Location = new Point(416, 26);
            ButtonInsert.Name = "ButtonInsert";
            ButtonInsert.Size = new Size(75, 23);
            ButtonInsert.TabIndex = 0;
            ButtonInsert.Text = "Insert";
            ButtonInsert.UseVisualStyleBackColor = true;
            ButtonInsert.UseWaitCursor = true;
            ButtonInsert.Click += ButtonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Student Name";
            label1.UseWaitCursor = true;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(178, 27);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(149, 23);
            txtStudentName.TabIndex = 2;
            txtStudentName.UseWaitCursor = true;
            // 
            // GridView
            // 
            GridView.BackgroundColor = SystemColors.ActiveCaption;
            GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView.GridColor = SystemColors.MenuHighlight;
            GridView.Location = new Point(12, 262);
            GridView.Name = "GridView";
            GridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.Size = new Size(609, 171);
            GridView.TabIndex = 3;
            GridView.UseWaitCursor = true;
            GridView.CellClick += GridView_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Student Id";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 118);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Father's Name";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 162);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Address";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 206);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 7;
            label5.Text = "Mobile Number";
            label5.UseWaitCursor = true;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(178, 71);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(149, 23);
            txtStudentId.TabIndex = 8;
            txtStudentId.UseWaitCursor = true;
            // 
            // txtFatherName
            // 
            txtFatherName.Location = new Point(178, 115);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new Size(149, 23);
            txtFatherName.TabIndex = 9;
            txtFatherName.UseWaitCursor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(178, 159);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(149, 23);
            txtAddress.TabIndex = 10;
            txtAddress.UseWaitCursor = true;
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Location = new Point(178, 203);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(149, 23);
            txtMobileNumber.TabIndex = 11;
            txtMobileNumber.UseWaitCursor = true;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(416, 71);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 12;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.UseWaitCursor = true;
            ButtonUpdate.Click += button2_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(416, 116);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 13;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.UseWaitCursor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(416, 161);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(75, 23);
            ButtonReset.TabIndex = 14;
            ButtonReset.Text = "Reset";
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.UseWaitCursor = true;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(633, 433);
            Controls.Add(ButtonReset);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(txtMobileNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtFatherName);
            Controls.Add(txtStudentId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GridView);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            Controls.Add(ButtonInsert);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Student Information";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonInsert;
        private Label label1;
        private TextBox txtStudentName;
        private DataGridView GridView;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentId;
        private TextBox txtFatherName;
        private TextBox txtAddress;
        private TextBox txtMobileNumber;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private Button ButtonReset;
    }
}

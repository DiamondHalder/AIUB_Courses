namespace UserLoginNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ClearButton = new Button();
            LoginButton = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            UserTxt = new TextBox();
            PassTxt = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(494, 315);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 0;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(363, 315);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(393, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "SHOW PASSWORD";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(425, 367);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(115, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "FORGOT PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 130);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 201);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "PASSWORD";
            // 
            // UserTxt
            // 
            UserTxt.Location = new Point(408, 127);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(100, 23);
            UserTxt.TabIndex = 6;
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(408, 198);
            PassTxt.Name = "PassTxt";
            PassTxt.PasswordChar = '$';
            PassTxt.Size = new Size(100, 23);
            PassTxt.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(609, 416);
            Controls.Add(pictureBox1);
            Controls.Add(PassTxt);
            Controls.Add(UserTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(LoginButton);
            Controls.Add(ClearButton);
            Name = "Form1";
            Text = "LOGIN PAGE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Button LoginButton;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private TextBox UserTxt;
        private TextBox PassTxt;
        private PictureBox pictureBox1;
    }
}

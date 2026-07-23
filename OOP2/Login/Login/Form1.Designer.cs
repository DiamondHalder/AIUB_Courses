namespace LOGIN
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
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            clearbutton = new Button();
            loginbutton = new Button();
            exitbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 74);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "USERNAME :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 107);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 23);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "WELCOME";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(136, 66);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 3;
            txt_username.TextChanged += textBox1_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(136, 107);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 4;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(139, 156);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(55, 23);
            clearbutton.TabIndex = 5;
            clearbutton.Text = "CLEAR";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(218, 156);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(58, 20);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "LOGIN";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(46, 234);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(75, 23);
            exitbutton.TabIndex = 7;
            exitbutton.Text = "EXIT";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 415);
            Controls.Add(exitbutton);
            Controls.Add(loginbutton);
            Controls.Add(clearbutton);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "LOGIN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button clearbutton;
        private Button loginbutton;
        private Button exitbutton;
    }
}

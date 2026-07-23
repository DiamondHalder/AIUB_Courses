namespace OnlineMarketManagmnetSystem
{
    public partial class Form1 : Form
    {
        int progressValue = 0;
        public Form1()
        {
            InitializeComponent();

            
            this.Load += new EventHandler(Form1_Load);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressValue += 2; // Increments the progress by 2 each tick (100ms * 50 = 5000ms = 5 seconds)

           
            progressBar1.Value = progressValue;

           
            if (progressValue >= 100)
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();

                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace HMS
{
    public partial class Splashscr : Form
    {
        public Splashscr()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        int startTime = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            startTime += 1;
            progressBar.Value = startTime;
            if(progressBar.Value == 100)
            {
                timer.Stop();
                progressBar.Value = 0;
                loginForm login = new loginForm();
                this.Hide();
                login.Show();
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
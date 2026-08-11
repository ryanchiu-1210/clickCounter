namespace clickCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timelbl_Click(object sender, EventArgs e)
        {
            timelbl.Text = $"System time：{DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timelbl.Text = $"System time：{DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickbtn_Click(object sender, EventArgs e)
        {
            string str = label2.Text.Trim();
            if (string.IsNullOrEmpty(str))
            {
                str = "0";
            }
            int last = int.Parse(str);
            last++;
            label2.Text = last.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
        }
    }
}

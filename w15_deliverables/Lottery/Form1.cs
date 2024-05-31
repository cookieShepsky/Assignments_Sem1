namespace _1._3_Lottery
{
    public partial class Form1 : Form
    {
        Lottery Lottery;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (numMax.Value == 0 || numWanted.Value == 0)
            {
                listBox.Items.Clear();
                MessageBox.Show("Please specify a maximum number and the wanted amount.");
                return;
            }
            Lottery = new Lottery((int)numMax.Value, (int)numWanted.Value);

            listBox.Items.Clear();
            MessageBox.Show("Lottery created!");

            btnCreate.Enabled = false;
            btnNext.Enabled = btnAll.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!Lottery.IsFinished())
            {
                listBox.Items.Add(Lottery.DrawNext());
                EndLottery();
                return;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (!Lottery.IsFinished())
            {
                foreach (int i in Lottery.DrawAll())
                {
                    listBox.Items.Add(i);
                }
                EndLottery();
                return;
            }
        }

        private void EndLottery()
        {
            if (Lottery.IsFinished())
            {
                MessageBox.Show("All numbers drawn, lottery over!");
                btnCreate.Enabled = true;
                btnNext.Enabled = btnAll.Enabled = false;
            }
        }
    }
}

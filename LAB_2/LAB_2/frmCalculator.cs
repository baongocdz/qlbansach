namespace LAB_2
{
    public partial class Calculator : Form
    {
        double A, B, KQ;
        char Op;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtResult.Text += bt.Text;
        }

        private void btnOpcong_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                A = Convert.ToDouble(txtResult.Text);
                txtResult.Text = "";
                Op = bt.Text[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            B = Convert.ToDouble(txtResult.Text);
            switch (Op)
            {
                case '+': KQ = A + B; break;
                case '-': KQ = A - B; break;
                case '/':
                    try
                    {
                        KQ = A / B;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case '*': KQ = A * B; break;
            }
            txtResult.Text = KQ.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}

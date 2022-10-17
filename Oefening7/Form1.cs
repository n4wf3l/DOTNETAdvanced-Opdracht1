namespace Oefening7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
            
            double N1 = Convert.ToDouble(Name1.Text);
            double berekening = 0;

           for(int i = 0; i <= N1; i++)
            {
                berekening += i
                    ;
            }
            Result1.Text = berekening.ToString();

        }

        private void Name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
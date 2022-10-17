namespace Oefening4
{
    public partial class Form1 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double Q1 = Convert.ToDouble(qty1.Text);
            double Q2 = Convert.ToDouble(qty2.Text);
            double Q3 = Convert.ToDouble(qty3.Text);
            double Q4 = Convert.ToDouble(qty4.Text);

            double PE1 = Convert.ToDouble(PriceEach1.Text);
            double PE2 = Convert.ToDouble(PriceEach2.Text);
            double PE3 = Convert.ToDouble(PriceEach3.Text);
            double PE4 = Convert.ToDouble(PriceEach4.Text);

            double result1 = Q1 * PE1;
            double result2 = Q2 * PE2;
            double result3 = Q3 * PE3;
            double result4 = Q4 * PE4;

            exlPrice1.Text = "€" + result1.ToString();
            exlPrice2.Text = "€" + result2.ToString();
            exlPrice3.Text = "€" + result3.ToString();
            exlPrice4.Text = "€" + result4.ToString();

            double subTotaal = result1 + result2 + result3 + result4;
            subTotal1.Text = "€" + subTotaal.ToString();

            double tVA = Convert.ToDouble(taxRate1.Text);
            double sTax = subTotaal * tVA;
            salesTax1.Text = "€" + sTax.ToString();
            double sH = Convert.ToDouble(shipping1.Text);
            double gTotaal = subTotaal + sTax + sH;
            grandTotal1.Text = "€" + gTotaal.ToString();
        }
    }
}
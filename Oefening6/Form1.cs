namespace Oefening6
{
    public partial class OrderForm : Form
    {
        
// ZEER BELANGRIJK VOOR DE LEERKRACHT : DE JUISTE OEFENINGEN DIE GERUND MOETEN WORDEN: Oef1.csproj / oefening2.csproj / Oefening3.csproj / Oefening4.csproj / Oefening5.csproj / Oefening6.csproj / Oefening7.csproj
        public OrderForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double Q1 = Convert.ToDouble(Quantity1.Text);
            double Q2 = Convert.ToDouble(Quantity2.Text);
            double Q3 = Convert.ToDouble(Quantity3.Text);
            double Q4 = Convert.ToDouble(Quantity4.Text);

            double PE1 = Convert.ToDouble(priceEach1.Text);
            double PE2 = Convert.ToDouble(priceEach2.Text);
            double PE3 = Convert.ToDouble(priceEach3.Text);
            double PE4 = Convert.ToDouble(priceEach4.Text);

            double result1 = Q1 * PE1;
            double result2 = Q2 * PE2;
            double result3 = Q3 * PE3;
            double result4 = Q4 * PE4;

            EXPrice1.Text = result1.ToString();
            EXPrice2.Text = result2.ToString();
            EXPrice3.Text = result3.ToString();
            EXPrice4.Text = result4.ToString();

            double subTotaal = result1 + result2 + result3 + result4;
            Subtotal1.Text = "€" + subTotaal.ToString();

            double TVA = subTotaal * 7 / 100;
            TaxRate1.Text = "€" + TVA.ToString();

            double shippingCalculate = 0;

            if (subTotaal < 20)
            {
                shippingCalculate = 5;
                shipping1.Text = "€" + shippingCalculate.ToString();
            }
            else if (subTotaal < 50 && subTotaal > 20)
            {
                shippingCalculate = 7.5;
                shipping1.Text = "€" + shippingCalculate.ToString();
            }
            else if(subTotaal < 75 && subTotaal > 50)
            { 
                shippingCalculate = 10;
                shipping1.Text = "€" + shippingCalculate.ToString();
            }
            else

            {
                shippingCalculate = 0;
                shipping1.Text = "€" + shippingCalculate.ToString();
            }

            double grandTotaal = subTotaal + TVA + shippingCalculate;
            grandTotal1.Text = "€" + grandTotaal.ToString();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }


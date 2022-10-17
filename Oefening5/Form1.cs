namespace Oefening5
{
    public partial class Form1 : Form
    {
        
// ZEER BELANGRIJK VOOR DE LEERKRACHT : DE JUISTE OEFENINGEN DIE GERUND MOETEN WORDEN : Oef1.csproj / oefening2.csproj / Oefening3.csproj / Oefening4.csproj / Oefening5.csproj / Oefening6.csproj / Oefening7.csproj
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CtoF_Click(object sender, EventArgs e)
        {
            double Convert1 = Convert.ToDouble(Celsius1.Text) * 9 / 5 + 32;
            Celsius1.Text = Convert1.ToString();

        }

        private void FtoC_Click(object sender, EventArgs e)
        {

            double Convert2 = (Convert.ToDouble(Fahrenheit1.Text) - 32) * 5 / 9;
            Fahrenheit1.Text = Convert2.ToString();
        }
    }
}
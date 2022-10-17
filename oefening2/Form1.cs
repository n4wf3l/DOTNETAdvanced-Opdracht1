namespace oefening2
{
    
// ZEER BELANGRIJK VOOR DE LEERKRACHT : DE JUISTE OEFENINGEN DIE GERUND MOETEN WORDEN : Oef1.csproj / oefening2.csproj / Oefening3.csproj / Oefening4.csproj / Oefening5.csproj / Oefening6.csproj / Oefening7.csproj
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int berekening1 = 1234 * 5432;

            string b = $"1234 * 54321 = {berekening1}";

            label1.Text = b;

            int berekening2 = 22222 * 33333;

            string b2 = $"2222*33333 = {berekening2}";

            label2.Text = b2;

            bool berekening3 = berekening1 > berekening2;

            string b3 = $"1234 * 54321 >  22222 * 33333 = {berekening3}";

            label3.Text = b3;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
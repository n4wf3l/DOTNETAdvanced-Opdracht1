namespace Oef1
{
    public partial class Form1 : Form
    {
        
// ZEER BELANGRIJK VOOR DE LEERKRACHT : DE JUISTE OEFENINGEN DIE GERUND MOETEN WORDEN : Oef1.csproj / oefening2.csproj / Oefening3.csproj / Oefening4.csproj / Oefening5.csproj / Oefening6.csproj / Oefening7.csproj
        public Form1()
        {
            InitializeComponent();
            string text = $"Hey {Environment.UserName} ! Het is momenteel {DateTime.Now.ToShortTimeString()} op {DateTime.Now.ToShortTimeString()}";
            text1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
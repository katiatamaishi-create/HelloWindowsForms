
namespace HelloWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);

            lblResultado.Text = $"IMC Calculado: {imc:F2}";

            if (imc < 18.5)
            {
                MessageBox.Show("Você está abaixo do peso.");
            }
            else if (imc < 25)
            {
                MessageBox.Show("Você está no peso normal.");
            }
            else if (imc < 30)
            {
                MessageBox.Show("Você está com sobrepeso.");
            }
            else if (imc < 35)
            {
                MessageBox.Show("Você está com obesidade grau I.");
            }
            else if (imc < 40)
            {
                MessageBox.Show("Você está com obesidade grau II.");
            }
            else
            {
                MessageBox.Show("Você está com obesidade grau III.");
            }
        }
    }
}

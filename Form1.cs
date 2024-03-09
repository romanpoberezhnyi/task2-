using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task2
{
    public partial class Form1 : Form
    {
        int a, b, c;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = int.Parse(textBox3.Text);
                string[] coef = { "a", "b", "c" };
                foreach (var coefficient in coef)
                {
                    switch (coefficient)
                    {
                        case "a" when a == 0:
                        case "b" when b == 0:
                        case "c" when c == 0:
                            MessageBox.Show($"Коефіцієнт '{coefficient}' не може бути нулем.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }

                int discrim = b * b - 4 * a * c;
                textBox4.Text = $"{a}x^2 + {b}x + {c} = 0";
                textBox5.Text = $"{discrim}";
                if (discrim > 0)
                {
                    double x1 = -b + Math.Sqrt(discrim) / 2 * a;
                    double x2 = -b - Math.Sqrt(discrim) / 2 * a;
                    textBox6.Text = $"x1 = {x1}";
                    textBox7.Text = $"x2 = {x2}";
                }
                else if (discrim == 0)
                {
                    double x3 = -b + Math.Sqrt(discrim);
                    textBox6.Text = $"x = {x3}";
                }
                else if (discrim < 0)
                {
                    textBox6.Text = "немає розв'язків";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректні значення для коефіцієнтів.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("програма для обчислення квадратного рівняння\n програма написана Побережним Романом Дмитровичем, студентом групи КН21-1", "about program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

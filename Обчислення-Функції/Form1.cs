using static System.Math;
namespace Обчислення_Функції
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // дозвіл на введення коми
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            // дозвіл на введення знаку мінус
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Length > 0))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; // приведення об'єкту sender до типу TextBox
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0"; // встановлення значення поля рівним 0
            }
            ;


        }

        static bool InputDoublePole(out double zminna, TextBox Pole, string povidom)
        {
            zminna = 0;
            try
            {
                zminna = Convert.ToDouble(Pole.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show(povidom, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pole.Focus();
                return false;
            }
            return true;
        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double a = 0;
            if (!InputDoublePole(out a, (TextBox)sender, "Ви ввели не дійсне число"))
            {
                e.Cancel = true;
                return;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Double x = 0, y = 0, z = 0, res;
            if (!InputDoublePole(out x, textBox1, "Ви ввели не число в поле змінної х"))
            {
                return;
            }
            if (!InputDoublePole(out y, textBox2, "Ви ввели не число в поле змінної y"))
            {
                return;
            }
            if (!InputDoublePole(out z, textBox3, "Ви ввели не число в поле змінної z"))
            {
                return;
            }
            res = Log10(Sin(x) + y) / 87 + 234 / Log10(Sin(x * y) + 3) + Log(Sin(3.1) + Pow(x, 2) * y) / z;
            textBox4.Text = res.ToString();
        }
        public double Logoriftm(double x)
        {
            return Log10(x);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Double x = 0, y = 0, z = 0, res;
            if (!InputDoublePole(out x, textBox1, "Ви ввели не число в поле змінної х"))
            {
                return;
            }
            if (!InputDoublePole(out y, textBox2, "Ви ввели не число в поле змінної y"))
            {
                return;
            }
            if (!InputDoublePole(out z, textBox3, "Ви ввели не число в поле змінної z"))
            {
                return;
            }
            res = (Logoriftm(Sin(x) + y) / 87) + (234 / Logoriftm(Sin(x * y) + 3)) + (Logoriftm(Sin(3.1) + Pow(x, 2) * y) / z);
            textBox4.Text = res.ToString();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2_Click(this , new EventArgs());
        }
    }
}
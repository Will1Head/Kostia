namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private object area;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо довжину сторони квадрата з текстового поля
                double sideLength = double.Parse(textBox1.Text);

                // Обчислюємо площу квадрата
                area = sideLength * sideLength;

                // Виводимо результат у текстове поле для виводу
                textBox1.Text = "Площа квадрата: " + area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть числове значення для довжини сторони.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
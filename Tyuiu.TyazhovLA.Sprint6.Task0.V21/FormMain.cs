
using Tyuiu.TyazhovLA.Sprint6.Task0.V21.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox2.Text = Convert.ToString(ds.Calculate(2));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 | Выполнил Тяжов Леонид Александрович | ПКТб-24-1", "Справка", MessageBoxButtons.OK);
        }
    }
}

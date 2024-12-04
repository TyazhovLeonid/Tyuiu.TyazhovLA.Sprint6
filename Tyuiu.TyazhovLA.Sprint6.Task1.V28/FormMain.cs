using Tyuiu.TyazhovLA.Sprint6.Task1.V28.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task1.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                string strLine;
                DataService ds = new DataService();
                int StartStep = Convert.ToInt32(textBoxStart.Text);
                int StopStep = Convert.ToInt32(textBoxEnd.Text);
                int len = ds.GetMassFunction(StartStep, StopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(StartStep, StopStep);
                Tablica.Text = "";
                Tablica.AppendText("+----------+----------+" + Environment.NewLine);
                Tablica.AppendText("+    X     +   f(x)   +" + Environment.NewLine);
                Tablica.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |    {1,5:f2}   |", StartStep, valueArray[i]);
                    Tablica.AppendText(strLine + Environment.NewLine);
                    StartStep++;
                }
                Tablica.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strLine;
                DataService ds = new DataService();
                int StartStep = Convert.ToInt32(textBoxStart.Text);
                int StopStep = Convert.ToInt32(textBoxEnd.Text);
                int len = ds.GetMassFunction(StartStep, StopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(StartStep, StopStep);
                Tablica.Text = "";
                Tablica.AppendText("+----------+----------+" + Environment.NewLine);
                Tablica.AppendText("+    X     +   f(x)   +" + Environment.NewLine);
                Tablica.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,5:f2}   |", StartStep, valueArray[i]);
                    Tablica.AppendText(strLine + Environment.NewLine);
                    StartStep++;
                }
                Tablica.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 1 | Выполнил Тяжов Леонид Александрович | ПКТб-24-1", "Справка", MessageBoxButtons.OK);
        }
    }
}

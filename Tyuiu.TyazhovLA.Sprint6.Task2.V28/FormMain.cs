using Tyuiu.TyazhovLA.Sprint6.Task2.V28.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
                
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(StartStep), Convert.ToString(valueArray[i]));
                    StartStep++;
                }
                
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

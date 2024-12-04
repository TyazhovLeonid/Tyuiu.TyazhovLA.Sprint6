using Tyuiu.TyazhovLA.Sprint6.Task4.V18.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task4.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            
            try
            {

                double[] valueArray = ds.GetMassFunction(-5, 5);
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxRes.Text = "";
                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(i,valueArray[i]);
                    textBoxRes.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Выведены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                string path = Path.GetTempFileName();
                File.WriteAllText(path, textBoxRes.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его?");
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 4 | Выполнил Тяжов Леонид Александрович | ПКТб-24-1", "Справка", MessageBoxButtons.OK);
        }

        
    }
}

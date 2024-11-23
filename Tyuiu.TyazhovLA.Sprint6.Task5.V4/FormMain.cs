using Tyuiu.TyazhovLA.Sprint6.Task5.V4.Lib;

namespace Tyuiu.TyazhovLA.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonGoReadFile_Click(object sender, EventArgs e)
        {
            try
            { 
                dataGridViewRawData.ColumnCount = 1;
                double[] valueArray = ds.LoadFromDataFile("C:\\DataSprint5\\Sprint6Task5\\InPutDataFileTask5V4.txt");
                for (int i = 0; i < valueArray.Length; i++)
                {
                    dataGridViewRawData.Rows.Add(valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

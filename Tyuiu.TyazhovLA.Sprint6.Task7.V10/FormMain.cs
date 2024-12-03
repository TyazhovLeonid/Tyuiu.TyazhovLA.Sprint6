
using System.IO;
using Tyuiu.TyazhovLA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.TyazhovLA.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        static string openFilePath;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        public static int[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return matrix;
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] matrix = new int[rows, columns];

            matrix = LoadFromFileData(openFilePath);

            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;

            for (int h = 0; h < columns; h++)
            {
                dataGridViewIn.Columns[h].Width = 35;
                dataGridViewOut.Columns[h].Width = 35;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            matrix = ds.GetMatrix(openFilePath);
            buttonRes.Enabled = true;

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++ )
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = matrix[i,j];
                }
            }
            buttonSave.Enabled = true;
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}

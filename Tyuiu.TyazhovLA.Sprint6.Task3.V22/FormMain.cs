using Tyuiu.TyazhovLA.Sprint6.Task3.V22.Lib;

namespace Tyuiu.TyazhovLA.Sprint6.Task3.V22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GroupBox groupBox1;

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            buttonQuestion = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(6, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(264, 195);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n17   0  19  -8  -1\r\n\r\n   9   4  -5   7  15\r\n\r\n  11  13   4  -4 -14\r\n\r\n  11  14   5 -15  16\r\n\r\n   2 -14  -2  11  11";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(153, 274);
            button1.Name = "button1";
            button1.Size = new Size(158, 53);
            button1.TabIndex = 1;
            button1.Text = "Заменить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(331, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 327);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результат";
            // 
            // buttonQuestion
            // 
            buttonQuestion.FlatStyle = FlatStyle.Flat;
            buttonQuestion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonQuestion.Location = new Point(562, 0);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(38, 42);
            buttonQuestion.TabIndex = 5;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(244, 297);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(612, 372);
            Controls.Add(buttonQuestion);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 5;
            this.dataGridView1.RowCount = 5;
            int[,] data = new int[,] { { 17, 0, 19, -8, -1 },
                                                               {9,   4,  -5,   7,  15},
                                                               {11,  13,   4,  -4, -14},
                                                               {11,  14,   5, -15,  16},
                                                               { 2, -14,  -2,  11,  11} };
            int[,] matrix = ds.Calculate(data);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private Button buttonQuestion;

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 3 | Выполнил Тяжов Леонид Александрович | ПКТб-24-1", "Справка", MessageBoxButtons.OK);
        }
    }

}

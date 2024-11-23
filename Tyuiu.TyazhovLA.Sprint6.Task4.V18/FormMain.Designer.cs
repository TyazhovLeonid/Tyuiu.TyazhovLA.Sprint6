namespace Tyuiu.TyazhovLA.Sprint6.Task4.V18
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            groupBoxUSL = new GroupBox();
            buttonSave = new Button();
            buttonDone = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            groupBoxTabRes = new GroupBox();
            textBoxRes = new TextBox();
            splitter1 = new Splitter();
            panel3 = new Panel();
            groupBoxChart = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBoxUSL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBoxTabRes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxUSL);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // groupBoxUSL
            // 
            groupBoxUSL.Controls.Add(buttonSave);
            groupBoxUSL.Controls.Add(buttonDone);
            groupBoxUSL.Controls.Add(pictureBox1);
            groupBoxUSL.Controls.Add(textBox1);
            groupBoxUSL.Dock = DockStyle.Fill;
            groupBoxUSL.Location = new Point(0, 0);
            groupBoxUSL.Name = "groupBoxUSL";
            groupBoxUSL.Size = new Size(800, 125);
            groupBoxUSL.TabIndex = 0;
            groupBoxUSL.TabStop = false;
            groupBoxUSL.Text = "Условие";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.Desktop;
            buttonSave.Location = new Point(569, 23);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(153, 84);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить в файл";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.MenuHighlight;
            buttonDone.Location = new Point(375, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(153, 84);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 48);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(308, 48);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вывести таблицу и график значений функции[-5,5]. Таблицу сохранить в файл";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTabRes);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 325);
            panel2.TabIndex = 0;
            // 
            // groupBoxTabRes
            // 
            groupBoxTabRes.Controls.Add(dataGridView1);
            groupBoxTabRes.Controls.Add(textBoxRes);
            groupBoxTabRes.Location = new Point(3, 3);
            groupBoxTabRes.Name = "groupBoxTabRes";
            groupBoxTabRes.Size = new Size(267, 325);
            groupBoxTabRes.TabIndex = 0;
            groupBoxTabRes.TabStop = false;
            groupBoxTabRes.Text = "Таблица";
            // 
            // textBoxRes
            // 
            textBoxRes.Dock = DockStyle.Fill;
            textBoxRes.Location = new Point(3, 23);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(261, 299);
            textBoxRes.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(273, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 325);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxChart);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(283, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(517, 325);
            panel3.TabIndex = 0;
            // 
            // groupBoxChart
            // 
            groupBoxChart.Dock = DockStyle.Fill;
            groupBoxChart.Location = new Point(0, 0);
            groupBoxChart.Name = "groupBoxChart";
            groupBoxChart.Size = new Size(517, 325);
            groupBoxChart.TabIndex = 0;
            groupBoxChart.TabStop = false;
            groupBoxChart.Text = "График";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-23, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 3;
            
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBoxUSL.ResumeLayout(false);
            groupBoxUSL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBoxTabRes.ResumeLayout(false);
            groupBoxTabRes.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxUSL;
        private Panel panel2;
        private GroupBox groupBoxTabRes;
        private Panel panel3;
        private GroupBox groupBoxChart;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Splitter splitter1;
        private Button buttonSave;
        private Button buttonDone;
        private TextBox textBoxRes;
        private DataGridView dataGridView1;
    }
}

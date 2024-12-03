namespace Tyuiu.TyazhovLA.Sprint6.Task7.V10
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            buttonLoad = new Button();
            buttonRes = new Button();
            buttonHelp = new Button();
            buttonSave = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewIn = new DataGridView();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            dataGridViewOut = new DataGridView();
            toolTip1 = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(805, 77);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(15, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 103);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // buttonLoad
            // 
            buttonLoad.BackgroundImage = (Image)resources.GetObject("buttonLoad.BackgroundImage");
            buttonLoad.BackgroundImageLayout = ImageLayout.Center;
            buttonLoad.Location = new Point(18, 10);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(76, 68);
            buttonLoad.TabIndex = 1;
            toolTip1.SetToolTip(buttonLoad, "Открыть файл");
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonRes
            // 
            buttonRes.BackgroundImage = (Image)resources.GetObject("buttonRes.BackgroundImage");
            buttonRes.BackgroundImageLayout = ImageLayout.Center;
            buttonRes.Enabled = false;
            buttonRes.Location = new Point(105, 9);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(93, 70);
            buttonRes.TabIndex = 1;
            toolTip1.SetToolTip(buttonRes, "Вывести результат");
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackgroundImage = (Image)resources.GetObject("buttonHelp.BackgroundImage");
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Location = new Point(750, 18);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(65, 65);
            buttonHelp.TabIndex = 1;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackgroundImage = (Image)resources.GetObject("buttonSave.BackgroundImage");
            buttonSave.BackgroundImageLayout = ImageLayout.Center;
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(210, 9);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 71);
            buttonSave.TabIndex = 1;
            toolTip1.SetToolTip(buttonSave, "Сохранить результат в файл");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonRes);
            panel1.Controls.Add(buttonLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 196);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 521);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewIn);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 521);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 23);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(419, 495);
            dataGridViewIn.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(425, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 521);
            panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOut);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 521);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 23);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(419, 495);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "InPutFileTask7V10.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 717);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(850, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "#6.7 Добавление к решению итоговых проектов по спринту";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button buttonLoad;
        private Button buttonRes;
        private Button buttonHelp;
        private Button buttonSave;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Panel panel3;
        private GroupBox groupBox3;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private SaveFileDialog saveFileDialogMatrix;
    }
}

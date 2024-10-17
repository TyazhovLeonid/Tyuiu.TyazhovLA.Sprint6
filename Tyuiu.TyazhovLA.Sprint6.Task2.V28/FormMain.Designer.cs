namespace Tyuiu.TyazhovLA.Sprint6.Task2.V28
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
            Условие = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxInfo = new GroupBox();
            textBoxET = new TextBox();
            textBoxST = new TextBox();
            buttonGo = new Button();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            groupBoxResult = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            Условие.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Условие
            // 
            Условие.Controls.Add(pictureBox1);
            Условие.Controls.Add(textBoxTask);
            Условие.FlatStyle = FlatStyle.Popup;
            Условие.Location = new Point(10, 8);
            Условие.Name = "Условие";
            Условие.Size = new Size(514, 246);
            Условие.TabIndex = 4;
            Условие.TabStop = false;
            Условие.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(454, 27);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вывести таблицу значений функции на заданном отрезке[-5,5]:";
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(textBoxET);
            groupBoxInfo.Controls.Add(textBoxST);
            groupBoxInfo.Controls.Add(buttonGo);
            groupBoxInfo.Controls.Add(textBoxEnd);
            groupBoxInfo.Controls.Add(textBoxStart);
            groupBoxInfo.Location = new Point(10, 260);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(514, 183);
            groupBoxInfo.TabIndex = 5;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Ввод данных";
            // 
            // textBoxET
            // 
            textBoxET.Location = new Point(174, 46);
            textBoxET.Name = "textBoxET";
            textBoxET.ReadOnly = true;
            textBoxET.Size = new Size(162, 27);
            textBoxET.TabIndex = 7;
            textBoxET.Text = "Введите конечный Х:";
            // 
            // textBoxST
            // 
            textBoxST.Location = new Point(6, 46);
            textBoxST.Name = "textBoxST";
            textBoxST.ReadOnly = true;
            textBoxST.Size = new Size(162, 27);
            textBoxST.TabIndex = 6;
            textBoxST.Text = "Введите стартовый Х:";
            // 
            // buttonGo
            // 
            buttonGo.BackColor = Color.Lime;
            buttonGo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGo.Location = new Point(338, 120);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(141, 44);
            buttonGo.TabIndex = 5;
            buttonGo.Text = "Вычислить";
            buttonGo.UseVisualStyleBackColor = false;
            buttonGo.Click += buttonGo_Click;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(189, 79);
            textBoxEnd.Multiline = true;
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(123, 41);
            textBoxEnd.TabIndex = 4;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(27, 79);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(116, 41);
            textBoxStart.TabIndex = 3;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridView1);
            groupBoxResult.Location = new Point(541, 17);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(250, 426);
            groupBoxResult.TabIndex = 6;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(6, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(227, 393);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "x";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "f(x)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 90;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 42);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Условие);
            Controls.Add(groupBoxInfo);
            Controls.Add(groupBoxResult);
            Name = "FormMain";
            Text = "FormMain";
            Условие.ResumeLayout(false);
            Условие.PerformLayout();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Условие;
        private TextBox textBoxTask;
        private GroupBox groupBoxInfo;
        private TextBox textBoxET;
        private TextBox textBoxST;
        private Button buttonGo;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private GroupBox groupBoxResult;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private PictureBox pictureBox1;
    }
}

namespace Tyuiu.TyazhovLA.Sprint6.Task5.V4
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
            buttonGoReadFile = new Button();
            dataGridViewRawData = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRawData).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGoReadFile
            // 
            buttonGoReadFile.BackColor = Color.Blue;
            buttonGoReadFile.FlatStyle = FlatStyle.Flat;
            buttonGoReadFile.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGoReadFile.Location = new Point(7, 18);
            buttonGoReadFile.Name = "buttonGoReadFile";
            buttonGoReadFile.Size = new Size(236, 82);
            buttonGoReadFile.TabIndex = 0;
            buttonGoReadFile.Text = "Прочесть данные из файла";
            buttonGoReadFile.UseVisualStyleBackColor = false;
            buttonGoReadFile.Click += buttonGoReadFile_Click;
            // 
            // dataGridViewRawData
            // 
            dataGridViewRawData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRawData.Location = new Point(7, 106);
            dataGridViewRawData.Name = "dataGridViewRawData";
            dataGridViewRawData.RowHeadersWidth = 51;
            dataGridViewRawData.Size = new Size(234, 396);
            dataGridViewRawData.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewRawData);
            groupBox1.Controls.Add(buttonGoReadFile);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 517);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Значения";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 540);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Подготовил Тяжов Л.А ПКТб-24-1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRawData).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGoReadFile;
        private DataGridView dataGridViewRawData;
        private GroupBox groupBox1;
    }
}

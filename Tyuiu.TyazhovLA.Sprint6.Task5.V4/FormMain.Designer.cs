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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonGoReadFile = new Button();
            dataGridViewRawData = new DataGridView();
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRawData).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
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
            // chartDiag
            // 
            chartArea2.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDiag.Legends.Add(legend2);
            chartDiag.Location = new Point(271, 30);
            chartDiag.Name = "chartDiag";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDiag.Series.Add(series2);
            chartDiag.Size = new Size(710, 484);
            chartDiag.TabIndex = 3;
            chartDiag.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 540);
            Controls.Add(chartDiag);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Подготовил Тяжов Л.А ПКТб-24-1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRawData).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGoReadFile;
        private DataGridView dataGridViewRawData;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
    }
}

namespace Tyuiu.TyazhovLA.Sprint6.Task1.V28
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
            pictureBoxFunction = new PictureBox();
            textBoxTask = new TextBox();
            groupBoxInfo = new GroupBox();
            textBoxET = new TextBox();
            textBoxST = new TextBox();
            buttonGo = new Button();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            groupBoxResult = new GroupBox();
            Tablica = new TextBox();
            buttonQuestion = new Button();
            Условие.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction).BeginInit();
            groupBoxInfo.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // Условие
            // 
            Условие.Controls.Add(pictureBoxFunction);
            Условие.Controls.Add(textBoxTask);
            Условие.FlatStyle = FlatStyle.Popup;
            Условие.Location = new Point(7, 3);
            Условие.Name = "Условие";
            Условие.Size = new Size(514, 246);
            Условие.TabIndex = 0;
            Условие.TabStop = false;
            Условие.Text = "Условие";
            // 
            // pictureBoxFunction
            // 
            pictureBoxFunction.Image = (Image)resources.GetObject("pictureBoxFunction.Image");
            pictureBoxFunction.Location = new Point(6, 59);
            pictureBoxFunction.Name = "pictureBoxFunction";
            pictureBoxFunction.Size = new Size(421, 53);
            pictureBoxFunction.TabIndex = 1;
            pictureBoxFunction.TabStop = false;
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
            groupBoxInfo.Controls.Add(buttonQuestion);
            groupBoxInfo.Controls.Add(textBoxET);
            groupBoxInfo.Controls.Add(textBoxST);
            groupBoxInfo.Controls.Add(buttonGo);
            groupBoxInfo.Controls.Add(textBoxEnd);
            groupBoxInfo.Controls.Add(textBoxStart);
            groupBoxInfo.Location = new Point(7, 255);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(514, 183);
            groupBoxInfo.TabIndex = 2;
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
            buttonGo.Click += buttonGo_Click_1;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(189, 79);
            textBoxEnd.Multiline = true;
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(123, 41);
            textBoxEnd.TabIndex = 4;
            textBoxEnd.Text = "5";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(27, 79);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(116, 41);
            textBoxStart.TabIndex = 3;
            textBoxStart.Text = "-5";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(Tablica);
            groupBoxResult.Location = new Point(538, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(250, 426);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // Tablica
            // 
            Tablica.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tablica.Location = new Point(6, 26);
            Tablica.Multiline = true;
            Tablica.Name = "Tablica";
            Tablica.ReadOnly = true;
            Tablica.ScrollBars = ScrollBars.Both;
            Tablica.Size = new Size(238, 394);
            Tablica.TabIndex = 4;
            Tablica.WordWrap = false;
            // 
            // buttonQuestion
            // 
            buttonQuestion.FlatStyle = FlatStyle.Flat;
            buttonQuestion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonQuestion.Location = new Point(294, 122);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(38, 39);
            buttonQuestion.TabIndex = 5;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInfo);
            Controls.Add(Условие);
            Name = "FormMain";
            Text = "Form1";
            Условие.ResumeLayout(false);
            Условие.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Условие;
        private PictureBox pictureBoxFunction;
        private TextBox textBoxTask;
        private GroupBox groupBoxInfo;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private TextBox textBoxET;
        private TextBox textBoxST;
        private Button buttonGo;
        private GroupBox groupBoxResult;
        private TextBox Tablica;
        private Button buttonQuestion;
    }
}

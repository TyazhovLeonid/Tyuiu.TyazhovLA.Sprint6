namespace Tyuiu.TyazhovLA.Sprint6.Task6.V14
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
            buttonHelp = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxIn = new TextBox();
            groupBox3 = new GroupBox();
            textBoxOut = new TextBox();
            buttonLoad = new Button();
            buttonDone = new Button();
            openFileDialogTask = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp
            // 
            buttonHelp.BackgroundImage = (Image)resources.GetObject("buttonHelp.BackgroundImage");
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Location = new Point(723, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(65, 65);
            buttonHelp.TabIndex = 0;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(5, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 103);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(776, 74);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxIn);
            groupBox2.Location = new Point(12, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 242);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(11, 27);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.Size = new Size(364, 210);
            textBoxIn.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxOut);
            groupBox3.Location = new Point(404, 196);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(380, 242);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(10, 23);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(364, 210);
            textBoxOut.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.DarkCyan;
            buttonLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLoad.Location = new Point(12, 12);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(132, 64);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Загрузить \r\nфайл";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.MediumTurquoise;
            buttonDone.Enabled = false;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone.Location = new Point(150, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(132, 64);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Вывести результат";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "InPutFileTask6V14.txt";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonLoad);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Name = "FormMain";
            Text = "FormMain";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBoxIn;
        private GroupBox groupBox3;
        private TextBox textBoxOut;
        private Button buttonLoad;
        private Button buttonDone;
        private OpenFileDialog openFileDialogTask;
    }
}

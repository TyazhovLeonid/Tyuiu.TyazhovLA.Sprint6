namespace Tyuiu.TyazhovLA.Sprint6.Task7.V10
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(245, 223);
            textBox1.TabIndex = 1;
            textBox1.Text = "Разработчик:\r\nТяжов Леонид Александрович\r\n\r\nГруппа:\r\nПКТб-24-1\r\n\r\nСпринт 6 \r\nЗадание 7\r\nВариант 10";
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.MediumSeaGreen;
            buttonOK.FlatStyle = FlatStyle.Popup;
            buttonOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK.Location = new Point(163, 241);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 33);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 286);
            Controls.Add(buttonOK);
            Controls.Add(textBox1);
            Name = "FormAbout";
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOK;
    }
}
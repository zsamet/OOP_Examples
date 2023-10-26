namespace Example1
{
    partial class Form1
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
            button2 = new Button();
            label1 = new Label();
            adtxt = new TextBox();
            adrestxt = new TextBox();
            yastxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mesaitxt = new TextBox();
            epostatxt = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            unvantxt = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.DialogResult = DialogResult.Ignore;
            button2.Location = new Point(244, 292);
            button2.Name = "button2";
            button2.Size = new Size(187, 65);
            button2.TabIndex = 1;
            button2.Text = "Bilgi Yazdır";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GrayText;
            label1.Location = new Point(37, 60);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad";
            label1.Click += label1_Click;
            // 
            // adtxt
            // 
            adtxt.Location = new Point(244, 60);
            adtxt.Name = "adtxt";
            adtxt.Size = new Size(187, 27);
            adtxt.TabIndex = 3;
            adtxt.TextChanged += textBox1_TextChanged;
            // 
            // adrestxt
            // 
            adrestxt.Location = new Point(244, 93);
            adrestxt.Name = "adrestxt";
            adrestxt.Size = new Size(187, 27);
            adrestxt.TabIndex = 4;
            // 
            // yastxt
            // 
            yastxt.Location = new Point(244, 126);
            yastxt.Name = "yastxt";
            yastxt.Size = new Size(187, 27);
            yastxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Location = new Point(63, 93);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Location = new Point(80, 126);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 7;
            label3.Text = "Yaş";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 8;
            label4.Text = "Çalışma Saati";
            label4.Click += label4_Click;
            // 
            // mesaitxt
            // 
            mesaitxt.Location = new Point(244, 159);
            mesaitxt.Name = "mesaitxt";
            mesaitxt.Size = new Size(187, 27);
            mesaitxt.TabIndex = 9;
            mesaitxt.TextChanged += textBox1_TextChanged_1;
            // 
            // epostatxt
            // 
            epostatxt.AutoSize = true;
            epostatxt.BackColor = SystemColors.ControlDarkDark;
            epostatxt.Location = new Point(52, 192);
            epostatxt.Name = "epostatxt";
            epostatxt.Size = new Size(58, 20);
            epostatxt.TabIndex = 10;
            epostatxt.Text = "E-Posta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Analist", "ML Uzmanı", "Veri Bilimci" });
            comboBox1.Location = new Point(244, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // unvantxt
            // 
            unvantxt.AutoSize = true;
            unvantxt.BackColor = SystemColors.ControlDarkDark;
            unvantxt.Location = new Point(60, 226);
            unvantxt.Name = "unvantxt";
            unvantxt.Size = new Size(50, 20);
            unvantxt.TabIndex = 13;
            unvantxt.Text = "Ünvan";
            unvantxt.Click += Ünvan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(578, 421);
            Controls.Add(unvantxt);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(epostatxt);
            Controls.Add(mesaitxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(yastxt);
            Controls.Add(adrestxt);
            Controls.Add(adtxt);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private TextBox adtxt;
        private TextBox adrestxt;
        private TextBox yastxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mesaitxt;
        private Label epostatxt;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label unvantxt;
    }
}
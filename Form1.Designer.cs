namespace WF_exel_find_17_04_2023
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
            textBox1 = new TextBox();
            ButtLoadFileList = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(689, 202);
            textBox1.TabIndex = 0;
            // 
            // ButtLoadFileList
            // 
            ButtLoadFileList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtLoadFileList.Location = new Point(751, 257);
            ButtLoadFileList.Name = "ButtLoadFileList";
            ButtLoadFileList.Size = new Size(300, 89);
            ButtLoadFileList.TabIndex = 1;
            ButtLoadFileList.Text = "загрузить из файла в список";
            ButtLoadFileList.UseVisualStyleBackColor = true;
            ButtLoadFileList.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(12, 257);
            progressBar1.Maximum = 1000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(689, 30);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressBar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar2.Location = new Point(12, 316);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(689, 30);
            progressBar2.Step = 1;
            progressBar2.TabIndex = 4;
            progressBar2.Click += progressBar2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1074, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.Location = new Point(751, 28);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(300, 202);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 368);
            Controls.Add(textBox2);
            Controls.Add(toolStrip1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(ButtLoadFileList);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button ButtLoadFileList;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private OpenFileDialog openFileDialog1;
        private ToolStrip toolStrip1;
        private TextBox textBox2;
    }
}
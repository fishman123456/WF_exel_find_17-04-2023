using Microsoft.Office.Interop.Excel;

using System.Collections.Generic;

namespace WF_exel_find_17_04_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            progressBar2.Value = 0;
            progressBar2.Maximum = 1000;
            openFileDialog1.Filter = "Exel files(*.xls)|*.xls|All files(*.*)|*.*";
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            //await Task.Run(() => { PrintAsync(); });
            PrintAsync();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       public async  Task PrintAsync()
        {
            List<string> list = new List<string>();

            //Create COM Objects.
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();


            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку

            MessageBox.Show("Файл открыт");

            Workbook excelBook = excelApp.Workbooks.Open(filename);
            _Worksheet excelSheet = excelBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = rows;
            for (int i = 1; i <= rows; i++)
            {
                progressBar1.Value = i;
                //create new line
                list.Add("\r\n");
                for (int j = 1; j <= cols; j++)
                {


                    //write the console
                    if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                        list.Add(excelRange.Cells[i, j].Value2.ToString() + "\t");

                }
            }
            //after reading, relaase the excel project
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            MessageBox.Show("Закончили");
            progressBar2.Minimum = 0;
            progressBar2.Maximum = list.Count;
            int count = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    progressBar2.Value = i;
            //}
            textBox1.Text = "\n";
            foreach (string f in list)
            {

                textBox1.Text += f;
                progressBar2.Value = list.Count;

            }
            //foreach (string f in list)
            //{
            //    dataGridView1.Rows.Add(f.ToArray());
            //}
        }
    }
}
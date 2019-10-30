/*
 * 
 * 
 * 
 * 
 * Sources....
 * 
 * https://stackoverflow.com/questions/5791235/how-to-select-an-item-in-a-listview-programmatically
 * 
 * https://www.c-sharpcorner.com/UploadFile/mahesh/working-with-listview-in-C-Sharp/
 * 
 * https://stackoverflow.com/questions/10476902/how-to-insert-object-type-in-listview
 * 
 * https://stackoverflow.com/questions/13952932/disable-beep-of-enter-and-escape-key-c-sharp
 * 
 * https://social.msdn.microsoft.com/Forums/en-US/e658f710-d3bd-4b0b-8797-d40000c1a6ff/set-listview-scroll-position?forum=winforms
 * 
 * https://www.c-sharpcorner.com/UploadFile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/
 * 
 * https://stackoverflow.com/questions/45418081/is-there-way-to-change-the-items-font-size-of-listview-in-winform-c
 * 
 * https://social.msdn.microsoft.com/Forums/vstudio/en-US/cc0af4a3-ab94-4182-8d06-39faf75b4a59/how-to-open-and-display-a-file-in-c?forum=csharpgeneral
 * 
 * http://csharphelper.com/blog/2016/02/let-the-user-select-a-folder-in-c/
 * 
 * https://stackoverflow.com/questions/11624298/how-to-use-openfiledialog-to-select-a-folder/11624322
 * 
 */


using PrimeNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicrisif_Assignment08
{
    public partial class form_MainForm : Form
    {
        public form_MainForm()
        {
            InitializeComponent();
            textBox_NumberToCheck.Select();


        }

        private void Btn_CheckNum_Click(object sender, EventArgs e)
        {
            try
            {
                CheckNumber(BigInteger.Parse(textBox_NumberToCheck.Text));

            }
            catch
            {
                AlertInvalidInput();
            }
     

        }

        public void CheckNumber(BigInteger num)
        {
            if(listView_PrimeCheckResults.Items.Count > 0)
            {
                foreach(ListViewItem item in listView_PrimeCheckResults.Items)
                {
                    item.Focused = false;
                    item.Selected = false;
                }
                

            }
            Boolean isPrime = BigIntPrimeChecker.isPrime(num);

            PrimeResult result = new PrimeResult(num, isPrime);
            listView_PrimeCheckResults.Items.Add(result.ToString());
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Tag = result;

            if (result.ToString().Length > 30)
            {
                listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Font = new Font("Veranda", 8);
            }


            if (isPrime) { listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].BackColor = Color.Green;}
            else { listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].BackColor = Color.Red; }

            textBox_NumberToCheck.Text = "";
            textBox_NumberToCheck.Select();

            listView_PrimeCheckResults.EnsureVisible(listView_PrimeCheckResults.Items.Count - 1);

            DetermineExportStatus();



        }

        private void Button_RemoveSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_PrimeCheckResults.Items)
            {
                if (item.Selected)
                {
                    item.Remove();
                }
            }

            if(listView_PrimeCheckResults.Items.Count != 0)
            {
                HighlightListViewObject();

            }

            DetermineExportStatus();



        }

        public void HighlightListViewObject()
        {
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Focused = true;
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Selected = true;
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].EnsureVisible();
            listView_PrimeCheckResults.Select();
        }

        private void Form_MainForm_Load(object sender, EventArgs e)
        {
            
            DetermineExportStatus();
        }


        private void Button_ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFromResultList();

            DetermineExportStatus();
        }

        public void DetermineExportStatus()
        {
            if(listView_PrimeCheckResults.Items.Count == 0)
            {
                button_ExportToTextFile.Hide();
            }
            else { button_ExportToTextFile.Show(); }
        }

        private void ClearAllFromResultList()
        {
            listView_PrimeCheckResults.Items.Clear();


        }



        private void Button_RemovePrimes_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_PrimeCheckResults.Items)
            {
                PrimeResult result = (PrimeResult)item.Tag;

                if (result.IsPrime)
                {

                    item.Remove();
                }
            }
            DetermineExportStatus();
        }

        private void Button_RemoveComposites_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_PrimeCheckResults.Items)
            {
                PrimeResult result = (PrimeResult)item.Tag;

                if (!result.IsPrime)
                {

                    item.Remove();
                }
            }
            DetermineExportStatus();
        }

        private void TextBox_NumberToCheck_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    CheckNumber((BigInteger.Parse(textBox_NumberToCheck.Text)));
                    e.Handled = e.SuppressKeyPress = true;
                }
                catch
                {
                    AlertInvalidInput();
                }

            }



        }

        private void AlertInvalidInput()
        {
            MessageBox.Show("INVALID INPUT", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBox_NumberToCheck.Text = "";
        }

      

        private void Button_SortResults_Click(object sender, EventArgs e)
        {

            PrimeResult[] resultArray = new PrimeResult[listView_PrimeCheckResults.Items.Count];

            for(int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = (PrimeResult)listView_PrimeCheckResults.Items[i].Tag;
            }

            Array.Sort(resultArray);

            ClearAllFromResultList();

            foreach(PrimeResult result in resultArray)
            {
                CheckNumber(result.Number);
            }
            if(listView_PrimeCheckResults.Items.Count > 0)
            {
                listView_PrimeCheckResults.EnsureVisible(0);

            }


        }

   

        private void Button_ExportToTextFile_Click(object sender, EventArgs e)
        {
            
            using (folderBrowserDialog_ChooseResultLocation)
            {
                DialogResult result = folderBrowserDialog_ChooseResultLocation.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog_ChooseResultLocation.SelectedPath))
                {
                    string[] files = Directory.GetFiles(folderBrowserDialog_ChooseResultLocation.SelectedPath);

                   // System.Windows.Forms.MessageBox.Show("Files found: " + folderBrowserDialog_ChooseResultLocation.SelectedPath, "Message");

                    string path = folderBrowserDialog_ChooseResultLocation.SelectedPath;

                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        string createText = GetListViewTextContents();
                        File.WriteAllText(path+"/PrimeResults.txt", createText);
                        Process.Start(path + "/PrimeResults.txt");
                    }
                }
            }

        }

        public string GetListViewTextContents()
        {
            String result = "";
            foreach(ListViewItem item in listView_PrimeCheckResults.Items)
            {
                result += item.Tag.ToString() + Environment.NewLine;
            }

            return result;
        }

        private void FolderBrowserDialog_ChooseResultLocation_HelpRequest(object sender, EventArgs e)
        {

        }
    }
    }


/*
 * Isaiah Dicristoforo
 * dicrisif@mail.uc.edu
 * 
 * Assignment 08:  GUI with PrimeNumber method integration
 * Due: 10/31/2019
 * IT 3045: Contemporary Programming, Fall 2019
 * Professor Bill Nicholson
 * 
 * Description:  This program contains a graphical user interface that allows the user to enter a number in a text 
 * box, or by importing a text file with numbers.  The program will then use the BigIntPrimeChecker class, which I created
 * earlier in the semester to check to see if the users number is prime.  The result will is displayed in a window, highlighted in
 * green if the number is prime, and red otherwise.  This program contains a lot of extra functionality, such as the ability to 
 * import and export text files, and delete and sort the results in the list view.  There is still a lot of functionality 
 * to make this "Ultimate" prime checker complete, but the current GUI still allows the user to preform a wide variety of 
 * operations on the data as prime results are generated.  In the future I will make my code more modular by making custom controls,
 * but because this is my first GUI project, I haven't gotten the hang of that yet.  Because of this, most of my methods are
 * contained in the PrimeForm.cs partial class.  
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
 * https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-open-files-using-the-openfiledialog-component
 * 
 * https://www.dotnetperls.com/parse
 */


using PrimeNumber;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Security;
using System.Windows.Forms;

namespace dicrisif_Assignment08
{
    /// <summary>
    /// This class provides the logic for the prime checker GUI
    /// </summary>
    public partial class form_PrimeForm : Form //Inheritence.  This class IS-A form.
    {
        /// <summary>
        /// Constructor which intializes the GUI components.  The initialize method is located in the Designer.cs class.
        /// </summary>
        public form_PrimeForm()
        {
            InitializeComponent();
            textBox_NumberToCheck.Select();//The user can begin entering numbers immediatly w/out clicking.


        }

        /// <summary>
        /// Cshecks if the users number is valid, and if so, triggers the calculation that determines if the number is prime.  
        /// </summary>
        /// <param name="sender">The object that triggered the event handler</param>
        /// <param name="e">The event data</param>
        private void Btn_CheckNum_Click(object sender, EventArgs e)
        {
            try
            {
                //The CheckNumAndDisplayResult method does not validate input, as requested by the assignment.  
                //If an exception is thrown, we simply catch the exception here.
                CheckNumAndDisplayResult(BigInteger.Parse(textBox_NumberToCheck.Text)); 


            }
            catch
            {
                AlertInvalidInput(); //Displays a method box saying an exception was thrown.
            }


        }
       
        /// <summary>
        /// Updates the labels which display the total results shown in the listview, and the total prime and composite numbers
        /// </summary>
        public void UpdateStatistics()
        {
            //Display the total number of results in the list view.
            label_totalNums.Text = "Total Numbers: " + listView_PrimeCheckResults.Items.Count; 

            //Display the total number of primes in the listView. The total primes in the list view are claculated by a seperate method.
            if (CalculateTotalPrimes() == 0)
            {
                label_TotalPrimes.Text = "Total Primes:  0";
            }
            else
            {   //If the text view is not empty, display the total primes, AND the percentage of primes.
                label_TotalPrimes.Text = "Total Primes: " + CalculateTotalPrimes().ToString() + "\nPrime:" + Math.Round((double)CalculateTotalPrimes() / listView_PrimeCheckResults.Items.Count * 100) + "%";

            }

            //Calculate the total number of composite numbers in the list view.
            int totalComposites = listView_PrimeCheckResults.Items.Count - CalculateTotalPrimes(); //Clever Logic :)

            if(totalComposites <= 0) //Check if the listView contains no results.
            {
                label_totalComposites.Text = "Total Composites: 0";

            }
            else
            {
                //If the list view is not empty, display the total number of composite number, and calculate the percentage of composite numbers.
                label_totalComposites.Text = "Total Composites: " + totalComposites + "\nComposite: " + Math.Round((double)totalComposites / listView_PrimeCheckResults.Items.Count * 100) + "%";

            }
        }


        /// <summary>
        /// Calculates the total number of primes in the list view.
        /// </summary>
        /// <returns>The total number of primes in the list view</returns>
        public int CalculateTotalPrimes()
        {
            int totalPrimes = 0; //Counter variable
            foreach(ListViewItem item in listView_PrimeCheckResults.Items)  //Look at each item in the list view.
            {
                if(((PrimeResult)item.Tag).IsPrime)//Each spot in the list view contains a PrimeResult object, which contains a IsPrime property.
                {
                    totalPrimes++; //If a prime is found, increment the counter variable.
                }
                    
            }

            return totalPrimes;
        }

        /// <summary>
        /// Calls our IsPrime method in the BigIntPrimeChecker class and displays the result in the listView control
        /// </summary>
        /// <param name="num"></param>
        public void CheckNumAndDisplayResult(BigInteger num)
        {

            if(listView_PrimeCheckResults.Items.Count > 0)
            {
                foreach(ListViewItem item in listView_PrimeCheckResults.Items)
                {
                    item.Focused = false;
                    item.Selected = false;
                }
                

            }
            Boolean isPrime = BigIntPrimeChecker.isPrime(num); //Calling our prime checker method located in the prime checker I created in a previous assignment.

            PrimeResult result = new PrimeResult(num, isPrime); //The prime result object stores a number, and whether or not the number is prime. 
            
            listView_PrimeCheckResults.Items.Add(result.ToString());//Add the result to the list.  
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Tag = result; //Causes the item added in the previous statement to associate with an object  (.Tag).

            if (result.ToString().Length > 30) //If the number is too large, we shrink the text size.  This could be improved in the future.
            {
                listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Font = new Font("Veranda", 8); //Give the list view entry a new font.
            }


            if (isPrime) { listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].BackColor = Color.Green;} //Green backround color if the listView entry is prime.
            else { listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].BackColor = Color.Red; } //Red backround color if the number is composite.

            textBox_NumberToCheck.Text = ""; //Clear the text box.
            textBox_NumberToCheck.Select(); //Automatically selects the text box to allow the user to enter a new number.

            listView_PrimeCheckResults.EnsureVisible(listView_PrimeCheckResults.Items.Count - 1);
            DetermineExportStatus();
            UpdateStatistics(); //After a new result is entered, we need to update the labels showing the total entrys, primes, and composites in the listView control.

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
            UpdateStatistics();



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
            UpdateStatistics();
            DetermineExportStatus();
           
        }


        private void Button_ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFromResultList();

            DetermineExportStatus();
            UpdateStatistics();

        }

        public void DetermineExportStatus()
        {
            if(listView_PrimeCheckResults.Items.Count == 0)
            {
                button_ExportToTextFile.Enabled = false;
            }
            else { button_ExportToTextFile.Enabled = true; }
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
            UpdateStatistics();

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
            UpdateStatistics();

        }

        private void TextBox_NumberToCheck_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    CheckNumAndDisplayResult((BigInteger.Parse(textBox_NumberToCheck.Text)));
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
                CheckNumAndDisplayResult(result.Number);
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


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog_ImportNumbers.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog_ImportNumbers.FileName);

                    while (!sr.EndOfStream)
                    {
                        BigInteger result = 0;
                        
                        if (BigInteger.TryParse(sr.ReadLine(), out result)){
                            CheckNumAndDisplayResult(BigInteger.Parse(result.ToString()));

                        }
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
    }


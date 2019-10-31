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
 * earlier in the semester to check to see if the users number is prime.  The result is displayed in a window, highlighted in
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
        /// Configures the initial state of the GUI controls when the form loads.
        /// </summary>
        /// <param name="sender">The object that triggers this event handler method</param>
        /// <param name="e">The event information</param>
        private void Form_MainForm_Load(object sender, EventArgs e)
        {
            UpdateStatistics();
            DetermineExportStatus(); //We won't be able to export out result at the beginning, as there will be nothing in the list view.

        }


        /// <summary>
        /// Constructor which intializes the GUI components.  The initialize method is located in the Designer.cs class.
        /// </summary>
        public form_PrimeForm()
        {
            InitializeComponent();
            textBox_NumberToCheck.Select();//The user can begin entering numbers immediatly w/out clicking.


        }

        /// <summary>
        /// Checks if the users number is valid, and if so, triggers the calculation that determines if the number is prime.  
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
        /// After the enter key is pressed, this method computes if the number in the text box is prime.
        /// </summary>
        /// <param name="sender">The object that triggered the event handler</param>
        /// <param name="e">The event information</param>
        private void TextBox_NumberToCheck_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) //Checks to see if the key pressed was the enter key.
            {
                try
                {
                    CheckNumAndDisplayResult((BigInteger.Parse(textBox_NumberToCheck.Text)));
                    e.Handled = e.SuppressKeyPress = true;
                }
                catch
                {
                    AlertInvalidInput(); //This method will display a message box alerting the user of bad input.
                }

            }



        }

        /// <summary>
        /// Calls our IsPrime method in the BigIntPrimeChecker class and displays the result in the listView control
        /// </summary>
        /// <param name="num"></param>
        public void CheckNumAndDisplayResult(BigInteger num)
        {

            if (listView_PrimeCheckResults.Items.Count > 0)
            {
                foreach (ListViewItem item in listView_PrimeCheckResults.Items)
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


            if (isPrime) { listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].BackColor = Color.Green; } //Green backround color if the listView entry is prime.
            else { listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].BackColor = Color.Red; } //Red backround color if the number is composite.

            textBox_NumberToCheck.Text = ""; //Clear the text box.
            textBox_NumberToCheck.Select(); //Automatically selects the text box to allow the user to enter a new number.

            listView_PrimeCheckResults.EnsureVisible(listView_PrimeCheckResults.Items.Count - 1);
            DetermineExportStatus();
            UpdateStatistics(); //After a new result is entered, we need to update the labels showing the total entrys, primes, and composites in the listView control.

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
        /// Remove the selected items from the list view.
        /// </summary>
        /// <param name="sender">The object that triggered the event handler</param>
        /// <param name="e">The event data</param>
        private void Button_RemoveSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_PrimeCheckResults.Items)
            {
                if (item.Selected) //Check to see if the item in the list is selected, and if so, remove it.
                {
                    item.Remove();
                }
            }

            if(listView_PrimeCheckResults.Items.Count != 0) 
            {
                HighlightListViewObject();

            }

            DetermineExportStatus();  //Determines whether or not we can export the results (we can't if we have an empty list)
            UpdateStatistics(); //Updates the display showing total results, primes, and composites.



        }

        /// <summary>
        /// Highlights the last object in the listView
        /// </summary>
        public void HighlightListViewObject()
        {
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Focused = true; //Accessing the LAST element in the list view.
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].Selected = true;
            listView_PrimeCheckResults.Items[listView_PrimeCheckResults.Items.Count - 1].EnsureVisible();
            listView_PrimeCheckResults.Select();
        }
   

        /// <summary>
        /// Triggers the deletion of all elements in the listView, and updates the GUI
        /// </summary>
        /// <param name="sender">The control that triggdered the event handler</param>
        /// <param name="e">The event information</param>
        private void Button_ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFromResultList();//Call this reusable helper method which clears the list view.
            DetermineExportStatus();
            UpdateStatistics();

        }

        /// <summary>
        /// Determines whether we should be able to export a list of results, and enables or disables the export button.
        /// </summary>
        public void DetermineExportStatus()
        {
            if(listView_PrimeCheckResults.Items.Count == 0)
            {
                button_ExportToTextFile.Enabled = false; //If the list is empty, we should not be able to export to a text file.
            }
            else { button_ExportToTextFile.Enabled = true; } //If the list has results, the export button will be enabled.
        }

        /// <summary>
        /// Clears the results from the list view.
        /// </summary>
        private void ClearAllFromResultList()
        {
            listView_PrimeCheckResults.Items.Clear();


        }

        /// <summary>
        /// Removes all prime numbers from the list view.
        /// </summary>
        /// <param name="sender">The object that triggered the event handler</param>
        /// <param name="e">The event information</param>
        private void Button_RemovePrimes_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_PrimeCheckResults.Items) //Check all the items in the list view
            {
                PrimeResult result = (PrimeResult)item.Tag; //Tag allows us to associate an object with a list view item.

                if (result.IsPrime) //Remove the item if it is prime.
                {

                    item.Remove();
                }
            }
            DetermineExportStatus(); //We have to update our GUI elements each time we remove or add elements. 
            UpdateStatistics();

        }
        /// <summary>
        /// Removes the composite elements from the list view.
        /// </summary>
        /// <param name="sender">The object that triggered the event handler</param>
        /// <param name="e">The event information</param>
        private void Button_RemoveComposites_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_PrimeCheckResults.Items) //Loop through each item in the list view.
            {
                PrimeResult result = (PrimeResult)item.Tag; 

                if (!result.IsPrime) //Remove the element if it is not prime.
                {

                    item.Remove();
                }
            }
            DetermineExportStatus(); //Update display elements 
            UpdateStatistics();

        }
       

        /// <summary>
        /// Sorts the results in the list view from least to greatest.
        /// </summary>
        /// <param name="sender">The objecgt that triggered the event handler</param>
        /// <param name="e">The event information</param>
        private void Button_SortResults_Click(object sender, EventArgs e)
        {
            //Temporarily transfer the elements in the list view to an array. The array has a sort method I implemented with the I-Comparable interface.
            PrimeResult[] resultArray = new PrimeResult[listView_PrimeCheckResults.Items.Count]; 

            for(int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = (PrimeResult)listView_PrimeCheckResults.Items[i].Tag; //Add each element in the listView collection to the array
            }

            Array.Sort(resultArray); //Call my sort method.  The sort method, CompareTo, is implemented in the PrimeResult class.

            ClearAllFromResultList(); //Clear the list.  We will be adding the same elements back, just sorted.

            foreach(PrimeResult result in resultArray)
            {
                CheckNumAndDisplayResult(result.Number);  //This method adds each element back to the listView.
            }
            if(listView_PrimeCheckResults.Items.Count > 0)  
            {
                listView_PrimeCheckResults.EnsureVisible(0);

            }


        }
   
        /// <summary>
        /// Displays the file explorer for the user, and exports the list of primes to the user's slected destination.
        /// </summary>
        /// <param name="sender">The object the triggered the event handler</param>
        /// <param name="e">The event information</param>
        private void Button_ExportToTextFile_Click(object sender, EventArgs e)
        {
            //A lot of this code is Stack Overflow and Microsoft Docs code that I combined and integreated into this project
            using (folderBrowserDialog_ChooseResultLocation) 
            {
                DialogResult result = folderBrowserDialog_ChooseResultLocation.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog_ChooseResultLocation.SelectedPath))
                {
                    string[] files = Directory.GetFiles(folderBrowserDialog_ChooseResultLocation.SelectedPath);

                    string path = folderBrowserDialog_ChooseResultLocation.SelectedPath;

                    if (!File.Exists(path)) //Make sure the file doesn't exsist, as we are creating a new file here.
                    {
                        // Create a file to write to.
                        string createText = GetListViewTextContents();
                        File.WriteAllText(path+"/PrimeResults.txt", createText);
                        Process.Start(path + "/PrimeResults.txt");  //PrimeResults.txt is the name of our new file.
                    }
                }
            }

        }
        
        /// <summary>
        /// Gets the contents of a list view formatted to be exported to a text file.
        /// </summary>
        /// <returns>A string containing the contents of the listView display</returns>
        public string GetListViewTextContents()
        {
            String result = "";
            foreach(ListViewItem item in listView_PrimeCheckResults.Items)
            {
                result += item.Tag.ToString() + Environment.NewLine; //Environment.NewLine worked well when I was exporting the text file.
            }

            return result; 
        }
        /// <summary>
        /// Opens a file dialog to allow the user to import a file of numbers into the program.
        /// </summary>
        /// <param name="sender">The control that triggered the event.</param>
        /// <param name="e">The event information</param>
        private void Button_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog_ImportNumbers.ShowDialog() == DialogResult.OK) //When the user selects a file to import...
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog_ImportNumbers.FileName); //Stream reader can read the contents of a text file.

                    while (!sr.EndOfStream)
                    {
                        BigInteger result = 0; //This is used for our TryParse statement.
                        
                        if (BigInteger.TryParse(sr.ReadLine(), out result)){  //TryParse won't throw an exception
                            CheckNumAndDisplayResult(BigInteger.Parse(result.ToString()));

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:   " + ex.Message); 
                    
                }
            }
        }

        /// <summary>
        /// Displays a message box alerting the user that there is an input error.
        /// </summary>
        private void AlertInvalidInput()
        {

            MessageBox.Show("INVALID INPUT", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBox_NumberToCheck.Text = ""; //Clears the text box after they entered "bad" input.
        }
    }
    }


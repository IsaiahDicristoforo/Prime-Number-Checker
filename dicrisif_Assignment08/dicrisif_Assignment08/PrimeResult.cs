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
 * to make this prime checker complete, but the current GUI still allows the user to preform a wide variety of 
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

using System;
using System.Numerics;


namespace dicrisif_Assignment08
{
    /// <summary>
    ///Stores a number and whether or not it is prime.
    /// </summary>
    class PrimeResult : IComparable //We will want to compare these objects so we can sort them in the list view of prime results.
    {
        private BigInteger numberChecked;  //The number we checked for primality.
        private bool isPrime; //Whether or not the number is prime.
       
        /// <summary>
        /// Constructor to set the number, and primality of a result to be displayed in the listView.
        /// </summary>
        /// <param name="numberChecked">The number we checked for primality</param>
        /// <param name="isPrime">Whether or not the number is prime</param>
        public PrimeResult(BigInteger numberChecked, bool isPrime)
        {
            this.numberChecked = numberChecked;
            this.isPrime = isPrime;

        } 

        /// <summary>
        /// Copy constructor so we don't violate data hiding
        /// </summary>
        /// <param name="result">The PrimeResult object we want to duplicate</param>
        public PrimeResult(PrimeResult result)
        {
            this.numberChecked = result.Number; //Copy the values.
            this.isPrime = result.isPrime;
        }
    
        /// <summary>
        /// Get the number we checked for primality.
        /// </summary>
        public BigInteger Number
        {
           
            get
            {
                return numberChecked;
            }
        }

        /// <summary>
        /// Get whether or not the currentResult is prime.
        /// </summary>
        public bool IsPrime
        {
            get
            {
            return isPrime; //Return if the number is prime or not.

            }
        }
        /// <summary>
        /// A string representation of a PrimeResult object's number and primalty
        /// </summary>
        /// <returns>The number the prime result is storing, and that numbers primality</returns>
        public override string ToString()
        {
            return numberChecked + (isPrime ? "   PRIME  " : "   NOT PRIME  "); //Conditional operator
        }

        /// <summary>
        /// Compare which PrimeResult object has a number greater than the other.
        /// </summary>
        /// <param name="obj">The object we are going to compare to</param>
        /// <returns>1 if this object has a number greater than the one we are comparing to, -1 otherwise</returns>
        public int CompareTo(object obj)
        {
            PrimeResult result = (PrimeResult)obj;

            if (this.Number > result.Number)
            {
                return 1;
            }
            if (this.Number < result.Number)
            {
                return -1;
            }
            return 0;
        }
    }
}

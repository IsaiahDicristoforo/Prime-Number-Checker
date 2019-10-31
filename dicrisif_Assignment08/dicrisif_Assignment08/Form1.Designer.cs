namespace dicrisif_Assignment08
{
    partial class form_MainForm
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
            this.btn_CheckNum = new System.Windows.Forms.Button();
            this.listView_PrimeCheckResults = new System.Windows.Forms.ListView();
            this.textBox_NumberToCheck = new System.Windows.Forms.TextBox();
            this.button_RemoveSelected = new System.Windows.Forms.Button();
            this.panel_ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button_SortResults = new System.Windows.Forms.Button();
            this.button_RemovePrimes = new System.Windows.Forms.Button();
            this.button_RemoveComposites = new System.Windows.Forms.Button();
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.panel_UserInput = new System.Windows.Forms.Panel();
            this.button_ExportToTextFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog_ChooseResultLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_Statistics = new System.Windows.Forms.Panel();
            this.label_totalComposites = new System.Windows.Forms.Label();
            this.label_TotalPrimes = new System.Windows.Forms.Label();
            this.label_totalNums = new System.Windows.Forms.Label();
            this.button_Import = new System.Windows.Forms.Button();
            this.openFileDialog_ImportNumbers = new System.Windows.Forms.OpenFileDialog();
            this.panel_ButtonPanel.SuspendLayout();
            this.panel_UserInput.SuspendLayout();
            this.panel_Statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CheckNum
            // 
            this.btn_CheckNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_CheckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_CheckNum.Location = new System.Drawing.Point(388, 32);
            this.btn_CheckNum.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_CheckNum.Name = "btn_CheckNum";
            this.btn_CheckNum.Size = new System.Drawing.Size(100, 48);
            this.btn_CheckNum.TabIndex = 0;
            this.btn_CheckNum.Text = "Check Number";
            this.btn_CheckNum.UseVisualStyleBackColor = false;
            this.btn_CheckNum.Click += new System.EventHandler(this.Btn_CheckNum_Click);
            // 
            // listView_PrimeCheckResults
            // 
            this.listView_PrimeCheckResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.listView_PrimeCheckResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView_PrimeCheckResults.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_PrimeCheckResults.ForeColor = System.Drawing.Color.White;
            this.listView_PrimeCheckResults.FullRowSelect = true;
            this.listView_PrimeCheckResults.HideSelection = false;
            this.listView_PrimeCheckResults.LabelWrap = false;
            this.listView_PrimeCheckResults.Location = new System.Drawing.Point(0, 0);
            this.listView_PrimeCheckResults.Name = "listView_PrimeCheckResults";
            this.listView_PrimeCheckResults.Size = new System.Drawing.Size(304, 532);
            this.listView_PrimeCheckResults.TabIndex = 1;
            this.listView_PrimeCheckResults.UseCompatibleStateImageBehavior = false;
            this.listView_PrimeCheckResults.View = System.Windows.Forms.View.Tile;
            // 
            // textBox_NumberToCheck
            // 
            this.textBox_NumberToCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_NumberToCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_NumberToCheck.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberToCheck.Location = new System.Drawing.Point(44, 39);
            this.textBox_NumberToCheck.Name = "textBox_NumberToCheck";
            this.textBox_NumberToCheck.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_NumberToCheck.Size = new System.Drawing.Size(324, 41);
            this.textBox_NumberToCheck.TabIndex = 2;
            this.textBox_NumberToCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_NumberToCheck_KeyDown);
            // 
            // button_RemoveSelected
            // 
            this.button_RemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_RemoveSelected.Location = new System.Drawing.Point(3, 58);
            this.button_RemoveSelected.Name = "button_RemoveSelected";
            this.button_RemoveSelected.Size = new System.Drawing.Size(116, 38);
            this.button_RemoveSelected.TabIndex = 3;
            this.button_RemoveSelected.Text = "Remove Selected";
            this.button_RemoveSelected.UseVisualStyleBackColor = false;
            this.button_RemoveSelected.Click += new System.EventHandler(this.Button_RemoveSelected_Click);
            // 
            // panel_ButtonPanel
            // 
            this.panel_ButtonPanel.Controls.Add(this.button_SortResults);
            this.panel_ButtonPanel.Controls.Add(this.button_RemoveSelected);
            this.panel_ButtonPanel.Controls.Add(this.button_RemovePrimes);
            this.panel_ButtonPanel.Controls.Add(this.button_RemoveComposites);
            this.panel_ButtonPanel.Controls.Add(this.button_ClearAll);
            this.panel_ButtonPanel.Location = new System.Drawing.Point(308, 10);
            this.panel_ButtonPanel.Margin = new System.Windows.Forms.Padding(9);
            this.panel_ButtonPanel.Name = "panel_ButtonPanel";
            this.panel_ButtonPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel_ButtonPanel.Size = new System.Drawing.Size(133, 399);
            this.panel_ButtonPanel.TabIndex = 4;
            // 
            // button_SortResults
            // 
            this.button_SortResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_SortResults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_SortResults.FlatAppearance.BorderSize = 20;
            this.button_SortResults.Location = new System.Drawing.Point(1, 1);
            this.button_SortResults.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_SortResults.Name = "button_SortResults";
            this.button_SortResults.Size = new System.Drawing.Size(98, 53);
            this.button_SortResults.TabIndex = 8;
            this.button_SortResults.Text = "Sort Results";
            this.button_SortResults.UseVisualStyleBackColor = false;
            this.button_SortResults.Click += new System.EventHandler(this.Button_SortResults_Click);
            // 
            // button_RemovePrimes
            // 
            this.button_RemovePrimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_RemovePrimes.Location = new System.Drawing.Point(1, 100);
            this.button_RemovePrimes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_RemovePrimes.Name = "button_RemovePrimes";
            this.button_RemovePrimes.Size = new System.Drawing.Size(118, 27);
            this.button_RemovePrimes.TabIndex = 6;
            this.button_RemovePrimes.Text = "Remove Primes";
            this.button_RemovePrimes.UseVisualStyleBackColor = false;
            this.button_RemovePrimes.Click += new System.EventHandler(this.Button_RemovePrimes_Click);
            // 
            // button_RemoveComposites
            // 
            this.button_RemoveComposites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_RemoveComposites.Location = new System.Drawing.Point(1, 129);
            this.button_RemoveComposites.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_RemoveComposites.Name = "button_RemoveComposites";
            this.button_RemoveComposites.Size = new System.Drawing.Size(118, 28);
            this.button_RemoveComposites.TabIndex = 7;
            this.button_RemoveComposites.Text = "Remove Composites";
            this.button_RemoveComposites.UseVisualStyleBackColor = false;
            this.button_RemoveComposites.Click += new System.EventHandler(this.Button_RemoveComposites_Click);
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_ClearAll.Location = new System.Drawing.Point(1, 159);
            this.button_ClearAll.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(118, 34);
            this.button_ClearAll.TabIndex = 5;
            this.button_ClearAll.Text = "Clear All";
            this.button_ClearAll.UseVisualStyleBackColor = false;
            this.button_ClearAll.Click += new System.EventHandler(this.Button_ClearAll_Click);
            // 
            // panel_UserInput
            // 
            this.panel_UserInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_UserInput.Controls.Add(this.textBox_NumberToCheck);
            this.panel_UserInput.Controls.Add(this.btn_CheckNum);
            this.panel_UserInput.Location = new System.Drawing.Point(544, 90);
            this.panel_UserInput.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel_UserInput.Name = "panel_UserInput";
            this.panel_UserInput.Size = new System.Drawing.Size(585, 113);
            this.panel_UserInput.TabIndex = 5;
            // 
            // button_ExportToTextFile
            // 
            this.button_ExportToTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ExportToTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_ExportToTextFile.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportToTextFile.ForeColor = System.Drawing.Color.Black;
            this.button_ExportToTextFile.Location = new System.Drawing.Point(588, 374);
            this.button_ExportToTextFile.Name = "button_ExportToTextFile";
            this.button_ExportToTextFile.Size = new System.Drawing.Size(131, 101);
            this.button_ExportToTextFile.TabIndex = 6;
            this.button_ExportToTextFile.Text = "Export Results";
            this.button_ExportToTextFile.UseVisualStyleBackColor = false;
            this.button_ExportToTextFile.Click += new System.EventHandler(this.Button_ExportToTextFile_Click);
            // 
            // folderBrowserDialog_ChooseResultLocation
            // 
            this.folderBrowserDialog_ChooseResultLocation.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog_ChooseResultLocation.HelpRequest += new System.EventHandler(this.FolderBrowserDialog_ChooseResultLocation_HelpRequest);
            // 
            // panel_Statistics
            // 
            this.panel_Statistics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_Statistics.Controls.Add(this.label_totalComposites);
            this.panel_Statistics.Controls.Add(this.label_TotalPrimes);
            this.panel_Statistics.Controls.Add(this.label_totalNums);
            this.panel_Statistics.Location = new System.Drawing.Point(544, 218);
            this.panel_Statistics.Name = "panel_Statistics";
            this.panel_Statistics.Size = new System.Drawing.Size(585, 98);
            this.panel_Statistics.TabIndex = 7;
            // 
            // label_totalComposites
            // 
            this.label_totalComposites.AutoSize = true;
            this.label_totalComposites.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalComposites.Location = new System.Drawing.Point(323, 36);
            this.label_totalComposites.Name = "label_totalComposites";
            this.label_totalComposites.Size = new System.Drawing.Size(177, 23);
            this.label_totalComposites.TabIndex = 2;
            this.label_totalComposites.Text = "Total Composites";
            // 
            // label_TotalPrimes
            // 
            this.label_TotalPrimes.AutoSize = true;
            this.label_TotalPrimes.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPrimes.Location = new System.Drawing.Point(16, 36);
            this.label_TotalPrimes.Name = "label_TotalPrimes";
            this.label_TotalPrimes.Size = new System.Drawing.Size(135, 23);
            this.label_TotalPrimes.TabIndex = 1;
            this.label_TotalPrimes.Text = "Total Primes:";
            this.label_TotalPrimes.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_totalNums
            // 
            this.label_totalNums.AutoSize = true;
            this.label_totalNums.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalNums.Location = new System.Drawing.Point(172, 0);
            this.label_totalNums.Name = "label_totalNums";
            this.label_totalNums.Size = new System.Drawing.Size(123, 23);
            this.label_totalNums.TabIndex = 0;
            this.label_totalNums.Text = "Total Nums:";
            // 
            // button_Import
            // 
            this.button_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_Import.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Import.Location = new System.Drawing.Point(932, 374);
            this.button_Import.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(124, 101);
            this.button_Import.TabIndex = 8;
            this.button_Import.Text = "Import Test Cases";
            this.button_Import.UseVisualStyleBackColor = false;
            this.button_Import.Click += new System.EventHandler(this.Button_Import_Click);
            // 
            // openFileDialog_ImportNumbers
            // 
            this.openFileDialog_ImportNumbers.FileName = "openFileDialog1";
            // 
            // form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1211, 532);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.panel_Statistics);
            this.Controls.Add(this.button_ExportToTextFile);
            this.Controls.Add(this.panel_UserInput);
            this.Controls.Add(this.panel_ButtonPanel);
            this.Controls.Add(this.listView_PrimeCheckResults);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "form_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Time:";
            this.Load += new System.EventHandler(this.Form_MainForm_Load);
            this.panel_ButtonPanel.ResumeLayout(false);
            this.panel_UserInput.ResumeLayout(false);
            this.panel_UserInput.PerformLayout();
            this.panel_Statistics.ResumeLayout(false);
            this.panel_Statistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CheckNum;
        private System.Windows.Forms.ListView listView_PrimeCheckResults;
        private System.Windows.Forms.TextBox textBox_NumberToCheck;
        private System.Windows.Forms.Button button_RemoveSelected;
        private System.Windows.Forms.FlowLayoutPanel panel_ButtonPanel;
        private System.Windows.Forms.Button button_ClearAll;
        private System.Windows.Forms.Button button_RemovePrimes;
        private System.Windows.Forms.Button button_RemoveComposites;
        private System.Windows.Forms.Button button_SortResults;
        private System.Windows.Forms.Panel panel_UserInput;
        private System.Windows.Forms.Button button_ExportToTextFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_ChooseResultLocation;
        private System.Windows.Forms.Panel panel_Statistics;
        private System.Windows.Forms.Label label_totalNums;
        private System.Windows.Forms.Label label_TotalPrimes;
        private System.Windows.Forms.Label label_totalComposites;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ImportNumbers;
    }
}


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
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.button_RemovePrimes = new System.Windows.Forms.Button();
            this.button_RemoveComposites = new System.Windows.Forms.Button();
            this.panel_UserInput = new System.Windows.Forms.Panel();
            this.button_ExportToTextFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog_ChooseResultLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_ButtonPanel.SuspendLayout();
            this.panel_UserInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CheckNum
            // 
            this.btn_CheckNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_CheckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CheckNum.Location = new System.Drawing.Point(388, 27);
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
            this.listView_PrimeCheckResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listView_PrimeCheckResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView_PrimeCheckResults.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_PrimeCheckResults.FullRowSelect = true;
            this.listView_PrimeCheckResults.HideSelection = false;
            this.listView_PrimeCheckResults.LabelWrap = false;
            this.listView_PrimeCheckResults.Location = new System.Drawing.Point(0, 0);
            this.listView_PrimeCheckResults.Name = "listView_PrimeCheckResults";
            this.listView_PrimeCheckResults.Size = new System.Drawing.Size(248, 422);
            this.listView_PrimeCheckResults.TabIndex = 1;
            this.listView_PrimeCheckResults.UseCompatibleStateImageBehavior = false;
            this.listView_PrimeCheckResults.View = System.Windows.Forms.View.Tile;
            // 
            // textBox_NumberToCheck
            // 
            this.textBox_NumberToCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_NumberToCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_NumberToCheck.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberToCheck.Location = new System.Drawing.Point(44, 27);
            this.textBox_NumberToCheck.Name = "textBox_NumberToCheck";
            this.textBox_NumberToCheck.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_NumberToCheck.Size = new System.Drawing.Size(324, 41);
            this.textBox_NumberToCheck.TabIndex = 2;
            this.textBox_NumberToCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_NumberToCheck_KeyDown);
            // 
            // button_RemoveSelected
            // 
            this.button_RemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_RemoveSelected.Location = new System.Drawing.Point(3, 78);
            this.button_RemoveSelected.Name = "button_RemoveSelected";
            this.button_RemoveSelected.Size = new System.Drawing.Size(75, 23);
            this.button_RemoveSelected.TabIndex = 3;
            this.button_RemoveSelected.Text = "Remove Selected";
            this.button_RemoveSelected.UseVisualStyleBackColor = false;
            this.button_RemoveSelected.Click += new System.EventHandler(this.Button_RemoveSelected_Click);
            // 
            // panel_ButtonPanel
            // 
            this.panel_ButtonPanel.Controls.Add(this.button_SortResults);
            this.panel_ButtonPanel.Controls.Add(this.button_ClearAll);
            this.panel_ButtonPanel.Controls.Add(this.button_RemoveSelected);
            this.panel_ButtonPanel.Controls.Add(this.button_RemovePrimes);
            this.panel_ButtonPanel.Controls.Add(this.button_RemoveComposites);
            this.panel_ButtonPanel.Location = new System.Drawing.Point(252, 14);
            this.panel_ButtonPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel_ButtonPanel.Name = "panel_ButtonPanel";
            this.panel_ButtonPanel.Size = new System.Drawing.Size(86, 302);
            this.panel_ButtonPanel.TabIndex = 4;
            // 
            // button_SortResults
            // 
            this.button_SortResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_SortResults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_SortResults.FlatAppearance.BorderSize = 20;
            this.button_SortResults.Location = new System.Drawing.Point(1, 1);
            this.button_SortResults.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_SortResults.Name = "button_SortResults";
            this.button_SortResults.Size = new System.Drawing.Size(75, 48);
            this.button_SortResults.TabIndex = 8;
            this.button_SortResults.Text = "Sort Results";
            this.button_SortResults.UseVisualStyleBackColor = false;
            this.button_SortResults.Click += new System.EventHandler(this.Button_SortResults_Click);
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_ClearAll.Location = new System.Drawing.Point(1, 51);
            this.button_ClearAll.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(75, 23);
            this.button_ClearAll.TabIndex = 5;
            this.button_ClearAll.Text = "Clear All";
            this.button_ClearAll.UseVisualStyleBackColor = false;
            this.button_ClearAll.Click += new System.EventHandler(this.Button_ClearAll_Click);
            // 
            // button_RemovePrimes
            // 
            this.button_RemovePrimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_RemovePrimes.Location = new System.Drawing.Point(1, 105);
            this.button_RemovePrimes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_RemovePrimes.Name = "button_RemovePrimes";
            this.button_RemovePrimes.Size = new System.Drawing.Size(77, 37);
            this.button_RemovePrimes.TabIndex = 6;
            this.button_RemovePrimes.Text = "Remove Primes";
            this.button_RemovePrimes.UseVisualStyleBackColor = false;
            this.button_RemovePrimes.Click += new System.EventHandler(this.Button_RemovePrimes_Click);
            // 
            // button_RemoveComposites
            // 
            this.button_RemoveComposites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_RemoveComposites.Location = new System.Drawing.Point(1, 144);
            this.button_RemoveComposites.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_RemoveComposites.Name = "button_RemoveComposites";
            this.button_RemoveComposites.Size = new System.Drawing.Size(77, 35);
            this.button_RemoveComposites.TabIndex = 7;
            this.button_RemoveComposites.Text = "Remove Composites";
            this.button_RemoveComposites.UseVisualStyleBackColor = false;
            this.button_RemoveComposites.Click += new System.EventHandler(this.Button_RemoveComposites_Click);
            // 
            // panel_UserInput
            // 
            this.panel_UserInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_UserInput.Controls.Add(this.textBox_NumberToCheck);
            this.panel_UserInput.Controls.Add(this.btn_CheckNum);
            this.panel_UserInput.Location = new System.Drawing.Point(412, 14);
            this.panel_UserInput.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel_UserInput.Name = "panel_UserInput";
            this.panel_UserInput.Size = new System.Drawing.Size(585, 96);
            this.panel_UserInput.TabIndex = 5;
            // 
            // button_ExportToTextFile
            // 
            this.button_ExportToTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ExportToTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_ExportToTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportToTextFile.ForeColor = System.Drawing.Color.Black;
            this.button_ExportToTextFile.Location = new System.Drawing.Point(254, 341);
            this.button_ExportToTextFile.Name = "button_ExportToTextFile";
            this.button_ExportToTextFile.Size = new System.Drawing.Size(98, 81);
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
            // form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1007, 422);
            this.Controls.Add(this.button_ExportToTextFile);
            this.Controls.Add(this.panel_UserInput);
            this.Controls.Add(this.panel_ButtonPanel);
            this.Controls.Add(this.listView_PrimeCheckResults);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "form_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime Checker";
            this.Load += new System.EventHandler(this.Form_MainForm_Load);
            this.panel_ButtonPanel.ResumeLayout(false);
            this.panel_UserInput.ResumeLayout(false);
            this.panel_UserInput.PerformLayout();
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
    }
}


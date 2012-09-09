namespace B00tme
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView_SelectPE_SearchResults = new System.Windows.Forms.ListView();
            this.textBox_SelectPE_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_LiveEnvSelector = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_ProgramFlow = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Parameters = new System.Windows.Forms.GroupBox();
            this.radioButton_Bootdiskparam_USB = new System.Windows.Forms.RadioButton();
            this.radioButton_Bootdiskparam_DVD = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Target = new System.Windows.Forms.GroupBox();
            this.comboBox_Target_selector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Target_showHarddisks = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_SelectPE_Searchdisk = new System.Windows.Forms.RadioButton();
            this.radioButton_SelectPE_BrowseForDisk = new System.Windows.Forms.RadioButton();
            this.textBox_SelectPE_imgPath = new System.Windows.Forms.TextBox();
            this.button_SelectPE_Browse = new System.Windows.Forms.Button();
            this.groupBox_StartProcess = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_StartProcess_Start = new System.Windows.Forms.Button();
            this.richTextBox_ConsoleOutput = new System.Windows.Forms.RichTextBox();
            this.progressBar_StartProcess_CloneProcess = new System.Windows.Forms.ProgressBar();
            this.groupBox_LiveEnvSelector.SuspendLayout();
            this.tableLayoutPanel_ProgramFlow.SuspendLayout();
            this.groupBox_Parameters.SuspendLayout();
            this.groupBox_Target.SuspendLayout();
            this.groupBox_StartProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_SelectPE_SearchResults
            // 
            this.listView_SelectPE_SearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_SelectPE_SearchResults.Location = new System.Drawing.Point(9, 67);
            this.listView_SelectPE_SearchResults.Name = "listView_SelectPE_SearchResults";
            this.listView_SelectPE_SearchResults.Size = new System.Drawing.Size(270, 104);
            this.listView_SelectPE_SearchResults.TabIndex = 0;
            this.listView_SelectPE_SearchResults.UseCompatibleStateImageBehavior = false;
            this.listView_SelectPE_SearchResults.View = System.Windows.Forms.View.Details;
            // 
            // textBox_SelectPE_Search
            // 
            this.textBox_SelectPE_Search.Location = new System.Drawing.Point(56, 41);
            this.textBox_SelectPE_Search.Name = "textBox_SelectPE_Search";
            this.textBox_SelectPE_Search.Size = new System.Drawing.Size(223, 20);
            this.textBox_SelectPE_Search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // groupBox_LiveEnvSelector
            // 
            this.groupBox_LiveEnvSelector.Controls.Add(this.button_SelectPE_Browse);
            this.groupBox_LiveEnvSelector.Controls.Add(this.textBox_SelectPE_imgPath);
            this.groupBox_LiveEnvSelector.Controls.Add(this.radioButton_SelectPE_BrowseForDisk);
            this.groupBox_LiveEnvSelector.Controls.Add(this.radioButton_SelectPE_Searchdisk);
            this.groupBox_LiveEnvSelector.Controls.Add(this.label4);
            this.groupBox_LiveEnvSelector.Controls.Add(this.textBox_SelectPE_Search);
            this.groupBox_LiveEnvSelector.Controls.Add(this.label1);
            this.groupBox_LiveEnvSelector.Controls.Add(this.listView_SelectPE_SearchResults);
            this.groupBox_LiveEnvSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_LiveEnvSelector.Location = new System.Drawing.Point(294, 3);
            this.groupBox_LiveEnvSelector.Name = "groupBox_LiveEnvSelector";
            this.groupBox_LiveEnvSelector.Size = new System.Drawing.Size(285, 286);
            this.groupBox_LiveEnvSelector.TabIndex = 3;
            this.groupBox_LiveEnvSelector.TabStop = false;
            this.groupBox_LiveEnvSelector.Text = "2: Select your live environment";
            // 
            // tableLayoutPanel_ProgramFlow
            // 
            this.tableLayoutPanel_ProgramFlow.ColumnCount = 2;
            this.tableLayoutPanel_ProgramFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProgramFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProgramFlow.Controls.Add(this.groupBox_Target, 0, 1);
            this.tableLayoutPanel_ProgramFlow.Controls.Add(this.groupBox_LiveEnvSelector, 1, 0);
            this.tableLayoutPanel_ProgramFlow.Controls.Add(this.groupBox_Parameters, 0, 0);
            this.tableLayoutPanel_ProgramFlow.Controls.Add(this.groupBox_StartProcess, 1, 1);
            this.tableLayoutPanel_ProgramFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProgramFlow.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_ProgramFlow.Name = "tableLayoutPanel_ProgramFlow";
            this.tableLayoutPanel_ProgramFlow.RowCount = 2;
            this.tableLayoutPanel_ProgramFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.03125F));
            this.tableLayoutPanel_ProgramFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.96875F));
            this.tableLayoutPanel_ProgramFlow.Size = new System.Drawing.Size(582, 512);
            this.tableLayoutPanel_ProgramFlow.TabIndex = 4;
            // 
            // groupBox_Parameters
            // 
            this.groupBox_Parameters.Controls.Add(this.label2);
            this.groupBox_Parameters.Controls.Add(this.radioButton_Bootdiskparam_DVD);
            this.groupBox_Parameters.Controls.Add(this.radioButton_Bootdiskparam_USB);
            this.groupBox_Parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Parameters.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Parameters.Name = "groupBox_Parameters";
            this.groupBox_Parameters.Size = new System.Drawing.Size(285, 286);
            this.groupBox_Parameters.TabIndex = 4;
            this.groupBox_Parameters.TabStop = false;
            this.groupBox_Parameters.Text = "1: Boot disk parameters";
            // 
            // radioButton_Bootdiskparam_USB
            // 
            this.radioButton_Bootdiskparam_USB.AutoSize = true;
            this.radioButton_Bootdiskparam_USB.Location = new System.Drawing.Point(6, 38);
            this.radioButton_Bootdiskparam_USB.Name = "radioButton_Bootdiskparam_USB";
            this.radioButton_Bootdiskparam_USB.Size = new System.Drawing.Size(69, 17);
            this.radioButton_Bootdiskparam_USB.TabIndex = 0;
            this.radioButton_Bootdiskparam_USB.TabStop = true;
            this.radioButton_Bootdiskparam_USB.Text = "USB disk";
            this.radioButton_Bootdiskparam_USB.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bootdiskparam_DVD
            // 
            this.radioButton_Bootdiskparam_DVD.AutoSize = true;
            this.radioButton_Bootdiskparam_DVD.Location = new System.Drawing.Point(6, 62);
            this.radioButton_Bootdiskparam_DVD.Name = "radioButton_Bootdiskparam_DVD";
            this.radioButton_Bootdiskparam_DVD.Size = new System.Drawing.Size(68, 17);
            this.radioButton_Bootdiskparam_DVD.TabIndex = 1;
            this.radioButton_Bootdiskparam_DVD.TabStop = true;
            this.radioButton_Bootdiskparam_DVD.Text = "CD/DVD";
            this.radioButton_Bootdiskparam_DVD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of disk:";
            // 
            // groupBox_Target
            // 
            this.groupBox_Target.Controls.Add(this.label5);
            this.groupBox_Target.Controls.Add(this.checkBox_Target_showHarddisks);
            this.groupBox_Target.Controls.Add(this.label3);
            this.groupBox_Target.Controls.Add(this.comboBox_Target_selector);
            this.groupBox_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Target.Location = new System.Drawing.Point(3, 295);
            this.groupBox_Target.Name = "groupBox_Target";
            this.groupBox_Target.Size = new System.Drawing.Size(285, 214);
            this.groupBox_Target.TabIndex = 5;
            this.groupBox_Target.TabStop = false;
            this.groupBox_Target.Text = "3: Target";
            // 
            // comboBox_Target_selector
            // 
            this.comboBox_Target_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Target_selector.FormattingEnabled = true;
            this.comboBox_Target_selector.Location = new System.Drawing.Point(98, 19);
            this.comboBox_Target_selector.Name = "comboBox_Target_selector";
            this.comboBox_Target_selector.Size = new System.Drawing.Size(181, 21);
            this.comboBox_Target_selector.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Disk to write to:";
            // 
            // checkBox_Target_showHarddisks
            // 
            this.checkBox_Target_showHarddisks.AutoSize = true;
            this.checkBox_Target_showHarddisks.Location = new System.Drawing.Point(178, 46);
            this.checkBox_Target_showHarddisks.Name = "checkBox_Target_showHarddisks";
            this.checkBox_Target_showHarddisks.Size = new System.Drawing.Size(101, 17);
            this.checkBox_Target_showHarddisks.TabIndex = 2;
            this.checkBox_Target_showHarddisks.Text = "Show harddisks";
            this.checkBox_Target_showHarddisks.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "------OR------";
            // 
            // radioButton_SelectPE_Searchdisk
            // 
            this.radioButton_SelectPE_Searchdisk.AutoSize = true;
            this.radioButton_SelectPE_Searchdisk.Location = new System.Drawing.Point(9, 17);
            this.radioButton_SelectPE_Searchdisk.Name = "radioButton_SelectPE_Searchdisk";
            this.radioButton_SelectPE_Searchdisk.Size = new System.Drawing.Size(259, 17);
            this.radioButton_SelectPE_Searchdisk.TabIndex = 4;
            this.radioButton_SelectPE_Searchdisk.TabStop = true;
            this.radioButton_SelectPE_Searchdisk.Text = "Search a disk online (Data from LiveCDList.com?)";
            this.radioButton_SelectPE_Searchdisk.UseVisualStyleBackColor = true;
            // 
            // radioButton_SelectPE_BrowseForDisk
            // 
            this.radioButton_SelectPE_BrowseForDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_SelectPE_BrowseForDisk.AutoSize = true;
            this.radioButton_SelectPE_BrowseForDisk.Location = new System.Drawing.Point(9, 190);
            this.radioButton_SelectPE_BrowseForDisk.Name = "radioButton_SelectPE_BrowseForDisk";
            this.radioButton_SelectPE_BrowseForDisk.Size = new System.Drawing.Size(207, 17);
            this.radioButton_SelectPE_BrowseForDisk.TabIndex = 5;
            this.radioButton_SelectPE_BrowseForDisk.TabStop = true;
            this.radioButton_SelectPE_BrowseForDisk.Text = "Specify an ISO, RAW or IMG manually";
            this.radioButton_SelectPE_BrowseForDisk.UseVisualStyleBackColor = true;
            // 
            // textBox_SelectPE_imgPath
            // 
            this.textBox_SelectPE_imgPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SelectPE_imgPath.Location = new System.Drawing.Point(9, 214);
            this.textBox_SelectPE_imgPath.Name = "textBox_SelectPE_imgPath";
            this.textBox_SelectPE_imgPath.Size = new System.Drawing.Size(189, 20);
            this.textBox_SelectPE_imgPath.TabIndex = 6;
            // 
            // button_SelectPE_Browse
            // 
            this.button_SelectPE_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SelectPE_Browse.Location = new System.Drawing.Point(204, 211);
            this.button_SelectPE_Browse.Name = "button_SelectPE_Browse";
            this.button_SelectPE_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_SelectPE_Browse.TabIndex = 7;
            this.button_SelectPE_Browse.Text = "Browse";
            this.button_SelectPE_Browse.UseVisualStyleBackColor = true;
            // 
            // groupBox_StartProcess
            // 
            this.groupBox_StartProcess.Controls.Add(this.progressBar_StartProcess_CloneProcess);
            this.groupBox_StartProcess.Controls.Add(this.richTextBox_ConsoleOutput);
            this.groupBox_StartProcess.Controls.Add(this.button_StartProcess_Start);
            this.groupBox_StartProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_StartProcess.Location = new System.Drawing.Point(294, 295);
            this.groupBox_StartProcess.Name = "groupBox_StartProcess";
            this.groupBox_StartProcess.Size = new System.Drawing.Size(285, 214);
            this.groupBox_StartProcess.TabIndex = 6;
            this.groupBox_StartProcess.TabStop = false;
            this.groupBox_StartProcess.Text = "4: Burn baby, Burn!";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 52);
            this.label5.TabIndex = 3;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // button_StartProcess_Start
            // 
            this.button_StartProcess_Start.Location = new System.Drawing.Point(72, 19);
            this.button_StartProcess_Start.Name = "button_StartProcess_Start";
            this.button_StartProcess_Start.Size = new System.Drawing.Size(144, 43);
            this.button_StartProcess_Start.TabIndex = 0;
            this.button_StartProcess_Start.Text = "Start!";
            this.button_StartProcess_Start.UseVisualStyleBackColor = true;
            // 
            // richTextBox_ConsoleOutput
            // 
            this.richTextBox_ConsoleOutput.BackColor = System.Drawing.Color.Black;
            this.richTextBox_ConsoleOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_ConsoleOutput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_ConsoleOutput.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox_ConsoleOutput.Location = new System.Drawing.Point(3, 107);
            this.richTextBox_ConsoleOutput.Name = "richTextBox_ConsoleOutput";
            this.richTextBox_ConsoleOutput.ReadOnly = true;
            this.richTextBox_ConsoleOutput.Size = new System.Drawing.Size(279, 104);
            this.richTextBox_ConsoleOutput.TabIndex = 1;
            this.richTextBox_ConsoleOutput.Text = "Console output";
            // 
            // progressBar_StartProcess_CloneProcess
            // 
            this.progressBar_StartProcess_CloneProcess.Location = new System.Drawing.Point(3, 78);
            this.progressBar_StartProcess_CloneProcess.Name = "progressBar_StartProcess_CloneProcess";
            this.progressBar_StartProcess_CloneProcess.Size = new System.Drawing.Size(276, 23);
            this.progressBar_StartProcess_CloneProcess.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 512);
            this.Controls.Add(this.tableLayoutPanel_ProgramFlow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "B00tme Live Disk Creator";
            this.groupBox_LiveEnvSelector.ResumeLayout(false);
            this.groupBox_LiveEnvSelector.PerformLayout();
            this.tableLayoutPanel_ProgramFlow.ResumeLayout(false);
            this.groupBox_Parameters.ResumeLayout(false);
            this.groupBox_Parameters.PerformLayout();
            this.groupBox_Target.ResumeLayout(false);
            this.groupBox_Target.PerformLayout();
            this.groupBox_StartProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_SelectPE_SearchResults;
        private System.Windows.Forms.TextBox textBox_SelectPE_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_LiveEnvSelector;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProgramFlow;
        private System.Windows.Forms.GroupBox groupBox_Parameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Bootdiskparam_DVD;
        private System.Windows.Forms.RadioButton radioButton_Bootdiskparam_USB;
        private System.Windows.Forms.GroupBox groupBox_Target;
        private System.Windows.Forms.CheckBox checkBox_Target_showHarddisks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Target_selector;
        private System.Windows.Forms.RadioButton radioButton_SelectPE_BrowseForDisk;
        private System.Windows.Forms.RadioButton radioButton_SelectPE_Searchdisk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_SelectPE_Browse;
        private System.Windows.Forms.TextBox textBox_SelectPE_imgPath;
        private System.Windows.Forms.GroupBox groupBox_StartProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_ConsoleOutput;
        private System.Windows.Forms.Button button_StartProcess_Start;
        private System.Windows.Forms.ProgressBar progressBar_StartProcess_CloneProcess;

    }
}


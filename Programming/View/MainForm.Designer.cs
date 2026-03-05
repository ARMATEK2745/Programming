namespace Programming
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            weekdayParsinggroupBox = new GroupBox();
            labelRecognizedValue = new Label();
            labelTypeValueForParsing = new Label();
            buttonParse = new Button();
            textBoxWeekendParsing = new TextBox();
            EnumarationsGroupBox = new GroupBox();
            IntValuelabel = new Label();
            ChooseValuelabel = new Label();
            ChooseEnumarationlabel = new Label();
            ValuesListBox = new ListBox();
            intValue = new TextBox();
            EnumsListBox = new ListBox();
            groupBoxSeasonHandle = new GroupBox();
            comboBoxSeason = new ComboBox();
            buttonGo = new Button();
            labelChooseSeason = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            weekdayParsinggroupBox.SuspendLayout();
            EnumarationsGroupBox.SuspendLayout();
            groupBoxSeasonHandle.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 505);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxSeasonHandle);
            tabPage1.Controls.Add(weekdayParsinggroupBox);
            tabPage1.Controls.Add(EnumarationsGroupBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // weekdayParsinggroupBox
            // 
            weekdayParsinggroupBox.Controls.Add(labelRecognizedValue);
            weekdayParsinggroupBox.Controls.Add(labelTypeValueForParsing);
            weekdayParsinggroupBox.Controls.Add(buttonParse);
            weekdayParsinggroupBox.Controls.Add(textBoxWeekendParsing);
            weekdayParsinggroupBox.Location = new Point(8, 296);
            weekdayParsinggroupBox.Name = "weekdayParsinggroupBox";
            weekdayParsinggroupBox.Size = new Size(337, 142);
            weekdayParsinggroupBox.TabIndex = 4;
            weekdayParsinggroupBox.TabStop = false;
            weekdayParsinggroupBox.Text = "Weekday Parsing";
            // 
            // labelRecognizedValue
            // 
            labelRecognizedValue.AutoSize = true;
            labelRecognizedValue.Location = new Point(6, 84);
            labelRecognizedValue.Name = "labelRecognizedValue";
            labelRecognizedValue.Size = new Size(0, 15);
            labelRecognizedValue.TabIndex = 3;
            // 
            // labelTypeValueForParsing
            // 
            labelTypeValueForParsing.AutoSize = true;
            labelTypeValueForParsing.Location = new Point(6, 28);
            labelTypeValueForParsing.Name = "labelTypeValueForParsing";
            labelTypeValueForParsing.Size = new Size(126, 15);
            labelTypeValueForParsing.TabIndex = 2;
            labelTypeValueForParsing.Text = "Type value for parsing:";
            // 
            // buttonParse
            // 
            buttonParse.Location = new Point(223, 46);
            buttonParse.Name = "buttonParse";
            buttonParse.Size = new Size(75, 23);
            buttonParse.TabIndex = 1;
            buttonParse.Text = "Parse";
            buttonParse.UseVisualStyleBackColor = true;
            buttonParse.Click += buttonParse_Click;
            // 
            // textBoxWeekendParsing
            // 
            textBoxWeekendParsing.Location = new Point(6, 46);
            textBoxWeekendParsing.Name = "textBoxWeekendParsing";
            textBoxWeekendParsing.Size = new Size(211, 23);
            textBoxWeekendParsing.TabIndex = 0;
            // 
            // EnumarationsGroupBox
            // 
            EnumarationsGroupBox.Controls.Add(IntValuelabel);
            EnumarationsGroupBox.Controls.Add(ChooseValuelabel);
            EnumarationsGroupBox.Controls.Add(ChooseEnumarationlabel);
            EnumarationsGroupBox.Controls.Add(ValuesListBox);
            EnumarationsGroupBox.Controls.Add(intValue);
            EnumarationsGroupBox.Controls.Add(EnumsListBox);
            EnumarationsGroupBox.Location = new Point(8, 6);
            EnumarationsGroupBox.Name = "EnumarationsGroupBox";
            EnumarationsGroupBox.Size = new Size(778, 275);
            EnumarationsGroupBox.TabIndex = 3;
            EnumarationsGroupBox.TabStop = false;
            EnumarationsGroupBox.Text = "Enumarations";
            // 
            // IntValuelabel
            // 
            IntValuelabel.AutoSize = true;
            IntValuelabel.Location = new Point(357, 25);
            IntValuelabel.Name = "IntValuelabel";
            IntValuelabel.Size = new Size(55, 15);
            IntValuelabel.TabIndex = 5;
            IntValuelabel.Text = "Int value:";
            // 
            // ChooseValuelabel
            // 
            ChooseValuelabel.AutoSize = true;
            ChooseValuelabel.Location = new Point(183, 25);
            ChooseValuelabel.Name = "ChooseValuelabel";
            ChooseValuelabel.Size = new Size(81, 15);
            ChooseValuelabel.TabIndex = 4;
            ChooseValuelabel.Text = "Choose value:";
            // 
            // ChooseEnumarationlabel
            // 
            ChooseEnumarationlabel.AutoSize = true;
            ChooseEnumarationlabel.Location = new Point(6, 25);
            ChooseEnumarationlabel.Name = "ChooseEnumarationlabel";
            ChooseEnumarationlabel.Size = new Size(121, 15);
            ChooseEnumarationlabel.TabIndex = 3;
            ChooseEnumarationlabel.Text = "Choose enumaration:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(183, 43);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(154, 214);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // intValue
            // 
            intValue.Location = new Point(357, 43);
            intValue.Name = "intValue";
            intValue.Size = new Size(99, 23);
            intValue.TabIndex = 2;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Location = new Point(6, 43);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(154, 214);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // groupBoxSeasonHandle
            // 
            groupBoxSeasonHandle.Controls.Add(labelChooseSeason);
            groupBoxSeasonHandle.Controls.Add(buttonGo);
            groupBoxSeasonHandle.Controls.Add(comboBoxSeason);
            groupBoxSeasonHandle.Location = new Point(365, 296);
            groupBoxSeasonHandle.Name = "groupBoxSeasonHandle";
            groupBoxSeasonHandle.Size = new Size(419, 142);
            groupBoxSeasonHandle.TabIndex = 5;
            groupBoxSeasonHandle.TabStop = false;
            groupBoxSeasonHandle.Text = "Season Handle";
            // 
            // comboBoxSeason
            // 
            comboBoxSeason.FormattingEnabled = true;
            comboBoxSeason.Location = new Point(6, 46);
            comboBoxSeason.Name = "comboBoxSeason";
            comboBoxSeason.Size = new Size(185, 23);
            comboBoxSeason.TabIndex = 0;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(197, 46);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(63, 23);
            buttonGo.TabIndex = 1;
            buttonGo.Text = "Go!";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // labelChooseSeason
            // 
            labelChooseSeason.AutoSize = true;
            labelChooseSeason.Location = new Point(6, 28);
            labelChooseSeason.Name = "labelChooseSeason";
            labelChooseSeason.Size = new Size(89, 15);
            labelChooseSeason.TabIndex = 2;
            labelChooseSeason.Text = "Choose season:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            weekdayParsinggroupBox.ResumeLayout(false);
            weekdayParsinggroupBox.PerformLayout();
            EnumarationsGroupBox.ResumeLayout(false);
            EnumarationsGroupBox.PerformLayout();
            groupBoxSeasonHandle.ResumeLayout(false);
            groupBoxSeasonHandle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TextBox intValue;
        private GroupBox EnumarationsGroupBox;
        private Label ChooseEnumarationlabel;
        private Label IntValuelabel;
        private Label ChooseValuelabel;
        private GroupBox weekdayParsinggroupBox;
        private Label labelTypeValueForParsing;
        private Button buttonParse;
        private TextBox textBoxWeekendParsing;
        private Label labelRecognizedValue;
        private GroupBox groupBoxSeasonHandle;
        private Label labelChooseSeason;
        private Button buttonGo;
        private ComboBox comboBoxSeason;
    }
}

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
            enums = new TabPage();
            groupBoxSeasonHandle = new GroupBox();
            labelChooseSeason = new Label();
            buttonGo = new Button();
            comboBoxSeason = new ComboBox();
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
            classes = new TabPage();
            groupBoxFilm = new GroupBox();
            labelRatingFilm = new Label();
            labelGenreFilm = new Label();
            labelReleaseYearFilm = new Label();
            labelMinutesDurationFilm = new Label();
            labelNameFilm = new Label();
            buttonFindBestFilm = new Button();
            textBoxRatingFilm = new TextBox();
            textBoxGenreFilm = new TextBox();
            textBoxReleaseYearFilm = new TextBox();
            textBoxMinutesDurationFilm = new TextBox();
            textBoxNameFilm = new TextBox();
            listBoxFilms = new ListBox();
            rectangles = new GroupBox();
            labelColor = new Label();
            labelWidth = new Label();
            labelLength = new Label();
            buttonFind = new Button();
            textBoxColor = new TextBox();
            textBoxWidth = new TextBox();
            textBoxLength = new TextBox();
            listBoxRectangles = new ListBox();
            tabControl1.SuspendLayout();
            enums.SuspendLayout();
            groupBoxSeasonHandle.SuspendLayout();
            weekdayParsinggroupBox.SuspendLayout();
            EnumarationsGroupBox.SuspendLayout();
            classes.SuspendLayout();
            groupBoxFilm.SuspendLayout();
            rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(enums);
            tabControl1.Controls.Add(classes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 505);
            tabControl1.TabIndex = 0;
            // 
            // enums
            // 
            enums.Controls.Add(groupBoxSeasonHandle);
            enums.Controls.Add(weekdayParsinggroupBox);
            enums.Controls.Add(EnumarationsGroupBox);
            enums.Location = new Point(4, 24);
            enums.Name = "enums";
            enums.Padding = new Padding(3);
            enums.Size = new Size(792, 477);
            enums.TabIndex = 0;
            enums.Text = "Enums";
            enums.UseVisualStyleBackColor = true;
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
            // labelChooseSeason
            // 
            labelChooseSeason.AutoSize = true;
            labelChooseSeason.Location = new Point(6, 28);
            labelChooseSeason.Name = "labelChooseSeason";
            labelChooseSeason.Size = new Size(89, 15);
            labelChooseSeason.TabIndex = 2;
            labelChooseSeason.Text = "Choose season:";
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
            // comboBoxSeason
            // 
            comboBoxSeason.FormattingEnabled = true;
            comboBoxSeason.Location = new Point(6, 46);
            comboBoxSeason.Name = "comboBoxSeason";
            comboBoxSeason.Size = new Size(185, 23);
            comboBoxSeason.TabIndex = 0;
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
            // classes
            // 
            classes.Controls.Add(groupBoxFilm);
            classes.Controls.Add(rectangles);
            classes.Location = new Point(4, 24);
            classes.Name = "classes";
            classes.Size = new Size(792, 477);
            classes.TabIndex = 0;
            classes.Text = "Classes";
            classes.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilm
            // 
            groupBoxFilm.Controls.Add(labelRatingFilm);
            groupBoxFilm.Controls.Add(labelGenreFilm);
            groupBoxFilm.Controls.Add(labelReleaseYearFilm);
            groupBoxFilm.Controls.Add(labelMinutesDurationFilm);
            groupBoxFilm.Controls.Add(labelNameFilm);
            groupBoxFilm.Controls.Add(buttonFindBestFilm);
            groupBoxFilm.Controls.Add(textBoxRatingFilm);
            groupBoxFilm.Controls.Add(textBoxGenreFilm);
            groupBoxFilm.Controls.Add(textBoxReleaseYearFilm);
            groupBoxFilm.Controls.Add(textBoxMinutesDurationFilm);
            groupBoxFilm.Controls.Add(textBoxNameFilm);
            groupBoxFilm.Controls.Add(listBoxFilms);
            groupBoxFilm.Location = new Point(329, 3);
            groupBoxFilm.Name = "groupBoxFilm";
            groupBoxFilm.Size = new Size(300, 304);
            groupBoxFilm.TabIndex = 0;
            groupBoxFilm.TabStop = false;
            groupBoxFilm.Text = "Films";
            // 
            // labelRatingFilm
            // 
            labelRatingFilm.AutoSize = true;
            labelRatingFilm.Location = new Point(150, 192);
            labelRatingFilm.Name = "labelRatingFilm";
            labelRatingFilm.Size = new Size(44, 15);
            labelRatingFilm.TabIndex = 7;
            labelRatingFilm.Text = "Rating:";
            // 
            // labelGenreFilm
            // 
            labelGenreFilm.AutoSize = true;
            labelGenreFilm.Location = new Point(150, 150);
            labelGenreFilm.Name = "labelGenreFilm";
            labelGenreFilm.Size = new Size(41, 15);
            labelGenreFilm.TabIndex = 7;
            labelGenreFilm.Text = "Genre:";
            // 
            // labelReleaseYearFilm
            // 
            labelReleaseYearFilm.AutoSize = true;
            labelReleaseYearFilm.Location = new Point(150, 107);
            labelReleaseYearFilm.Name = "labelReleaseYearFilm";
            labelReleaseYearFilm.Size = new Size(74, 15);
            labelReleaseYearFilm.TabIndex = 7;
            labelReleaseYearFilm.Text = "Release year:";
            // 
            // labelMinutesDurationFilm
            // 
            labelMinutesDurationFilm.AutoSize = true;
            labelMinutesDurationFilm.Location = new Point(150, 64);
            labelMinutesDurationFilm.Name = "labelMinutesDurationFilm";
            labelMinutesDurationFilm.Size = new Size(101, 15);
            labelMinutesDurationFilm.TabIndex = 6;
            labelMinutesDurationFilm.Text = "Minutes duration:";
            // 
            // labelNameFilm
            // 
            labelNameFilm.AutoSize = true;
            labelNameFilm.Location = new Point(150, 22);
            labelNameFilm.Name = "labelNameFilm";
            labelNameFilm.Size = new Size(42, 15);
            labelNameFilm.TabIndex = 5;
            labelNameFilm.Text = "Name:";
            // 
            // buttonFindBestFilm
            // 
            buttonFindBestFilm.Location = new Point(150, 258);
            buttonFindBestFilm.Name = "buttonFindBestFilm";
            buttonFindBestFilm.Size = new Size(100, 23);
            buttonFindBestFilm.TabIndex = 4;
            buttonFindBestFilm.Text = "Find";
            buttonFindBestFilm.UseVisualStyleBackColor = true;
            buttonFindBestFilm.Click += buttonFindBestFilm_Click;
            // 
            // textBoxRatingFilm
            // 
            textBoxRatingFilm.Location = new Point(150, 210);
            textBoxRatingFilm.Name = "textBoxRatingFilm";
            textBoxRatingFilm.Size = new Size(100, 23);
            textBoxRatingFilm.TabIndex = 3;
            textBoxRatingFilm.TextChanged += textBoxRatingFilm_TextChanged;
            // 
            // textBoxGenreFilm
            // 
            textBoxGenreFilm.Location = new Point(150, 167);
            textBoxGenreFilm.Name = "textBoxGenreFilm";
            textBoxGenreFilm.Size = new Size(100, 23);
            textBoxGenreFilm.TabIndex = 3;
            textBoxGenreFilm.TextChanged += textBoxGenreFilm_TextChanged;
            // 
            // textBoxReleaseYearFilm
            // 
            textBoxReleaseYearFilm.Location = new Point(150, 125);
            textBoxReleaseYearFilm.Name = "textBoxReleaseYearFilm";
            textBoxReleaseYearFilm.Size = new Size(100, 23);
            textBoxReleaseYearFilm.TabIndex = 3;
            textBoxReleaseYearFilm.TextChanged += textBoxReleaseYearFilm_TextChanged;
            // 
            // textBoxMinutesDurationFilm
            // 
            textBoxMinutesDurationFilm.Location = new Point(150, 82);
            textBoxMinutesDurationFilm.Name = "textBoxMinutesDurationFilm";
            textBoxMinutesDurationFilm.Size = new Size(100, 23);
            textBoxMinutesDurationFilm.TabIndex = 2;
            textBoxMinutesDurationFilm.TextChanged += textBoxMinutesDurationFilm_TextChanged;
            // 
            // textBoxNameFilm
            // 
            textBoxNameFilm.Location = new Point(150, 38);
            textBoxNameFilm.Name = "textBoxNameFilm";
            textBoxNameFilm.Size = new Size(100, 23);
            textBoxNameFilm.TabIndex = 1;
            // 
            // listBoxFilms
            // 
            listBoxFilms.FormattingEnabled = true;
            listBoxFilms.ItemHeight = 15;
            listBoxFilms.Location = new Point(6, 22);
            listBoxFilms.Name = "listBoxFilms";
            listBoxFilms.Size = new Size(128, 259);
            listBoxFilms.TabIndex = 0;
            listBoxFilms.SelectedIndexChanged += listBoxFilms_SelectedIndexChanged;
            // 
            // rectangles
            // 
            rectangles.Controls.Add(labelColor);
            rectangles.Controls.Add(labelWidth);
            rectangles.Controls.Add(labelLength);
            rectangles.Controls.Add(buttonFind);
            rectangles.Controls.Add(textBoxColor);
            rectangles.Controls.Add(textBoxWidth);
            rectangles.Controls.Add(textBoxLength);
            rectangles.Controls.Add(listBoxRectangles);
            rectangles.Location = new Point(8, 3);
            rectangles.Name = "rectangles";
            rectangles.Size = new Size(300, 259);
            rectangles.TabIndex = 0;
            rectangles.TabStop = false;
            rectangles.Text = "Rectangles";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(150, 108);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(39, 15);
            labelColor.TabIndex = 7;
            labelColor.Text = "Color:";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(150, 64);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(42, 15);
            labelWidth.TabIndex = 6;
            labelWidth.Text = "Width:";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(150, 22);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(47, 15);
            labelLength.TabIndex = 5;
            labelLength.Text = "Length:";
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(150, 213);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(100, 23);
            buttonFind.TabIndex = 4;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(150, 126);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(100, 23);
            textBoxColor.TabIndex = 3;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(150, 82);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 2;
            textBoxWidth.TextChanged += textBoxWidth_TextChanged;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(150, 38);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 1;
            textBoxLength.TextChanged += textBoxLength_TextChanged;
            // 
            // listBoxRectangles
            // 
            listBoxRectangles.FormattingEnabled = true;
            listBoxRectangles.ItemHeight = 15;
            listBoxRectangles.Location = new Point(6, 22);
            listBoxRectangles.Name = "listBoxRectangles";
            listBoxRectangles.Size = new Size(128, 214);
            listBoxRectangles.TabIndex = 0;
            listBoxRectangles.SelectedIndexChanged += listBoxRectangles_SelectedIndexChanged;
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
            enums.ResumeLayout(false);
            groupBoxSeasonHandle.ResumeLayout(false);
            groupBoxSeasonHandle.PerformLayout();
            weekdayParsinggroupBox.ResumeLayout(false);
            weekdayParsinggroupBox.PerformLayout();
            EnumarationsGroupBox.ResumeLayout(false);
            EnumarationsGroupBox.PerformLayout();
            classes.ResumeLayout(false);
            groupBoxFilm.ResumeLayout(false);
            groupBoxFilm.PerformLayout();
            rectangles.ResumeLayout(false);
            rectangles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage enums;
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
        private TabPage classes;
        private GroupBox rectangles;
        private ListBox listBoxRectangles;
        private Label labelColor;
        private Label labelWidth;
        private Label labelLength;
        private Button buttonFind;
        private TextBox textBoxColor;
        private TextBox textBoxWidth;
        private TextBox textBoxLength;
        private GroupBox groupBoxFilm;
        private Label labelReleaseYearFilm;
        private Label labelMinutesDurationFilm;
        private Label labelNameFilm;
        private Button buttonFindBestFilm;
        private TextBox textBoxReleaseYearFilm;
        private TextBox textBoxMinutesDurationFilm;
        private TextBox textBoxNameFilm;
        private ListBox listBoxFilms;
        private Label labelRatingFilm;
        private Label labelGenreFilm;
        private TextBox textBoxRatingFilm;
        private TextBox textBoxGenreFilm;
    }
}

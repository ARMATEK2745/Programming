namespace Programming.View
{
    partial class FilmsUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            groupBoxFilm.SuspendLayout();
            SuspendLayout();
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
            groupBoxFilm.Location = new Point(3, 3);
            groupBoxFilm.Name = "groupBoxFilm";
            groupBoxFilm.Size = new Size(300, 304);
            groupBoxFilm.TabIndex = 1;
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
            // FilmsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxFilm);
            Name = "FilmsUserControl";
            Size = new Size(306, 311);
            groupBoxFilm.ResumeLayout(false);
            groupBoxFilm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFilm;
        private Label labelRatingFilm;
        private Label labelGenreFilm;
        private Label labelReleaseYearFilm;
        private Label labelMinutesDurationFilm;
        private Label labelNameFilm;
        private Button buttonFindBestFilm;
        private TextBox textBoxRatingFilm;
        private TextBox textBoxGenreFilm;
        private TextBox textBoxReleaseYearFilm;
        private TextBox textBoxMinutesDurationFilm;
        private TextBox textBoxNameFilm;
        private ListBox listBoxFilms;
    }
}

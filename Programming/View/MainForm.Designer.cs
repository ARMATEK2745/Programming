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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            enums = new TabPage();
            seasonHandleUserControl1 = new Programming.View.SeasonHandleUserControl();
            weekdayParsingUserControl1 = new Programming.View.WeekdayParsingUserControl();
            enumarationsUserControl1 = new Programming.View.EnumarationsUserControl();
            classes = new TabPage();
            rectanglesUserControl1 = new Programming.View.RectanglesUserControl();
            filmsUserControl1 = new Programming.View.FilmsUserControl();
            tabPageRectangles = new TabPage();
            errorProvider1 = new ErrorProvider(components);
            rectanglesParametersUserControl1 = new Programming.View.RectanglesParametersUserControl();
            tabControl1.SuspendLayout();
            enums.SuspendLayout();
            classes.SuspendLayout();
            tabPageRectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(enums);
            tabControl1.Controls.Add(classes);
            tabControl1.Controls.Add(tabPageRectangles);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 505);
            tabControl1.TabIndex = 0;
            // 
            // enums
            // 
            enums.Controls.Add(seasonHandleUserControl1);
            enums.Controls.Add(weekdayParsingUserControl1);
            enums.Controls.Add(enumarationsUserControl1);
            enums.Location = new Point(4, 24);
            enums.Name = "enums";
            enums.Padding = new Padding(3);
            enums.Size = new Size(792, 477);
            enums.TabIndex = 0;
            enums.Text = "Enums";
            enums.UseVisualStyleBackColor = true;
            // 
            // seasonHandleUserControl1
            // 
            seasonHandleUserControl1.Location = new Point(352, 299);
            seasonHandleUserControl1.Name = "seasonHandleUserControl1";
            seasonHandleUserControl1.Size = new Size(432, 162);
            seasonHandleUserControl1.TabIndex = 8;
            // 
            // weekdayParsingUserControl1
            // 
            weekdayParsingUserControl1.Location = new Point(6, 299);
            weekdayParsingUserControl1.Name = "weekdayParsingUserControl1";
            weekdayParsingUserControl1.Size = new Size(344, 149);
            weekdayParsingUserControl1.TabIndex = 7;
            // 
            // enumarationsUserControl1
            // 
            enumarationsUserControl1.Location = new Point(4, 6);
            enumarationsUserControl1.Name = "enumarationsUserControl1";
            enumarationsUserControl1.Size = new Size(786, 287);
            enumarationsUserControl1.TabIndex = 6;
            // 
            // classes
            // 
            classes.Controls.Add(rectanglesUserControl1);
            classes.Controls.Add(filmsUserControl1);
            classes.Location = new Point(4, 24);
            classes.Name = "classes";
            classes.Size = new Size(792, 477);
            classes.TabIndex = 0;
            classes.Text = "Classes";
            classes.UseVisualStyleBackColor = true;
            // 
            // rectanglesUserControl1
            // 
            rectanglesUserControl1.Location = new Point(8, 3);
            rectanglesUserControl1.Name = "rectanglesUserControl1";
            rectanglesUserControl1.Size = new Size(307, 390);
            rectanglesUserControl1.TabIndex = 1;
            // 
            // filmsUserControl1
            // 
            filmsUserControl1.Location = new Point(321, 3);
            filmsUserControl1.Name = "filmsUserControl1";
            filmsUserControl1.Size = new Size(306, 311);
            filmsUserControl1.TabIndex = 0;
            // 
            // tabPageRectangles
            // 
            tabPageRectangles.Controls.Add(rectanglesParametersUserControl1);
            tabPageRectangles.Location = new Point(4, 24);
            tabPageRectangles.Name = "tabPageRectangles";
            tabPageRectangles.Padding = new Padding(3);
            tabPageRectangles.Size = new Size(792, 477);
            tabPageRectangles.TabIndex = 1;
            tabPageRectangles.Text = "Rectangles";
            tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // rectanglesParametersUserControl1
            // 
            rectanglesParametersUserControl1.Location = new Point(6, 6);
            rectanglesParametersUserControl1.Name = "rectanglesParametersUserControl1";
            rectanglesParametersUserControl1.Size = new Size(783, 465);
            rectanglesParametersUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabControl1.ResumeLayout(false);
            enums.ResumeLayout(false);
            classes.ResumeLayout(false);
            tabPageRectangles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage enums;
        private TabPage classes;
        private TabPage tabPageRectangles;
        private View.EnumarationsUserControl enumarationsUserControl1;
        private ErrorProvider errorProvider1;
        private View.SeasonHandleUserControl seasonHandleUserControl1;
        private View.WeekdayParsingUserControl weekdayParsingUserControl1;
        private View.RectanglesUserControl rectanglesUserControl1;
        private View.FilmsUserControl filmsUserControl1;
        private View.RectanglesParametersUserControl rectanglesParametersUserControl1;
    }
}

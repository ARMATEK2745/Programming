namespace Programming.View
{
    partial class WeekdayParsingUserControl
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
            weekdayParsinggroupBox = new GroupBox();
            labelRecognizedValue = new Label();
            labelTypeValueForParsing = new Label();
            buttonParse = new Button();
            textBoxWeekendParsing = new TextBox();
            weekdayParsinggroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // weekdayParsinggroupBox
            // 
            weekdayParsinggroupBox.Controls.Add(labelRecognizedValue);
            weekdayParsinggroupBox.Controls.Add(labelTypeValueForParsing);
            weekdayParsinggroupBox.Controls.Add(buttonParse);
            weekdayParsinggroupBox.Controls.Add(textBoxWeekendParsing);
            weekdayParsinggroupBox.Location = new Point(3, 3);
            weekdayParsinggroupBox.Name = "weekdayParsinggroupBox";
            weekdayParsinggroupBox.Size = new Size(337, 142);
            weekdayParsinggroupBox.TabIndex = 5;
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
            // WeekdayParsingUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(weekdayParsinggroupBox);
            Name = "WeekdayParsingUserControl";
            Size = new Size(344, 149);
            weekdayParsinggroupBox.ResumeLayout(false);
            weekdayParsinggroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox weekdayParsinggroupBox;
        private Label labelRecognizedValue;
        private Label labelTypeValueForParsing;
        private Button buttonParse;
        private TextBox textBoxWeekendParsing;
    }
}

namespace Programming.View
{
    partial class EnumarationsUserControl
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
            EnumarationsGroupBox = new GroupBox();
            IntValuelabel = new Label();
            ChooseValuelabel = new Label();
            ChooseEnumarationlabel = new Label();
            ValuesListBox = new ListBox();
            intValue = new TextBox();
            EnumsListBox = new ListBox();
            EnumarationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumarationsGroupBox
            // 
            EnumarationsGroupBox.Controls.Add(IntValuelabel);
            EnumarationsGroupBox.Controls.Add(ChooseValuelabel);
            EnumarationsGroupBox.Controls.Add(ChooseEnumarationlabel);
            EnumarationsGroupBox.Controls.Add(ValuesListBox);
            EnumarationsGroupBox.Controls.Add(intValue);
            EnumarationsGroupBox.Controls.Add(EnumsListBox);
            EnumarationsGroupBox.Location = new Point(3, 3);
            EnumarationsGroupBox.Name = "EnumarationsGroupBox";
            EnumarationsGroupBox.Size = new Size(778, 275);
            EnumarationsGroupBox.TabIndex = 4;
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
            // EnumarationsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumarationsGroupBox);
            Name = "EnumarationsUserControl";
            Size = new Size(786, 287);
            EnumarationsGroupBox.ResumeLayout(false);
            EnumarationsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumarationsGroupBox;
        private Label IntValuelabel;
        private Label ChooseValuelabel;
        private Label ChooseEnumarationlabel;
        private ListBox ValuesListBox;
        private TextBox intValue;
        private ListBox EnumsListBox;
    }
}

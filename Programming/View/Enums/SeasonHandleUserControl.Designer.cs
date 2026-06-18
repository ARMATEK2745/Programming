namespace Programming.View
{
    partial class SeasonHandleUserControl
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
            groupBoxSeasonHandle = new GroupBox();
            labelChooseSeason = new Label();
            buttonGo = new Button();
            comboBoxSeason = new ComboBox();
            groupBoxSeasonHandle.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSeasonHandle
            // 
            groupBoxSeasonHandle.Controls.Add(labelChooseSeason);
            groupBoxSeasonHandle.Controls.Add(buttonGo);
            groupBoxSeasonHandle.Controls.Add(comboBoxSeason);
            groupBoxSeasonHandle.Location = new Point(3, 3);
            groupBoxSeasonHandle.Name = "groupBoxSeasonHandle";
            groupBoxSeasonHandle.Size = new Size(419, 142);
            groupBoxSeasonHandle.TabIndex = 6;
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
            // SeasonHandleUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxSeasonHandle);
            Name = "SeasonHandleUserControl";
            Size = new Size(425, 148);
            groupBoxSeasonHandle.ResumeLayout(false);
            groupBoxSeasonHandle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSeasonHandle;
        private Label labelChooseSeason;
        private Button buttonGo;
        private ComboBox comboBoxSeason;
    }
}

namespace Programming.View
{
    partial class RectanglesParametersUserControl
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
            labelHeightRectangleParameter = new Label();
            labelWidthRectangleParameter = new Label();
            labelYRectangleParameter = new Label();
            labelXRectangleParameter = new Label();
            labelIdRectangleParameter = new Label();
            labelSelectedRectangle = new Label();
            textBoxHeightRectangleParameter = new TextBox();
            textBoxWidthRectangleParameter = new TextBox();
            textBoxYRectangleParameter = new TextBox();
            textBoxXRectangleParameter = new TextBox();
            textBoxIdRectangleParameter = new TextBox();
            panelRectanglesDisplay = new Panel();
            buttonDelRectangleParameters = new Button();
            buttonAddRectangleParameters = new Button();
            labelRectanglesParameters = new Label();
            listBoxRectanglesParameters = new ListBox();
            SuspendLayout();
            // 
            // labelHeightRectangleParameter
            // 
            labelHeightRectangleParameter.AutoSize = true;
            labelHeightRectangleParameter.Location = new Point(24, 386);
            labelHeightRectangleParameter.Name = "labelHeightRectangleParameter";
            labelHeightRectangleParameter.Size = new Size(46, 15);
            labelHeightRectangleParameter.TabIndex = 18;
            labelHeightRectangleParameter.Text = "Height:";
            // 
            // labelWidthRectangleParameter
            // 
            labelWidthRectangleParameter.AutoSize = true;
            labelWidthRectangleParameter.Location = new Point(28, 357);
            labelWidthRectangleParameter.Name = "labelWidthRectangleParameter";
            labelWidthRectangleParameter.Size = new Size(42, 15);
            labelWidthRectangleParameter.TabIndex = 19;
            labelWidthRectangleParameter.Text = "Width:";
            // 
            // labelYRectangleParameter
            // 
            labelYRectangleParameter.AutoSize = true;
            labelYRectangleParameter.Location = new Point(53, 328);
            labelYRectangleParameter.Name = "labelYRectangleParameter";
            labelYRectangleParameter.Size = new Size(17, 15);
            labelYRectangleParameter.TabIndex = 20;
            labelYRectangleParameter.Text = "Y:";
            // 
            // labelXRectangleParameter
            // 
            labelXRectangleParameter.AutoSize = true;
            labelXRectangleParameter.Location = new Point(53, 299);
            labelXRectangleParameter.Name = "labelXRectangleParameter";
            labelXRectangleParameter.Size = new Size(17, 15);
            labelXRectangleParameter.TabIndex = 21;
            labelXRectangleParameter.Text = "X:";
            // 
            // labelIdRectangleParameter
            // 
            labelIdRectangleParameter.AutoSize = true;
            labelIdRectangleParameter.Location = new Point(50, 270);
            labelIdRectangleParameter.Name = "labelIdRectangleParameter";
            labelIdRectangleParameter.Size = new Size(20, 15);
            labelIdRectangleParameter.TabIndex = 22;
            labelIdRectangleParameter.Text = "Id:";
            // 
            // labelSelectedRectangle
            // 
            labelSelectedRectangle.AutoSize = true;
            labelSelectedRectangle.Location = new Point(3, 243);
            labelSelectedRectangle.Name = "labelSelectedRectangle";
            labelSelectedRectangle.Size = new Size(109, 15);
            labelSelectedRectangle.TabIndex = 23;
            labelSelectedRectangle.Text = "Selected Rectangle:";
            // 
            // textBoxHeightRectangleParameter
            // 
            textBoxHeightRectangleParameter.Location = new Point(76, 383);
            textBoxHeightRectangleParameter.Name = "textBoxHeightRectangleParameter";
            textBoxHeightRectangleParameter.Size = new Size(100, 23);
            textBoxHeightRectangleParameter.TabIndex = 14;
            textBoxHeightRectangleParameter.TextChanged += textBoxHeightRectangleParameter_TextChanged;
            // 
            // textBoxWidthRectangleParameter
            // 
            textBoxWidthRectangleParameter.Location = new Point(76, 354);
            textBoxWidthRectangleParameter.Name = "textBoxWidthRectangleParameter";
            textBoxWidthRectangleParameter.Size = new Size(100, 23);
            textBoxWidthRectangleParameter.TabIndex = 15;
            textBoxWidthRectangleParameter.TextChanged += textBoxWidthRectangleParameter_TextChanged;
            // 
            // textBoxYRectangleParameter
            // 
            textBoxYRectangleParameter.Location = new Point(76, 325);
            textBoxYRectangleParameter.Name = "textBoxYRectangleParameter";
            textBoxYRectangleParameter.Size = new Size(100, 23);
            textBoxYRectangleParameter.TabIndex = 16;
            textBoxYRectangleParameter.TextChanged += textBoxYRectangleParameter_TextChanged;
            // 
            // textBoxXRectangleParameter
            // 
            textBoxXRectangleParameter.Location = new Point(76, 296);
            textBoxXRectangleParameter.Name = "textBoxXRectangleParameter";
            textBoxXRectangleParameter.Size = new Size(100, 23);
            textBoxXRectangleParameter.TabIndex = 17;
            textBoxXRectangleParameter.TextChanged += textBoxXRectangleParameter_TextChanged;
            // 
            // textBoxIdRectangleParameter
            // 
            textBoxIdRectangleParameter.Location = new Point(76, 267);
            textBoxIdRectangleParameter.Name = "textBoxIdRectangleParameter";
            textBoxIdRectangleParameter.Size = new Size(100, 23);
            textBoxIdRectangleParameter.TabIndex = 13;
            // 
            // panelRectanglesDisplay
            // 
            panelRectanglesDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRectanglesDisplay.BorderStyle = BorderStyle.FixedSingle;
            panelRectanglesDisplay.Location = new Point(263, 7);
            panelRectanglesDisplay.Name = "panelRectanglesDisplay";
            panelRectanglesDisplay.Size = new Size(565, 467);
            panelRectanglesDisplay.TabIndex = 12;
            // 
            // buttonDelRectangleParameters
            // 
            buttonDelRectangleParameters.FlatStyle = FlatStyle.Flat;
            buttonDelRectangleParameters.Location = new Point(182, 185);
            buttonDelRectangleParameters.Name = "buttonDelRectangleParameters";
            buttonDelRectangleParameters.Size = new Size(75, 23);
            buttonDelRectangleParameters.TabIndex = 11;
            buttonDelRectangleParameters.Text = "Delete";
            buttonDelRectangleParameters.UseVisualStyleBackColor = true;
            buttonDelRectangleParameters.Click += buttonDelRectangleParameters_Click;
            // 
            // buttonAddRectangleParameters
            // 
            buttonAddRectangleParameters.FlatStyle = FlatStyle.Flat;
            buttonAddRectangleParameters.Location = new Point(3, 185);
            buttonAddRectangleParameters.Name = "buttonAddRectangleParameters";
            buttonAddRectangleParameters.Size = new Size(75, 23);
            buttonAddRectangleParameters.TabIndex = 10;
            buttonAddRectangleParameters.Text = "Add";
            buttonAddRectangleParameters.UseVisualStyleBackColor = true;
            buttonAddRectangleParameters.Click += buttonAddRectangleParameters_Click;
            // 
            // labelRectanglesParameters
            // 
            labelRectanglesParameters.AutoSize = true;
            labelRectanglesParameters.Location = new Point(3, 7);
            labelRectanglesParameters.Name = "labelRectanglesParameters";
            labelRectanglesParameters.Size = new Size(67, 15);
            labelRectanglesParameters.TabIndex = 9;
            labelRectanglesParameters.Text = "Rectangles:";
            // 
            // listBoxRectanglesParameters
            // 
            listBoxRectanglesParameters.FormattingEnabled = true;
            listBoxRectanglesParameters.ItemHeight = 15;
            listBoxRectanglesParameters.Location = new Point(3, 25);
            listBoxRectanglesParameters.Name = "listBoxRectanglesParameters";
            listBoxRectanglesParameters.Size = new Size(254, 154);
            listBoxRectanglesParameters.TabIndex = 8;
            listBoxRectanglesParameters.SelectedIndexChanged += listBoxRectanglesParameters_SelectedIndexChanged;
            // 
            // RectanglesParametersUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHeightRectangleParameter);
            Controls.Add(labelWidthRectangleParameter);
            Controls.Add(labelYRectangleParameter);
            Controls.Add(labelXRectangleParameter);
            Controls.Add(labelIdRectangleParameter);
            Controls.Add(labelSelectedRectangle);
            Controls.Add(textBoxHeightRectangleParameter);
            Controls.Add(textBoxWidthRectangleParameter);
            Controls.Add(textBoxYRectangleParameter);
            Controls.Add(textBoxXRectangleParameter);
            Controls.Add(textBoxIdRectangleParameter);
            Controls.Add(panelRectanglesDisplay);
            Controls.Add(buttonDelRectangleParameters);
            Controls.Add(buttonAddRectangleParameters);
            Controls.Add(labelRectanglesParameters);
            Controls.Add(listBoxRectanglesParameters);
            Name = "RectanglesParametersUserControl";
            Size = new Size(831, 477);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeightRectangleParameter;
        private Label labelWidthRectangleParameter;
        private Label labelYRectangleParameter;
        private Label labelXRectangleParameter;
        private Label labelIdRectangleParameter;
        private Label labelSelectedRectangle;
        private TextBox textBoxHeightRectangleParameter;
        private TextBox textBoxWidthRectangleParameter;
        private TextBox textBoxYRectangleParameter;
        private TextBox textBoxXRectangleParameter;
        private TextBox textBoxIdRectangleParameter;
        private Panel panelRectanglesDisplay;
        private Button buttonDelRectangleParameters;
        private Button buttonAddRectangleParameters;
        private Label labelRectanglesParameters;
        private ListBox listBoxRectanglesParameters;
    }
}

namespace Programming.View
{
    partial class RectanglesUserControl
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
            rectangles = new GroupBox();
            labelIdRectangles = new Label();
            textBoxIdRectangles = new TextBox();
            labelCenterRectangle = new Label();
            labelYRectangle = new Label();
            labelXRectangle = new Label();
            textBoxYRectangle = new TextBox();
            textBoxXRectangle = new TextBox();
            labelColor = new Label();
            labelWidth = new Label();
            labelLength = new Label();
            buttonFind = new Button();
            textBoxColor = new TextBox();
            textBoxWidth = new TextBox();
            textBoxLength = new TextBox();
            listBoxRectangles = new ListBox();
            rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // rectangles
            // 
            rectangles.Controls.Add(labelIdRectangles);
            rectangles.Controls.Add(textBoxIdRectangles);
            rectangles.Controls.Add(labelCenterRectangle);
            rectangles.Controls.Add(labelYRectangle);
            rectangles.Controls.Add(labelXRectangle);
            rectangles.Controls.Add(textBoxYRectangle);
            rectangles.Controls.Add(textBoxXRectangle);
            rectangles.Controls.Add(labelColor);
            rectangles.Controls.Add(labelWidth);
            rectangles.Controls.Add(labelLength);
            rectangles.Controls.Add(buttonFind);
            rectangles.Controls.Add(textBoxColor);
            rectangles.Controls.Add(textBoxWidth);
            rectangles.Controls.Add(textBoxLength);
            rectangles.Controls.Add(listBoxRectangles);
            rectangles.Location = new Point(3, 3);
            rectangles.Name = "rectangles";
            rectangles.Size = new Size(300, 384);
            rectangles.TabIndex = 1;
            rectangles.TabStop = false;
            rectangles.Text = "Rectangles";
            // 
            // labelIdRectangles
            // 
            labelIdRectangles.AutoSize = true;
            labelIdRectangles.Location = new Point(6, 289);
            labelIdRectangles.Name = "labelIdRectangles";
            labelIdRectangles.Size = new Size(20, 15);
            labelIdRectangles.TabIndex = 13;
            labelIdRectangles.Text = "Id:";
            // 
            // textBoxIdRectangles
            // 
            textBoxIdRectangles.Location = new Point(6, 305);
            textBoxIdRectangles.Name = "textBoxIdRectangles";
            textBoxIdRectangles.ReadOnly = true;
            textBoxIdRectangles.Size = new Size(100, 23);
            textBoxIdRectangles.TabIndex = 12;
            // 
            // labelCenterRectangle
            // 
            labelCenterRectangle.AutoSize = true;
            labelCenterRectangle.Location = new Point(150, 179);
            labelCenterRectangle.Name = "labelCenterRectangle";
            labelCenterRectangle.Size = new Size(45, 15);
            labelCenterRectangle.TabIndex = 11;
            labelCenterRectangle.Text = "Center:";
            // 
            // labelYRectangle
            // 
            labelYRectangle.AutoSize = true;
            labelYRectangle.Location = new Point(206, 201);
            labelYRectangle.Name = "labelYRectangle";
            labelYRectangle.Size = new Size(17, 15);
            labelYRectangle.TabIndex = 10;
            labelYRectangle.Text = "Y:";
            // 
            // labelXRectangle
            // 
            labelXRectangle.AutoSize = true;
            labelXRectangle.Location = new Point(151, 201);
            labelXRectangle.Name = "labelXRectangle";
            labelXRectangle.Size = new Size(17, 15);
            labelXRectangle.TabIndex = 9;
            labelXRectangle.Text = "X:";
            // 
            // textBoxYRectangle
            // 
            textBoxYRectangle.Location = new Point(206, 219);
            textBoxYRectangle.Name = "textBoxYRectangle";
            textBoxYRectangle.ReadOnly = true;
            textBoxYRectangle.Size = new Size(44, 23);
            textBoxYRectangle.TabIndex = 8;
            // 
            // textBoxXRectangle
            // 
            textBoxXRectangle.Location = new Point(150, 219);
            textBoxXRectangle.Name = "textBoxXRectangle";
            textBoxXRectangle.ReadOnly = true;
            textBoxXRectangle.Size = new Size(45, 23);
            textBoxXRectangle.TabIndex = 8;
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
            buttonFind.Location = new Point(150, 258);
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
            listBoxRectangles.Size = new Size(128, 259);
            listBoxRectangles.TabIndex = 0;
            listBoxRectangles.SelectedIndexChanged += listBoxRectangles_SelectedIndexChanged;
            // 
            // RectanglesUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rectangles);
            Name = "RectanglesUserControl";
            Size = new Size(307, 390);
            rectangles.ResumeLayout(false);
            rectangles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox rectangles;
        private Label labelIdRectangles;
        private TextBox textBoxIdRectangles;
        private Label labelCenterRectangle;
        private Label labelYRectangle;
        private Label labelXRectangle;
        private TextBox textBoxYRectangle;
        private TextBox textBoxXRectangle;
        private Label labelColor;
        private Label labelWidth;
        private Label labelLength;
        private Button buttonFind;
        private TextBox textBoxColor;
        private TextBox textBoxWidth;
        private TextBox textBoxLength;
        private ListBox listBoxRectangles;
    }
}

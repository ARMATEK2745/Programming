namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            InfoLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            InfoTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(RemoveButton);
            ItemsGroupBox.Controls.Add(AddButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(284, 437);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(117, 398);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(85, 33);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(6, 398);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(85, 33);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 28);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(278, 364);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(InfoLabel);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(IdLabel);
            SelectedItemGroupBox.Controls.Add(InfoTextBox);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IdTextBox);
            SelectedItemGroupBox.Location = new Point(293, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(488, 437);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(6, 249);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(70, 15);
            InfoLabel.TabIndex = 1;
            InfoLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 93);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(6, 62);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 30);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // InfoTextBox
            // 
            InfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InfoTextBox.Location = new Point(6, 267);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.Size = new Size(476, 151);
            InfoTextBox.TabIndex = 0;
            InfoTextBox.TextChanged += InfoTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 111);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(476, 116);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Leave += NameTextBox_Leave;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(46, 59);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 0;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(46, 27);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 0;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(784, 443);
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox InfoTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label InfoLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
    }
}

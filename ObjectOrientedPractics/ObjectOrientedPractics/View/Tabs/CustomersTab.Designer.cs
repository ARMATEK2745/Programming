namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomersGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            AddressTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            AddressLabel = new Label();
            FullNameLabel = new Label();
            IdLabel = new Label();
            Panel2 = new Panel();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersGroupBox.Controls.Add(RemoveButton);
            CustomersGroupBox.Controls.Add(AddButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(284, 437);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
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
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 28);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(278, 364);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(AddressTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullnameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IdTextBox);
            SelectedCustomerGroupBox.Controls.Add(AddressLabel);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(IdLabel);
            SelectedCustomerGroupBox.Location = new Point(293, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(488, 195);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Custoner";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(76, 83);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(406, 105);
            AddressTextBox.TabIndex = 4;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Location = new Point(76, 54);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(406, 23);
            FullnameTextBox.TabIndex = 3;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            FullnameTextBox.Leave += FullnameTextBox_Leave;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(76, 25);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(6, 86);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Address:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(6, 57);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 28);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.Location = new Point(293, 204);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(488, 236);
            Panel2.TabIndex = 2;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel2);
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(784, 443);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private GroupBox SelectedCustomerGroupBox;
        private ListBox CustomersListBox;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox AddressTextBox;
        private TextBox FullnameTextBox;
        private TextBox IdTextBox;
        private Label AddressLabel;
        private Label FullNameLabel;
        private Label IdLabel;
        private Panel Panel2;
    }
}

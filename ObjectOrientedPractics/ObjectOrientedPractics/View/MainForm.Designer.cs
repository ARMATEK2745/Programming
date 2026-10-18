namespace ObjectOrientedPractics
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
            ItemsTabPage = new TabPage();
            itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            CustomersTabPage = new TabPage();
            customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTabPage);
            tabControl1.Controls.Add(CustomersTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(584, 466);
            tabControl1.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(576, 438);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(570, 432);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(customersTab1);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(576, 438);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(570, 432);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 466);
            Controls.Add(tabControl1);
            MinimumSize = new Size(600, 505);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemsTabPage;
        private TabPage CustomersTabPage;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
    }
}

namespace Shop13.View
{
    partial class ShopUserControl
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
            groupBoxProduct = new GroupBox();
            labelQuantity = new Label();
            labelCategory = new Label();
            labelManufacturer = new Label();
            labelName = new Label();
            comboBoxCategory = new ComboBox();
            textBoxQuantity = new TextBox();
            textBoxManufacturer = new TextBox();
            textBoxName = new TextBox();
            listBoxProducts = new ListBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            groupBoxProduct.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxProduct
            // 
            groupBoxProduct.Controls.Add(labelQuantity);
            groupBoxProduct.Controls.Add(labelCategory);
            groupBoxProduct.Controls.Add(labelManufacturer);
            groupBoxProduct.Controls.Add(labelName);
            groupBoxProduct.Controls.Add(comboBoxCategory);
            groupBoxProduct.Controls.Add(textBoxQuantity);
            groupBoxProduct.Controls.Add(textBoxManufacturer);
            groupBoxProduct.Controls.Add(textBoxName);
            groupBoxProduct.Location = new Point(216, 3);
            groupBoxProduct.Name = "groupBoxProduct";
            groupBoxProduct.Size = new Size(461, 237);
            groupBoxProduct.TabIndex = 3;
            groupBoxProduct.TabStop = false;
            groupBoxProduct.Text = "Информация о товаре";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(45, 186);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(75, 15);
            labelQuantity.TabIndex = 5;
            labelQuantity.Text = "Количество:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(54, 136);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(66, 15);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Категория:";
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.Location = new Point(25, 90);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(95, 15);
            labelManufacturer.TabIndex = 3;
            labelManufacturer.Text = "Производитель:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(18, 41);
            labelName.Name = "labelName";
            labelName.Size = new Size(102, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Название товара:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(126, 133);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(302, 23);
            comboBoxCategory.TabIndex = 1;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(126, 183);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(302, 23);
            textBoxQuantity.TabIndex = 0;
            textBoxQuantity.TextChanged += textBoxQuantity_TextChanged;
            // 
            // textBoxManufacturer
            // 
            textBoxManufacturer.Location = new Point(126, 87);
            textBoxManufacturer.Name = "textBoxManufacturer";
            textBoxManufacturer.Size = new Size(302, 23);
            textBoxManufacturer.TabIndex = 0;
            textBoxManufacturer.TextChanged += textBoxManufacturer_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(126, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(302, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Enter += textBoxName_Enter;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(3, 3);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(186, 304);
            listBoxProducts.TabIndex = 2;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 313);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(67, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Создать";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(130, 313);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(59, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // ShopUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxProduct);
            Controls.Add(listBoxProducts);
            Name = "ShopUserControl";
            Size = new Size(686, 345);
            Leave += ShopUserControl_Leave;
            groupBoxProduct.ResumeLayout(false);
            groupBoxProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProduct;
        private Label labelQuantity;
        private Label labelCategory;
        private Label labelManufacturer;
        private Label labelName;
        private ComboBox comboBoxCategory;
        private TextBox textBoxQuantity;
        private TextBox textBoxManufacturer;
        private TextBox textBoxName;
        private ListBox listBoxProducts;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}

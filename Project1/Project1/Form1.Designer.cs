namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.stroreItemCategoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.itemCategoryNumLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryDescriptionLabel = new System.Windows.Forms.Label();
            this.itemCategorySelLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.searchForLabel = new System.Windows.Forms.Label();
            this.startsWithLabel = new System.Windows.Forms.Label();
            this.endsWithLabel = new System.Windows.Forms.Label();
            this.searchForTextBox = new System.Windows.Forms.TextBox();
            this.startsWithTextBox = new System.Windows.Forms.TextBox();
            this.endsWithTextBox = new System.Windows.Forms.TextBox();
            this.searchForButton = new System.Windows.Forms.Button();
            this.startsWithButton = new System.Windows.Forms.Button();
            this.endsWithButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.lengthButton = new System.Windows.Forms.Button();
            this.infobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(286, 26);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(266, 23);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "AVG Store System";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // stroreItemCategoryTextBox
            // 
            this.stroreItemCategoryTextBox.Location = new System.Drawing.Point(373, 124);
            this.stroreItemCategoryTextBox.Name = "stroreItemCategoryTextBox";
            this.stroreItemCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.stroreItemCategoryTextBox.TabIndex = 2;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(373, 78);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // categoryDescriptionTextBox
            // 
            this.categoryDescriptionTextBox.Location = new System.Drawing.Point(373, 185);
            this.categoryDescriptionTextBox.Name = "categoryDescriptionTextBox";
            this.categoryDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryDescriptionTextBox.TabIndex = 3;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(477, 237);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(84, 23);
            this.addCategoryButton.TabIndex = 4;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // itemCategoryNumLabel
            // 
            this.itemCategoryNumLabel.AutoSize = true;
            this.itemCategoryNumLabel.Location = new System.Drawing.Point(236, 127);
            this.itemCategoryNumLabel.Name = "itemCategoryNumLabel";
            this.itemCategoryNumLabel.Size = new System.Drawing.Size(110, 13);
            this.itemCategoryNumLabel.TabIndex = 5;
            this.itemCategoryNumLabel.Text = "Store Item Category #";
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(257, 78);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(80, 13);
            this.categoryNameLabel.TabIndex = 6;
            this.categoryNameLabel.Text = "Category Name";
            // 
            // categoryDescriptionLabel
            // 
            this.categoryDescriptionLabel.AutoSize = true;
            this.categoryDescriptionLabel.Location = new System.Drawing.Point(257, 185);
            this.categoryDescriptionLabel.Name = "categoryDescriptionLabel";
            this.categoryDescriptionLabel.Size = new System.Drawing.Size(105, 13);
            this.categoryDescriptionLabel.TabIndex = 7;
            this.categoryDescriptionLabel.Text = "Category Description";
            // 
            // itemCategorySelLabel
            // 
            this.itemCategorySelLabel.AutoSize = true;
            this.itemCategorySelLabel.Location = new System.Drawing.Point(264, 291);
            this.itemCategorySelLabel.Name = "itemCategorySelLabel";
            this.itemCategorySelLabel.Size = new System.Drawing.Size(72, 13);
            this.itemCategorySelLabel.TabIndex = 8;
            this.itemCategorySelLabel.Text = "Item Category";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(265, 338);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.itemNameLabel.TabIndex = 9;
            this.itemNameLabel.Text = "Item Name";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(268, 382);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(54, 13);
            this.itemPriceLabel.TabIndex = 10;
            this.itemPriceLabel.Text = "Item Price";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(373, 338);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 12;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(373, 382);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPriceTextBox.TabIndex = 13;
            // 
            // itemCategoryComboBox
            // 
            this.itemCategoryComboBox.FormattingEnabled = true;
            this.itemCategoryComboBox.Location = new System.Drawing.Point(373, 291);
            this.itemCategoryComboBox.Name = "itemCategoryComboBox";
            this.itemCategoryComboBox.Size = new System.Drawing.Size(100, 21);
            this.itemCategoryComboBox.TabIndex = 14;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(477, 423);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(84, 23);
            this.addItemButton.TabIndex = 15;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // searchForLabel
            // 
            this.searchForLabel.AutoSize = true;
            this.searchForLabel.Location = new System.Drawing.Point(268, 487);
            this.searchForLabel.Name = "searchForLabel";
            this.searchForLabel.Size = new System.Drawing.Size(65, 13);
            this.searchForLabel.TabIndex = 16;
            this.searchForLabel.Text = "Search For: ";
            // 
            // startsWithLabel
            // 
            this.startsWithLabel.AutoSize = true;
            this.startsWithLabel.Location = new System.Drawing.Point(268, 535);
            this.startsWithLabel.Name = "startsWithLabel";
            this.startsWithLabel.Size = new System.Drawing.Size(62, 13);
            this.startsWithLabel.TabIndex = 17;
            this.startsWithLabel.Text = "Starts With:";
            // 
            // endsWithLabel
            // 
            this.endsWithLabel.AutoSize = true;
            this.endsWithLabel.Location = new System.Drawing.Point(268, 585);
            this.endsWithLabel.Name = "endsWithLabel";
            this.endsWithLabel.Size = new System.Drawing.Size(59, 13);
            this.endsWithLabel.TabIndex = 18;
            this.endsWithLabel.Text = "Ends With:";
            // 
            // searchForTextBox
            // 
            this.searchForTextBox.Location = new System.Drawing.Point(373, 487);
            this.searchForTextBox.Name = "searchForTextBox";
            this.searchForTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchForTextBox.TabIndex = 19;
            // 
            // startsWithTextBox
            // 
            this.startsWithTextBox.Location = new System.Drawing.Point(373, 532);
            this.startsWithTextBox.Name = "startsWithTextBox";
            this.startsWithTextBox.Size = new System.Drawing.Size(100, 20);
            this.startsWithTextBox.TabIndex = 20;
            // 
            // endsWithTextBox
            // 
            this.endsWithTextBox.Location = new System.Drawing.Point(373, 582);
            this.endsWithTextBox.Name = "endsWithTextBox";
            this.endsWithTextBox.Size = new System.Drawing.Size(100, 20);
            this.endsWithTextBox.TabIndex = 21;
            // 
            // searchForButton
            // 
            this.searchForButton.Location = new System.Drawing.Point(499, 485);
            this.searchForButton.Name = "searchForButton";
            this.searchForButton.Size = new System.Drawing.Size(75, 23);
            this.searchForButton.TabIndex = 22;
            this.searchForButton.Text = "Submit";
            this.searchForButton.UseVisualStyleBackColor = true;
            this.searchForButton.Click += new System.EventHandler(this.searchForButton_Click);
            // 
            // startsWithButton
            // 
            this.startsWithButton.Location = new System.Drawing.Point(499, 532);
            this.startsWithButton.Name = "startsWithButton";
            this.startsWithButton.Size = new System.Drawing.Size(75, 23);
            this.startsWithButton.TabIndex = 23;
            this.startsWithButton.Text = "Submit";
            this.startsWithButton.UseVisualStyleBackColor = true;
            this.startsWithButton.Click += new System.EventHandler(this.startsWithButton_Click);
            // 
            // endsWithButton
            // 
            this.endsWithButton.Location = new System.Drawing.Point(499, 580);
            this.endsWithButton.Name = "endsWithButton";
            this.endsWithButton.Size = new System.Drawing.Size(75, 23);
            this.endsWithButton.TabIndex = 24;
            this.endsWithButton.Text = "Submit";
            this.endsWithButton.UseVisualStyleBackColor = true;
            this.endsWithButton.Click += new System.EventHandler(this.endsWithButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(236, 674);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 25;
            this.outputLabel.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.AcceptsReturn = true;
            this.outputTextBox.Location = new System.Drawing.Point(291, 711);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(350, 350);
            this.outputTextBox.TabIndex = 26;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(647, 711);
            this.lengthTextBox.MaximumSize = new System.Drawing.Size(20, 1000);
            this.lengthTextBox.Multiline = true;
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.ReadOnly = true;
            this.lengthTextBox.Size = new System.Drawing.Size(20, 350);
            this.lengthTextBox.TabIndex = 27;
            // 
            // lengthButton
            // 
            this.lengthButton.Location = new System.Drawing.Point(647, 674);
            this.lengthButton.Name = "lengthButton";
            this.lengthButton.Size = new System.Drawing.Size(100, 23);
            this.lengthButton.TabIndex = 28;
            this.lengthButton.Text = "Show Length";
            this.lengthButton.UseVisualStyleBackColor = true;
            this.lengthButton.Click += new System.EventHandler(this.lengthButton_Click);
            // 
            // infobutton
            // 
            this.infobutton.Location = new System.Drawing.Point(156, 482);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(94, 23);
            this.infobutton.TabIndex = 29;
            this.infobutton.Text = "Info (Hover me)";
            this.infobutton.UseVisualStyleBackColor = true;
            this.infobutton.MouseHover += new System.EventHandler(this.infobutton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 1161);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.lengthButton);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.endsWithButton);
            this.Controls.Add(this.startsWithButton);
            this.Controls.Add(this.searchForButton);
            this.Controls.Add(this.endsWithTextBox);
            this.Controls.Add(this.startsWithTextBox);
            this.Controls.Add(this.searchForTextBox);
            this.Controls.Add(this.endsWithLabel);
            this.Controls.Add(this.startsWithLabel);
            this.Controls.Add(this.searchForLabel);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemCategoryComboBox);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemCategorySelLabel);
            this.Controls.Add(this.categoryDescriptionLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.itemCategoryNumLabel);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoryDescriptionTextBox);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.stroreItemCategoryTextBox);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox stroreItemCategoryTextBox;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox categoryDescriptionTextBox;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label itemCategoryNumLabel;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.Label categoryDescriptionLabel;
        private System.Windows.Forms.Label itemCategorySelLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.ComboBox itemCategoryComboBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label searchForLabel;
        private System.Windows.Forms.Label startsWithLabel;
        private System.Windows.Forms.Label endsWithLabel;
        private System.Windows.Forms.TextBox searchForTextBox;
        private System.Windows.Forms.TextBox startsWithTextBox;
        private System.Windows.Forms.TextBox endsWithTextBox;
        private System.Windows.Forms.Button searchForButton;
        private System.Windows.Forms.Button startsWithButton;
        private System.Windows.Forms.Button endsWithButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Button lengthButton;
        private System.Windows.Forms.Button infobutton;
    }
}


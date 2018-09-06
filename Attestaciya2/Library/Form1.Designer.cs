namespace Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.t_Author = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_Year = new System.Windows.Forms.TextBox();
            this.t_Publishing = new System.Windows.Forms.TextBox();
            this.l_Author = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.l_Year = new System.Windows.Forms.Label();
            this.l_Publishing = new System.Windows.Forms.Label();
            this.l_Annotation = new System.Windows.Forms.Label();
            this.t_Annotation = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Block = new System.Windows.Forms.GroupBox();
            this.l_Subcategory = new System.Windows.Forms.Label();
            this.l_Category = new System.Windows.Forms.Label();
            this.t_Subcategory = new System.Windows.Forms.TextBox();
            this.t_Category = new System.Windows.Forms.TextBox();
            this.RecordButton = new System.Windows.Forms.Button();
            this.SearchButtun = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ReviewImage = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.l_Books = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ReviewBooks = new System.Windows.Forms.Button();
            this.СhangeButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Block.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_Author
            // 
            this.t_Author.Enabled = false;
            this.t_Author.Location = new System.Drawing.Point(95, 22);
            this.t_Author.Name = "t_Author";
            this.t_Author.Size = new System.Drawing.Size(165, 20);
            this.t_Author.TabIndex = 0;
            this.t_Author.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_Author_MouseClick);
            // 
            // t_Name
            // 
            this.t_Name.Enabled = false;
            this.t_Name.Location = new System.Drawing.Point(95, 49);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(165, 20);
            this.t_Name.TabIndex = 1;
            this.t_Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_Name_MouseClick);
            // 
            // t_Year
            // 
            this.t_Year.Enabled = false;
            this.t_Year.Location = new System.Drawing.Point(95, 76);
            this.t_Year.Name = "t_Year";
            this.t_Year.Size = new System.Drawing.Size(165, 20);
            this.t_Year.TabIndex = 2;
            this.t_Year.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_Year_MouseClick);
            // 
            // t_Publishing
            // 
            this.t_Publishing.Enabled = false;
            this.t_Publishing.Location = new System.Drawing.Point(95, 102);
            this.t_Publishing.Name = "t_Publishing";
            this.t_Publishing.Size = new System.Drawing.Size(165, 20);
            this.t_Publishing.TabIndex = 3;
            this.t_Publishing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_Publishing_MouseClick);
            // 
            // l_Author
            // 
            this.l_Author.AutoSize = true;
            this.l_Author.Location = new System.Drawing.Point(10, 25);
            this.l_Author.Name = "l_Author";
            this.l_Author.Size = new System.Drawing.Size(37, 13);
            this.l_Author.TabIndex = 5;
            this.l_Author.Text = "Автор";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(10, 52);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(57, 13);
            this.l_Name.TabIndex = 6;
            this.l_Name.Text = "Название";
            // 
            // l_Year
            // 
            this.l_Year.AutoSize = true;
            this.l_Year.Location = new System.Drawing.Point(10, 79);
            this.l_Year.Name = "l_Year";
            this.l_Year.Size = new System.Drawing.Size(70, 13);
            this.l_Year.TabIndex = 7;
            this.l_Year.Text = "Год издания";
            // 
            // l_Publishing
            // 
            this.l_Publishing.AutoSize = true;
            this.l_Publishing.Location = new System.Drawing.Point(10, 105);
            this.l_Publishing.Name = "l_Publishing";
            this.l_Publishing.Size = new System.Drawing.Size(79, 13);
            this.l_Publishing.TabIndex = 8;
            this.l_Publishing.Text = "Издательство";
            // 
            // l_Annotation
            // 
            this.l_Annotation.AutoSize = true;
            this.l_Annotation.Location = new System.Drawing.Point(10, 185);
            this.l_Annotation.Name = "l_Annotation";
            this.l_Annotation.Size = new System.Drawing.Size(61, 13);
            this.l_Annotation.TabIndex = 9;
            this.l_Annotation.Text = "Аннотации";
            // 
            // t_Annotation
            // 
            this.t_Annotation.Enabled = false;
            this.t_Annotation.Location = new System.Drawing.Point(95, 182);
            this.t_Annotation.Name = "t_Annotation";
            this.t_Annotation.Size = new System.Drawing.Size(294, 53);
            this.t_Annotation.TabIndex = 10;
            this.t_Annotation.Text = "";
            this.t_Annotation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_Annotation_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(684, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Block
            // 
            this.Block.Controls.Add(this.l_Subcategory);
            this.Block.Controls.Add(this.l_Category);
            this.Block.Controls.Add(this.t_Subcategory);
            this.Block.Controls.Add(this.t_Category);
            this.Block.Controls.Add(this.t_Publishing);
            this.Block.Controls.Add(this.t_Name);
            this.Block.Controls.Add(this.t_Author);
            this.Block.Controls.Add(this.l_Author);
            this.Block.Controls.Add(this.t_Year);
            this.Block.Controls.Add(this.t_Annotation);
            this.Block.Controls.Add(this.l_Name);
            this.Block.Controls.Add(this.l_Annotation);
            this.Block.Controls.Add(this.l_Year);
            this.Block.Controls.Add(this.l_Publishing);
            this.Block.Location = new System.Drawing.Point(12, 12);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(395, 270);
            this.Block.TabIndex = 12;
            this.Block.TabStop = false;
            this.Block.Text = "Выберите действие";
            // 
            // l_Subcategory
            // 
            this.l_Subcategory.AutoSize = true;
            this.l_Subcategory.Location = new System.Drawing.Point(10, 159);
            this.l_Subcategory.Name = "l_Subcategory";
            this.l_Subcategory.Size = new System.Drawing.Size(79, 13);
            this.l_Subcategory.TabIndex = 14;
            this.l_Subcategory.Text = "Подкатегория";
            // 
            // l_Category
            // 
            this.l_Category.AutoSize = true;
            this.l_Category.Location = new System.Drawing.Point(10, 132);
            this.l_Category.Name = "l_Category";
            this.l_Category.Size = new System.Drawing.Size(60, 13);
            this.l_Category.TabIndex = 13;
            this.l_Category.Text = "Категория";
            // 
            // t_Subcategory
            // 
            this.t_Subcategory.Enabled = false;
            this.t_Subcategory.Location = new System.Drawing.Point(95, 156);
            this.t_Subcategory.Name = "t_Subcategory";
            this.t_Subcategory.Size = new System.Drawing.Size(165, 20);
            this.t_Subcategory.TabIndex = 12;
            this.t_Subcategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_Subcategory_MouseClick);
            // 
            // t_Category
            // 
            this.t_Category.Enabled = false;
            this.t_Category.Location = new System.Drawing.Point(95, 129);
            this.t_Category.Name = "t_Category";
            this.t_Category.Size = new System.Drawing.Size(165, 20);
            this.t_Category.TabIndex = 11;
            this.t_Category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_Category_MouseClick);
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(314, 241);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(75, 23);
            this.RecordButton.TabIndex = 0;
            this.RecordButton.Text = "Записать";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // SearchButtun
            // 
            this.SearchButtun.Location = new System.Drawing.Point(95, 241);
            this.SearchButtun.Name = "SearchButtun";
            this.SearchButtun.Size = new System.Drawing.Size(75, 23);
            this.SearchButtun.TabIndex = 21;
            this.SearchButtun.Text = "Найти";
            this.SearchButtun.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(12, 288);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(12, 317);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(12, 346);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(105, 23);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ReviewImage
            // 
            this.ReviewImage.Enabled = false;
            this.ReviewImage.Location = new System.Drawing.Point(774, 253);
            this.ReviewImage.Name = "ReviewImage";
            this.ReviewImage.Size = new System.Drawing.Size(75, 23);
            this.ReviewImage.TabIndex = 16;
            this.ReviewImage.Text = "Обзор";
            this.ReviewImage.UseVisualStyleBackColor = true;
            this.ReviewImage.Click += new System.EventHandler(this.review_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(123, 288);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 23);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(511, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 212);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // l_Books
            // 
            this.l_Books.AutoSize = true;
            this.l_Books.Location = new System.Drawing.Point(572, 13);
            this.l_Books.Name = "l_Books";
            this.l_Books.Size = new System.Drawing.Size(37, 13);
            this.l_Books.TabIndex = 19;
            this.l_Books.Text = "Книги";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReviewBooks
            // 
            this.ReviewBooks.Location = new System.Drawing.Point(603, 253);
            this.ReviewBooks.Name = "ReviewBooks";
            this.ReviewBooks.Size = new System.Drawing.Size(75, 23);
            this.ReviewBooks.TabIndex = 20;
            this.ReviewBooks.Text = "Обзор";
            this.ReviewBooks.UseVisualStyleBackColor = true;
            this.ReviewBooks.Click += new System.EventHandler(this.ReviewBooks_Click);
            // 
            // СhangeButton
            // 
            this.СhangeButton.Location = new System.Drawing.Point(314, 241);
            this.СhangeButton.Name = "СhangeButton";
            this.СhangeButton.Size = new System.Drawing.Size(75, 23);
            this.СhangeButton.TabIndex = 21;
            this.СhangeButton.Text = "Изменить";
            this.СhangeButton.UseVisualStyleBackColor = true;
            this.СhangeButton.Click += new System.EventHandler(this.СhangeButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(314, 241);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 21;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 381);
            this.Controls.Add(this.ReviewBooks);
            this.Controls.Add(this.l_Books);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ReviewImage);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Block);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Block.ResumeLayout(false);
            this.Block.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Block;
        private System.Windows.Forms.TextBox t_Author;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_Year;
        private System.Windows.Forms.TextBox t_Publishing;
        private System.Windows.Forms.Label l_Author;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label l_Year;
        private System.Windows.Forms.Label l_Publishing;
        private System.Windows.Forms.Label l_Annotation;
        private System.Windows.Forms.RichTextBox t_Annotation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ReviewImage;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Label l_Subcategory;
        private System.Windows.Forms.Label l_Category;
        private System.Windows.Forms.TextBox t_Subcategory;
        private System.Windows.Forms.TextBox t_Category;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label l_Books;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ReviewBooks;
        private System.Windows.Forms.Button SearchButtun;
        private System.Windows.Forms.Button СhangeButton;
        private System.Windows.Forms.Button FindButton;
    }
}


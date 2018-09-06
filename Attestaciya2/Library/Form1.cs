using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Block.Text = "Добавить книгу";

            this.Block.Controls.Add(this.RecordButton);
            this.Block.Controls.Remove(this.СhangeButton);
            this.Block.Controls.Remove(this.FindButton);

            this.ReviewImage.Enabled = true;

            Reset();
            SetActive();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            ResetColor();
            Reset();
            this.Block.Text = "Поиск книги";

            this.Block.Controls.Add(this.FindButton);
            this.Block.Controls.Remove(this.RecordButton);
            this.Block.Controls.Remove(this.СhangeButton);

            #region visible
            SetActive();
            this.ReviewImage.Enabled = false;
            this.t_Subcategory.Enabled = false;
            this.t_Annotation.Enabled = false;
            #endregion
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            ResetColor();
            this.Block.Text = "Редактировать книгу";

            this.Block.Controls.Add(СhangeButton);
            this.Block.Controls.Remove(this.RecordButton);
            this.Block.Controls.Remove(this.FindButton);

            this.ReviewImage.Enabled = true;

            SetActive();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Reset();

            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                listBox1.Items.RemoveAt(index);
                Data.RemoveBook(index);
                Data.RecordToFile(Data.FileName);

                listBox1.Focus();
            }
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Book item = ReadForm();

            if (item != null)
            {
                if (!Data.ContainsBook(item))
                {
                    Data.AddBook(item);
                    listBox1.Items.Add(item.Name);
                    Data.RecordToFile(Data.FileName);
                }
            }
            Reset();
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            if (t_Author.Text == "" &&
                t_Name.Text == "" &&
                t_Year.Text == "" &&
                t_Publishing.Text == "" &&
                t_Category.Text == "")
            {
                Data.Search = false;
                foreach (Book item in Data.Lib)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
            else
            {
                Data.Search = true;
                Data.Reset();
                foreach (Book item in Data.Lib)
                {
                    bool Category = true;

                    if (t_Author.Text != "") if (item.Author != t_Author.Text) Category = false;
                    if (t_Name.Text != "") if (item.Name != t_Name.Text) Category = false;
                    if (t_Year.Text != "") if (item.Year != Convert.ToInt32(t_Year.Text)) Category = false;
                    if (t_Publishing.Text != "") if (item.Publishing != t_Publishing.Text) Category = false;
                    if (t_Category.Text != "") if (item.Category != t_Category.Text) Category = false;

                    if (Category && !Data.ContainsBook(item)) Data.AddBook(item);
                }

                foreach (Book item in Data.SearchLib)
                {
                    this.listBox1.Items.Add(item.Name);
                }
            }

        }
        private void СhangeButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                Book item = ReadForm();

                if(item != null)
                {
                    Data.RemoveBook(index);
                    Data.AddBook(item);
                    this.listBox1.Items.RemoveAt(index);
                    this.listBox1.Items.Add(item.Name);
                    Data.RecordToFile(Data.FileName);
                }
            }
            //Reset();
        }

        private void ResetColor()
        {
            t_Author.BackColor = Color.White;
            t_Name.BackColor = Color.White;
            t_Year.BackColor = Color.White;
            t_Publishing.BackColor = Color.White;
            t_Category.BackColor = Color.White;
            t_Subcategory.BackColor = Color.White;
            t_Annotation.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
        }
        private void Reset()
        {
            this.t_Author.Clear();
            this.t_Name.Clear();
            this.t_Year.Clear();
            this.t_Publishing.Clear();
            this.t_Category.Clear();
            this.t_Subcategory.Clear();
            this.t_Annotation.Clear();
            this.pictureBox1.Image = null;
        }
        private void SetActive()
        {
            this.t_Author.Enabled = true;
            this.t_Name.Enabled = true;
            this.t_Year.Enabled = true;
            this.t_Publishing.Enabled = true;
            this.t_Category.Enabled = true;
            this.t_Subcategory.Enabled = true;
            this.t_Annotation.Enabled = true;
        }
        private Book ReadForm()
        {
            Book item = new Book();
            Regex regex = new Regex("^[1-9][0-9][0-9][0-9]$");

            bool format = true;

            if (t_Author.Text == "") { t_Author.BackColor = Color.Red; format = false; }
            if (t_Name.Text == "") { t_Name.BackColor = Color.Red; format = false; }
            if (t_Year.Text == "" || !regex.IsMatch(t_Year.Text)) { t_Year.BackColor = Color.Red; format = false; }
            if (t_Publishing.Text == "") { t_Publishing.BackColor = Color.Red; format = false; }
            if (t_Category.Text == "") { t_Category.BackColor = Color.Red; format = false; }
            if (t_Subcategory.Text == "") { t_Subcategory.BackColor = Color.Red; format = false; }
            if (pictureBox1.Image == null) { pictureBox1.BackColor = Color.Red; format = false; }

            if (t_Author.Text.Contains(" ")) { t_Author.BackColor = Color.Red; format = false; };
            if (t_Name.Text.Contains(" ")) { t_Name.BackColor = Color.Red; format = false; }
            if (t_Publishing.Text.Contains(" ")) { t_Publishing.BackColor = Color.Red; format = false; }
            if (t_Category.Text.Contains(" ")) { t_Category.BackColor = Color.Red; format = false; }
            if (t_Subcategory.Text.Contains(" ")) { t_Subcategory.BackColor = Color.Red; format = false; }
            if (t_Annotation.Text.Contains(" ")) { t_Annotation.BackColor = Color.Red; format = false; }

            if (!format) return null;

            item.Author = t_Author.Text;
            item.Name = t_Name.Text;
            item.Year = Convert.ToInt32(t_Year.Text);
            item.Publishing = t_Publishing.Text;
            item.Category = t_Category.Text;
            item.Subcategory = t_Subcategory.Text;
            item.ImageName = pictureBox1.ImageLocation;
            item.Annotation = t_Annotation.Text;

            return item;
        }

        private void t_Author_MouseClick(object sender, MouseEventArgs e)
        {
            t_Author.BackColor = Color.White;
        }
        private void t_Name_MouseClick(object sender, MouseEventArgs e)
        {
            t_Name.BackColor = Color.White;
        }
        private void t_Year_MouseClick(object sender, MouseEventArgs e)
        {
            t_Year.BackColor = Color.White;
        }
        private void t_Publishing_MouseClick(object sender, MouseEventArgs e)
        {
            t_Publishing.BackColor = Color.White;
        }
        private void t_Category_MouseClick(object sender, MouseEventArgs e)
        {
            t_Category.BackColor = Color.White;
        }
        private void t_Subcategory_MouseClick(object sender, MouseEventArgs e)
        {
            t_Subcategory.BackColor = Color.White;
        }
        private void t_Annotation_MouseClick(object sender, MouseEventArgs e)
        {
            t_Annotation.BackColor = Color.White;
        }

        private void review_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        private void ReviewBooks_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.AddButton.Enabled = true;
                this.SearchButton.Enabled = true;
                this.DeleteButton.Enabled = true;

                Data.Reset();

                Data.LoadFromFile(openFileDialog1.FileName);
                listBox1.Items.Clear();

                foreach (Book item in Data.Lib)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ReviewImage.Enabled = false;
            this.Block.Controls.Remove(this.RecordButton);
            this.Block.Controls.Remove(this.FindButton);
            this.Block.Controls.Remove(this.СhangeButton);

            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                Block.Text = "Информация книги";

                this.EditButton.Enabled = true;

                ResetColor();
                SetActive();

                Book item = Data.Book(index);

                t_Author.Text = item.Author;
                t_Name.Text = item.Name;
                t_Year.Text = item.Year.ToString();
                t_Publishing.Text = item.Publishing;
                t_Category.Text = item.Category;
                t_Subcategory.Text = item.Subcategory;
                t_Annotation.Text = item.Annotation;
                pictureBox1.Load(item.ImageName);
            }
        }
    }
}

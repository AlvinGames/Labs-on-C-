using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void certificate_Click(object sender, EventArgs e)
        {
            if (certificate.Checked == true)
            {
                categoryA.Enabled = true;
                categoryB.Enabled = true;
                categoryC.Enabled = true;
                categoryD.Enabled = true;
            }
            else if (certificate.Checked == false)
            {
                categoryA.Enabled = false;
                categoryB.Enabled = false;
                categoryC.Enabled = false;
                categoryD.Enabled = false;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            surname.BackColor = Color.White;
            name.BackColor = Color.White;
            middleName.BackColor = Color.White;
            address.BackColor = Color.White;
            email.BackColor = Color.White;
            mobilePhone.BackColor = Color.White;

            surname.Text = "";
            name.Text = "";
            middleName.Text = "";

            man.Checked = true;

            day.Text = "1";
            month.Text = "Январь";
            year.Text = "2010";

            address.Text = "";
            email.Text = "";
            mobileOperator.Text = "MTS";
            mobilePhone.Text = "";

            st1.Checked = true;
            gr1.Checked = true;

            transport.Checked = false;
            certificate.Checked = false;

            categoryA.Checked = true;
            categoryB.Checked = false;
            categoryC.Checked = false;
            categoryD.Checked = false;

            categoryA.Enabled = false;
            categoryB.Enabled = false;
            categoryC.Enabled = false;
            categoryD.Enabled = false;

            minSalary.Value = 100;
            maxSalary.Value = 300;

            resume.Text = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            Data obj = ReadForm();

            if (obj != null)
            {
                obj.LoadToFile("data.txt");
            }
        }

        private Data ReadForm()
        {
            Data obj = new Data();

            bool isFormat = true;

            if (surname.Text == "" 
                || surname.Text.Contains('1')
                || surname.Text.Contains('2')
                || surname.Text.Contains('3')
                || surname.Text.Contains('4')
                || surname.Text.Contains('5')
                || surname.Text.Contains('6')
                || surname.Text.Contains('7')
                || surname.Text.Contains('8')
                || surname.Text.Contains('9')
                || surname.Text.Contains('0')
                )
            {
                surname.BackColor = Color.Red;
                isFormat = false;
            }
            obj.surname = surname.Text;

            if (name.Text == ""
                || surname.Text.Contains('1')
                || surname.Text.Contains('2')
                || surname.Text.Contains('3')
                || surname.Text.Contains('4')
                || surname.Text.Contains('5')
                || surname.Text.Contains('6')
                || surname.Text.Contains('7')
                || surname.Text.Contains('8')
                || surname.Text.Contains('9')
                || surname.Text.Contains('0'))
            {
                name.BackColor = Color.Red;
                isFormat = false;
            }
            obj.name = name.Text;

            if (middleName.Text == ""
                || surname.Text.Contains('1')
                || surname.Text.Contains('2')
                || surname.Text.Contains('3')
                || surname.Text.Contains('4')
                || surname.Text.Contains('5')
                || surname.Text.Contains('6')
                || surname.Text.Contains('7')
                || surname.Text.Contains('8')
                || surname.Text.Contains('9')
                || surname.Text.Contains('0')
                )
            {
                middleName.BackColor = Color.Red;
                isFormat = false;
            }
            obj.middleName = middleName.Text;

            if (man.Checked) obj.gender = 'М';
            else if (woman.Checked) obj.gender = 'Ж';

            obj.date.day = Convert.ToInt32(day.Text);
            obj.date.month = month.Text;
            obj.date.year = Convert.ToInt32(year.Text);

            if (address.Text == "")
            {
                address.BackColor = Color.Red;
                isFormat = false;
            }
            obj.address = address.Text;

            if (!email.Text.EndsWith("@mail.ru") && !email.Text.EndsWith("@gmail.com"))
            {
                email.BackColor = Color.Red;
                isFormat = false;
            }
            obj.email = email.Text;

            obj.mobileOperator = mobileOperator.Text;

            bool phone = false;
            if (mobilePhone.Text.StartsWith("+375"))
            {
                if (mobilePhone.Text.Length == 13) phone = true;
            }
            else if(mobilePhone.Text.StartsWith("375"))
            {
                if (mobilePhone.Text.Length == 12) phone = true;
            }
            else if(mobilePhone.Text.StartsWith("80"))
            {
                if (mobilePhone.Text.Length == 11) phone = true;
            }
            else
            {
                mobilePhone.BackColor = Color.Red;
                isFormat = false;
            }

            if (phone) obj.mobilePhone = mobilePhone.Text;

            if (st1.Checked) obj.experience = 1;
            else if (st2.Checked) obj.experience = 2;
            else if (st3.Checked) obj.experience = 3;
            else if (st4.Checked) obj.experience = 4;
            else if (st5.Checked) obj.experience = 5;

            if (gr1.Checked) obj.graphic = 1;
            else if (gr2.Checked) obj.graphic = 2;
            else if (gr3.Checked) obj.graphic = 3;
            else if (gr4.Checked) obj.graphic = 4;

            obj.transport = transport.Checked;
            obj.certificate = certificate.Checked;

            if (certificate.Checked)
            {
                if (categoryA.Checked) obj.category += " A";
                if (categoryB.Checked) obj.category += " B";
                if (categoryC.Checked) obj.category += " C";
                if (categoryD.Checked) obj.category += " D";
            }

            obj.minSalary = Convert.ToInt32(minSalary.Value);
            obj.maxSalary = Convert.ToInt32(maxSalary.Value);

            obj.resume = resume.Text;

            if (!isFormat) return null;

            return obj;
        }

        private void minSalary_Click(object sender, EventArgs e)
        {
            if (minSalary.Value >= maxSalary.Value)
                maxSalary.Value = minSalary.Value + 1;
        }

        private void maxSalary_Click(object sender, EventArgs e)
        {
            if (maxSalary.Value <= minSalary.Value)
                minSalary.Value = maxSalary.Value - 1;
        }

        private void categoryA_CheckedChanged(object sender, EventArgs e)
        {
            if (
                !(categoryA.Checked ||
                categoryB.Checked ||
                categoryC.Checked ||
                categoryD.Checked)
                )
                categoryA.Checked = true;
        }

        private void categoryB_CheckedChanged(object sender, EventArgs e)
        {
            if (
                !(categoryA.Checked ||
                categoryB.Checked ||
                categoryC.Checked ||
                categoryD.Checked)
                )
                categoryA.Checked = true;
        }

        private void categoryC_CheckedChanged(object sender, EventArgs e)
        {
            if (
                !(categoryA.Checked ||
                categoryB.Checked ||
                categoryC.Checked ||
                categoryD.Checked)
                )
                categoryA.Checked = true;
        }

        private void categoryD_CheckedChanged(object sender, EventArgs e)
        {
            if (
                !(categoryA.Checked ||
                categoryB.Checked ||
                categoryC.Checked ||
                categoryD.Checked)
                )
                categoryA.Checked = true;
        }

        private void surname_TextChanged(object sender, EventArgs e)
        {
            surname.BackColor = Color.White;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            name.BackColor = Color.White;
        }

        private void middleName_TextChanged(object sender, EventArgs e)
        {
            middleName.BackColor = Color.White;
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            address.BackColor = Color.White;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            email.BackColor = Color.White;
        }

        private void mobilePhone_TextChanged(object sender, EventArgs e)
        {
            mobilePhone.BackColor = Color.White;
        }
    }
}

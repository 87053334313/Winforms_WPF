using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClass;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string Author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Title
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page //Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year //Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public int InvNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
         public bool Existence
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public bool ReturnTime
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        List<Item> its = new List<Item>();
        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author,Title,PublishHouse,Page,Year,InvNumber,Existence);
            if (ReturnTime == true)
            {
                b.ReturnSrok();
            }
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber == true)
            {
                its.Sort();
            }
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n"+item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button_addStudent_Click(object sender, EventArgs e)
        {
            Label studLab = new Label();
            studLab.Location = new System.Drawing.Point(50, 20);
            studLab.Text = "Имя Фамилия Очество";
            studLab.Size = new Size(150, 50);
            groupBox_ST.Controls.Add(studLab);

            TextBox studtxt = new TextBox();
            studtxt.Text = "";
            studtxt.Location = new System.Drawing.Point(200, 20);
            groupBox_ST.Controls.Add(studtxt);
        }
        List<Jurnal> ListJur= new List<Jurnal>();
        private void button_AddJurn_Click(object sender, EventArgs e)
        {
            Jurnal jur = new Jurnal();
            jur.Author = textBox_author.Text;
            jur.Name = textBox_Name.Text;
            jur.Izd = textBox_PublishHouse.Text;
            jur.god = (int)numericUpDown_Year.Value;
            jur.srok = (int)numericUpDown_Srok.Value;
            jur.str = (int)numericUpDown_Str.Value;
            ListJur.Add(jur);
        }

        private void button_Look_Click(object sender, EventArgs e)
        {
            

             
            foreach (Jurnal j in ListJur)
            {
                richTextBox_ST.Text = richTextBox_ST.Text+ j.DateStr();
            }
             
        }
    }
}

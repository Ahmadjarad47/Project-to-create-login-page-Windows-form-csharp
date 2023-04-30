using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college
{
    public partial class Form1 : Form
    {
        const int MOS = 10;
        Student[] student1 = new Student[MOS];
        Student[] student2 = new Student[MOS];
        int NUMstudent1;
        int NUMstudent2;
        public Form1()
        {
            InitializeComponent();

        }
        string College = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Id = textBox2.Text;
            if (comboBox4.SelectedIndex == 1 && NUMstudent1 < MOS)
            {
                student1[NUMstudent1++] = new Student(Name, Id, College);
                MessageBox.Show("لقد قمت بتسجيل الدخول إلى الفئة الأولى");
                return;


            }
            else if (comboBox4.SelectedIndex == 2 && NUMstudent2 < MOS)
            {
                student2[NUMstudent2++] = new Student(Name, Id, College);
                MessageBox.Show("لقد قمت بتسجيل الدخول إلى الفئة الثانية");
                return;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" دير الزور");
            comboBox1.Items.Add(" حلب");
            comboBox1.Items.Add("الحسكة");
            comboBox1.Items.Add(" السويداء");
            comboBox1.Items.Add(" حمص");
            comboBox1.Items.Add("اللاذقية");
            comboBox1.Items.Add("دمشق");
            comboBox1.Items.Add("درعا");
            comboBox1.Items.Add("القنيطرة");
            comboBox1.Items.Add("طرطوس");
            comboBox1.Items.Add("حماه");
            comboBox1.Items.Add(" ريف دمشق ");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (radioButton1.Checked)
            {
                College = "IT";
                comboBox2.Items.Add("تحليل الأنظمة وتصميمها");
                comboBox2.Items.Add("التفاضل والتكامل");
                comboBox2.Items.Add("تراكيب البيانات");
                comboBox2.Items.Add("قواعد البيانات");
                comboBox2.Items.Add("تصميم وتحليل الخوارزميات");
                comboBox2.Items.Add("فحص البرمجيات");

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (radioButton2.Checked)
            {
                College = "Civil engineer";
                comboBox2.Items.Add("رياضيات هندسية");
                comboBox2.Items.Add("مختبر هندسة جيوتقنية");
                comboBox2.Items.Add("طرق عددية هندسية ");
                comboBox2.Items.Add("تفاضل وتكامل");
                comboBox2.Items.Add("كيمياء عامة");
                comboBox2.Items.Add("كيمياء عملية");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (radioButton3.Checked)
            {
                College = "Electron engineering";
                comboBox2.Items.Add("الاتصالات الرقمية");
                comboBox2.Items.Add("أساليب توليد الطاقة");
                comboBox2.Items.Add("الآلات الكهربائية");
                comboBox2.Items.Add("الإلكترونيات الرقمية");
                comboBox2.Items.Add("تصميم الآلات الكهربائية");
                comboBox2.Items.Add("برمجة الحاسبات");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();

        }
    }
}

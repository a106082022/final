using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // textBox1.Attributes.Add("onFocus", "this.value=''");
            float frg = 0, cp = 0, tv = 0, dyson = 0, warm = 0, cold = 0, travel = 0, eat = 0, eatdays = 0, wtotal, traveldays = 0, mtotal, mdays = 0, kw = 0;
            

            frg = float.Parse(textBox1.Text);//冰箱變數
            cp = float.Parse(textBox2.Text);//電腦變數
            tv = float.Parse(textBox3.Text);//電視變數
            dyson = float.Parse(textBox4.Text);//吹風機變數
            warm = float.Parse(textBox5.Text);//暖氣變數
            cold = float.Parse(textBox6.Text);//冷氣變數
            mdays = float.Parse(textBox7.Text);//每月幾天變數
            travel = float.Parse(textBox8.Text);//交通費變數
            eat = float.Parse(textBox9.Text);//餐費變數
            kw = float.Parse(textBox10.Text);//幾度電變數
            eatdays = float.Parse(textBox10.Text);//吃幾天變數
            traveldays = float.Parse(textBox11.Text);//通勤幾天變數

            wtotal = kw * ((130 * frg + 250 * cp + 100 * tv + 1600 * dyson + 1600 * warm + 1600 * cold) / 1000) + traveldays * travel + eatdays * eat;//計算過程
            mtotal = (wtotal / 7) * mdays;//先把每週除7變成每日，再乘以每月天數
            week.Text = wtotal.ToString();//輸出
            month.Text = mtotal.ToString();//輸出
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator__doAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float data1, data2;
        string pheptinh;

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(hienThi1.Text);
            hienThi1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + ".";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "0";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "1";

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "2";

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "3";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "4";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "5";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "6";

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "7";

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "8";

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            hienThi1.Text = hienThi1.Text + "9";

        }

        private void hienThi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(hienThi1.Text);
            hienThi1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(pheptinh == "cong")
            {
                hienThi2.Text = data1.ToString() + " + " + float.Parse(hienThi1.Text) + " = ";
                data2 = data1 + float.Parse(hienThi1.Text);
                hienThi1.Text = data2.ToString();
            }

            if (pheptinh == "tru")
            {
                hienThi2.Text = data1.ToString() + " - " + float.Parse(hienThi1.Text) + " = ";
                data2 = data1 - float.Parse(hienThi1.Text);
                hienThi1.Text = data2.ToString();
            }

            if (pheptinh == "nhan")
            {
                hienThi2.Text = data1.ToString() + " x " + float.Parse(hienThi1.Text) + " = ";
                data2 = data1 * float.Parse(hienThi1.Text);
                hienThi1.Text = data2.ToString();
            }

            if (pheptinh == "chia")
            {

                    if (float.Parse(hienThi1.Text) == 0)
                    {
                        hienThi1.Text = "Khong chia duoc";
                    }
                else
                {
                    hienThi2.Text = data1.ToString() + " / " + float.Parse(hienThi1.Text) + " = ";
                    data2 = data1 / float.Parse(hienThi1.Text);
                    hienThi1.Text = data2.ToString();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(hienThi1.Text);
            hienThi1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(hienThi1.Text);
            hienThi1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienThi1.Clear();
            hienThi2.Clear();
        }
    }
}

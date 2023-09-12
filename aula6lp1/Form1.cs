using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6lp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < 11; i++)
                {
                    int tabu;
                    tabu = 2 * i;
                    listBox1.Items.Add(tabu);
                }

                for (int i = 1; i < 11; i++)
                {
                    int tabu;
                    tabu = 5 * i;
                    listBox2.Items.Add(tabu);
                }   
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                for (int i = 1; i < 13; i++)
                {
                    int tabu;

                    if (i % 3 == 0)
                    {
                        listBox3.Items.Add("Tabuada do " + i);

                        for (int j = 1; j < 11; j++)
                        {
                            tabu = i * j;
                            listBox3.Items.Add(tabu);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int [] numb = new int[8];
            int [] par = new int[8];
            int [] impar = new int[8];
            try
            {
                int temp;
                for (int i = 0; i < 8; i++)
                {
                    numb[i] = randNum.Next(-20, 20);
                    listBox6.Items.Add(numb[i]);    
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (numb[i] > numb[j])
                        {
                            temp = numb[i];
                            numb[i] = numb[j];
                            numb[j] = temp;
                        }
                    }
                }
                for (int i = 0;i < 8; i++)
                {
                    if (numb[i] % 2 == 0)
                    {
                        listBox4.Items.Add(numb[i]);
                    }
                    if (numb[i] % 5 == 0)
                    {
                        listBox5.Items.Add(numb[i]);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
        }
    }
}

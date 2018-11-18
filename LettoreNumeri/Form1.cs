using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreNumeri
{
    public partial class Form1 : Form
    {
        int[] vettore = new int[10];
        int ll = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Ordina_vettore (int [] vettore)
        {
            for (int i = 0; i < vettore.Length; ++i)
            {
                for (int j = i + 1; j  < vettore.Length; ++j)
                {
                    if (vettore[j] < vettore[i])
                    {
                        int temp = vettore[j];
                        vettore[j] = vettore[i];
                        vettore[i] = temp;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vettore[ll++] = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato non corretto");
            }      
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vettore.Length; ++i)
            {
                for (int j = i + 1; j < vettore.Length; ++j)
                {
                    if (vettore[j] < vettore[i])
                    {
                        int temp = vettore[j];
                        vettore[j] = vettore[i];
                        vettore[i] = temp;
                    }
                }
            }
            listBox1.Items.Clear();

            for (int i = (vettore.Length - ll); i < vettore.Length; i++)
            {
                listBox1.Items.Add(vettore[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (var item in listBox1.Items)
            {
                text += item.ToString() + ",";
            }
           
            FileSystem.write("provalist2.txt", text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string lines = FileSystem.readFile("provalist2.txt");
            string[] numeri = lines.Split(',');
            for (int i = 0; i < numeri.Length; i++)
            {
                listBox1.Items.Add(numeri[i]);
            }
        }
    }
}

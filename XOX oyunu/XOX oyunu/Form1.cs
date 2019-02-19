using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
       
            
            InitializeComponent();          
        }
        int ceza = 0, sayi = 0,toplam1,toplam2; 
        string a = "", b,c,d,e,f,g,h,j,k,l;
        void fnk2()
        {  
            b = (button1.Text + button2.Text + button3.Text);
            c = (button7.Text + button5.Text + button3.Text);
            d = (button1.Text + button5.Text + button9.Text);
            e = (button1.Text + button4.Text + button7.Text);
            f = (button2.Text + button5.Text + button8.Text);
            g = (button3.Text + button6.Text + button9.Text);
            h = (button4.Text + button5.Text + button6.Text);
            j = (button7.Text + button8.Text + button9.Text);          
        }
        void cez()
        {
            if (ceza>=5 && a=="X")
            {
                MessageBox.Show("O oyuncusu 5 puan ceza yedi");
                toplam2 -= 5;
                textBox2.Text = Convert.ToString(toplam2);
                ceza = 0;    
            }
            else if(ceza>=5 && a == "O")
            {
                MessageBox.Show("X oyuncusu 5 puan ceza yedi");
                toplam1 -= 5;
                textBox1.Text = Convert.ToString(toplam1);
                ceza = 0;
            }
            else
            {
                ceza = 0;
            }
        }
        void fnk4()
        {
            button1.BackgroundImage = Image.FromFile("X (1).jpg");
            button4.BackgroundImage = Image.FromFile("X (1).jpg");
            button7.BackgroundImage = Image.FromFile("X (1).jpg");
            button3.BackgroundImage = Image.FromFile("X (1).jpg");
            button6.BackgroundImage = Image.FromFile("X (1).jpg");
            button9.BackgroundImage = Image.FromFile("X (1).jpg");
            button2.BackgroundImage = Image.FromFile("indir.jpg");
            button5.BackgroundImage = Image.FromFile("indir.jpg");
            button8.BackgroundImage = Image.FromFile("indir.jpg"); 
        }
        void fnk3()
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            a = "";
        }
        void fnk()
        {
            if ((b=="XXX") || (c=="XXX") || (d=="XXX") || (e=="XXX") || (f=="XXX") || (g=="XXX") || (h=="XXX") || (j=="XXX"))
            {
                label1.Text = "X'ler kazandı..";
                label1.BackColor = Color.Yellow;
                toplam1 +=10;
                textBox1.Text = Convert.ToString(toplam1);
                fnk3();
                fnk4();
            }
            else if((b == "OOO") || (c == "OOO") || (d == "OOO") || (e == "OOO") || (f == "OOO") || (g == "OOO") || (h == "OOO") || (j == "OOO"))
            {
                label1.Text = "O'lar kazandı..";
                label1.BackColor = Color.Blue;
                toplam2 += 10;
                textBox2.Text = Convert.ToString(toplam2);
                fnk3();
                fnk4();
            }
            else if (b != "OOO" && b != "XXX" && c != "OOO" && c != "XXX" && d != "OOO" && d != "XXX" && e != "OOO" && e != "XXX" && f != "OOO" && f != "XXX" && g != "OOO" && g != "XXX" && h != "OOO" && h != "XXX" && j != "OOO" && j != "XXX")
            {
                if (button1.Text !=" " && button2.Text !=" " && button3.Text != " " && button4.Text != " " && button5.Text != " " && button6.Text != " " && button7.Text != " " && button8.Text != " " && button9.Text != " ")
                { 
                   label1.Text = "OYUN BERABERE SONUÇLANDI..";
                   label1.BackColor = Color.Red;
                   fnk3();
                   fnk4();
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            fnk4();
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            textBox1.Text = "0";
            textBox2.Text = "0";
            label1.Text = "";
            sayi = 0;
            ceza = 0;
            a = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                       
            label4.Text = Convert.ToString(sayi++);
            timer1.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            ceza++;
            timer2.Interval = 1000;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            info inf = new info();
            inf.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a == "" || a == "O")
            {
                button8.BackgroundImage = null;
                button8.Text = "X";
                button8.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();                
            }
            else if (a == "X")
            {
                button8.BackgroundImage = null;
                button8.Text = "O";
                button8.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();              
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (a == "" || a == "O")
            {
                button9.BackgroundImage = null;
                button9.Text = "X";
                button9.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();                
            }
            else if (a == "X")
            {
                button9.BackgroundImage = null;
                button9.Text = "O";
                button9.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();               
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {           
            if (a == "" || a == "O")
            {
                button7.BackgroundImage = null;
                button7.Text = "X";
                button7.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();               
            }
            else if (a == "X")
            {
                button7.BackgroundImage = null;
                button7.Text = "O";
                button7.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();                
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {           
            if (a == "" || a == "O")
            {
                button6.BackgroundImage = null;
                button6.Text = "X";
                button6.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();               
            }
            else if (a == "X")
            {
                button6.BackgroundImage = null;
                button6.Text = "O";
                button6.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();             
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {           
            if (a == "" || a == "O")
            {
                button5.BackgroundImage = null;
                button5.Text = "X";
                button5.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();               
            }
            else if (a == "X")
            {
                button5.BackgroundImage = null;
                button5.Text = "O";
                button5.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();               
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {           
            if (a == "" || a == "O")
            {
                button4.BackgroundImage = null;
                button4.Text = "X";
                button4.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();                
            }
            else if (a == "X")
            {
                button4.BackgroundImage = null;
                button4.Text = "O";
                button4.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();                
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (a == "" || a == "O")
            {
                button3.BackgroundImage = null;
                button3.Text = "X";
                button3.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();               
            }
            else if (a == "X")
            {
                button3.BackgroundImage = null;
                button3.Text = "O";
                button3.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {           
            if (a == "" || a == "O")
            {
                button2.BackgroundImage = null;
                button2.Text = "X";
                button2.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();
            }
            else if (a == "X")
            {
                button2.BackgroundImage = null;
                button2.Text = "O";
                button2.Enabled = false;
                cez();
                a = "O";
                fnk2();
                fnk();                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            if (a == "" || a == "O")
            {
                button1.BackgroundImage = null;
                button1.Text = "X";
                button1.Enabled = false;
                cez();
                a = "X";
                fnk2();
                fnk();                
            }
            else if (a == "X") 
            {
                button1.BackgroundImage = null;
                button1.Text = "O";
                button1.Enabled = false;
                cez();
                a = "O"; 
                fnk2();
                fnk();                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace milion
{
    public partial class Form1 : Form
    {
        string p;   //Pytanie
        
        int licznik = 0;   //licznki pyt
        int good = 0;     //licznik dobrych
        string a;
        string b;
        string c;
        string d;
        string o;   //odpowiedź poprawna
        string wybrane;     //wybrana odpowiedź
        public Form1()
        {
            Wczytaj();
            
            InitializeComponent();
            Ustaw();
        }

        //private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void A_btt_CheckedChanged(object sender, EventArgs e)
        {
            if (A_btt.Checked == true)
            {
                wybrane = "A";
                //MessageBox.Show("Napewno A?");
            }
            else wybrane = "0";


        }

        private void B_btt_CheckedChanged(object sender, EventArgs e)
        {
            if (B_btt.Checked == true)
            {
                wybrane = "B";
            }
            else wybrane = "0";
        }

        private void C_btt_CheckedChanged(object sender, EventArgs e)
        {
            if (C_btt.Checked == true)
            {
                wybrane = "C";
            }
            else wybrane = "0";
        }

        private void D_btt_CheckedChanged(object sender, EventArgs e)
        {
            if (D_btt.Checked == true)
            {
                wybrane = "D";
            }
            else wybrane = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spr();         //sprawdza czy odpowiedź udzielona jest dobra
            
            licznik++;

            BttRes();   //uncheck

            Wczytaj();      //wczytuje z pliku do zmiennych

            if (a != null)
            {
                Ustaw();    //wstawia zmienne do kontrolek
            }
            else
            {
               // Form2 frm = new Form2();
                button1.Text = "Koniec";
                MessageBox.Show("Koniec! Zdobyłeś " + good.ToString() + "pkt na " + licznik.ToString() + " możliwych!");
                
            }

            if (button1.Text == "Koniec") this.Close();
                
            
        }
        
        private /*async*/ void Wczytaj() //synchronicznie czy nie???
        {                       
            string plk = @"test.txt";
            StreamReader sr = new StreamReader(plk);
            for(int i=0; i <= licznik ; i++)
            { 
                p = sr.ReadLine();
                a = sr.ReadLine();
                b = sr.ReadLine();
                c = sr.ReadLine();
                d = sr.ReadLine();
                o = sr.ReadLine();
            }
            sr.Close();
            
        }

        void Ustaw()
        {
            textBox1.Text = p;
            A_btt.Text = a;
            B_btt.Text = b;
            C_btt.Text = c;
            D_btt.Text = d;
        }

        void Spr()
        {
            switch (wybrane)
            {
                case "A":
                    if (o == "A") good++;
                    break;

                case "B":
                    if (o == "B") good++;
                    break;

                case "C":
                    if (o == "C") good++;
                    break;

                case "D":
                    if (o == "D") good++;
                    break;
            }
        }

        void BttRes()
        {
            A_btt.Checked = false;
            B_btt.Checked = false;
            C_btt.Checked = false;
            D_btt.Checked = false;
        }

        
    }
}

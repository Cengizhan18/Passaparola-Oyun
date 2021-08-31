using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_oyunu_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "aksaray")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 2:
                        if (textBox1.Text == "balıkçılık")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 4:
                        if (textBox1.Text == "deniz")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 8:
                        if (textBox1.Text == "hatay")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 10:
                        if (textBox1.Text == "jandarma")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 11:
                        if (textBox1.Text == "kitap")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 12:
                        if (textBox1.Text == "limon")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 13:
                        if (textBox1.Text == "martı")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 14:
                        if (textBox1.Text == "nar")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 15:
                        if (textBox1.Text == "pasta")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 16:
                        if (textBox1.Text == "rize")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 17:
                        if (textBox1.Text == "sufle")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 18:
                        if (textBox1.Text == "tuğla")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         case 19:
                        if (textBox1.Text == "uyuşturucu")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                        
                         case 20:
                        if (textBox1.Text == "vaşak")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         
                         case 21:
                        if (textBox1.Text == "yalova")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }
                      break;
                         
                         case 22:
                        if (textBox1.Text == "zurna")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();

                        }


                      break;
                       
                        
                        


                     

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Plaka Numarası 68 Olan İlimiz Neresidir?";
                button1.BackColor = Color.Yellow;
                button23.Text = "A";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Deniz Kasabalarının En Önemli Geçim Kaynaklarından Biri?";
                button2.BackColor = Color.Yellow;
                button23.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların Kutsal Günü? ";
                button3.BackColor = Color.Yellow;
                button23.Text = "C";
            } 
            if (soruno == 4)
            {
                richTextBox1.Text = "Gölden Büyük Okyanustan Küçük?";
                button4.BackColor = Color.Yellow;
                button23.Text = "D";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni Kelimesinin Zıt Anlamlısı?";
                button5.BackColor = Color.Yellow;
                button23.Text = "E";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın Emirlerlinin Yazılı Hali? ";
                button6.BackColor = Color.Yellow;
                button23.Text = "F";
            } 
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın Isı Kaynağı?";
                button7.BackColor = Color.Yellow;
                button23.Text = "G";
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "......  Usulü Dürüm?";
                button8.BackColor = Color.Yellow;
                button23.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle Ünlü İlimiz? ";
                button9.BackColor = Color.Yellow;
                button23.Text = "I";
            } 
            if (soruno == 10)
            {
                richTextBox1.Text = "...... Bir Kanun Ordusudur?";
                button10.BackColor = Color.Yellow;
                button23.Text = "J";
            }

            if (soruno == 11)
            {
                richTextBox1.Text = "Bilgi Kaynaklarından Bir Tanesi?";
                button11.BackColor = Color.Yellow;
                button23.Text = "K";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Sarı Bir Meyve? ";
                button12.BackColor = Color.Yellow;
                button23.Text = "L";
            }

            if (soruno == 13)
            {
                richTextBox1.Text = "Hangi Hayvana Vapurdan Simit Atılır?";
                button13.BackColor = Color.Yellow;
                button23.Text = "M";
            }

            if (soruno == 14)
            {
                richTextBox1.Text = "Pazardan Aldım Bir Tane Eve Geldim Bin Tane?";
                button14.BackColor = Color.Yellow;
                button23.Text = "N";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Ekmek Yoksa .... Yiyin? ";
                button15.BackColor = Color.Yellow;
                button23.Text = "P";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Çayıyla Ünlü İlimiz?";
                button16.BackColor = Color.Yellow;
                button23.Text = "R";
            }

            if (soruno == 17)
            {
                richTextBox1.Text = "Hem Tatlı İsmi Hem Sinema Terimi Olan Kelime?";
                button17.BackColor = Color.Yellow;
                button23.Text = "S";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Bina Yapımında Kullanılan Kırmızı İnşaat Malzemesi? ";
                button18.BackColor = Color.Yellow;
                button23.Text = "T";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Zaralı Bir Madde?";
                button19.BackColor = Color.Yellow;
                button23.Text = "U";
            }

            if (soruno == 20)
            {
                richTextBox1.Text = "Yırtıcı Bir Kedi Türü?";
                button20.BackColor = Color.Yellow;
                button23.Text = "V";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "77 Plaka Numarası Hangi İlimize Aittir? ";
                button21.BackColor = Color.Yellow;
                button23.Text = "Y";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Davul İle Çalınan Çalgı Aleti?";
                button22.BackColor = Color.Yellow;
                button23.Text = "Z";
            }

            if (soruno == 23)
            {
                MessageBox.Show("Yarışma Bitti" + "\n" + "Skor: " + dogru + "\n" + yanlis);

            }
        }
    }
}

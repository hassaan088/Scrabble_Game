using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using Microsoft.Xna.Framework;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<string> str = new List<string>();
        string[] abc= new string[26];
        string mesg1 = "words.txt";
        List<int> sum = new List<int>();
        List<int> finalscore = new List<int>();
        Random r = new Random();
        string[] arr = new string[6];
        int[] score = new int[6];
        
        StreamReader reader ;//= new StreamReader(TitleContainer.OpenStream(mesg1));

        // Constructor
        public MainPage()
        {
            InitializeComponent();

          
            abcd();
            reader= new StreamReader(TitleContainer.OpenStream(mesg1));
            String word = reader.ReadLine();
            while (word != null)
            {
                str.Add(word.ToLower());
                word = reader.ReadLine();
            }
           
            //lb.ItemsSource = str;
            refresh();
                        
        }
        public void refresh()
    {
            for (var x = 0; x < 6; ++x)
            {
                int a = r.Next(0,25);
                arr[x] = abc[a];
            }
            for (var x = 0; x < 6; ++x)
            {
                int a = r.Next(1, 9);
                score[x] = a;
            }
            tblock1.Text = score[0].ToString();
            tblock2.Text = score[1].ToString();
            tblock3.Text = score[2].ToString();
            tblock4.Text = score[3].ToString();
            tblock5.Text = score[4].ToString();
            tblock6.Text = score[5].ToString();
            
            bt4.Content = arr[0];
            bt5.Content = arr[1];
            bt6.Content = arr[2];
            bt10.Content = arr[3];
            bt11.Content = arr[4];
            bt12.Content = arr[5];
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            String st = tb1.Text;
            if (str.Contains(st.ToLower()))
            {
                MessageBox.Show("found"+sum.Sum());
               // finalscore.Add(Convert.ToInt32(sum));
                sum.Clear();
            }
            else
            {
                MessageBox.Show(" not found");
                sum.Clear();
            }
            bt1.Content = "";
            bt2.Content = "";
            bt3.Content = "";
            bt7.Content = "";
            bt8.Content = "";
            bt9.Content = "";
            tb1.Text = "";
            fillMissingAlpha();
            //socre.Text = finalscore.Sum().ToString();

        }

        public void fillMissingAlpha()
        {
            if (bt4.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt4.Content= abc[a];
                }
            }
            if (bt5.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt5.Content = abc[a];
                }
            }
            if (bt6.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt6.Content = abc[a];
                }
            }
            if (bt10.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt10.Content = abc[a];
                }
            }
            if (bt11.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt11.Content = abc[a];
                }
            }
            if (bt12.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt12.Content = abc[a];
                }
            }
        }
        public void abcd()
        {
            abc[0] = "A";
            abc[1] = "B";
            abc[2] = "C";
            abc[3] = "D";
            abc[4] = "E";
            abc[5] = "F";
            abc[6] = "G";
            abc[7] = "H";
            abc[8] = "I";
            abc[9] = "J";
            abc[10] = "K";
            abc[11] = "L";
            abc[12] = "M";
            abc[13] = "N";
            abc[14] = "O";
            abc[15] = "P";
            abc[16] = "Q";
            abc[17] = "R";
            abc[18] = "S";
            abc[19] = "T";
            abc[20] = "U";
            abc[21] = "V";
            abc[22] = "W";
            abc[23] = "X";
            abc[24] = "Y";
            abc[25] = "Z";
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt1.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock1.Text;
                bt4.Content = "";
            }
           else if (bt2.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt2.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock1.Text;
                bt4.Content = "";
            }
            else if (bt3.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt3.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt4.Content += "  ";
                bt3.Content += tblock1.Text;
                bt4.Content = "";
            }
            else if (bt7.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt7.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock1.Text;
                bt4.Content = "";
            }
            else if (bt8.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt9.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock1.Text;
                bt4.Content = "";
            }
            else if (bt9.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt9.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock1.Text;
                bt4.Content = "";
            }
            sum.Add(Convert.ToInt32(tblock1.Text));
            
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt1.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock2.Text;
                bt5.Content = "";
            }
            else if (bt2.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt2.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock2.Text;
                bt5.Content = "";
            }
            else if (bt3.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt3.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock2.Text;
                
                bt5.Content = "";
            }
            else if (bt7.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt7.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock2.Text;
                
                bt5.Content = "";
            }
            else if (bt8.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt8.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock2.Text;
                
                bt5.Content = "";
            }
            else if (bt9.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt9.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock2.Text;
                
                bt5.Content = "";
            }
            sum.Add(Convert.ToInt32(tblock2.Text));
            
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt1.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock3.Text;
                
                bt6.Content = "";
            }
            else if (bt2.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt2.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock3.Text;
                bt6.Content = "";
            }
            else if (bt3.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt3.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock3.Text;
                bt6.Content = "";
            }
            else if (bt7.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt7.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock3.Text;
                bt6.Content = "";
            }
            else if (bt8.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt8.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock3.Text;
                bt6.Content = "";
            }
            else if (bt9.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt9.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock3.Text;
                bt6.Content = "";
            }
            sum.Add(Convert.ToInt32(tblock3.Text));
            
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt1.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock4.Text;
                bt10.Content = "";
            }
            else if (bt2.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt2.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock4.Text;
                bt10.Content = "";
            }
            else if (bt3.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt3.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock4.Text;
                bt10.Content = "";
            }
            else if (bt7.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt7.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock4.Text;
                bt10.Content = "";
            }
            else if (bt8.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt8.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock4.Text;
                bt10.Content = "";
            }
            else if (bt9.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt9.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock4.Text;
                bt10.Content = "";
            }
            sum.Add(Convert.ToInt32(tblock4.Text));
            
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content.Equals("") && !bt11.Content.Equals(""))
            {
                bt1.Content = bt11.Content;
                tb1.Text += bt11.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock5.Text;
                bt11.Content = "";
            }
            else if (bt2.Content.Equals("") && !bt11.Content.Equals(""))
            {
                bt2.Content = bt11.Content;
                tb1.Text += bt11.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock5.Text;
                bt11.Content = "";
            }
            else if (bt3.Content.Equals("") && !bt11.Content.Equals(""))
            {
                bt3.Content = bt11.Content;
                tb1.Text += bt11.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock5.Text;
                bt11.Content = "";
            }
            else if (bt7.Content.Equals("") && !bt11.Content.Equals(""))
            {
                bt7.Content = bt11.Content;
                tb1.Text += bt11.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock5.Text;
                bt11.Content = "";
            }
            else if (bt8.Content.Equals("") && !bt11.Content.Equals(""))
            {
                bt9.Content = bt11.Content;
                tb1.Text += bt11.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock5.Text;
                bt11.Content = "";
            }
            else if (bt9.Content.Equals("") && !bt11.Content.Equals(""))
            {
                bt9.Content = bt11.Content;
                tb1.Text += bt11.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock5.Text;
                bt11.Content = "";
            }
            sum.Add(Convert.ToInt32(tblock5.Text));
           
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            if (bt1.Content.Equals("") && !bt12.Content.Equals(""))
            {
                bt1.Content = bt12.Content;
                tb1.Text += bt12.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock6.Text;
                bt12.Content = "";
            }
            else if (bt2.Content.Equals("") && !bt12.Content.Equals(""))
            {
                bt2.Content = bt12.Content;
                tb1.Text += bt12.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock6.Text;
                bt12.Content = "";
            }
            else if (bt3.Content.Equals("") && !bt12.Content.Equals(""))
            {
                bt3.Content = bt12.Content;
                tb1.Text += bt12.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock6.Text;
                bt12.Content = "";
            }
            else if (bt7.Content.Equals("") && !bt12.Content.Equals(""))
            {
                bt7.Content = bt12.Content;
                tb1.Text += bt12.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock6.Text;
                bt12.Content = "";
            }
            else if (bt8.Content.Equals("") && !bt12.Content.Equals(""))
            {
                bt9.Content = bt12.Content;
                tb1.Text += bt12.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock6.Text;
                bt12.Content = "";
            }
            else if (bt9.Content.Equals("") && !bt12.Content.Equals(""))
            {
                bt9.Content = bt12.Content;
                tb1.Text += bt12.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock6.Text;
                bt12.Content = "";
            }
            sum.Add(Convert.ToInt32(tblock6.Text));
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            refresh();
        }
    }
}
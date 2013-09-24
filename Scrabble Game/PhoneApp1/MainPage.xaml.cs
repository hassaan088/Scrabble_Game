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
using System.Windows.Threading;
using System.Diagnostics;
using System.Threading;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<string> str = new List<string>();
        string[] abc= new string[26];
        string mesg1 = "words.txt";
        List<int> eachTurnScore = new List<int>();
        List<int> finalScore = new List<int>();
        Random r = new Random();
        string[] arr = new string[6];
      //  int[] score = new int[6];
        List<string> t_alpha = new List<string>();
        bool bt4C = false;
        string bt4value = "";
        string bt4score = "";
        bool bt5C = false;
        string bt5value = "";
        string bt5score = "";
        bool bt6C = false;
        string bt6value = "";
        string bt6score = "";
        bool bt10C = false;
        string bt10value = "";
        string bt10score = "";
        bool bt11C = false;
        string bt11value = "";
        string bt11score = "";
        bool bt12C = false;
        string bt12value = "";
        string bt12score = "";
        string bt4backword = "";
        string bt5backword = "";
        string bt6backword = "";
        string bt10backword = "";
        string bt11backword = "";
        string bt12backword = "";
        int timerDuration = 30;
        DispatcherTimer timer;    
        bool chacha = false;
        StreamReader reader ;

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
           
            newGame();
          
                        
        }
        public void newGame()
        {
           timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) =>
            {
                timeCount.Text = "" + timerDuration;
                if (timerDuration > 0)
                {
                    timerDuration--;
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("Times Up");
                    MessageBoxResult res = MessageBox.Show("Game Time Over : Are you want to play a new Game", "Game?", MessageBoxButton.OKCancel);
                    if (res == MessageBoxResult.OK)
                    {
                        newGame();
                        timerDuration = 30;
                    }
                    else
                    {
                        NavigationService.GoBack();
                    }

                }

            };


            //            1 Point - A, E, I, L, N, O, R, S, T and U.
            //2 Points - D and G.
            //3 Points - B, C, M and P.
            //4 Points - F, H, V, W and Y.
            //5 Points - K.
            //8 Points - J and X.
            //10 Points - Q and Z


            for (var x = 0; x < 6; ++x)
            {
                int a = r.Next(0, 25);
                arr[x] = abc[a];
            }

            bt4.Content = arr[0];
            bt5.Content = arr[1];
            bt6.Content = arr[2];
            bt10.Content = arr[3];
            bt11.Content = arr[4];
            bt12.Content = arr[5];
            score();
            timer.Start();
        }
        
        public void score()
        {
            List<string> point1 = new List<string>();
            point1.Add("A");
            point1.Add("E");
            point1.Add("I");
            point1.Add("L");
            point1.Add("N");
            point1.Add("O");
            point1.Add("R");
            point1.Add("S");
            point1.Add("T");
            point1.Add("U");

            List<string> point2 = new List<string>();
            point2.Add("D");
            point2.Add("G");

            List<string> point3 = new List<string>();
            point3.Add("B");
            point3.Add("C");
            point3.Add("M");
            point3.Add("P");

            List<string> point4 = new List<string>();
            point4.Add("F");
            point4.Add("H");
            point4.Add("V");
            point4.Add("W");
            point4.Add("Y");

            List<string> point5 = new List<string>();
            point5.Add("K");

            List<string> point8 = new List<string>();
            point8.Add("J");
            point8.Add("X");

            List<string> point10 = new List<string>();
            point10.Add("Q");
            point10.Add("Z");

            //point 1
            if (point1.Contains(bt4.Content.ToString()))
            {
                tblock1.Text = "1";
            }
            if (point1.Contains(bt5.Content.ToString()))
            {
                tblock2.Text = "1";
            }
            if (point1.Contains(bt6.Content.ToString()))
            {
                tblock3.Text = "1";
            }
            if (point1.Contains(bt10.Content.ToString()))
            {
                tblock4.Text = "1";
            }
            if (point1.Contains(bt11.Content.ToString()))
            {
                tblock5.Text = "1";
            }
            if (point1.Contains(bt12.Content.ToString()))
            {
                tblock6.Text = "1";
            }
            //point 2
            if (point2.Contains(bt4.Content.ToString()))
            {
                tblock1.Text = "2";
            }
            if (point2.Contains(bt5.Content.ToString()))
            {
                tblock2.Text = "2";
            }
            if (point2.Contains(bt6.Content.ToString()))
            {
                tblock3.Text = "2";
            }
            if (point2.Contains(bt10.Content.ToString()))
            {
                tblock4.Text = "2";
            }
            if (point2.Contains(bt11.Content.ToString()))
            {
                tblock5.Text = "2";
            }
            if (point2.Contains(bt12.Content.ToString()))
            {
                tblock6.Text = "2";
            }
            //point 3
            if (point3.Contains(bt4.Content.ToString()))
            {
                tblock1.Text = "3";
            }
            if (point3.Contains(bt5.Content.ToString()))
            {
                tblock2.Text = "3";
            }
            if (point3.Contains(bt6.Content.ToString()))
            {
                tblock3.Text = "3";
            }
            if (point3.Contains(bt10.Content.ToString()))
            {
                tblock4.Text = "3";
            }
            if (point3.Contains(bt11.Content.ToString()))
            {
                tblock5.Text = "3";
            }
            if (point3.Contains(bt12.Content.ToString()))
            {
                tblock6.Text = "3";
            }
            //point 4
            if (point4.Contains(bt4.Content.ToString()))
            {
                tblock1.Text = "4";
            }
            if (point4.Contains(bt5.Content.ToString()))
            {
                tblock2.Text = "4";
            }
            if (point4.Contains(bt6.Content.ToString()))
            {
                tblock3.Text = "4";
            }
            if (point4.Contains(bt10.Content.ToString()))
            {
                tblock4.Text = "4";
            }
            if (point4.Contains(bt11.Content.ToString()))
            {
                tblock5.Text = "4";
            }
            if (point4.Contains(bt12.Content.ToString()))
            {
                tblock6.Text = "4";
            }
            //point5
            if (point5.Contains(bt4.Content.ToString()))
            {
                tblock1.Text = "5";
            }
            if (point5.Contains(bt5.Content.ToString()))
            {
                tblock2.Text = "5";
            }
            if (point5.Contains(bt6.Content.ToString()))
            {
                tblock3.Text = "5";
            }
            if (point5.Contains(bt10.Content.ToString()))
            {
                tblock4.Text = "5";
            }
            if (point5.Contains(bt11.Content.ToString()))
            {
                tblock5.Text = "5";
            }
            if (point5.Contains(bt12.Content.ToString()))
            {
                tblock6.Text = "5";
            }
            //point 8
            if (point8.Contains(bt4.Content.ToString()))
            {
                tblock1.Text = "8";
            }
            if (point8.Contains(bt5.Content.ToString()))
            {
                tblock2.Text = "8";
            }
            if (point8.Contains(bt6.Content.ToString()))
            {
                tblock3.Text = "8";
            }
            if (point8.Contains(bt10.Content.ToString()))
            {
                tblock4.Text = "8";
            }
            if (point8.Contains(bt11.Content.ToString()))
            {
                tblock5.Text = "8";
            }
            if (point8.Contains(bt12.Content.ToString()))
            {
                tblock6.Text = "8";
            }
            //point 10
            if (point10.Contains(bt4.Content.ToString()))
            {
                tblock1.Text = "10";
            }
            if (point10.Contains(bt5.Content.ToString()))
            {
                tblock2.Text = "10";
            }
            if (point10.Contains(bt6.Content.ToString()))
            {
                tblock3.Text = "10";
            }
            if (point10.Contains(bt10.Content.ToString()))
            {
                tblock4.Text = "10";
            }
            if (point10.Contains(bt11.Content.ToString()))
            {
                tblock5.Text = "10";
            }
            if (point10.Contains(bt12.Content.ToString()))
            {
                tblock6.Text = "10";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String st = tb1.Text;
            if (str.Contains(st.ToLower()))
            {
                finalScore.Add(eachTurnScore.Sum());
                listboxScore.ItemsSource +=eachTurnScore.Sum().ToString();
                finalSocre.Text = finalScore.Sum().ToString();
                for (int j = 0; j < t_alpha.Count; j++)
                {
                    for (int i = 1; i <= 36; i++)
                    {
                        //if()
                        var a = this.FindName("t" + i);
                        
                        Button b = (Button)a;
                     
                        if (b != null)
                        {
                            if (b.Content.Equals(""))
                            {
                                if (b.Name.Equals("t36"))
                                {
                                    b.Content = t_alpha[j];
                                    MessageBox.Show("Game over");
                                }
                                else
                                //MessageBox.Show(t_alpha[j]);
                                b.Content = t_alpha[j];
                                break;
                            }
                        }
                    }
                }
                fillMissingAlpha();
               
            }
            else
            {
                MessageBox.Show(" OOPS Word Not Exist!!");
                if (bt4C == true)
                {
                    bt4.Content = bt4value;
                    tblock1.Text = bt4score;
                }
                if (bt5C == true)
                {
                    bt5.Content = bt5value;
                    tblock2.Text = bt5score;
                }
                if (bt6C == true)
                {
                    bt6.Content = bt6value;
                    tblock3.Text = bt6score;
                }

                if (bt10C == true)
                {
                    bt10.Content = bt10value;
                    tblock4.Text = bt10score;
                }
                if (bt11C == true)
                {
                    bt11.Content = bt11value;
                    tblock5.Text = bt11score;
                }
                if (bt12C == true)
                {
                    bt12.Content = bt12value;
                    tblock6.Text = bt12score;
                }
                //bt10.Content = bt10value;
            }
            bt1.Content = "";
            bt2.Content = "";
            bt3.Content = "";
            bt7.Content = "";
            bt8.Content = "";
            bt9.Content = "";
            tb1.Text = "";
                
           
            t_alpha.Clear();
            //socre.Text = finalscore.Sum().ToString();
            eachTurnScore.Clear();

        }

        public void fillMissingAlpha()
        {
            if (bt4.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt4.Content= abc[a];
                    score();
                }
            }
            if (bt5.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt5.Content = abc[a];
                    score();
                }
            }
            if (bt6.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt6.Content = abc[a];
                    score();
                }
            }
            if (bt10.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt10.Content = abc[a];
                    score();
                }
            }
            if (bt11.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt11.Content = abc[a];
                    score();
                }
            }
            if (bt12.Content.Equals(""))
            {
                for (var x = 0; x < 1; ++x)
                {
                    int a = r.Next(0, 25);
                    bt12.Content = abc[a];
                    score();
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
            if(!bt4.Content.Equals(""))
            {
            bt4C = true;
            if (bt1.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt1.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock1.Text;
                bt4backword = bt1.Content.ToString() + "/bt4/tblock1";
            }
           else if (bt2.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt2.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock1.Text;
                bt5backword = bt2.Content.ToString() + "/bt4/tblock1";
                
            }
            else if (bt3.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt3.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt4.Content += "  ";
                bt3.Content += tblock1.Text;
                bt6backword = bt3.Content.ToString() + "/bt4/tblock1";
            }
            else if (bt7.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt7.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock1.Text;
                bt10backword = bt7.Content.ToString() + "/bt4/tblock1";
            }
            else if (bt8.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt8.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock1.Text;
                bt11backword = bt8.Content.ToString() + "/bt4/tblock1";
            }
            else if (bt9.Content.Equals("") && !bt4.Content.Equals(""))
            {
                bt9.Content = bt4.Content;
                tb1.Text += bt4.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock1.Text;
                bt12backword = bt9.Content.ToString() + "/bt4/tblock1";
            }
            eachTurnScore.Add(Convert.ToInt32(tblock1.Text));   
            t_alpha.Add(bt4.Content.ToString());
            bt4value = bt4.Content.ToString();
            bt4score = tblock1.Text;
            bt4.Content = "";
            tblock1.Text = "";
        }
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if(!bt5.Content.Equals(""))
            {
            bt5C = true;
            if (bt1.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt1.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock2.Text;
                bt4backword = bt1.Content.ToString() + "/bt5/tblock2";
               
            }
            else if (bt2.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt2.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock2.Text;
                bt5backword = bt2.Content.ToString() + "/bt5/tblock2";
            }
            else if (bt3.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt3.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock2.Text;
                bt6backword = bt3.Content.ToString() + "/bt5/tblock2";
            }
            else if (bt7.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt7.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock2.Text;
                bt10backword = bt7.Content.ToString() + "/bt5/tblock2";
            }
            else if (bt8.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt8.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock2.Text;
                bt11backword = bt8.Content.ToString() + "/bt5/tblock2";
            }
            else if (bt9.Content.Equals("") && !bt5.Content.Equals(""))
            {
                bt9.Content = bt5.Content;
                tb1.Text += bt5.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock2.Text;
                bt12backword = bt9.Content.ToString() + "/bt5/tblock2";
            }
            eachTurnScore.Add(Convert.ToInt32(tblock2.Text));
            t_alpha.Add(bt5.Content.ToString());
            bt5value = bt5.Content.ToString();
            bt5score = tblock2.Text;
            bt5.Content = "";
            tblock2.Text = "";
        }
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if(!bt6.Content.Equals(""))
            {
            bt6C = true;
            if (bt1.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt1.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock3.Text;
                bt6backword = bt1.Content.ToString() + "/bt6/tblock3";
            }
            else if (bt2.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt2.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock3.Text;
                bt6backword = bt2.Content.ToString() + "/bt6/tblock3";
            }
            else if (bt3.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt3.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock3.Text;
                bt6backword = bt3.Content.ToString() + "/bt6/tblock3";
            }
            else if (bt7.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt7.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock3.Text;
                bt6backword = bt7.Content.ToString() + "/bt6/tblock3";
            }
            else if (bt8.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt8.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock3.Text;
                bt6backword = bt8.Content.ToString() + "/bt6/tblock3";
            }
            else if (bt9.Content.Equals("") && !bt6.Content.Equals(""))
            {
                bt9.Content = bt6.Content;
                tb1.Text += bt6.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock3.Text;
                bt6backword = bt9.Content.ToString() + "/bt6/tblock3";
            }
            eachTurnScore.Add(Convert.ToInt32(tblock3.Text));
            t_alpha.Add(bt6.Content.ToString());
            bt6value = bt6.Content.ToString();
            bt6score = tblock3.Text;
            bt6.Content = "";
            tblock3.Text = "";
        }
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            if(!bt10.Content.Equals(""))
            {
            bt10C = true;
            if (bt1.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt1.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt1.Content += "  ";
                bt1.Content += tblock4.Text;
                bt10backword = bt1.Content.ToString() + "/bt10/tblock4";
            }
            else if (bt2.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt2.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt2.Content += "  ";
                bt2.Content += tblock4.Text;
                bt10backword = bt2.Content.ToString() + "/bt10/tblock4";
            }
            else if (bt3.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt3.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt3.Content += "  ";
                bt3.Content += tblock4.Text;
                bt10backword = bt3.Content.ToString() + "/bt10/tblock4";
            }
            else if (bt7.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt7.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt7.Content += "  ";
                bt7.Content += tblock4.Text;
                bt10backword = bt7.Content.ToString() + "/bt10/tblock4";
            }
            else if (bt8.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt8.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt8.Content += "  ";
                bt8.Content += tblock4.Text;
                bt10backword = bt8.Content.ToString() + "/bt10/tblock4";
            }
            else if (bt9.Content.Equals("") && !bt10.Content.Equals(""))
            {
                bt9.Content = bt10.Content;
                tb1.Text += bt10.Content.ToString();
                bt9.Content += "  ";
                bt9.Content += tblock4.Text;
                bt10backword = bt9.Content.ToString() + "/bt10/tblock4";
            }
            eachTurnScore.Add(Convert.ToInt32(tblock4.Text));
            t_alpha.Add(bt10.Content.ToString());
            bt10value = bt10.Content.ToString();
            bt10score = tblock4.Text;
            bt10.Content = "";
            tblock4.Text = "";
        }
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            if (!bt11.Content.Equals(""))
            {
                bt11C = true;
                if (bt1.Content.Equals("") && !bt11.Content.Equals(""))
                {
                    bt1.Content = bt11.Content;
                    tb1.Text += bt11.Content.ToString();
                    bt1.Content += "  ";
                    bt1.Content += tblock5.Text;
                    bt11backword = bt1.Content.ToString() + "/bt11/tblock5";
                }
                else if (bt2.Content.Equals("") && !bt11.Content.Equals(""))
                {
                    bt2.Content = bt11.Content;
                    tb1.Text += bt11.Content.ToString();
                    bt2.Content += "  ";
                    bt2.Content += tblock5.Text;
                    bt11backword = bt2.Content.ToString() + "/bt11/tblock5";
                }
                else if (bt3.Content.Equals("") && !bt11.Content.Equals(""))
                {
                    bt3.Content = bt11.Content;
                    tb1.Text += bt11.Content.ToString();
                    bt3.Content += "  ";
                    bt3.Content += tblock5.Text;
                    bt11backword = bt3.Content.ToString() + "/bt11/tblock5";
                }
                else if (bt7.Content.Equals("") && !bt11.Content.Equals(""))
                {
                    bt7.Content = bt11.Content;
                    tb1.Text += bt11.Content.ToString();
                    bt7.Content += "  ";
                    bt7.Content += tblock5.Text;
                    bt11backword = bt7.Content.ToString() + "/bt11/tblock5";
                }
                else if (bt8.Content.Equals("") && !bt11.Content.Equals(""))
                {
                    bt8.Content = bt11.Content;
                    tb1.Text += bt11.Content.ToString();
                    bt8.Content += "  ";
                    bt8.Content += tblock5.Text;
                    bt11backword = bt8.Content.ToString() + "/bt11/tblock5";
                }
                else if (bt9.Content.Equals("") && !bt11.Content.Equals(""))
                {
                    bt9.Content = bt11.Content;
                    tb1.Text += bt11.Content.ToString();
                    bt9.Content += "  ";
                    bt9.Content += tblock5.Text;
                    bt11backword = bt9.Content.ToString() + "/bt11/tblock5";
                }
                eachTurnScore.Add(Convert.ToInt32(tblock5.Text));
                t_alpha.Add(bt11.Content.ToString());
                bt11value = bt11.Content.ToString();
                bt11score = tblock5.Text;
                bt11.Content = "";
                tblock5.Text = "";
            }
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            if (!bt12.Content.Equals(""))
            {
                bt12C = true;
                if (bt1.Content.Equals("") && !bt12.Content.Equals(""))
                {
                    bt1.Content = bt12.Content;
                    tb1.Text += bt12.Content.ToString();
                    bt1.Content += "  ";
                    bt1.Content += tblock6.Text;
                    bt12backword = bt1.Content.ToString() + "/bt12/tblock6";
                }
                else if (bt2.Content.Equals("") && !bt12.Content.Equals(""))
                {
                    bt2.Content = bt12.Content;
                    tb1.Text += bt12.Content.ToString();
                    bt2.Content += "  ";
                    bt2.Content += tblock6.Text;
                    bt12backword = bt2.Content.ToString() + "/bt12/tblock6";
                }
                else if (bt3.Content.Equals("") && !bt12.Content.Equals(""))
                {
                    bt3.Content = bt12.Content;
                    tb1.Text += bt12.Content.ToString();
                    bt3.Content += "  ";
                    bt3.Content += tblock6.Text;
                    bt12backword = bt3.Content.ToString() + "/bt12/tblock6";
                }
                else if (bt7.Content.Equals("") && !bt12.Content.Equals(""))
                {
                    bt7.Content = bt12.Content;
                    tb1.Text += bt12.Content.ToString();
                    bt7.Content += "  ";
                    bt7.Content += tblock6.Text;
                    bt12backword = bt7.Content.ToString() + "/bt12/tblock6";
                }
                else if (bt8.Content.Equals("") && !bt12.Content.Equals(""))
                {
                    bt8.Content = bt12.Content;
                    tb1.Text += bt12.Content.ToString();
                    bt8.Content += "  ";
                    bt8.Content += tblock6.Text;
                    bt12backword = bt8.Content.ToString() + "/bt12/tblock6";
                }
                else if (bt9.Content.Equals("") && !bt12.Content.Equals(""))
                {
                    bt9.Content = bt12.Content;
                    tb1.Text += bt12.Content.ToString();
                    bt9.Content += "  ";
                    bt9.Content += tblock6.Text;
                    bt12backword = bt9.Content.ToString() + "/bt12/tblock6";
                }
                eachTurnScore.Add(Convert.ToInt32(tblock6.Text));

                eachTurnScore.Add(Convert.ToInt32(tblock6.Text));
                t_alpha.Add(bt12.Content.ToString());
                bt12value = bt12.Content.ToString();
                bt12score = tblock6.Text;
                bt12.Content = "";
                tblock6.Text = "";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mixup();
        }
        public void mixup()
        {
            string[] changeArray = new string[6];
            List<int> checkrepeat = new List<int>();
            if (!bt4.Content.Equals("") && !bt5.Content.Equals("") && !bt6.Content.Equals("") && !bt10.Content.Equals("") && !bt11.Content.Equals("") && !bt12.Content.Equals(""))
            {
                changeArray[0] = bt4.Content.ToString();
                changeArray[1] = bt5.Content.ToString();
                changeArray[2] = bt6.Content.ToString();
                changeArray[3] = bt10.Content.ToString();
                changeArray[4] = bt11.Content.ToString();
                changeArray[5] = bt12.Content.ToString();

                Random rnd = new Random();
                for (int inx = changeArray.Length - 1; inx > 0; --inx)
                {
                    int position = rnd.Next(inx);
                    string  temp = changeArray[inx];
                    changeArray[inx] = changeArray[position];
                    changeArray[position] = temp;
                }
                

                bt4.Content = changeArray[0];
                bt5.Content = changeArray[1];
                bt6.Content = changeArray[2];
                
                bt10.Content = changeArray[3];
                bt11.Content = changeArray[4];
                bt12.Content = changeArray[5];
                score();
            }

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            //if (!bt4backword.Equals(""))
            //{
            //    string[] str = bt4backword.Split('/');
            //    string content = str[0];
            //    string[] split_content = content.Split(' ');

            //    var b = (Button)FindName(str[1]);
            //    b.Content = split_content[0];

            //    var t = (TextBlock)FindName(str[2]);
            //    t.Text = split_content[2];
            //    bt1.Content = "";
            //}
            //if (!bt5backword.Equals(""))
            //{
            //    string[] str = bt5backword.Split('/');
            //    string content = str[0];
            //    string[] split_content = content.Split(' ');

            //    var b = (Button)FindName(str[1]);
            //    b.Content = split_content[0];

            //    var t = (TextBlock)FindName(str[2]);
            //    t.Text = split_content[2];
            //    bt1.Content = "";
            //}
            //if (!bt6backword.Equals(""))
            //{
            //    string[] str = bt6backword.Split('/');
            //    string content = str[0];
            //    string[] split_content = content.Split(' ');

            //    var b = (Button)FindName(str[1]);
            //    b.Content = split_content[0];

            //    var t = (TextBlock)FindName(str[2]);
            //    t.Text = split_content[2];
            //    bt1.Content = "";
            //}
            //if (!bt10backword.Equals(""))
            //{
            //    string[] str = bt10backword.Split('/');
            //    string content = str[0];
            //    string[] split_content = content.Split(' ');

            //    var b = (Button)FindName(str[1]);
            //    b.Content = split_content[0];

            //    var t = (TextBlock)FindName(str[2]);
            //    t.Text = split_content[2];
            //    bt1.Content = "";
            //}

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            //string[] str = bt4backword.Split('/');

            //string content = str[0];

            //string[] split_content = content.Split(' ');

            //var b = (Button)FindName(str[1]);
            //b.Content = split_content[0];

            //var t = (TextBlock)FindName(str[2]);
            //t.Text = split_content[2];
            //bt1.Content = "";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            timerDuration = 30;
            newGame();
        }
    }
}
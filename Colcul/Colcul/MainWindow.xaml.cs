﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Colcul
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            foreach(UIElement el in Main.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "CE")
            {
                labelosn.Content = "";
                labelsec.Content = "";
            }
            else if (str == "C")
            {
                labelosn.Content = "";
            }
            else if (str == "=")
            {
                string s = labelsec.Content.ToString();
                string s2 = s.Substring(s.Length-1);
                if (labelosn.Content == "")
                {
                    if (s2 == "+")
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                    else if (s2 == "-")
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                    else if (s2 == "/")
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                    else if (s2 == "*")
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                }
                labelsec.Content += labelosn.Content.ToString();
                string value = new DataTable().Compute(labelsec.Content.ToString(), null).ToString();
                labelosn.Content = value;
            }
            else if (str == "+/-")
            {
                string s = labelosn.Content.ToString();
                string s2 = s.Substring(0,1);
                if (s2 != "-")
                {
                    s = s.Insert(0, "-");
                    labelosn.Content = s;
                }
                else
                {
                    s = s.Remove(0,1);
                    labelosn.Content = s;
                }
            }
            else if (str == "+")
            {
                labelosn.Content += str;
                labelsec.Content += labelosn.Content.ToString();
                labelosn.Content = "";
            }
            else if (str == "-")
            {
                labelosn.Content += str;
                labelsec.Content += labelosn.Content.ToString();
                labelosn.Content = "";
            }
            else if (str == "*")
            {
                labelosn.Content += str;
                labelsec.Content += labelosn.Content.ToString();
                labelosn.Content = "";
            }
            else if (str == "/")
            {
                labelosn.Content += str;
                labelsec.Content += labelosn.Content.ToString();
                labelosn.Content = "";
            }
            else
            {
                labelosn.Content += str;
            }
        }
        //public void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "1";
        //    labelosn.Content += "1";
        //}
        //public void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "2";
        //    labelosn.Content += "2";
        //}
        //public void Button3_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "3";
        //    labelosn.Content += "3";
        //}
        //public void Button4_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "4";
        //    labelosn.Content += "4";
        //}
        //public void Button5_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "5";
        //    labelosn.Content += "5";
        //}
        //public void Button6_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "6";
        //    labelosn.Content += "6";
        //}
        //public void Button7_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "7";
        //    labelosn.Content += "7";
        //}
        //public void Button8_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "8";
        //    labelosn.Content += "8";
        //}
        //public void Button9_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "9";
        //    labelosn.Content += "9";
        //}
        //public void Button0_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "0";
        //    labelosn.Content += "0";
        //}
        //public void Buttonplus_Click(object sender, RoutedEventArgs e)
        //{
        //    osn = int.Parse(osn).ToString();
        //    labelosn.Content = "+";
        //}
        //public void Buttonmin_Click(object sender, RoutedEventArgs e)
        //{
        //    osn += "-";
        //    labelosn.Content += "-";
        //}
        //public void Buttonres_Click(object sender, RoutedEventArgs e)
        //{
        //    labelsec.Content = labelosn.Content;
        //    labelosn = osn.GetType();
        //    labelosn.Content = .ToString();
        //}
    }
}

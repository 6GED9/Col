using System;
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
                if (labelsec.Content != "")
                {
                    string s2 = s.Substring(s.Length - 1);
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
                }
                labelsec.Content += labelosn.Content.ToString();
                string value;
                try
                {
                    value = new DataTable().Compute(labelsec.Content.ToString(), null).ToString();
                }
                catch
                {
                    value = "∞";
                }
                labelosn.Content = value;
                labelsec.Content = "";
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
                if (labelsec.Content != "" && labelosn.Content.ToString().Length == 1)
                {
                    string s = labelsec.Content.ToString();
                    if (labelsec.Content.ToString().Last() == '+' || labelsec.Content.ToString().Last() == '-' || labelsec.Content.ToString().Last() == '*' || labelsec.Content.ToString().Last() == '/')
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                }
                    labelsec.Content += labelosn.Content.ToString();
                        labelosn.Content = "";
                    }
                    else if (str == "-")
                    {
                        labelosn.Content += str;
                if (labelsec.Content != "" && labelosn.Content.ToString().Length == 1)
                {
                    string s = labelsec.Content.ToString();
                    if (labelsec.Content.ToString().Last() == '+' || labelsec.Content.ToString().Last() == '-' || labelsec.Content.ToString().Last() == '*' || labelsec.Content.ToString().Last() == '/')
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                }
                labelsec.Content += labelosn.Content.ToString();
                        labelosn.Content = "";
                    }
                    else if (str == "*")
                    {
                        labelosn.Content += str;
                if (labelsec.Content != "" && labelosn.Content.ToString().Length == 1)
                {
                    string s = labelsec.Content.ToString();
                    if (labelsec.Content.ToString().Last() == '+' || labelsec.Content.ToString().Last() == '-' || labelsec.Content.ToString().Last() == '*' || labelsec.Content.ToString().Last() == '/')
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                }
                labelsec.Content += labelosn.Content.ToString();
                        labelosn.Content = "";
                    }
                    else if (str == "/")
                    {
                        labelosn.Content += str;
                if (labelsec.Content != "" && labelosn.Content.ToString().Length == 1)
                {
                    string s = labelsec.Content.ToString();
                    if (labelsec.Content.ToString().Last() == '+' || labelsec.Content.ToString().Last() == '-' || labelsec.Content.ToString().Last() == '*' || labelsec.Content.ToString().Last() == '/')
                    {
                        s = s.Remove(s.Length - 1);
                        labelsec.Content = s;
                    }
                }
                labelsec.Content += labelosn.Content.ToString();
                        labelosn.Content = "";
                    }
                    else
                    {
                        labelosn.Content += str;
                    }
            }
        }
    }

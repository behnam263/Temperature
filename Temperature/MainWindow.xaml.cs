using System;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Temperature
{
    [TestClass]
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Business business;
        public MainWindow()
        {
            InitializeComponent();
             business = new Business();
            Inputtxt.Text = "HOT 8, 6, 4, 2, 1, 7;\nCOLD 8, 6, 3, 4, 2, 5, 1, 7;\nHOT 8, 6, 6;\nHOT 8, 6, 3;\nCOLD 8, 6, 3, 4, 2, 5, 7;\nCOLD 6;";
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            outputtxt.Text = "";
            string[] str =  Inputtxt.Text.ToLower().Split(new string[] {";" , "\n" },StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < str.Length; i++)
            {
              string[] input=  str[i].Split(new string[] {" ","," },StringSplitOptions.RemoveEmptyEntries);
              bool result=   business.checkRules(input);
                if (result)
                    outputtxt.Text+= business.Output(input) + "Success";
                else
                    outputtxt.Text += business.Output(input) + "Fail";

                outputtxt.Text += "\n";
             
            }
        }
        [TestMethod]
        public void Datatest()
        {
            string[] input = "hot 8, 6, 4, 2, 1, 7".Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
           Assert.IsTrue(  business.checkRules(input));
            string str = business.Output(input);
          Assert.AreEqual(str, "removing pjs, shorts, t-shirt, sun visor, sandals, leaving house, ");
        

        }
    }
}

using System;
using System.Collections;
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

namespace Lec86SortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {

            sortedList.Add(int.Parse(keytxt.Text),valuetxt.Text);
            ICollection coollection = sortedList.Keys;
            //ICollection coollection2 = sortedList.Values;
            string showAll = String.Empty;
            //string showAll2 = String.Empty;
            foreach (int key in coollection)
            {
                showAll = showAll + " " + "\n" + sortedList[key].ToString();
                //MessageBox.Show(coollection[key].ToString());
                // showAll += key.ToString();
                //  showAll2 += coollection2.ToString();

            }
               MessageBox.Show(showAll);

        }
    }
}

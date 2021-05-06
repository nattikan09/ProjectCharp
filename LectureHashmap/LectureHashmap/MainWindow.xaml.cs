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

namespace LectureHashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            //Add
            // hashtable.Add("Ohh","pen"); 
            // hashtable.Add("Ohh2", "cup");
            // hashtable.Add("Ohh3", "cup2");
            hashtable.Add(textBoxKey.Text, textBoxValue.Text);
        }

        private void RemoveBth_Click(object sender, RoutedEventArgs e)
        {

            hashtable.Remove(textBoxKey.Text);
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //Show All
            foreach (String key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}

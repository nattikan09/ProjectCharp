﻿using System;
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
using System.Collections;


namespace LCArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();

        }

        private void bntShowAll_Click(object sender, RoutedEventArgs e)
        {
             //Show Data
            MessageBox.Show("Count is " + arrayList.Count);
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
               
            }

        }

        private void bntAdd_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(int.Parse(textBox.Text));
            MessageBox.Show(textBox.Text);

        }

        private void bntRemove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(int.Parse(textBox.Text));
        }
    }
}

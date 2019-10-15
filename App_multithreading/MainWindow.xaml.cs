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

namespace App_multithreading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_task_Click(object sender, RoutedEventArgs e)
        {
            //DoWork();
            Task.Factory.StartNew(DoWork);
        }

        private void btn_count_Click(object sender, RoutedEventArgs e)
        {
            //DoCount();
            Task.Factory.StartNew(DoCount);
        }

        private void DoWork()
        {
            for (int i = 0; i <= 1000000; i++)
            {
                for (int j = 0; j <= 1000000; j++)
                {

                }
            }
            //AggiornaInterfaccia();
            Dispatcher.Invoke(AggiornaInterfaccia);
        }

        private void DoCount()
        {
            for (int i = 0; i <= 1000000; i++)
            {
                for (int j = 0; j <= 1000000; j++)
                {
                    Dispatcher.Invoke(()=>AggiornaInterfaccia(j));
                }
            }
        }

        private void AggiornaInterfaccia()
        {
            lbl_risultato.Content = "finito";
        }

        private void AggiornaInterfaccia(int j)
        {
            lbl_conteggio.Content = j.ToString();
        }
    }
}

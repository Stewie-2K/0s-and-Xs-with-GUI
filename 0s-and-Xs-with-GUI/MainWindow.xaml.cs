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

namespace _0s_and_Xs_with_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player[] Players = new Player[2];
        private Board b = new Board();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == P1)
            {
                P1.Content = "X";
            }
            if (sender == P2)
            {
                P2.Content = "X";
            }
            if (sender == P3)
            {
                P3.Content = "X";
            }
            if (sender == P4)
            {
                P4.Content = "X";
            }
            if (sender == P5)
            {
                P5.Content = "X";
            }
            if (sender == P6)
            {
                P6.Content = "X";
            }
            if (sender == P7)
            {
                P7.Content = "X";
            }
            if (sender == P8)
            {
                P8.Content = "X";
            }
            if (sender == P9)
            {
                P9.Content = "X";
            }
        }
        private void choosePlayers(int Choice)
        {
            if (Choice == 0)
            {
                Players[0] = new Human_Player();
                Players[1] = new Human_Player();
            }
            if (Choice == 1)
            {
                Players[0] = new AI_Player(b, Choice);
                Players[1] = new Human_Player();
            }
            if (Choice == 2)
            {
                Players[0] = new Human_Player();
                Players[1] = new AI_Player(b, Choice);
            }
        }

        private void Update()
        {
            int who = 0;
            while (b.checkwin() == 0)
            {
                b.addCounter((who % 2) + 1, Players[who % 2].Move());
                //need to update UI
                who++;
            }
        }    
    }
}

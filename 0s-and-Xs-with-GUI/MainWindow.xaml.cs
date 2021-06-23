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
        private Game g = new Game();
        public MainWindow()
        {
            InitializeComponent();
            g.choosePlayers(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            if (sender == P1)
            {
                Update(1);
            }
            if (sender == P2)
            {
                Update(2);
            }
            if (sender == P3)
            {
                Update(3);
            }
            if (sender == P4)
            {
                Update(4);
            }
            if (sender == P5)
            {
                Update(5);
            }
            if (sender == P6)
            {
                Update(6);
            }
            if (sender == P7)
            {
                Update(7);
            }
            if (sender == P8)
            {
                Update(8);
            }
            if (sender == P9)
            {
                Update(9);
            }
        }
        
        private void Update(int Pos)
        {
            char[,] b = g.getBoard();
            int winStatus = g.Update(Pos);

            UpdateBoardUI(b);

            if (winStatus == 1)
            {
                Status.Content = "Xs Win!";
            }
            if (winStatus == 2)
            {
                Status.Content = "Os Win!";
            }
            if (winStatus == 3)
            {
                Status.Content = "It's a Draw!";
            }
        }
        private void UpdateBoardUI(char[,] b)
        {
            P1.Content = b[0, 0];
            P2.Content = b[0, 1];
            P3.Content = b[0, 2];
            P4.Content = b[1, 0];
            P5.Content = b[1, 1];
            P6.Content = b[1, 2];
            P7.Content = b[2, 0];
            P8.Content = b[2, 1];
            P9.Content = b[2, 2];
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            char[,] b = new char[3, 3];
            g.reset();
            UpdateBoardUI(b);
            Status.Content = "";
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }
    }
}

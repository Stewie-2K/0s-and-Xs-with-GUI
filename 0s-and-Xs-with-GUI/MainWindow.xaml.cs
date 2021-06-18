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
        private object[] buttons = new object[9];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == P1)
            {
                P1.Content = "X";
                Update(1);
            }
            if (sender == P2)
            {
                P2.Content = "X";
                Update(2);
            }
            if (sender == P3)
            {
                P3.Content = "X";
                Update(3);
            }
            if (sender == P4)
            {
                P4.Content = "X";
                Update(4);
            }
            if (sender == P5)
            {
                P5.Content = "X";
                Update(5);
            }
            if (sender == P6)
            {
                P6.Content = "X";
                Update(6);
            }
            if (sender == P7)
            {
                P7.Content = "X";
                Update(7);
            }
            if (sender == P8)
            {
                P8.Content = "X";
                Update(8);
            }
            if (sender == P9)
            {
                P9.Content = "X";
                Update(9);
            }
        }
        
        private void Update(int Pos)
        {
            g.Update(Pos);
            for ()
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        board[y, x];
                    }
                }
            }            
        }
        
    }
}

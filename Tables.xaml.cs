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
using System.Windows.Shapes;

namespace FTA
{
    public partial class Tables : Window
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void Button_Marshrut_Click(object sender, RoutedEventArgs e)
        {
            Marshruti marshruti = new Marshruti();
            marshruti.Show();
            Hide();
        }

        private void Button_Voditel_Click(object sender, RoutedEventArgs e)
        {
            Voditel voditel = new Voditel();
            voditel.Show();
            Hide();
        }

        private void Button_Work_Click(object sender, RoutedEventArgs e)
        {
            Works works = new Works();
            works.Show();
            Hide();
        }
    }
}

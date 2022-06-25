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

namespace mfc1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
 
        public Window1()
        {
            InitializeComponent();
        }

        private void bd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window1 po = new Window1();
                Form1 pp = new Form1();
                po.Close();
                pp.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки БД");
            }
            
        }
    }
}

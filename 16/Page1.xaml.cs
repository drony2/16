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

namespace _16
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txbAppointment.Text !="" &&  txbColor.Text!= "" && txbheight.Text != "" && txblength.Text != "" && txbManufacturer.Text != "" && txbNameProduct.Text != "" && txbwidth.Text != "" &&)
            {
                MessageBox.Show("Товар добавлен!!!");
            }
            else
            {
                MessageBox.Show("Не все поля были заполнены");

            }
        }
    }
}

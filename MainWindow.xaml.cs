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

namespace Q2
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

        private void btn_AddSomeone_Click(object sender, RoutedEventArgs e)
        {
            if (!(txtListBox.Items.Contains(txtBox.Text)))
            {
                txtListBox.Items.Add(txtBox.Text);
                txtBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Name is already in the List");
                txtBox.Text = String.Empty;
            }
        }
    }
}

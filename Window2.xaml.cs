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

namespace UI_2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        bool dialogRes;
        public bool DialogRes
        {
            get { return dialogRes; }
        }

        public Window2()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible) 
                dialogRes = false;
        }
        private void button21_Click(object sender, RoutedEventArgs e)
        {
            dialogRes = true;
            Close();
        }
        public void button22_Click(object sender, RoutedEventArgs e)
        {
            Owner.Title = textBox1.Text;
            Owner.OwnedWindows[0].Title = textBox2.Text;
        }
    }
}

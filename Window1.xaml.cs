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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int count;
        public Window1()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            if (MessageBox.Show("Закрити підпорядковане вікно?", "Підтвердження",
            MessageBoxButton.YesNo,
            MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                Hide();
                Owner.Activate();
            }

        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            (Owner.FindName("button1") as Button).Content = IsVisible ?
            "Закрити підпорядковане вікно" : "Відкрити підпорядковане вікно";
            if (IsVisible)
                textBlock.Text = "Вікно відкрите " + (++count) + "-й раз.";
        }

    }
}

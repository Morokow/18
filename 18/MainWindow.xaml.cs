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

namespace _18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.X_left.PreviewTextInput += new TextCompositionEventHandler(X_left_PreviewTextInput);
            this.X_right.PreviewTextInput += new TextCompositionEventHandler(X_right_PreviewTextInput);
            ResizeMode = ResizeMode.CanMinimize;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (Checkbox_Left.IsChecked.Value == true)
            {
                GroupBox_Left.IsEnabled = true;
                GroupBox_Right.IsEnabled = false;
                CheckBox_Right.IsChecked = false;
            }
            else Checkbox_Left.IsEnabled = true;
        }
        private void X_left_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            if (Char.IsNumber(e.Text, 0) | Char.IsPunctuation(e.Text, 0))
            {
                
                return;
            }
            else
                e.Handled = true;
        }
        private void X_right_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            if (Char.IsNumber(e.Text, 0) | Char.IsPunctuation(e.Text, 0))
            {

                return;
            }
            else
                e.Handled = true;
        }

            private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            if (CheckBox_Right.IsChecked.Value == true)
            {
                GroupBox_Right.IsEnabled = true;
                GroupBox_Left.IsEnabled = false;
                Checkbox_Left.IsChecked = false;
            }
            else CheckBox_Right.IsEnabled = true; 
            
        }

        private void Checkbox_Left_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Checkbox_Left.IsChecked.Value == true)
            {
                GroupBox_Left.IsEnabled = true;
            }
            else Checkbox_Left.IsEnabled = true;
        }

        private void CheckBox_Right_Unchecked(object sender, RoutedEventArgs e)
        {
            if (CheckBox_Right.IsChecked.Value == true)
            {
                GroupBox_Right.IsEnabled = true;
            }
            else CheckBox_Right.IsEnabled = true;
        }

        private void X_left_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Mil_left_Checked(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(X_left.Text);
            Otvet_Left.Text = Convert.ToString(a / 1000);
        }

        private void San_Left_Checked(object sender, RoutedEventArgs e)
        {
            Otvet_Left.Text = Convert.ToString(Convert.ToDouble(X_left.Text) / 100);
        }

        private void Dec_Left_Checked(object sender, RoutedEventArgs e)
        {
            Otvet_Left.Text = Convert.ToString(Convert.ToDouble(X_left.Text) / 10);
        }

        private void Metr_Left_Checked(object sender, RoutedEventArgs e)
        {
            Otvet_Left.Text = Convert.ToString(Convert.ToDouble(X_left.Text) / 1);
        }

        private void Killom_Left_Checked(object sender, RoutedEventArgs e)
        {
            Otvet_Left.Text = Convert.ToString(Convert.ToDouble(X_left.Text) * 1000);
        }
        private void X_right_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Rash_Right_Click(object sender, RoutedEventArgs e)
        {
            if (Mil_Right.IsChecked.Value == true)
            {
                Otvet_Right.Text = Convert.ToString(Convert.ToDouble(X_right.Text) / 1000);
            }
            if (San_Left.IsChecked.Value == true)
            {
                Otvet_Right.Text = Convert.ToString(Convert.ToDouble(X_right.Text) / 100);
            }
            if (Dec_Right.IsChecked.Value == true)
            {
                Otvet_Right.Text = Convert.ToString(Convert.ToDouble(X_right.Text) / 10);
            }
            if (Metr_Right.IsChecked.Value == true)
            {
                Otvet_Right.Text = Convert.ToString(Convert.ToDouble(X_right.Text) / 1);
            }
            if (Killom_Right.IsChecked.Value == true)
            {
                Otvet_Right.Text = Convert.ToString(Convert.ToDouble(X_right.Text) * 1000);
            }
        }

        private void X_right_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}

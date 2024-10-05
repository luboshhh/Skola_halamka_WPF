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

namespace Skola_halamka_WPF
{
   
    public partial class Window1 : Window
    {
        public string FullName { get; private set; }

        public Window1()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
           
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();

            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
               
                MessageBox.Show("Vyplň celé jméno", "Chyba", MessageBoxButton.OK, MessageBoxImage.Warning);
                return; 
            }

            
            FullName = $"{firstName} {lastName}";
            DialogResult = true;
            Close();
        }

    }
}

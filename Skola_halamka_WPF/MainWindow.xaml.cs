using System.Collections.ObjectModel;
using System.Windows;

namespace Skola_halamka_WPF
{
    public partial class MainWindow : Window
    {
        
        ObservableCollection<string> Teachers = new ObservableCollection<string>();
        ObservableCollection<string> Maintenance = new ObservableCollection<string>();
        ObservableCollection<string> Support = new ObservableCollection<string>();
        ObservableCollection<string> Students = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

           
            TeachersList.ItemsSource = Teachers;
            MaintenanceList.ItemsSource = Maintenance;
            SupportList.ItemsSource = Support;
            StudentsList.ItemsSource = Students;
        }

       
        private void AddTeacher_Click(object sender, RoutedEventArgs e)
        {
            var addMemberWindow = new Window1();
            if (addMemberWindow.ShowDialog() == true) 
            {
                Teachers.Add(addMemberWindow.FullName); 
            }
        }

        private void DeleteTeacher_Click(object sender, RoutedEventArgs e)
        {
            if (TeachersList.SelectedItem != null)
                Teachers.Remove((string)TeachersList.SelectedItem);
        }

        private void AddMaintenance_Click(object sender, RoutedEventArgs e)
        {
            var addMemberWindow = new Window1();
            if (addMemberWindow.ShowDialog() == true)
            {
                Maintenance.Add(addMemberWindow.FullName);
            }
        }

        private void DeleteMaintenance_Click(object sender, RoutedEventArgs e)
        {
            if (MaintenanceList.SelectedItem != null)
                Maintenance.Remove((string)MaintenanceList.SelectedItem);
        }

        private void AddSupport_Click(object sender, RoutedEventArgs e)
        {
            var addMemberWindow = new Window1();
            if (addMemberWindow.ShowDialog() == true)
            {
                Support.Add(addMemberWindow.FullName);
            }
        }

        private void DeleteSupport_Click(object sender, RoutedEventArgs e)
        {
            if (SupportList.SelectedItem != null)
                Support.Remove((string)SupportList.SelectedItem);
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            var addMemberWindow = new Window1();
            if (addMemberWindow.ShowDialog() == true)
            {
                Students.Add(addMemberWindow.FullName);
            }
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (StudentsList.SelectedItem != null)
                Students.Remove((string)StudentsList.SelectedItem);
        }
    }
}

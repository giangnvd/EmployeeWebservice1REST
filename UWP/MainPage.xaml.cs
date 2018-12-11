using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }
            void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            getEmployee();
        }
        async void getEmployee()
        {
            try
            {
                ProgressBar.IsIndeterminate = true;
                ProgressBar.Visibility = Visibility.Visible;
                GridViewEmployee.ItemsSource = await webService.GetProductListAsync();
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
             }
            catch(Exception ex)
            {
                MessageDialog messageDialog = new MessageDialog(ex.Message);
                await messageDialog.ShowAsync();
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;

            }
        }  
        private async void GridViewEmpolyee_SelectionChanger(object sender , SelectionChangedEventArgs e)
        {
            try
            {
                if (e.AddedItems.Count != 0)
                {
                    Employee selectedEmployee = e.AddedItems[0] as Employee;
                    TextBoxName.Text = selectedEmployee.firstName;
                    TextBoxSurName.Text = selectedEmployee.lastName;
                    TextBoxCity.Text = selectedEmployee.address;
                    TextBoxAge.Text = selectedEmployee.Age.Totring();   

                }
            }
            catch
            {
                MessageDialog messageDialog = new MessageDialog("Error Data! ");
                await messageDialog.ShowAsync();
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;    
            }
        }

        private  async void ButtonAdd_Click(object sender , RoutedEventArgs e)
        {
            try
            {
                ProgressBar.IsIndeterminate = true;
                ProgressBar.Visibility = Visibility.Visible;
                Employee newEmployee = new Employee();
                newEmployee.firsName = TextBoxName.Text;
                newEmployee.lastName = TextBoxSurName.Text;
                newEmployee.Age = Int32.Parse(TextBoxAge.Text);
                newEmployee.address = TextBoxCity.Text;
                bool result = await webService.AddEmployeeAsync(newEmployee);
                ProgressBar.Visibility = Visibility.Collapsed;
                ProgressBar.IsIndeterminate = false;
                if (result== true)
                {
                    Me

                }
            }
        } 

    }
}

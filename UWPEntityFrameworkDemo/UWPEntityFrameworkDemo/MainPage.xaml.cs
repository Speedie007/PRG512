using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPEntityFrameworkDemo.Models.DatabaseContext;
using UWPEntityFrameworkDemo.Models.DataModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Linq;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPEntityFrameworkDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new UWPEFDemoDbContext())
                {
                    Students.ItemsSource = db.Students.ToList();
                }

            }
            catch (Exception ex)
            {
                var ss = ex.Message;
            }

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new UWPEFDemoDbContext())
            {
                var blog = new Student
                {
                    FirstName = StudentFirstName.Text,
                    LastName = StudentLastName.Text,
                    DateOfBirth = DateTime.Now
                };
                db.Students.Add(blog);
                db.SaveChanges();

                Students.ItemsSource = db.Students.ToList();
            }
        }
    }
}

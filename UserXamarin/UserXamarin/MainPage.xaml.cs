using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserXamarin.Models;
using Xamarin.Forms;

namespace UserXamarin
{
    public partial class MainPage : ContentPage
    {

        services.IUserService userService = DependencyService.Get<services.IUserService>();
        List<User> myList;

        public MainPage()
        {
            InitializeComponent();

            //List<User> myList = new List<User>
            //{
            //    new User {first_name="Anirudha", avatar="https://reqres.in/img/faces/1-image.jpg" },
            //    new User {first_name="Lucifer", avatar="https://reqres.in/img/faces/1-image.jpg" },
            //    new User {first_name="Zoro", avatar="https://reqres.in/img/faces/1-image.jpg" },
            //};

            // userListView.ItemsSource = myList;

            getUsers();

        }

        public async void getUsers() {
            var result = await userService.getUsers(page: 1);
            myList = result.data;

            userListView.ItemsSource = myList;

        }
    }
}


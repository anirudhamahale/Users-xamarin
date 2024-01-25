using System.Collections.Generic;
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
            getUsers();

            userListView.ItemTapped += async (o, e) => {
                User user = e.Item as User;
                // await DisplayAlert(title: "I am clicked", message: user.full_name, cancel: "Cancel");
                await pushDetailPage(user);
            };

        }

        public async void getUsers() {
            var result = await userService.getUsers(page: 1);
            myList = result.data;

            userListView.ItemsSource = myList;

        }

        async Task pushDetailPage(User user) {
            await this.Navigation.PushModalAsync(new UserDetailPage(user));
        }
    }
}


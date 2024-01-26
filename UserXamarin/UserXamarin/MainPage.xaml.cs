using System.Collections.Generic;
using System.Threading.Tasks;
using UserXamarin.Models;
using UserXamarin.ViewModels;
using Xamarin.Forms;

namespace UserXamarin
{
    public partial class MainPage : ContentPage
    {

        
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
            await (BindingContext as UserListViewModel).loadDataAsync();
        }

        async Task pushDetailPage(User user) {
            await this.Navigation.PushModalAsync(new UserDetailPage(user));
        }
    }
}


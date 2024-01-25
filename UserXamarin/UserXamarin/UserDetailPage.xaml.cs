using System.Collections.Generic;
using System.Threading.Tasks;
using UserXamarin.Models;
using Xamarin.Forms;

namespace UserXamarin
{	
	public partial class UserDetailPage : ContentPage
	{
		public User user;

		public UserDetailPage (User user)
		{
            this.user = user;
            InitializeComponent();
            nameLabel.Text = user.full_name;
            profileImage.Source = user.avatar;
            emailLabel.Text = user.email;

            closeButton.Clicked += (o, e) => {
                this.Navigation.PopModalAsync();
            };

            nameLabel.Text = "Anirudha Mahale";
            profileImage.Source = "https://reqres.in/img/faces/1-image.jpg";
            emailLabel.Text = "george.bluth@reqres.in";

        }
    }
}


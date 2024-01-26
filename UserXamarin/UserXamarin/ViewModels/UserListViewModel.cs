using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UserXamarin.Models;
using Xamarin.Forms;

namespace UserXamarin.ViewModels
{
	public class UserListViewModel: INotifyPropertyChanged
	{
		public UserListViewModel()
		{
		}

        public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<User> users = new ObservableCollection<User>();

        public Color shouldShow = Color.Green;

        services.IUserService userService = DependencyService.Get<services.IUserService>();

        public async Task loadDataAsync() {
            var result = await userService.getUsers(page: 1);
            result.data.ForEach(delegate (User user)
            {
                users.Add(user);
            });
            shouldShow = Color.Red;
            // INotifyPropertyChanged;
            OnPropertyChanged();
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}


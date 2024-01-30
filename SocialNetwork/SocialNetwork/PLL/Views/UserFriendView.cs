using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        FriendService friendService;

        public UserFriendView(FriendService friendService)
        {
            this.friendService = friendService;
        }

        public void Show(User user)
        {
            var friendData = new FriendData();

            Console.WriteLine("Добавить в друзья: ");
            Console.WriteLine("Введите почтовый адрес друга:");

            friendData.Email = Console.ReadLine();
            friendData.User_id = user.Id;

            try
            {
                friendService.AddFriend(friendData);

                SuccessMessage.Show($"Вы успешно добавили в друзья: {friendData.Email}");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при отправке сообщения!");
            }

        }
    }
}

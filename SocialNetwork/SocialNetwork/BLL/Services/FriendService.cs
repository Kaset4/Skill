using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IUserRepository userRepository;
        IFriendRepository friendRepository;

        public FriendService()
        {
            userRepository = new UserRepository();
            friendRepository = new FriendRepository();
        }

        public void AddFriend(FriendData friendData)
        {
            if (String.IsNullOrEmpty(friendData.Email))
                throw new ArgumentNullException();

            var findUserEntity = this.userRepository.FindByEmail(friendData.Email);
            if (findUserEntity is null) throw new UserNotFoundException();

            if (CheckForDublicateFriendsEntry(friendData, findUserEntity))
                throw new UserNotFoundException();

            var friendEntity = new FriendEntity()
            {
                user_id = friendData.User_id,
                friend_id = findUserEntity.id
            };

            if (this.friendRepository.Create(friendEntity) == 0)
                throw new Exception();
        }

        private bool CheckForDublicateFriendsEntry(FriendData friendData, UserEntity user)
        {
            IEnumerable<FriendEntity> friendEntities = friendRepository.FindAllByUserId(friendData.User_id);

            foreach (var friendEntity in friendEntities)
            {
                if (friendEntity.friend_id == user.id)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

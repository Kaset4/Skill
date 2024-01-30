using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocicalNetwork.Tests
{
    public class UserServiceTests
    {
        [TestFixture]        
        public class RegisterTests
        {
            UserService userService = new UserService();
            UserRegistrationData registrationData;
            string testEmail = "test@mail.ru";
            UserRepository userRepository = new UserRepository();
            [Test]
            public void RegisterTestForArgumentNullExceptionOnFirstName()
            {
                registrationData = new UserRegistrationData()
                {
                    Email = testEmail,
                    FirstName = "",
                    LastName = "test",
                    Password = "123456789"
                };

                Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
            }

            [Test]
            public void RegisterTestForArgumentNullExceptionOnLastName()
            {
                registrationData = new UserRegistrationData()
                {
                    Email = testEmail,
                    FirstName = "test",
                    LastName = "",
                    Password = "123456789"
                };

                Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
            }

            [Test]
            public void RegisterTestForArgumentNullExceptionOnPassword()
            {
                registrationData = new UserRegistrationData()
                {
                    Email = testEmail,
                    FirstName = "test",
                    LastName = "test",
                    Password = ""
                };

                Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
            }

            [Test]
            public void RegisterTestForArgumentNullExceptionOnEmail()
            {
                registrationData = new UserRegistrationData()
                {
                    Email = "",
                    FirstName = "test",
                    LastName = "test",
                    Password = "123456789"
                };

                Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
            }

            [Test]
            public void RegisterTestForArgumentNullExceptionOnPasswordLength()
            {
                registrationData = new UserRegistrationData()
                {
                    Email = testEmail,
                    FirstName = "test",
                    LastName = "test",
                    Password = "12345"
                };

                Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
            }

            [Test]
            public void RegisterTestForArgumentNullExceptionOnCorrectEmail()
            {
                registrationData = new UserRegistrationData()
                {
                    Email = "test",
                    FirstName = "test",
                    LastName = "test",
                    Password = "123456789"
                };

                Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
            }

            [Test]
            public void RegisterTestForArgumentNullExceptionOnFindByEmail()

            {
                registrationData = new UserRegistrationData()
                {
                    Email = testEmail,
                    FirstName = "test",
                    LastName = "test",
                    Password = "123456789"
                };

                if (userRepository.FindByEmail(testEmail) != null)
                {
                    Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
                }
                else
                {
                    userService.Register(registrationData);
                    Assert.Throws<ArgumentNullException>(() => userService.Register(registrationData));
                }

            }
            [TearDown]
            public void CleanUp()
            {
                var user = userRepository.FindByEmail(testEmail);
                if (user != null)
                {
                    userRepository.DeleteById(user.id);
                }
            }
        }

        [TestFixture]
        public class AuthenticateTests
        {
            UserService userService = new UserService();
            UserRepository userRepository = new UserRepository();
            UserAuthenticationData userAuthenticationData;
            string testEmail = "test@mail.ru";

            [Test]
            public void AuthenticateTestForUserNotFoundExceptionOnFindByEmail()
            {
                userAuthenticationData = new UserAuthenticationData()
                {
                    Email = "tasdewfrgtyhuj23432redafrdqw@mail.ru",
                    Password = "123456789"
                };

                Assert.Throws<UserNotFoundException>(() => userService.Authenticate(userAuthenticationData));
            }

            [Test]
            public void AuthenticateTestForWrongPasswordExceptionOnPassword()
            {
                userAuthenticationData = new UserAuthenticationData()
                {
                    Email = testEmail,
                    Password = "dwqfregerfewf13221frev"
                };

                if (userRepository.FindByEmail(testEmail) != null)
                {
                    Assert.Throws<WrongPasswordException>(() => userService.Authenticate(userAuthenticationData));
                }
                else
                {
                    UserRegistrationData registrationData = new UserRegistrationData()
                    {
                        Email = testEmail,
                        FirstName = "test",
                        LastName = "test",
                        Password = "123456789"
                    };
                    userService.Register(registrationData);
                    Assert.Throws<WrongPasswordException>(() => userService.Authenticate(userAuthenticationData));
                }
            }
            [TearDown]
            public void CleanUp()
            {
                var user = userRepository.FindByEmail(testEmail);
                if (user != null)
                {
                    userRepository.DeleteById(user.id);
                }
            }
        }

        [TestFixture]
        public class FindByEmailTests
        {
            UserService userService = new UserService();

            [Test]
            public void FindByEmailTestForUserNotFoundExceptionOnFindByEmail()
            {
                Assert.Throws<UserNotFoundException>(() => userService.FindByEmail("tasdewfrgtyhuj23432redafrdqw@mail.ru"));
            }
        }

        [TestFixture]
        public class FindByIdTests
        {
            UserService userService = new UserService();

            [Test]
            public void FindByIdTestForUserNotFoundExceptionOnFindById()
            {
                Assert.Throws<UserNotFoundException>(() => userService.FindById(931458));
            }
        }
    }
}

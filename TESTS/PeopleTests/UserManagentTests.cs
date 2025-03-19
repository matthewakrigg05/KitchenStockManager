using KitchenStockManager.Models.People.Users;
using Xunit;

namespace KitchenStockManager.TESTS.PeopleTests
{
    public class UserMnanagementTests
    {
        [Fact]
        public async Task SuccessfulUserRegistrationTest()
        {
            // Arrange
            string email = "test@example.com";
            string password = "password";
            string firstName = "John";
            string lastName = "Doe";

            // Act
            User? user = await UserManager.RegisterUser(email, password, firstName, lastName);

            // Assert
            Assert.NotNull(user);
            Assert.Equal(email, user.getEmail());
            Assert.Equal(password, user.getPassword());
            Assert.Equal(firstName, user.getFirstName());
            Assert.Equal(lastName, user.getLastName());
        }

        [Fact]
        public async Task LogIn_ShouldReturnUser_WhenCredentialsAreCorrect()
        {
            // Arrange
            string email = "test@example.com";
            string password = "password";

            // Act
            var user = await UserManager.LogIn(email, password);

            // Assert
            Assert.NotNull(user);
            Assert.Equal(email, user.getEmail());
            Assert.Equal(password, user.getPassword());
        }

        [Fact]
        public async Task LogIn_ShouldReturnNull_WhenCredentialsAreIncorrect()
        {
            // Arrange
            string email = "wrong@example.com";
            string password = "wrongpassword";

            // Act
            var user = await UserManager.LogIn(email, password);

            // Assert
            Assert.Null(user);
        }

        [Fact]
        public async Task RegisterUser_ShouldReturnNull_WhenEmailAlreadyExists()
        {
            // Arrange
            string email = "existing@example.com";
            string password = "password";
            string firstName = "John";
            string lastName = "Doe";

            // Act
            var user = await UserManager.RegisterUser(email, password, firstName, lastName);

            // Assert
            Assert.Null(user);
        }
    }
}
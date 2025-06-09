using Xunit;
using Utils;

public class DBHelperTests
{
    [Fact]
    public static void IsConnect_ShouldReturnTrue_WhenConnectionIsEstablished()
    {
        // Act
        using var dbConnection = DBHelper.GetConnection();

        // Assert
        Assert.True(dbConnection.State == System.Data.ConnectionState.Open);
    }

    [Fact]
    public static void Close_ShouldCloseConnection()
    {
        // Arrange
        var dbConnection = DBHelper.GetConnection();

        // Act
        dbConnection.Close();

        // Assert
        Assert.True(dbConnection.State == System.Data.ConnectionState.Closed);
    }

    // [Fact]
    // public void HashPassword_ShouldReturnHashedPassword()
    // {
    //     // Arrange
    //     string password = "password123";

    //     // Act
    //     string hashedPassword = DBHelper.HashPassword(password);

    //     // Assert
    //     Assert.NotNull(hashedPassword);
    //     Assert.NotEmpty(hashedPassword);
    // }

    // [Fact]
    // public void HashPassword_ShouldReturnDifferentHashesForDifferentPasswords()
    // {
    //     // Arrange
    //     string password1 = "password123";
    //     string password2 = "differentpassword";

    //     // Act
    //     string hashedPassword1 = DBHelper.HashPassword(password1);
    //     string hashedPassword2 = DBHelper.HashPassword(password2);

    //     // Assert
    //     Assert.NotEqual(hashedPassword1, hashedPassword2);
    // }

    // [Fact]
    // public void HashPassword_ShouldReturnSameHashForSamePasswordAndSalt()
    // {
    //     // Arrange
    //     string password = "password123";

    //     // Act
    //     string hashedPassword1 = DBHelper.HashPassword(password);
    //     string hashedPassword2 = DBHelper.HashPassword(password);

    //     // Assert
    //     Assert.Equal(hashedPassword1, hashedPassword2);
    // }
}

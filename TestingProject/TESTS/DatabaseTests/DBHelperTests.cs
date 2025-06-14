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
}

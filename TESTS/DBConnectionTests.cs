using Xunit;
using Utils;

namespace TESTS
{
    public class DBConnectionTests
    {

        [Fact]
        public async Task IsConnect_ShouldReturnTrue_WhenConnectionIsEstablished()
        {
            // Act
            var dbConnection = await DBHelper.GetConnection();

            // Assert
            Assert.True(dbConnection.State == System.Data.ConnectionState.Open);
        }

        [Fact]
        public async Task Close_ShouldCloseConnection()
        {
            // Arrange
            var dbConnection = await DBHelper.GetConnection();

            // Act
            dbConnection.Close();

            // Assert
            Assert.True(dbConnection.State == System.Data.ConnectionState.Closed);
        }
    }
}

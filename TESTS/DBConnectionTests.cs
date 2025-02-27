using System;
using Moq;
using MySql.Data.MySqlClient;
using Xunit;
using Utils;

namespace TESTS
{
    public class DBConnectionTests
    {
        [Fact]
        public void Instance_ShouldReturnSameInstance()
        {
            // Act
            var instance1 = DBConnection.Instance();
            var instance2 = DBConnection.Instance();

            // Assert
            Assert.Same(instance1, instance2);
        }

        [Fact]
        public void IsConnect_ShouldReturnFalse_WhenDatabaseNameIsNullOrEmpty()
        {
            // Arrange
            var dbConnection = DBConnection.Instance();
            dbConnection.DatabaseName = null;

            // Act
            var result = dbConnection.IsConnect();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsConnect_ShouldReturnTrue_WhenConnectionIsEstablished()
        {
            // Arrange
            var dbConnection = DBConnection.Instance();
            dbConnection.Server = "127.0.0.1";
            dbConnection.DatabaseName = "TempKSMdb";
            dbConnection.UserName = "root";
            dbConnection.Password = "NnVaZnNvAz29!";

            var mockConnection = new Mock<MySqlConnection>();
            mockConnection.Setup(c => c.Open());

            dbConnection.Connection = mockConnection.Object;

            // Act
            var result = dbConnection.IsConnect();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Close_ShouldCloseConnection()
        {
            // Arrange
            var dbConnection = DBConnection.Instance();
            var mockConnection = new Mock<MySqlConnection>();
            mockConnection.Setup(c => c.Close());

            dbConnection.Connection = mockConnection.Object;

            // Act
            dbConnection.Close();

            // Assert
            mockConnection.Verify(c => c.Close(), Times.Once);
        }
    }
}

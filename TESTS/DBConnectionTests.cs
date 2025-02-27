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
            var result = dbConnection.Connect();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsConnect_ShouldReturnTrue_WhenConnectionIsEstablished()
        {
            // Arrange
            var dbConnection = DBConnection.Instance();
            dbConnection.Server = "localhost";
            dbConnection.DatabaseName = "ksm";
            dbConnection.UserName = "root";
            dbConnection.Password = "";

            // Act
            var result = dbConnection.Connect();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Close_ShouldCloseConnection()
        {
            // Arrange
            var dbConnection = DBConnection.Instance();
            dbConnection.Server = "localhost";
            dbConnection.DatabaseName = "ksm";
            dbConnection.UserName = "root";
            dbConnection.Password = "";
            dbConnection.Connect();

            // Act
            dbConnection.Close();

            // Assert
            Assert.True(dbConnection.Connection.State == System.Data.ConnectionState.Closed);
        }
    }
}

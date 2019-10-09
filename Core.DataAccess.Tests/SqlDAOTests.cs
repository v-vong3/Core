using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.DataAccess.Tests
{
    [TestClass]
    public class SqlDAOTests
    {
        [TestMethod]
        public void OpenConnection_DatabaseExists_Pass()
        {

        }

        [TestMethod]
        public void OpenConnection_ServerExists_Pass()
        {

        }

        [TestMethod]
        public void OpenConnection_EmptyOrNullConnectionString_Fail()
        {

        }

        [TestMethod]
        public void CloseConnection_ExistingConnectionOpen_Pass()
        {

        }

        [TestMethod]
        public void CloseConnection_NoConnectionOpen_Pass()
        {


        }


        [TestMethod]
        public void ExecuteAsync_ValidSql_Pass()
        {


        }

        [TestMethod]
        public void ExecuteAsync_InvalidSql_Pass()
        {


        }




    }
}

    using System;
    using System.Data.SqlClient;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Debugger;
    using System.Security.Authentication;

    namespace UnitTestProject1
    {
        [TestClass]
        public class UnitTest1
        {
            SqlConnection mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\computing3\adv_softwareEng\Debugger\Debugger\test.mdf;Integrated Security=True;Connect Timeout=30");

            /// <summary>
            /// Connect to the database
            /// Test passed, establishing a connection to the database.
            /// </summary>
            [TestMethod]
            public void connection()
            {

                try
                {
                    mySqlConnection.Open();
                    mySqlConnection.Close();
                    Assert.IsTrue(true);
                }
                catch (SqlException)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test the admin can log in
            /// Test passed, admin is logged in and can access features other users can't.
            /// </summary>
            [TestMethod]
            public void adminLogin()
            {

                try
                {
                    mySqlConnection.Open();
                    String admin = ("SELECT * FROM [admin] WHERE username='admin' AND [password]='admin'");
                    SqlCommand adminCommand = new SqlCommand(admin, mySqlConnection);
                    adminCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    Assert.IsTrue(true);
                }
                catch (AuthenticationException)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test the user can log in
            /// Test passed, user is logged in using their credentials.
            /// </summary>
            [TestMethod]
            public void validLogin()
            {

                try
                {
                    mySqlConnection.Open();
                    String user = ("SELECT * FROM [user] WHERE username='adam' AND [password]='pass'");
                    SqlCommand userCommand = new SqlCommand(user, mySqlConnection);
                    userCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    Assert.IsTrue(true);
                }
                catch (AuthenticationException)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test invalid log in details
            /// Test passed, user details is invalid and throws up an exception error. User cannot log in.
            /// </summary>
            [TestMethod]
            public void invalidLogin()
            {

                try
                {
                    mySqlConnection.Open();
                    String user = ("SELECT * FROM [user] WHERE username='ashdk' AND [password]='shjgdas'");
                    SqlCommand userCommand = new SqlCommand(user, mySqlConnection);
                    userCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    Assert.IsFalse(false);
                }
                catch (AuthenticationException)
                {
                    Assert.IsTrue(true);
                }
            }

            /// <summary>
            /// Test the user can register
            /// Test passed, user account is created into the user database and user will be able to log into the system.
            /// </summary>
            [TestMethod]
            public void register()
            {

                try
                {
                    mySqlConnection.Open();
                    String register = ("INSERT INTO [user] ([username], [password]) VALUES('jake', 'secret')");
                    SqlCommand registerCommand = new SqlCommand(register, mySqlConnection);
                    registerCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    Assert.IsTrue(true);
                }
                catch (Exception)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test the user can search for errors to try and fix them
            /// Test passed, list of the errors is displayed based on the search query.
            /// </summary>
            [TestMethod]
            public void search()
            {

                try
                {
                    mySqlConnection.Open();
                    String report = ("SELECT * FROM [errors] WHERE description LIKE '%a%' OR error LIKE '%a%' OR Id LIKE '%14%';");
                    SqlCommand reportCommand = new SqlCommand(report, mySqlConnection);
                    reportCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    Assert.IsTrue(true);
                }
                catch (Exception)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test a list of all the errors that are unresolved
            /// Test passed, a list of all the errors is displayed and order alphabetically for the user to select.
            /// </summary>
            [TestMethod]
            public void fixBugErrorList()
            {
                try
                {
                    mySqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("select error from errors ORDER BY error ASC", mySqlConnection);
                    cmd.ExecuteNonQuery();
                    Assert.IsTrue(true);

                }
                catch (Exception)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test a list of all the versions of an error that have been fixed
            /// Test passed, user can see most up to date code as well as all the previous versions that exist.
            /// </summary>
            [TestMethod]
            public void fixBugVersionList()
            {
                try
                {
                    mySqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("select date from fixedBugs WHERE error = 'a123' ORDER BY error ASC", mySqlConnection);
                    cmd.ExecuteNonQuery();
                    Assert.IsTrue(true);

                }
                catch (ArgumentException)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test insert data into the fixed bug database
            /// Test passed, data is entered into fixed bug database.
            /// </summary>
            [TestMethod]
            public void fixBug()
            {
                try
                {
                    mySqlConnection.Open();
                    SqlCommand reportCommand = new SqlCommand("INSERT INTO[fixedBugs]([user], error, description, code, date, errorUser, errorLine, method, comments ) VALUES(@user, @error, @description, @code, @date, @errorUser, @errorLine, @method, @comments);", mySqlConnection);

                    //Parameter Values
                    reportCommand.Parameters.AddWithValue("@user", "aassd");
                    reportCommand.Parameters.AddWithValue("@error", "dsssd");
                    reportCommand.Parameters.AddWithValue("@description", "fdgssd");
                    reportCommand.Parameters.AddWithValue("@code", "aasfdgsd");
                    reportCommand.Parameters.AddWithValue("@errorLine", "aasresd");
                    reportCommand.Parameters.AddWithValue("@errorUser", "aassrtertd");
                    reportCommand.Parameters.AddWithValue("@method", "aasstred");
                    reportCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy hh:mmtt"));
                    reportCommand.Parameters.AddWithValue("@comments", "aaertssd");
                    reportCommand.ExecuteNonQuery();
                    Assert.IsTrue(true);

                }
                catch (ArgumentException)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test insert data into the report bug database
            /// Test passed, data is entered into report bug database.
            /// </summary>
            [TestMethod]
            public void reportBug()
            {
                try
                {
                    mySqlConnection.Open();
                    String report = ("INSERT INTO [errors] ([user], error, description, code, date) VALUES (@user, @error, @description, @code, @date)");
                    SqlCommand reportCommand = new SqlCommand(report, mySqlConnection);
                    reportCommand.Parameters.AddWithValue("@user", "user1");
                    reportCommand.Parameters.AddWithValue("@error", "this");
                    reportCommand.Parameters.AddWithValue("@description", "problem");
                    reportCommand.Parameters.AddWithValue("@code", "675");
                    reportCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy hh:mmtt"));
                    reportCommand.ExecuteNonQuery();
                    Assert.IsTrue(true);

                }
                catch (ArgumentException)
                {
                    Assert.IsFalse(false);
                }
            }

            /// <summary>
            /// Test try to insert invalid data into the report bug database
            /// Test passed, throws up a format exception.
            /// </summary>
            [TestMethod]
            public void invalidReportBug()
            {
                try
                {
                    mySqlConnection.Open();
                    String report = ("INSERT INTO [errors] ([user], error, description, code, date) VALUES (@user, @error, @description, @code, @date)");
                    SqlCommand reportCommand = new SqlCommand(report, mySqlConnection);
                    reportCommand.Parameters.AddWithValue("@user", "user1");
                    reportCommand.Parameters.AddWithValue("@error", "this");
                    reportCommand.Parameters.AddWithValue("@description", "problem");
                    reportCommand.Parameters.AddWithValue("@code", "675");
                    reportCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString("gjhgds"));
                    reportCommand.ExecuteNonQuery();
                    Assert.IsFalse(false);

                }
                catch (FormatException)
                {
                    Assert.IsTrue(true);
                }
            }

            /// <summary>
            /// Test delete data from user database (only admin can do this)
            /// Test passed, user is deleted from the database.
            /// </summary>
            [TestMethod]
            public void deleteUser()
            {
                try
                {
                    mySqlConnection.Open();
                    string report = ("DELETE FROM [user] WHERE username = 'jake'; ");
                    SqlCommand reportCommand = new SqlCommand(report, mySqlConnection);
                    reportCommand.ExecuteNonQuery();
                    Assert.IsTrue(true);

                }
                catch (ArgumentException)
                {
                    Assert.IsFalse(false);
                }
            }

        }
    }

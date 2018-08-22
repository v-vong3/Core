using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Core.Exceptions.Tests
{
    [TestCategory("Regression")]
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        public void Guard_EmptyArray_ExceptionThrown()
        {
            // Arrange
            var emptyArray = new object[0];
            var exceptionThrown = false;


            // Act
            try
            {
                var result = Guard.AgainstEmptyCollection(emptyArray, nameof(emptyArray));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Guard_NonEmptyArray_Pass()
        {
            // Arrange
            var nonEmptyArray = new object[1] { new { } };


            // Act
            var result = Guard.AgainstEmptyCollection(nonEmptyArray, nameof(nonEmptyArray));


            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Guard_NullArray_ExceptionThrown()
        {
            // Arrange
            object[] nullArray = null;
            var exceptionThrown = false;


            // Act
            try
            {
                var result = Guard.AgainstEmptyCollection(nullArray, nameof(nullArray));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_EmptyWeakCollection_ExceptionThrown()
        {
            // Arrange
            ICollection collection = new ArrayList();
            var exceptionThrown = false;


            // Act
            try
            {
                var result = Guard.AgainstEmptyCollection(collection, nameof(collection));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Guard_NonEmptyWeakCollection_Pass()
        {
            // Arrange
            ICollection collection = new ArrayList(new int[] { 1 });


            // Act
            var result = Guard.AgainstEmptyCollection(collection, nameof(collection));


            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Guard_NullWeakCollection_ExceptionThrown()
        {
            // Arrange
            ICollection collection = null;
            var exceptionThrown = false;


            // Act
            try
            {
                var result = Guard.AgainstEmptyCollection(collection, nameof(collection));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_EmptyStrongCollection_ExceptionThrown()
        {
            // Arrange
            ICollection<int> collection = new List<int>();
            var exceptionThrown = false;


            // Act
            try
            {
                var result = Guard.AgainstEmptyCollection(collection, nameof(collection));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Guard_NullStrongCollection_ExceptionThrown()
        {
            // Arrange
            ICollection<int> collection = null;
            var exceptionThrown = false;


            // Act
            try
            {
                var result = Guard.AgainstEmptyCollection(collection, nameof(collection));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Guard_NonEmptyStrongCollection_Pass()
        {
            // Arrange
            ICollection<int> collection = new List<int>() { 1 };


            // Act
            var result = Guard.AgainstEmptyCollection(collection, nameof(collection));


            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Guard_NullStringArgument_ExceptionThrown()
        {
            // Arrange
            string argument = null;
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNullArgument(argument, nameof(argument));
            }
            catch (ArgumentNullException)
            {
                exceptionThrown = true;
            }

            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_EmptyStringArgument_ExceptionThrown()
        {
            // Arrange
            string argument = string.Empty;
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNullArgument(argument, nameof(argument));
            }
            catch (ArgumentNullException)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }



        [TestMethod]
        public void Guard_BlankStringArgument_ExceptionThrown()
        {
            // Arrange
            string argument = "               ";
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNullArgument(argument, nameof(argument));
            }
            catch (ArgumentNullException)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_NullObjectArgument_ExceptionThrown()
        {
            // Arrange
            object argument = null;
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNullArgument(argument, nameof(argument));
            }
            catch (ArgumentNullException)
            {
                exceptionThrown = true;
            }

            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_NonEmptyStringArgument_Pass()
        {
            // Arrange
            string argument = nameof(argument);

            // Act
            var result = Guard.AgainstNullArgument(argument, nameof(argument));


            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Guard_NonNullObjectArgument_Pass()
        {
            // Arrange
            object argument = new object();

            // Act
            var result = Guard.AgainstNullArgument(argument, nameof(argument));

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Guard_EmptyStringVariable_ExceptionThrown()
        {
            // Arrange
            string argument = string.Empty;
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNullVariable(argument, nameof(argument));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Guard_NullStringVariable_ExceptionThrown()
        {
            // Arrange
            string argument = null;
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNullVariable(argument, nameof(argument));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_BlankStringVariable_ExceptionThrown()
        {
            // Arrange
            string argument = "       ";
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNullVariable(argument, nameof(argument));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_NonEmptyStringVariable_Pass()
        {
            // Arrange
            string argument = nameof(argument);

            // Act
            var result = Guard.AgainstNullVariable(argument, nameof(argument));


            // Assert
            Assert.IsNull(result);
        }



        [TestMethod]
        public void Guard_IsMinorDOB_ExceptionThrown()
        {
            // Arrange
            DateTime dob = DateTime.UtcNow;
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstMinors(dob, nameof(dob));
            }
            catch (BusinessRuleException)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Guard_NonMinorDOB_Pass()
        {
            // Arrange
            DateTime dob = new DateTime(1980, 1, 1, 1, 1, 1, DateTimeKind.Utc);


            // Act
            var result = Guard.AgainstMinors(dob, nameof(dob));

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Guard_UnspecifiedDateTimeKind_ExceptionThrown()
        {
            // Arrange
            DateTime dob = new DateTime(1980, 1, 1, 1, 1, 1, DateTimeKind.Unspecified);
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstMinors(dob, nameof(dob));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_LocalDateTimeKindIsMinorDOB_ExceptionThrown()
        {
            // Arrange
            DateTime dob = DateTime.Now;

            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstMinors(dob, nameof(dob));
            }
            catch (Exception)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }


        [TestMethod]
        public void Guard_LocalDateTimeKindNonMinorDOB_Pass()
        {
            // Arrange
            DateTime dob = new DateTime(1980, 1, 1, 1, 1, 1, DateTimeKind.Local);

            // Act
            var result = Guard.AgainstMinors(dob, nameof(dob));


            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Guard_ExistingPath_Pass()
        {
            // Arrange
            string path = Assembly.GetCallingAssembly().Location;
            var lastDirectoryIndex = path.LastIndexOf(@"\");
            path = path.Substring(0, lastDirectoryIndex);


            // Act
            var result = Guard.AgainstNonExistentPath(path, nameof(path));

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Guard_NonExistingPath_ExceptionThrown()
        {
            // Arrange
            var rng = new Random();

            // Creates a randomly generated invalid path
            var path = Path.Combine(rng.Next(int.MaxValue).ToString(), rng.Next(int.MaxValue).ToString());
            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNonExistentPath(path, nameof(path));
            }
            catch (IOException)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Guard_ExistingFile_Pass()
        {
            // Arrange
            string file = Assembly.GetCallingAssembly().Location;


            // Act
            var result = Guard.AgainstNonExistentFile(file, nameof(file));

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Guard_NonExistingFile_ExceptionThrown()
        {
            // Arrange
            var rng = new Random();

            // Arrange
            // Creates a randomly generated invalid file
            string file = Assembly.GetCallingAssembly().Location + "." + rng.Next(int.MaxValue).ToString("x");

            var exceptionThrown = false;

            // Act
            try
            {
                var result = Guard.AgainstNonExistentFile(file, nameof(file));
            }
            catch (IOException)
            {
                exceptionThrown = true;
            }


            // Assert
            Assert.IsTrue(exceptionThrown);
        }



    }
}

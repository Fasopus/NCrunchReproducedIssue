using NUnit.Framework;
using System.Collections;

namespace ApplicationLibrary.Tests
{
    [TestFixture]
    public class StringConcatenatorTests
    {
        // Including this test breaks NCrunch code coverage. The entire system under test will show no coverage.
        #region NUnit Generated Tests With Non-Primitive Parameter
        [TestCaseSource("ConcatenateStringDataTestCases_WithStringDataObject")]
        public void ConcatenateStringData_ReturnsExpectedString(StringData stringData, string expectedResult)
        {
            // Arrange
            var sut = new StringConcatenator();

            // Act
            var result = sut.ConcatenateStringData(stringData);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        public static IEnumerable ConcatenateStringDataTestCases_WithStringDataObject
        {
            get
            {
                var stringData = new StringData()
                {
                    String1 = "foo",
                    String2 = "bar"
                };

                yield return new TestCaseData(stringData, "foobar").SetName("ConcatenateStringDataNonPrimitive_Withfoobar_Returnsfoobar");
            }
        }
        #endregion

        // This test is properly shown in code coverage if there are no generated tests with non-primitive parameters
        #region NUnit Generated Tests With Primitive Parameters
        [TestCaseSource("ConcatenateStringDataTestCases_WithStrings")]
        public void ConcatenateStringData_ReturnsExpectedString(string string1, string string2, string expectedResult)
        {
            // Arrange
            var sut = new StringConcatenator();
            var stringData = new StringData()
            {
                String1 = string1,
                String2 = string2
            };

            // Act
            var result = sut.ConcatenateStringData(stringData);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        public static IEnumerable ConcatenateStringDataTestCases_WithStrings
        {
            get
            {
                yield return new TestCaseData("foo","bar", "foobar").SetName("ConcatenateStringDataPrimitive_Withfoobar_Returnsfoobar");
            }
        }
        #endregion

        // This test is properly shown in code coverage if there are no generated tests with non-primitive parameters
        #region Basic NUnitTest
        [Test]
        public void ConcatenateStringData_DuplicatedTest()
        {
            // Arrange
            var stringData = new StringData()
            {
                String1 = "foo",
                String2 = "bar"
            };
            var sut = new StringConcatenator();

            // Act
            var result = sut.ConcatenateStringData(stringData);

            // Assert
            Assert.AreEqual(result, "foobar");
        }
        #endregion

    }
}

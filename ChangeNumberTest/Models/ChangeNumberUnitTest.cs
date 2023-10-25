using ChangeNumber.Models;
using System.Reflection;

namespace ChangeNumberTest.Models
{
    public class ChangeNumberUnitTest
	{
        [Fact]
        public void MultiPleOfThreeTest()
        {
            // arrange
            int num = 30;

            // act
            bool result = new ChangeNumberClass().MultiPleOfThree(num);

            // assert
            Assert.True(result);

		}
        [Fact]
        public void MultiPleOfFiveTest()
        {
            // arrange
            int num = 30;

            // act
            bool result = new ChangeNumberClass().MultiPleOfFive(num);

            // assert
            Assert.True(result);

		}
        [Fact]
        public void MultiPleOfFourTest()
        {
            // arrange
            int num = 40;

            // act
            bool result = new ChangeNumberClass().MultiPleOfFour(num);

            // assert
            Assert.True(result);

		}
        [Fact]
        public void MultiPleOfSevenTest()
        {
            // arrange
            int num = 70;

            // act
            bool result = new ChangeNumberClass().MultiPleOfSeven(num);

            // assert
            Assert.True(result);

		}
        [Fact]
        public void CheckNumberV1Test()
        {
            // arrange
            ChangeNumberClass cnc = new ChangeNumberClass();
			List<object> data = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

			List<object> expected = new List<object> { 1, 2, "fizz", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", 13, 14, "fizz-buzz" };

			// act

			List<object> result = data.Select(x => cnc.CheckNumberV1((int)x)).ToList();

            // assert
            Assert.Equal(expected, result);

		}
        [Fact]
        public void CheckNumberV2Test()
		{
			// arrange
			ChangeNumberClass cnc = new ChangeNumberClass();
			List<object> data = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

			List<object> expected = new List<object> { 1, 2, "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", 11, "fizz-muzz", 13, "guzz", "fizz-buzz", "fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz" };

			// act

			List<object> result = data.Select(x => cnc.CheckNumberV2((int)x)).ToList();

			// assert
			Assert.Equal(expected, result);

		}
        [Fact]
        public void CheckNumberV3Test()
		{
			// arrange
			ChangeNumberClass cnc = new ChangeNumberClass();
			List<object> data = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

			List<object> expected = new List<object> { 1, 2, "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", 11, "fizz-muzz", 13, "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz" };

			// act

			List<object> result = data.Select(x => cnc.CheckNumberV3((int)x)).ToList();

			// assert
			Assert.Equal(expected, result);
		}
    }
}
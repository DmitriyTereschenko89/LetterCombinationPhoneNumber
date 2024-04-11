using LetterCombinationPhoneNumber;

namespace LetterCombinationUnitTests
{
	public class LetterCombinationTests
	{
		private readonly LetterCombinations combinations = new();
		
		[TestCase("23", "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf")]
		[TestCase("2", "a", "b", "c")]
		[TestCase("-123")]
		[TestCase("12r")]
		[TestCase("12345")]
		[TestCase("")]
		public void Letter_Combination_With_String1(string digits, params string[] expectedResult)
		{
			List<string> result = combinations.Combinations(digits);
			Assert.That(result.SequenceEqual(expectedResult), Is.EqualTo(true));
		}
	}
}

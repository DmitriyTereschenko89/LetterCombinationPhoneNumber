using LetterCombinationPhoneNumber;

namespace LetterCombinationUnitTests
{
	public class LetterCombinationTests
	{
		private readonly LetterCombinations combinations = new();

		private bool IsSame(List<string> answer, List<string> curResult)
		{
			if (answer.Count != curResult.Count)
			{
				return false;
			}
			for (int i = 0; i < answer.Count; ++i)
			{
				if (answer[i] != curResult[i])
				{
					return false;
				}
			}
			return true;
		}

		[Test]
		public void Letter_Combination_With_String1()
		{
			List<string> result = combinations.Combinations("23");
			Assert.That(IsSame(["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"], result), Is.EqualTo(true));
		}

		[Test]
		public void Letter_Combination_Test_With_String2()
		{
			List<string> result = combinations.Combinations("2");
			Assert.That(IsSame(["a", "b", "c"], result), Is.EqualTo(true));
		}

		[Test]
		public void Letter_Combination_With_Empty_String()
		{
			List<string> result = combinations.Combinations("");
			Assert.That(result, Is.Empty);
		}		
	}
}

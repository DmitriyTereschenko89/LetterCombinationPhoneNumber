namespace LetterCombinationPhoneNumber
{
	public class LetterCombinations
	{
		private readonly string[] buttons = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
		public List<string> Combinations(string digits)
		{
			if (string.IsNullOrEmpty(digits))
			{
				return [];
			}
			List<string> combinations = [];
			Queue<string> queueCombinations = [];
			queueCombinations.Enqueue("");
			int dIdx = 0;
			while (queueCombinations.Count > 0)
			{
				for (int count = queueCombinations.Count; count > 0; --count)
				{
					string curCombination = queueCombinations.Dequeue();
					string letters = buttons[digits[dIdx] - '0'];
					foreach (char letter in letters)
					{
						string newCombination = curCombination + letter;
						if (dIdx == digits.Length - 1)
						{
							combinations.Add(newCombination);
							continue;
						}
						queueCombinations.Enqueue(newCombination);
					}
				}
				++dIdx;
			}
			return combinations;
		}
	}
}

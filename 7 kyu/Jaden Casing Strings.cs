// -----------------------------------------------------------
// Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). Jaden is also known for some of his 
// philosophy that he delivers via Twitter. When writing on Twitter, he is known for almost always capitalizing every word. For simplicity, you'll have to 
// capitalize each word, check out how contractions are expected to be in the example below.
// 
// Your task is to convert strings to how they would be written by Jaden Smith. The strings are actual quotes from Jaden Smith, but they are not 
// capitalized in the same way he originally typed them.
// 
// Example:
// 
// Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
// Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
// 
// Link to Jaden's former Twitter account @officialjaden via archive.org (https://web.archive.org/web/20190624190255/https://twitter.com/officialjaden)
// -----------------------------------------------------------

using System.Globalization;

public static class JadenCase
{
	public static string ToJadenCase(this string phrase)
	{
		TextInfo jadenInfo = new CultureInfo("en-US", false).TextInfo;
		string[] jaden = phrase.Split(" ");
		for (int i = 0; i < jaden.Length; i++)
		{
			jaden[i] = jadenInfo.ToTitleCase(jaden[i]);
		}
		return string.Join(" ", jaden);
	}
}

// or

using System.Globalization;

public static class JadenCase
{
	public static string ToJadenCase(this string phrase)
	{
		return CultureInfo
			.CurrentCulture
			.TextInfo
			.ToTitleCase(phrase);
	}
}

// -----------------------------------------------------------
// License
// Tasks are the property of Codewars (https://www.codewars.com/) 
// and users of this resource.
// 
// All solution code in this repository 
// is the personal property of Vladimir Rukavishnikov
// (vladimirrukavishnikovmail@gmail.com).
// 
// Copyright (C) 2023 Vladimir Rukavishnikov
// 
// This file is part of the HungryVovka/Codewars-C-sharp
// (https://github.com/HungryVovka/Codewars-C-sharp)
// 
// License is GNU General Public License v3.0
// (https://github.com/HungryVovka/Codewars-C-sharp/blob/main/LICENSE)
// 
// You should have received a copy of the GNU General Public License v3.0
// along with this code. If not, see http://www.gnu.org/licenses/
// -----------------------------------------------------------